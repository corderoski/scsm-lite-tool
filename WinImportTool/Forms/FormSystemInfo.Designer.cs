namespace WinSCSMLiteTool.Forms
{
    partial class FormSystemInfo
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCopyToClipBoard = new System.Windows.Forms.LinkLabel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtSCSMServer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblCopyToClipBoard);
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.txtSCSMServer);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 55);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ManagementPack Settings";
            // 
            // lblCopyToClipBoard
            // 
            this.lblCopyToClipBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyToClipBoard.AutoSize = true;
            this.lblCopyToClipBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyToClipBoard.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCopyToClipBoard.Location = new System.Drawing.Point(438, 32);
            this.lblCopyToClipBoard.Name = "lblCopyToClipBoard";
            this.lblCopyToClipBoard.Size = new System.Drawing.Size(35, 13);
            this.lblCopyToClipBoard.TabIndex = 6;
            this.lblCopyToClipBoard.TabStop = true;
            this.lblCopyToClipBoard.Text = "Copy";
            this.lblCopyToClipBoard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCopyToClipBoard_LinkClicked);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoad.Location = new System.Drawing.Point(372, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(40, 33);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "L";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtSCSMServer
            // 
            this.txtSCSMServer.Location = new System.Drawing.Point(141, 19);
            this.txtSCSMServer.Name = "txtSCSMServer";
            this.txtSCSMServer.Size = new System.Drawing.Size(195, 20);
            this.txtSCSMServer.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Server:";
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(12, 64);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(479, 214);
            this.richTextBox.TabIndex = 6;
            this.richTextBox.Text = "";
            // 
            // FormSystemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 285);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormSystemInfo";
            this.Text = "FormSystemInfo";
            this.Load += new System.EventHandler(this.FormSystemInfo_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel lblCopyToClipBoard;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtSCSMServer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}