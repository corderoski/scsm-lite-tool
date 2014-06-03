using System;
using System.Net.Sockets;
using System.Windows.Forms;
using SCSMTool.Framework;

namespace WinSCSMLiteTool.Controls
{
    public partial class ServerInformationControl : UserControl
    {

        private PackageManager _packageManager;

        public delegate void LoadControlActioned(PackageManager pgManager, EventArgs e);

        public delegate void ToCopyLinkControlActioned(EventArgs e);

        public event LoadControlActioned SILoadControlClicked;

        public event ToCopyLinkControlActioned SICopyLinkControlClicked;

        public bool LblCopyLinkControlVisible
        {
            set { lblCopyToClipBoard.Visible = value; }
        }

        public bool InsertInDatabase
        {
            get { return false; }
        }

        public ServerInformationControl()
        {
            InitializeComponent();
        }

        private void ServerInformationControl_Load(object sender, EventArgs e)
        {

        }

        protected virtual void OnLoadControlClicked()
        {
            LoadControlActioned handler = SILoadControlClicked;
            if (handler != null) handler(_packageManager, EventArgs.Empty);
        }

        protected virtual void OnCopyLinkControlClicked()
        {
            ToCopyLinkControlActioned handler = SICopyLinkControlClicked;
            if (handler != null) handler(EventArgs.Empty);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                _packageManager = new PackageManager(txtSCSMServer.Text);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(this, "The input was in a wrong format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (SocketException)
            {
                MessageBox.Show(this, "The indicated server wasn't reached. Unkown host.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!String.IsNullOrEmpty(txtPackId.Text))
                _packageManager.LoadById(new Guid(txtPackId.Text));
            else if (!String.IsNullOrEmpty(txtPackageName.Text) && !String.IsNullOrEmpty(txtVersion.Text))
                _packageManager.LoadByName(txtPackageName.Text, txtVersion.Text);
            else
            {
                MessageBox.Show(this, "Pack's information is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.OnLoadControlClicked();
        }

        private void lblCopyToClipBoard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.OnCopyLinkControlClicked();
        }

        private void txtVersion_Validated(object sender, EventArgs e)
        {
            if (!StringUtil.IsValidVersionString(txtVersion.Text)) return;

            MessageBox.Show(this, "Version's format is invalid.");
            txtVersion.ResetText();
        }



    }
}
