using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCSMTool.Framework;

namespace WinSCSMLiteTool.Forms
{
    public partial class FormSystemInfo : Form
    {

        private PackageManager _packageManager;


        public FormSystemInfo()
        {
            InitializeComponent();
        }

        private void FormSystemInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var exists = PackageManager.TryConnection(txtSCSMServer.Text);

            var strBuilder = new StringBuilder();
            richTextBox.ResetText();

            if (!exists)
            {
                strBuilder.AppendLine("Invalid Connection.");
            }
            else
            {
                _packageManager = new PackageManager(txtSCSMServer.Text);

                strBuilder.Append(_packageManager.GetPackageInfo());
            }

            richTextBox.AppendText(strBuilder.ToString());
        }

        private void lblCopyToClipBoard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(richTextBox.Text);

            MessageBox.Show(this, "Copied!");
        }

    }

}
