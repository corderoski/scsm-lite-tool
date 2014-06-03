namespace WinSCSMLiteTool.Forms
{
    partial class FormEnumerationJoiner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeViewSource = new System.Windows.Forms.TreeView();
            this.treeViewDestiny = new System.Windows.Forms.TreeView();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.serverInformationControl1 = new WinSCSMLiteTool.Controls.ServerInformationControl();
            this.SuspendLayout();
            // 
            // treeViewSource
            // 
            this.treeViewSource.AllowDrop = true;
            this.treeViewSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewSource.FullRowSelect = true;
            this.treeViewSource.HideSelection = false;
            this.treeViewSource.Location = new System.Drawing.Point(12, 90);
            this.treeViewSource.Name = "treeViewSource";
            this.treeViewSource.Size = new System.Drawing.Size(285, 278);
            this.treeViewSource.TabIndex = 0;
            // 
            // treeViewDestiny
            // 
            this.treeViewDestiny.AllowDrop = true;
            this.treeViewDestiny.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewDestiny.FullRowSelect = true;
            this.treeViewDestiny.HideSelection = false;
            this.treeViewDestiny.HotTracking = true;
            this.treeViewDestiny.Location = new System.Drawing.Point(345, 90);
            this.treeViewDestiny.Name = "treeViewDestiny";
            this.treeViewDestiny.Size = new System.Drawing.Size(280, 278);
            this.treeViewDestiny.TabIndex = 0;
            // 
            // btnClean
            // 
            this.btnClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClean.Location = new System.Drawing.Point(445, 378);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(543, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(303, 141);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(36, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = ">";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(303, 265);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(36, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "rel";
            this.saveFileDialog.Filter = "SCSM Lite Tool List|*.rel";
            this.saveFileDialog.RestoreDirectory = true;
            this.saveFileDialog.Title = "SCSM Lite Tool";
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(345, 378);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "SCSM Tool Lite Rel (*.rel)|*.rel";
            // 
            // serverInformationControl1
            // 
            this.serverInformationControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverInformationControl1.Location = new System.Drawing.Point(3, 5);
            this.serverInformationControl1.Name = "serverInformationControl1";
            this.serverInformationControl1.Size = new System.Drawing.Size(622, 79);
            this.serverInformationControl1.TabIndex = 1;
            this.serverInformationControl1.SILoadControlClicked += new WinSCSMLiteTool.Controls.ServerInformationControl.LoadControlActioned(this.serverInformationControl1_SILoadControlClicked);
            // 
            // FormEnumerationJoiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 413);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.serverInformationControl1);
            this.Controls.Add(this.treeViewDestiny);
            this.Controls.Add(this.treeViewSource);
            this.Name = "FormEnumerationJoiner";
            this.Text = "SCSM Lite Tool - Enumerations Join";
            this.Load += new System.EventHandler(this.FormEnumerationJoiner_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewSource;
        private Controls.ServerInformationControl serverInformationControl1;
        private System.Windows.Forms.TreeView treeViewDestiny;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}