namespace FileUploadApp
{
    partial class FileUploadAppForm
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
            this.link1 = new System.Windows.Forms.LinkLabel();
            this.link2 = new System.Windows.Forms.LinkLabel();
            this.link4 = new System.Windows.Forms.LinkLabel();
            this.link3 = new System.Windows.Forms.LinkLabel();
            this.link5 = new System.Windows.Forms.LinkLabel();
            this.link6 = new System.Windows.Forms.LinkLabel();
            this.link7 = new System.Windows.Forms.LinkLabel();
            this.link8 = new System.Windows.Forms.LinkLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // link1
            // 
            this.link1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.link1.AutoEllipsis = true;
            this.link1.Cursor = System.Windows.Forms.Cursors.Default;
            this.link1.LinkColor = System.Drawing.Color.Blue;
            this.link1.Location = new System.Drawing.Point(66, 227);
            this.link1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.link1.Name = "link1";
            this.link1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.link1.Size = new System.Drawing.Size(405, 74);
            this.link1.TabIndex = 7;
            this.link1.TabStop = true;
            this.link1.Text = "Set Up 1099 Process (Skiped)";
            this.link1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.link1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.setUp_LinkClicked);
            // 
            // link2
            // 
            this.link2.ActiveLinkColor = System.Drawing.Color.Blue;
            this.link2.AutoEllipsis = true;
            this.link2.Cursor = System.Windows.Forms.Cursors.Default;
            this.link2.Enabled = false;
            this.link2.LinkColor = System.Drawing.Color.Blue;
            this.link2.Location = new System.Drawing.Point(66, 306);
            this.link2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.link2.Name = "link2";
            this.link2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.link2.Size = new System.Drawing.Size(405, 74);
            this.link2.TabIndex = 8;
            this.link2.TabStop = true;
            this.link2.Text = "Build Vendor Info (Skiped)";
            this.link2.VisitedLinkColor = System.Drawing.Color.Blue;
            this.link2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.buildVendor_LinkClicked);
            // 
            // link4
            // 
            this.link4.ActiveLinkColor = System.Drawing.Color.Blue;
            this.link4.AutoEllipsis = true;
            this.link4.Cursor = System.Windows.Forms.Cursors.Default;
            this.link4.Enabled = false;
            this.link4.LinkColor = System.Drawing.Color.Blue;
            this.link4.Location = new System.Drawing.Point(66, 466);
            this.link4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.link4.Name = "link4";
            this.link4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.link4.Size = new System.Drawing.Size(405, 74);
            this.link4.TabIndex = 9;
            this.link4.TabStop = true;
            this.link4.Text = "Print 1099 Form";
            this.link4.VisitedLinkColor = System.Drawing.Color.Blue;
            this.link4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.printTnn_LinkClicked);
            // 
            // link3
            // 
            this.link3.ActiveLinkColor = System.Drawing.Color.Blue;
            this.link3.AutoEllipsis = true;
            this.link3.Cursor = System.Windows.Forms.Cursors.Default;
            this.link3.Enabled = false;
            this.link3.LinkColor = System.Drawing.Color.Blue;
            this.link3.Location = new System.Drawing.Point(66, 387);
            this.link3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.link3.Name = "link3";
            this.link3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.link3.Size = new System.Drawing.Size(405, 74);
            this.link3.TabIndex = 9;
            this.link3.TabStop = true;
            this.link3.Text = "Review Vendor Information";
            this.link3.VisitedLinkColor = System.Drawing.Color.Blue;
            this.link3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reviewVendor_LinkClicked);
            // 
            // link5
            // 
            this.link5.ActiveLinkColor = System.Drawing.Color.Blue;
            this.link5.AutoEllipsis = true;
            this.link5.Cursor = System.Windows.Forms.Cursors.Default;
            this.link5.Enabled = false;
            this.link5.LinkColor = System.Drawing.Color.Blue;
            this.link5.Location = new System.Drawing.Point(66, 545);
            this.link5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.link5.Name = "link5";
            this.link5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.link5.Size = new System.Drawing.Size(405, 74);
            this.link5.TabIndex = 10;
            this.link5.TabStop = true;
            this.link5.Text = "Upload 1099 Form";
            this.link5.VisitedLinkColor = System.Drawing.Color.Blue;
            this.link5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uploadTnn_LinkClicked);
            // 
            // link6
            // 
            this.link6.ActiveLinkColor = System.Drawing.Color.Blue;
            this.link6.AutoEllipsis = true;
            this.link6.Cursor = System.Windows.Forms.Cursors.Default;
            this.link6.Enabled = false;
            this.link6.LinkColor = System.Drawing.Color.Blue;
            this.link6.Location = new System.Drawing.Point(66, 623);
            this.link6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.link6.Name = "link6";
            this.link6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.link6.Size = new System.Drawing.Size(405, 74);
            this.link6.TabIndex = 13;
            this.link6.TabStop = true;
            this.link6.Text = "Update";
            this.link6.VisitedLinkColor = System.Drawing.Color.Blue;
            this.link6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.update_LinkClicked);
            // 
            // link7
            // 
            this.link7.ActiveLinkColor = System.Drawing.Color.Blue;
            this.link7.AutoEllipsis = true;
            this.link7.Cursor = System.Windows.Forms.Cursors.Default;
            this.link7.Enabled = false;
            this.link7.LinkColor = System.Drawing.Color.Blue;
            this.link7.Location = new System.Drawing.Point(559, 227);
            this.link7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.link7.Name = "link7";
            this.link7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.link7.Size = new System.Drawing.Size(405, 74);
            this.link7.TabIndex = 11;
            this.link7.TabStop = true;
            this.link7.Text = "Store 1099 Form";
            this.link7.Visible = false;
            this.link7.VisitedLinkColor = System.Drawing.Color.Blue;
            this.link7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.storeTnn_LinkClicked);
            // 
            // link8
            // 
            this.link8.ActiveLinkColor = System.Drawing.Color.Blue;
            this.link8.AutoEllipsis = true;
            this.link8.Cursor = System.Windows.Forms.Cursors.Default;
            this.link8.Enabled = false;
            this.link8.LinkColor = System.Drawing.Color.Blue;
            this.link8.Location = new System.Drawing.Point(1050, 227);
            this.link8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.link8.Name = "link8";
            this.link8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.link8.Size = new System.Drawing.Size(405, 74);
            this.link8.TabIndex = 12;
            this.link8.TabStop = true;
            this.link8.Text = "Export 1099 Form";
            this.link8.Visible = false;
            this.link8.VisitedLinkColor = System.Drawing.Color.Blue;
            this.link8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exportTnn_LinkClicked);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1049, 37);
            this.button4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(400, 155);
            this.button4.TabIndex = 16;
            this.button4.TabStop = false;
            this.button4.Text = "Delivery";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.delivery_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(559, 37);
            this.button5.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(400, 155);
            this.button5.TabIndex = 15;
            this.button5.TabStop = false;
            this.button5.Text = "Reporting";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.reporting_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 155);
            this.button1.TabIndex = 17;
            this.button1.TabStop = false;
            this.button1.Text = "Processing";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.processing_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(65, 701);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(141, 51);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FileUploadAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 812);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.link6);
            this.Controls.Add(this.link8);
            this.Controls.Add(this.link7);
            this.Controls.Add(this.link5);
            this.Controls.Add(this.link3);
            this.Controls.Add(this.link4);
            this.Controls.Add(this.link2);
            this.Controls.Add(this.link1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileUploadAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Upload App";
            this.Load += new System.EventHandler(this.FileUploadAppForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel link1;
        private System.Windows.Forms.LinkLabel link2;
        private System.Windows.Forms.LinkLabel link4;
        private System.Windows.Forms.LinkLabel link3;
        private System.Windows.Forms.LinkLabel link5;
        private System.Windows.Forms.LinkLabel link6;
        private System.Windows.Forms.LinkLabel link7;
        private System.Windows.Forms.LinkLabel link8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitButton;
    }
}
