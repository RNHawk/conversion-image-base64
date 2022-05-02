namespace base64_image_conversion
{
    partial class FormStart
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
            this.btnGoToBase64ToImageConversion = new System.Windows.Forms.Button();
            this.btnGoToImageToBase64Conversion = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGoToBase64ToImageConversion
            // 
            this.btnGoToBase64ToImageConversion.BackColor = System.Drawing.Color.DimGray;
            this.btnGoToBase64ToImageConversion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGoToBase64ToImageConversion.ForeColor = System.Drawing.Color.White;
            this.btnGoToBase64ToImageConversion.Location = new System.Drawing.Point(303, 289);
            this.btnGoToBase64ToImageConversion.Name = "btnGoToBase64ToImageConversion";
            this.btnGoToBase64ToImageConversion.Size = new System.Drawing.Size(230, 107);
            this.btnGoToBase64ToImageConversion.TabIndex = 4;
            this.btnGoToBase64ToImageConversion.Text = "Go to base64 to image conversion";
            this.btnGoToBase64ToImageConversion.UseVisualStyleBackColor = false;
            this.btnGoToBase64ToImageConversion.Click += new System.EventHandler(this.btnGoToBase64ToImageConversion_Click);
            // 
            // btnGoToImageToBase64Conversion
            // 
            this.btnGoToImageToBase64Conversion.BackColor = System.Drawing.Color.DimGray;
            this.btnGoToImageToBase64Conversion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGoToImageToBase64Conversion.ForeColor = System.Drawing.Color.White;
            this.btnGoToImageToBase64Conversion.Location = new System.Drawing.Point(58, 289);
            this.btnGoToImageToBase64Conversion.Name = "btnGoToImageToBase64Conversion";
            this.btnGoToImageToBase64Conversion.Size = new System.Drawing.Size(230, 107);
            this.btnGoToImageToBase64Conversion.TabIndex = 3;
            this.btnGoToImageToBase64Conversion.Text = "Go to image to base64 conversion";
            this.btnGoToImageToBase64Conversion.UseVisualStyleBackColor = false;
            this.btnGoToImageToBase64Conversion.Click += new System.EventHandler(this.btnGoToImageToBase64Conversion_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BackColor = System.Drawing.Color.Red;
            this.btnCloseApp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCloseApp.ForeColor = System.Drawing.Color.White;
            this.btnCloseApp.Location = new System.Drawing.Point(554, 289);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(192, 107);
            this.btnCloseApp.TabIndex = 6;
            this.btnCloseApp.Text = "Close App";
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // lblStart
            // 
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStart.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStart.ForeColor = System.Drawing.Color.DimGray;
            this.lblStart.Location = new System.Drawing.Point(57, 47);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(689, 211);
            this.lblStart.TabIndex = 7;
            this.lblStart.Text = "Welcome to image base 64 conversion App";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.btnGoToBase64ToImageConversion);
            this.Controls.Add(this.btnGoToImageToBase64Conversion);
            this.Name = "FormStart";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGoToBase64ToImageConversion;
        private Button btnGoToImageToBase64Conversion;
        private Button btnCloseApp;
        private Label lblStart;
    }
}