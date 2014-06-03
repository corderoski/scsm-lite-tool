namespace WinSCSMLiteTool.Controls
{
    partial class ServerInformationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCopyToClipBoard = new System.Windows.Forms.LinkLabel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtPackId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSCSMServer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblCopyToClipBoard);
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.txtPackId);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtSCSMServer);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtVersion);
            this.groupBox3.Controls.Add(this.txtPackageName);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.MinimumSize = new System.Drawing.Size(616, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(616, 74);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ManagementPack Settings";
            // 
            // lblCopyToClipBoard
            // 
            this.lblCopyToClipBoard.AutoSize = true;
            this.lblCopyToClipBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyToClipBoard.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCopyToClipBoard.Location = new System.Drawing.Point(561, 53);
            this.lblCopyToClipBoard.Name = "lblCopyToClipBoard";
            this.lblCopyToClipBoard.Size = new System.Drawing.Size(35, 13);
            this.lblCopyToClipBoard.TabIndex = 7;
            this.lblCopyToClipBoard.TabStop = true;
            this.lblCopyToClipBoard.Text = "Copy";
            this.lblCopyToClipBoard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCopyToClipBoard_LinkClicked);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoad.Image = global::WinSCSMLiteTool.Properties.Resources.refresh;
            this.btnLoad.Location = new System.Drawing.Point(554, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(46, 40);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtPackId
            // 
            this.txtPackId.Location = new System.Drawing.Point(95, 46);
            this.txtPackId.Name = "txtPackId";
            this.txtPackId.Size = new System.Drawing.Size(195, 20);
            this.txtPackId.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Target Pack ID:";
            // 
            // txtSCSMServer
            // 
            this.txtSCSMServer.Location = new System.Drawing.Point(95, 19);
            this.txtSCSMServer.Name = "txtSCSMServer";
            this.txtSCSMServer.Size = new System.Drawing.Size(195, 20);
            this.txtSCSMServer.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Server:";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(383, 46);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(158, 20);
            this.txtVersion.TabIndex = 3;
            this.txtVersion.Validated += new System.EventHandler(this.txtVersion_Validated);
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(383, 17);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(158, 20);
            this.txtPackageName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Version:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Target Name:";
            // 
            // ServerInformationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Name = "ServerInformationControl";
            this.Size = new System.Drawing.Size(622, 80);
            this.Load += new System.EventHandler(this.ServerInformationControl_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel lblCopyToClipBoard;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtPackId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSCSMServer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}
