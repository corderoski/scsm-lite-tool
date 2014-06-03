using System;
using System.Net.Sockets;
using System.Windows.Forms;
using SCSMTool.Framework;

namespace WinSCSMLiteTool.Forms
{
    public partial class FormViewAllManagementPacks : Form
    {

        private PackageManager _packageManager;


        public FormViewAllManagementPacks()
        {
            InitializeComponent();
        }

        private void txtSCSMServer_Validated(object sender, EventArgs e)
        {
            try
            {
                _packageManager = new PackageManager(txtSCSMServer.Text);
                LoadPacks();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(this, "The input was in a wrong format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
            catch (SocketException)
            {
                MessageBox.Show(this, "The indicated server wasn't reached. Unkown host.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void LoadPacks()
        {
            listView.Items.Clear();
            foreach (var dataItem in _packageManager.GetAllManagementPacks())
            {
                var text = String.Format("{0} [{1}]", dataItem.DisplayName, dataItem.Id);
                var item = new ListViewItem(text);
                listView.Items.Add(item);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
           txtSCSMServer_Validated(sender, e);
        }

        private void lblCopyToClipBoard_Click(object sender, EventArgs e)
        {
            if (listView.SelectedIndices.Count <= 0) return;
            
            var item = listView.SelectedItems[0];
            Clipboard.SetText(item.Text);

            MessageBox.Show(this, "Copied!");
        }

        private void FormViewAllManagementPacks_Load(object sender, EventArgs e)
        {
            this.Text = MainForm.AppFormTitle + "ManagementPack / All Enumerations";
        }

    }

}
