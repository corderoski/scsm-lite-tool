namespace WinSCSMLiteTool.Forms
{
    partial class FormViewChilds
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
            this.listViewList = new System.Windows.Forms.ListView();
            this.serverInformationControl1 = new WinSCSMLiteTool.Controls.ServerInformationControl();
            this.SuspendLayout();
            // 
            // listViewList
            // 
            this.listViewList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewList.Location = new System.Drawing.Point(13, 93);
            this.listViewList.Name = "listViewList";
            this.listViewList.Size = new System.Drawing.Size(618, 228);
            this.listViewList.TabIndex = 4;
            this.listViewList.UseCompatibleStateImageBehavior = false;
            this.listViewList.View = System.Windows.Forms.View.List;
            // 
            // serverInformationControl1
            // 
            this.serverInformationControl1.Location = new System.Drawing.Point(12, 8);
            this.serverInformationControl1.Name = "serverInformationControl1";
            this.serverInformationControl1.Size = new System.Drawing.Size(622, 79);
            this.serverInformationControl1.TabIndex = 5;
            this.serverInformationControl1.SILoadControlClicked += new WinSCSMLiteTool.Controls.ServerInformationControl.LoadControlActioned(this.serverInformationControl1_SILoadControlClicked);
            this.serverInformationControl1.SICopyLinkControlClicked += new WinSCSMLiteTool.Controls.ServerInformationControl.ToCopyLinkControlActioned(this.serverInformationControl1_SICopyLinkControlClicked);
            // 
            // FormViewChilds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 333);
            this.Controls.Add(this.serverInformationControl1);
            this.Controls.Add(this.listViewList);
            this.Name = "FormViewChilds";
            this.Text = "SCSM Lite Tool - ManagementPack / View of Childs";
            this.Load += new System.EventHandler(this.FormViewChilds_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewList;
        private Controls.ServerInformationControl serverInformationControl1;
    }
}