using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinSCSMLiteTool.Forms
{
    public partial class FormRequestDbLogin : Form
    {
        public FormRequestDbLogin()
        {
            InitializeComponent();
        }

        private void FormRequestDbLogin_Load(object sender, EventArgs e)
        {
            this.Text = MainForm.AppFormTitle + "LogIn Credentials for DB Connection";
        }
    }
}
