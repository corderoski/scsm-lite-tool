using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.EnterpriseManagement.Configuration;
using SCSMTool.Framework;

namespace WinSCSMLiteTool.Forms
{
    public partial class FormViewChilds: Form
    {

        private PackageManager _packageManager;
        
        public FormViewChilds()
        {
            InitializeComponent();
        }
        
        private void FillListBox(ref ListView listControl, IEnumerable<ManagementPackEnumeration> dataList)
        {
            listControl.Items.Clear();
            if (dataList == null) return; 
            foreach (var dataItem in dataList)
            {
                var text = String.Format("{0}", dataItem.DisplayName);
                var item = new ListViewItem(text);
                listControl.Items.Add(item);
            }
        }

        private void FormViewChilds_Load(object sender, EventArgs e)
        {
            this.Text = MainForm.AppFormTitle + "ManagementPack / View of Childs";
        }

        private void serverInformationControl1_SICopyLinkControlClicked(EventArgs e)
        {
            if (listViewList.SelectedIndices.Count <= 0) return;

            var item = listViewList.SelectedItems[0];
            Clipboard.SetText(item.Text);

            MessageBox.Show(this, "Copied!");
        }

        private void serverInformationControl1_SILoadControlClicked(PackageManager pgManager, EventArgs e)
        {
            _packageManager = pgManager;

            FillListBox(ref listViewList, _packageManager.GetChilds());
        }

    }

}
