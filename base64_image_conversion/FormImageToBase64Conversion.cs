namespace base64_image_conversion
{
    public partial class FormImageToBase64Conversion : Form
    {
        OpenFileDialog dialog;

        public FormImageToBase64Conversion()
        {
            dialog = new OpenFileDialog();            
            InitializeComponent();          
        }

        private void btnGoToBase64ToImageConversion_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formBase64ToImageConversion = new FormBase64ToImageConversion();
            formBase64ToImageConversion.Show();
        }

        private void btnGoBackToStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formStart = new FormStart();
            formStart.Show();
        }

        private void btnOpenImageToBase64_Click(object sender, EventArgs e)
        {
            dialog.Filter = "Image Files(*.BMP;*.JPEG,*.PNG)|*.BMP;*.JPEG,*.PNG|All files(*.*)|*.*";
            dialog.CheckFileExists = true;
            dialog.Multiselect = false;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(dialog.FileName);
                pictureBoxImageToBase64.Image = (Image)image;
            }
            else
            {
                MessageBox.Show("Error! No image file is selected", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void btnSaveBase64_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBoxImageToBase64.Text)) {
                SetLoading(true);
                String path = @"D:\C#\C# Convert Image to Base64 String and Save\New folder\base64_image_conversion\data\base64.txt";
                using (StreamWriter stream = File.CreateText(path))
                {
                    stream.Write(richTextBoxImageToBase64.Text);
                }
                MessageBox.Show("Success! successfully saved the base64 text", "SUCCESS");
                SetLoading(false);
            }
            else
            {
                SetLoading(false);
                MessageBox.Show("Error! No base64 text is found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConvertBase64ToImage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dialog.FileName))
            {
                SetLoading(true);
                byte[] imageArray = System.IO.File.ReadAllBytes(dialog.FileName);
                String base64Text = Convert.ToBase64String(imageArray);
                richTextBoxImageToBase64.Text = base64Text;        
                MessageBox.Show("Success! successfully convert the image into base64", "SUCCESS");
                SetLoading(false);
            }
            else
            {
                SetLoading(false);
                MessageBox.Show("Error! No image is selected to convert", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetLoading(bool displayLoader)
        {
            if (displayLoader)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.Cursor = System.Windows.Forms.Cursors.Default;
                });
            }
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formClose = new FormClose();
            formClose.Show();
        }
    }
}