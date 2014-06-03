using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.EnterpriseManagement.Configuration;
using SCSMTool.Framework;

namespace WinSCSMLiteTool.Forms
{
    public partial class FormViewParents : Form
    {

        private PackageManager _packageManager;

        public FormViewParents()
        {
            InitializeComponent();
        }

        private void FillListBox(ref ListView listControl, IEnumerable<ManagementPackEnumeration> dataList)
        {
            if (dataList == null) return;
            
            listControl.Items.Clear();

            foreach (var dataItem in dataList)
            {
                var strText = String.Format("{0} - [{1}]", dataItem.DisplayName, dataItem.Id);
                var item = new ListViewItem(strText) { Tag = dataItem };
                listControl.Items.Add(item);
            }
        }

        private void FormViewParents_Load(object sender, EventArgs e)
        {
            this.Text = MainForm.AppFormTitle + "ManagementPack / View of Parents";
        }

        private void serverInformationControl_SICopyLinkControlClicked(EventArgs e)
        {
            if (listViewList.SelectedIndices.Count <= 0) return;

            var item = listViewList.SelectedItems[0];
            Clipboard.SetText(item.Text);

            MessageBox.Show(this, "Copied!");
        }

        private void serverInformationControl_SILoadControlClicked(PackageManager pgManager, EventArgs e)
        {
            _packageManager = pgManager;
            FillListBox(ref listViewList, _packageManager.GetParents());
        }

    }
}
