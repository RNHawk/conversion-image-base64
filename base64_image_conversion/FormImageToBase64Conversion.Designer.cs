namespace base64_image_conversion
{
    partial class FormImageToBase64Conversion
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
            this.richTextBoxImageToBase64 = new System.Windows.Forms.RichTextBox();
            this.pictureBoxImageToBase64 = new System.Windows.Forms.PictureBox();
            this.btnGoToBase64ToImageConversion = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblBase64 = new System.Windows.Forms.Label();
            this.btnOpenImageToBase64 = new System.Windows.Forms.Button();
            this.btnSaveBase64 = new System.Windows.Forms.Button();
            this.btnGoBackToStart = new System.Windows.Forms.Button();
            this.btnConvertBase64ToImage = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageToBase64)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxImageToBase64
            // 
            this.richTextBoxImageToBase64.Location = new System.Drawing.Point(412, 53);
            this.richTextBoxImageToBase64.Name = "richTextBoxImageToBase64";
            this.richTextBoxImageToBase64.ReadOnly = true;
            this.richTextBoxImageToBase64.Size = new System.Drawing.Size(360, 267);
            this.richTextBoxImageToBase64.TabIndex = 5;
            this.richTextBoxImageToBase64.Text = "";
            // 
            // pictureBoxImageToBase64
            // 
            this.pictureBoxImageToBase64.Location = new System.Drawing.Point(30, 53);
            this.pictureBoxImageToBase64.Name = "pictureBoxImageToBase64";
            this.pictureBoxImageToBase64.Size = new System.Drawing.Size(354, 267);
            this.pictureBoxImageToBase64.TabIndex = 4;
            this.pictureBoxImageToBase64.TabStop = false;
            // 
            // btnGoToBase64ToImageConversion
            // 
            this.btnGoToBase64ToImageConversion.BackColor = System.Drawing.Color.DimGray;
            this.btnGoToBase64ToImageConversion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGoToBase64ToImageConversion.ForeColor = System.Drawing.Color.White;
            this.btnGoToBase64ToImageConversion.Location = new System.Drawing.Point(412, 337);
            this.btnGoToBase64ToImageConversion.Name = "btnGoToBase64ToImageConversion";
            this.btnGoToBase64ToImageConversion.Size = new System.Drawing.Size(231, 95);
            this.btnGoToBase64ToImageConversion.TabIndex = 6;
            this.btnGoToBase64ToImageConversion.Text = "Go to base64 to image conversion";
            this.btnGoToBase64ToImageConversion.UseVisualStyleBackColor = false;
            this.btnGoToBase64ToImageConversion.Click += new System.EventHandler(this.btnGoToBase64ToImageConversion_Click);
            // 
            // lblImage
            // 
            this.lblImage.BackColor = System.Drawing.Color.Transparent;
            this.lblImage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblImage.ForeColor = System.Drawing.Color.Black;
            this.lblImage.Location = new System.Drawing.Point(24, 9);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(153, 41);
            this.lblImage.TabIndex = 7;
            this.lblImage.Text = "Image";
            // 
            // lblBase64
            // 
            this.lblBase64.BackColor = System.Drawing.Color.Transparent;
            this.lblBase64.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBase64.ForeColor = System.Drawing.Color.Black;
            this.lblBase64.Location = new System.Drawing.Point(412, 9);
            this.lblBase64.Name = "lblBase64";
            this.lblBase64.Size = new System.Drawing.Size(153, 41);
            this.lblBase64.TabIndex = 8;
            this.lblBase64.Text = "Base64 ";
            // 
            // btnOpenImageToBase64
            // 
            this.btnOpenImageToBase64.BackColor = System.Drawing.Color.DimGray;
            this.btnOpenImageToBase64.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenImageToBase64.ForeColor = System.Drawing.Color.White;
            this.btnOpenImageToBase64.Location = new System.Drawing.Point(30, 337);
            this.btnOpenImageToBase64.Name = "btnOpenImageToBase64";
            this.btnOpenImageToBase64.Size = new System.Drawing.Size(102, 45);
            this.btnOpenImageToBase64.TabIndex = 9;
            this.btnOpenImageToBase64.Text = "Browse";
            this.btnOpenImageToBase64.UseVisualStyleBackColor = false;
            this.btnOpenImageToBase64.Click += new System.EventHandler(this.btnOpenImageToBase64_Click);
            // 
            // btnSaveBase64
            // 
            this.btnSaveBase64.BackColor = System.Drawing.Color.DimGray;
            this.btnSaveBase64.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveBase64.ForeColor = System.Drawing.Color.White;
            this.btnSaveBase64.Location = new System.Drawing.Point(262, 337);
            this.btnSaveBase64.Name = "btnSaveBase64";
            this.btnSaveBase64.Size = new System.Drawing.Size(122, 45);
            this.btnSaveBase64.TabIndex = 11;
            this.btnSaveBase64.Text = "Save";
            this.btnSaveBase64.UseVisualStyleBackColor = false;
            this.btnSaveBase64.Click += new System.EventHandler(this.btnSaveBase64_Click);
            // 
            // btnGoBackToStart
            // 
            this.btnGoBackToStart.BackColor = System.Drawing.Color.DimGray;
            this.btnGoBackToStart.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGoBackToStart.ForeColor = System.Drawing.Color.White;
            this.btnGoBackToStart.Location = new System.Drawing.Point(30, 387);
            this.btnGoBackToStart.Name = "btnGoBackToStart";
            this.btnGoBackToStart.Size = new System.Drawing.Size(354, 45);
            this.btnGoBackToStart.TabIndex = 12;
            this.btnGoBackToStart.Text = "Go back to start";
            this.btnGoBackToStart.UseVisualStyleBackColor = false;
            this.btnGoBackToStart.Click += new System.EventHandler(this.btnGoBackToStart_Click);
            // 
            // btnConvertBase64ToImage
            // 
            this.btnConvertBase64ToImage.BackColor = System.Drawing.Color.DimGray;
            this.btnConvertBase64ToImage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConvertBase64ToImage.ForeColor = System.Drawing.Color.White;
            this.btnConvertBase64ToImage.Location = new System.Drawing.Point(138, 337);
            this.btnConvertBase64ToImage.Name = "btnConvertBase64ToImage";
            this.btnConvertBase64ToImage.Size = new System.Drawing.Size(120, 45);
            this.btnConvertBase64ToImage.TabIndex = 13;
            this.btnConvertBase64ToImage.Text = "Convert";
            this.btnConvertBase64ToImage.UseVisualStyleBackColor = false;
            this.btnConvertBase64ToImage.Click += new System.EventHandler(this.btnConvertBase64ToImage_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BackColor = System.Drawing.Color.Red;
            this.btnCloseApp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCloseApp.ForeColor = System.Drawing.Color.White;
            this.btnCloseApp.Location = new System.Drawing.Point(661, 337);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(111, 96);
            this.btnCloseApp.TabIndex = 14;
            this.btnCloseApp.Text = "Close App";
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // FormImageToBase64Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.btnConvertBase64ToImage);
            this.Controls.Add(this.btnGoBackToStart);
            this.Controls.Add(this.btnSaveBase64);
            this.Controls.Add(this.btnOpenImageToBase64);
            this.Controls.Add(this.lblBase64);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnGoToBase64ToImageConversion);
            this.Controls.Add(this.richTextBoxImageToBase64);
            this.Controls.Add(this.pictureBoxImageToBase64);
            this.Name = "FormImageToBase64Conversion";
            this.Text = "Image To Base64 Conversion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageToBase64)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RichTextBox richTextBoxImageToBase64;
        private PictureBox pictureBoxImageToBase64;
        private Button btnGoToBase64ToImageConversion;
        private Label lblImage;
        private Label lblBase64;
        private Button btnOpenImageToBase64;
        private Button btnSaveBase64;
        private Button btnGoBackToStart;
        private Button btnConvertBase64ToImage;
        private Button btnCloseApp;
    }
}