using System;
using System.Linq;
using System.Windows.Forms;
using SCSMTool.Framework;
using SCSMTool.Framework.Entities;

namespace WinSCSMLiteTool.Forms
{
    public partial class FormEnumerationJoiner : Form
    {

        private PackageManager _packageManager;

        public FormEnumerationJoiner()
        {
            InitializeComponent();
        }

        private void FormEnumerationJoiner_Load(object sender, EventArgs e)
        { }

        private void serverInformationControl1_SILoadControlClicked(PackageManager pgManager, EventArgs e)
        {
            if (pgManager == null) return;
            _packageManager = pgManager;

            treeViewSource.Nodes.Clear();
            foreach (var parent in _packageManager.GetParents())
            {
                var node = new TreeNode
                {
                    Text = parent.DisplayName,
                    Name = parent.Id.ToString(),
                    Tag = parent
                };
                foreach (var child in _packageManager.GetChildsByParentId(parent.Id))
                {
                    node.Nodes.Add(child.Id.ToString(), child.DisplayName);
                }
                treeViewSource.Nodes.Add(node);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var node = (TreeNode)treeViewSource.SelectedNode.Clone();

            var parent = treeViewDestiny.SelectedNode;
            if (parent == null)
            {
                treeViewDestiny.Nodes.Add(node);
            }
            else
            {
                parent.Nodes.Add(node);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var dResult = openFileDialog.ShowDialog(this);
             
            if (dResult != DialogResult.OK) return;

            var content = System.IO.File.ReadAllText(openFileDialog.FileName);
            var nodeString = Serialization.Deserialize(content);

            treeViewDestiny.Nodes.Add(SetNodes(nodeString));
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            treeViewDestiny.Nodes.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var nodes = treeViewDestiny.Nodes;

            var result = RipNode(nodes[0]);

            var content = Serialization.Serialize(result);

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, content);
                MessageBox.Show(this, "Relationship saved.");
            }
            else
            {
                MessageBox.Show(this, "File wasn't selected.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var node = treeViewDestiny.SelectedNode;
            if (node != null)
                node.Remove();
        }

        private NodeString RipNode(TreeNode node)
        {
            var result = new NodeString
            {
                Name = node.Name,
                Text = node.Text
            };

            foreach (var treeNode in node.Nodes.OfType<TreeNode>())
            {
                var childs = new NodeString
                    {
                        Name = treeNode.Name,
                        Text = treeNode.Text
                    };

                if (treeNode.GetNodeCount(true) > 0)
                {
                    childs = RipNode(treeNode);
                }
                result.Childs.Add(childs);
            }
            return result;
        }

        private TreeNode SetNodes(NodeString node)
        {
            var parent = new TreeNode(node.Text)
                {
                    Name = node.Name
                };

            foreach (var child in node.Childs)
            {
                var innerChild = new TreeNode(child.Text)
                    {
                        Name = child.Name
                    };

                if (child.Childs.Count > 0)
                {
                    innerChild = SetNodes(child);
                }

                parent.Nodes.Add(innerChild);
            }
            return parent;
        }
    }
}
