using System;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace WinSCSMLiteTool
{

    public partial class MainForm : Form
    {

        public const String AppFormTitle = "SCSM Lite Tool - ";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
           this.textBoxDescription.Text = AssemblyDescription;
        }

    #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                var stringBuilder = new StringBuilder();
                stringBuilder.AppendLine(String.Format("====== {0} ======", AssemblyVersion));
                stringBuilder.AppendLine();
            
                return stringBuilder.ToString();
                //object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                //if (attributes.Length == 0)
                //{
                //    return "";
                //}
                //return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Forms.FormExcelImport();
            frm.ShowDialog(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new Forms.AboutBox())
            {
                frm.ShowDialog(this);
            }
        }

        private void parentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.FormViewParents().Show();
        }

        private void childsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.FormViewChilds().Show();
        }

        private void allPacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.FormViewAllManagementPacks().Show();
        }

        

        private void systemInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.FormSystemInfo().Show();
        }

        private void enumerationsJoinerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.FormEnumerationJoiner().Show();
        }

    }

}
