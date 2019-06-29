namespace FileUploadApp
{
    partial class VendorInformation
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
            this.vendorTin = new System.Windows.Forms.Label();
            this.recipientTin = new System.Windows.Forms.Label();
            this.incomeTax = new System.Windows.Forms.Label();
            this.recipientName = new System.Windows.Forms.Label();
            this.texasResident = new System.Windows.Forms.CheckBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.vendorTinBox = new System.Windows.Forms.TextBox();
            this.recipientTinBox = new System.Windows.Forms.TextBox();
            this.recipientNameBox = new System.Windows.Forms.TextBox();
            this.incomeTaxBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // vendorTin
            // 
            this.vendorTin.AutoSize = true;
            this.vendorTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorTin.Location = new System.Drawing.Point(27, 59);
            this.vendorTin.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.vendorTin.Name = "vendorTin";
            this.vendorTin.Size = new System.Drawing.Size(94, 17);
            this.vendorTin.TabIndex = 0;
            this.vendorTin.Text = "Vendor\'s TIN:";
            this.vendorTin.Click += new System.EventHandler(this.VendorTin_Click);
            // 
            // recipientTin
            // 
            this.recipientTin.AutoSize = true;
            this.recipientTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipientTin.Location = new System.Drawing.Point(27, 101);
            this.recipientTin.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.recipientTin.Name = "recipientTin";
            this.recipientTin.Size = new System.Drawing.Size(107, 17);
            this.recipientTin.TabIndex = 1;
            this.recipientTin.Text = "Recipient\'s TIN:";
            this.recipientTin.Click += new System.EventHandler(this.RecipientTin_Click);
            // 
            // incomeTax
            // 
            this.incomeTax.AutoSize = true;
            this.incomeTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeTax.Location = new System.Drawing.Point(27, 185);
            this.incomeTax.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.incomeTax.Name = "incomeTax";
            this.incomeTax.Size = new System.Drawing.Size(84, 17);
            this.incomeTax.TabIndex = 3;
            this.incomeTax.Text = "Income Tax:";
            // 
            // recipientName
            // 
            this.recipientName.AutoSize = true;
            this.recipientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipientName.Location = new System.Drawing.Point(27, 143);
            this.recipientName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.recipientName.Name = "recipientName";
            this.recipientName.Size = new System.Drawing.Size(122, 17);
            this.recipientName.TabIndex = 2;
            this.recipientName.Text = "Recipient\'s Name:";
            this.recipientName.Click += new System.EventHandler(this.RecipientName_Click);
            // 
            // texasResident
            // 
            this.texasResident.AutoSize = true;
            this.texasResident.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texasResident.Location = new System.Drawing.Point(210, 226);
            this.texasResident.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.texasResident.Name = "texasResident";
            this.texasResident.Size = new System.Drawing.Size(125, 21);
            this.texasResident.TabIndex = 4;
            this.texasResident.Text = "Texas Resident";
            this.texasResident.UseVisualStyleBackColor = true;
            this.texasResident.CheckedChanged += new System.EventHandler(this.TexasResident_CheckedChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // vendorTinBox
            // 
            this.vendorTinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorTinBox.Location = new System.Drawing.Point(210, 59);
            this.vendorTinBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.vendorTinBox.Name = "vendorTinBox";
            this.vendorTinBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.vendorTinBox.Size = new System.Drawing.Size(195, 22);
            this.vendorTinBox.TabIndex = 5;
            this.vendorTinBox.TabStop = false;
            // 
            // recipientTinBox
            // 
            this.recipientTinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipientTinBox.Location = new System.Drawing.Point(210, 99);
            this.recipientTinBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.recipientTinBox.Name = "recipientTinBox";
            this.recipientTinBox.Size = new System.Drawing.Size(195, 22);
            this.recipientTinBox.TabIndex = 6;
            this.recipientTinBox.TabStop = false;
            // 
            // recipientNameBox
            // 
            this.recipientNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipientNameBox.Location = new System.Drawing.Point(210, 141);
            this.recipientNameBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.recipientNameBox.Name = "recipientNameBox";
            this.recipientNameBox.Size = new System.Drawing.Size(195, 22);
            this.recipientNameBox.TabIndex = 7;
            this.recipientNameBox.TabStop = false;
            // 
            // incomeTaxBox
            // 
            this.incomeTaxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeTaxBox.Location = new System.Drawing.Point(210, 183);
            this.incomeTaxBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.incomeTaxBox.Name = "incomeTaxBox";
            this.incomeTaxBox.Size = new System.Drawing.Size(195, 22);
            this.incomeTaxBox.TabIndex = 8;
            this.incomeTaxBox.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(350, 226);
            this.saveButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(53, 28);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // VendorInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 341);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.incomeTaxBox);
            this.Controls.Add(this.recipientNameBox);
            this.Controls.Add(this.recipientTinBox);
            this.Controls.Add(this.vendorTinBox);
            this.Controls.Add(this.texasResident);
            this.Controls.Add(this.incomeTax);
            this.Controls.Add(this.recipientName);
            this.Controls.Add(this.recipientTin);
            this.Controls.Add(this.vendorTin);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VendorInformation";
            this.Text = "Vendor Information";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vendorTin;
        private System.Windows.Forms.Label recipientTin;
        private System.Windows.Forms.Label incomeTax;
        private System.Windows.Forms.Label recipientName;
        private System.Windows.Forms.CheckBox texasResident;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox incomeTaxBox;
        private System.Windows.Forms.TextBox recipientNameBox;
        private System.Windows.Forms.TextBox recipientTinBox;
        private System.Windows.Forms.TextBox vendorTinBox;
        private System.Windows.Forms.Button saveButton;
    }
}