using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.EnterpriseManagement.Configuration;
using SCSMTool.Framework;
using SCSMTool.Framework.Entities;

namespace WinSCSMLiteTool.Forms
{
    public partial class FormExcelImport : Form
    {

        private PackageManager _packageManager;

        private IEnumerable<DataItem> _rows;

        public FormExcelImport()
        {
            InitializeComponent();
            btnOk.Enabled = false;
            btnRefresh.Enabled = false;
            serverInformationControl.LblCopyLinkControlVisible = false;
        }

        private void FormExcelImport_Load(object sender, EventArgs e)
        {

            var type = typeof(DataItem);
            dataGridView1.Columns.Add("Item", "Item");
            foreach (var item in type.GetFields())
            {
                //dataGridView1.Columns.Add(item.Name, item.Name); //--
                comboBoxField.Items.Add(item.Name);
                comboBoxDescription.Items.Add(item.Name);
            }
        }

        private void btnChangePath_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
                btnRefresh.Enabled = true;
                btnOk.Enabled = false;
            }
        }


        private void chckBoxEnableDescription_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDescription.Enabled = chckBoxEnableDescription.Checked;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (numericListFirstRow.Value < 1 || numericListFirstColumn.Value < 1)
            {
                MessageBox.Show(this, "Excel's Rows & Columns information is missed.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (_packageManager == null)
            {
                MessageBox.Show(this, "System is disconnected. You must indicated a correct server/connection for continue.");
                return;
            }
            // init
            comboBoxField.SelectedIndex = 0;
            comboBoxDescription.SelectedIndex = 0;

            var file = new System.IO.FileInfo(txtFilePath.Text);
            _rows = ExcelImport.LoadFile(file.FullName,
                                         (int)numericListFirstRow.Value, (int)numericListFirstColumn.Value);

            // Fill
            lblExcelInfo.Text = String.Format("{0} rows.", _rows.Count());
            FillListBox(ref listViewParent, _packageManager.GetParents());
            dataGridView1.Rows.Clear();
            for (int i = 0; i < _rows.Count(); i++)
            {
                dataGridView1.Rows.Add(_rows.ElementAt(i).ToString());
            }
            // Sets
            lblLoadedFile.Text = file.Name;
            btnOk.Enabled = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (listViewParent.SelectedItems.Count <= 0)
            {
                MessageBox.Show(this, "No 'Section' field selected.");
                return;
            }

            //  NodeStringManager
            if (serverInformationControl.InsertInDatabase)
            {
                //TODO: ...    
            }

            //  PackageManager
            // DataItem Entity Fields
            var field = comboBoxField.SelectedItem + "";
            var desc = comboBoxDescription.SelectedItem + "";
            // ManagementPack Entity for transact
            var item = listViewParent.SelectedItems[0];
            var pack = item.Tag as ManagementPackEnumeration;

            for (int i = 0; i < _rows.Count(); i++)
            {
                var dataItem = _rows.ElementAt(i);
                var value = dataItem.GetType().GetField(field).GetValue(dataItem);
                var description = String.IsNullOrEmpty(desc) ? value : dataItem.GetType().GetField(desc).GetValue(dataItem);
                _packageManager.Add(pack, value + "", description + "");
                backgroundWorker.ReportProgress(i * 100 / _rows.Count());
            }
            MessageBox.Show(this, "Finished.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            var frm = new BaseForm();

            var txtControl = new TextBox
            {
                Multiline = true,
                Dock = DockStyle.Fill,
                ReadOnly = true
            };

            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("====== Help & Information ======");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("First-Row/Column will indicate where to start extracting");
            stringBuilder.AppendLine("Field equeals to '0' = null / empty");
            stringBuilder.AppendLine("Press the Refresh/Reload button for try a test connection.");
            stringBuilder.AppendLine("Mark 'Description' for indicate a field with this information");
            stringBuilder.AppendLine("Pressing 'Load' will fill the UI with the excel's data.");
            stringBuilder.AppendLine("You can use Target Id or Target Name + Version.");
            txtControl.Text = stringBuilder.ToString();

            frm.Controls.Add(txtControl);
            frm.Size = new Size(400, 260);
            frm.SetDesktopLocation(150, 150);
            frm.Show();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(this, "End.");
        }

        private void FillListBox(ref ListView listControl, IEnumerable<ManagementPackEnumeration> dataList)
        {
            listControl.Items.Clear();
            if (dataList == null) return;
            foreach (var dataItem in dataList)
            {
                var item = new ListViewItem(dataItem.DisplayName) { Tag = dataItem };
                listControl.Items.Add(item);
            }
        }

        private void FillListBox(ref ComboBox listControl, IEnumerable<ManagementPackEnumeration> dataList)
        {
            listControl.Items.Clear();
            if (dataList == null) return;
            foreach (var dataItem in dataList)
            {
                //var temp = new { Value = dataItem, Text = dataItem.DisplayName }; 
                listControl.Items.Add(dataItem);
            }
        }

        private void serverInformationControl_SILoadControlClicked(PackageManager pgManager, EventArgs e)
        {
            _packageManager = pgManager;
        }

    }
}
