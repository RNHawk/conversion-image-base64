namespace base64_image_conversion
{
    partial class FormBase64ToImageConversion
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
            this.btnGoBackToStart = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnOpenBase64ToImage = new System.Windows.Forms.Button();
            this.lblBase64 = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnGoToImageToBase64Conversion = new System.Windows.Forms.Button();
            this.richTextBoxBase64ToImage = new System.Windows.Forms.RichTextBox();
            this.pictureBoxBase64ToImage = new System.Windows.Forms.PictureBox();
            this.btnConvertImageToBase64 = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBase64ToImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoBackToStart
            // 
            this.btnGoBackToStart.BackColor = System.Drawing.Color.DimGray;
            this.btnGoBackToStart.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGoBackToStart.ForeColor = System.Drawing.Color.White;
            this.btnGoBackToStart.Location = new System.Drawing.Point(32, 392);
            this.btnGoBackToStart.Name = "btnGoBackToStart";
            this.btnGoBackToStart.Size = new System.Drawing.Size(354, 45);
            this.btnGoBackToStart.TabIndex = 21;
            this.btnGoBackToStart.Text = "Go back to start";
            this.btnGoBackToStart.UseVisualStyleBackColor = false;
            this.btnGoBackToStart.Click += new System.EventHandler(this.btnGoBackToStart_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.BackColor = System.Drawing.Color.DimGray;
            this.btnSaveImage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveImage.ForeColor = System.Drawing.Color.White;
            this.btnSaveImage.Location = new System.Drawing.Point(285, 342);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(101, 45);
            this.btnSaveImage.TabIndex = 20;
            this.btnSaveImage.Text = "Save";
            this.btnSaveImage.UseVisualStyleBackColor = false;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnOpenBase64ToImage
            // 
            this.btnOpenBase64ToImage.BackColor = System.Drawing.Color.DimGray;
            this.btnOpenBase64ToImage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenBase64ToImage.ForeColor = System.Drawing.Color.White;
            this.btnOpenBase64ToImage.Location = new System.Drawing.Point(32, 342);
            this.btnOpenBase64ToImage.Name = "btnOpenBase64ToImage";
            this.btnOpenBase64ToImage.Size = new System.Drawing.Size(104, 45);
            this.btnOpenBase64ToImage.TabIndex = 18;
            this.btnOpenBase64ToImage.Text = "Browse";
            this.btnOpenBase64ToImage.UseVisualStyleBackColor = false;
            this.btnOpenBase64ToImage.Click += new System.EventHandler(this.btnOpenBase64ToImage_Click);
            // 
            // lblBase64
            // 
            this.lblBase64.BackColor = System.Drawing.Color.Transparent;
            this.lblBase64.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBase64.ForeColor = System.Drawing.Color.Black;
            this.lblBase64.Location = new System.Drawing.Point(32, 14);
            this.lblBase64.Name = "lblBase64";
            this.lblBase64.Size = new System.Drawing.Size(153, 41);
            this.lblBase64.TabIndex = 17;
            this.lblBase64.Text = "Base64 ";
            // 
            // lblImage
            // 
            this.lblImage.BackColor = System.Drawing.Color.Transparent;
            this.lblImage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblImage.ForeColor = System.Drawing.Color.Black;
            this.lblImage.Location = new System.Drawing.Point(414, 14);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(153, 41);
            this.lblImage.TabIndex = 16;
            this.lblImage.Text = "Image";
            // 
            // btnGoToImageToBase64Conversion
            // 
            this.btnGoToImageToBase64Conversion.BackColor = System.Drawing.Color.DimGray;
            this.btnGoToImageToBase64Conversion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGoToImageToBase64Conversion.ForeColor = System.Drawing.Color.White;
            this.btnGoToImageToBase64Conversion.Location = new System.Drawing.Point(414, 342);
            this.btnGoToImageToBase64Conversion.Name = "btnGoToImageToBase64Conversion";
            this.btnGoToImageToBase64Conversion.Size = new System.Drawing.Size(233, 95);
            this.btnGoToImageToBase64Conversion.TabIndex = 15;
            this.btnGoToImageToBase64Conversion.Text = "Go to image to base64 conversion";
            this.btnGoToImageToBase64Conversion.UseVisualStyleBackColor = false;
            this.btnGoToImageToBase64Conversion.Click += new System.EventHandler(this.btnGoToImageToBase64Conversion_Click);
            // 
            // richTextBoxBase64ToImage
            // 
            this.richTextBoxBase64ToImage.Location = new System.Drawing.Point(32, 58);
            this.richTextBoxBase64ToImage.Name = "richTextBoxBase64ToImage";
            this.richTextBoxBase64ToImage.ReadOnly = true;
            this.richTextBoxBase64ToImage.Size = new System.Drawing.Size(354, 267);
            this.richTextBoxBase64ToImage.TabIndex = 14;
            this.richTextBoxBase64ToImage.Text = "";
            // 
            // pictureBoxBase64ToImage
            // 
            this.pictureBoxBase64ToImage.Location = new System.Drawing.Point(414, 58);
            this.pictureBoxBase64ToImage.Name = "pictureBoxBase64ToImage";
            this.pictureBoxBase64ToImage.Size = new System.Drawing.Size(360, 267);
            this.pictureBoxBase64ToImage.TabIndex = 22;
            this.pictureBoxBase64ToImage.TabStop = false;
            // 
            // btnConvertImageToBase64
            // 
            this.btnConvertImageToBase64.BackColor = System.Drawing.Color.DimGray;
            this.btnConvertImageToBase64.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConvertImageToBase64.ForeColor = System.Drawing.Color.White;
            this.btnConvertImageToBase64.Location = new System.Drawing.Point(156, 342);
            this.btnConvertImageToBase64.Name = "btnConvertImageToBase64";
            this.btnConvertImageToBase64.Size = new System.Drawing.Size(111, 45);
            this.btnConvertImageToBase64.TabIndex = 23;
            this.btnConvertImageToBase64.Text = "Convert";
            this.btnConvertImageToBase64.UseVisualStyleBackColor = false;
            this.btnConvertImageToBase64.Click += new System.EventHandler(this.btnConvertImageToBase64_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BackColor = System.Drawing.Color.Red;
            this.btnCloseApp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCloseApp.ForeColor = System.Drawing.Color.White;
            this.btnCloseApp.Location = new System.Drawing.Point(663, 342);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(111, 95);
            this.btnCloseApp.TabIndex = 24;
            this.btnCloseApp.Text = "Close App";
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // FormBase64ToImageConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.btnConvertImageToBase64);
            this.Controls.Add(this.pictureBoxBase64ToImage);
            this.Controls.Add(this.btnGoBackToStart);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnOpenBase64ToImage);
            this.Controls.Add(this.lblBase64);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnGoToImageToBase64Conversion);
            this.Controls.Add(this.richTextBoxBase64ToImage);
            this.Name = "FormBase64ToImageConversion";
            this.Text = "Form Base64 To Image Conversion";
            this.Load += new System.EventHandler(this.FormBase64ToImageConversion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBase64ToImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGoBackToStart;
        private Button btnSaveImage;
        private Button btnOpenBase64ToImage;
        private Label lblBase64;
        private Label lblImage;
        private Button btnGoToImageToBase64Conversion;
        private RichTextBox richTextBoxBase64ToImage;
        private PictureBox pictureBoxBase64ToImage;
        private Button btnConvertImageToBase64;
        private Button btnCloseApp;
    }
}