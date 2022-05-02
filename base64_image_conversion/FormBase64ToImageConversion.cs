namespace base64_image_conversion
{
    public partial class FormBase64ToImageConversion : Form
    {
        public FormBase64ToImageConversion()
        {           
            InitializeComponent();
        }

        private void btnGoToImageToBase64Conversion_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formImageToBase64Conversion = new FormImageToBase64Conversion();
            formImageToBase64Conversion.Show();
        }

        private void btnGoBackToStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formStart = new FormStart();
            formStart.Show();
        }

        private void btnOpenBase64ToImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.txt)|*.txt|All files(*.*)|*.*";
            dialog.CheckFileExists = true;
            dialog.Multiselect = false;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SetLoading(true);
                String base64Text = System.IO.File.ReadAllText(dialog.FileName);
                richTextBoxBase64ToImage.Text = base64Text;
            }
            else
            {
                MessageBox.Show("Error! No file with .txt is selected", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SetLoading(false);
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            if (pictureBoxBase64ToImage.Image!= null)
            {
                SetLoading(true);
                Bitmap imgout = new Bitmap(pictureBoxBase64ToImage.Image);
                String path = @"D:\C#\C# Convert Image to Base64 String and Save\New folder\base64_image_conversion\data\image.Jpeg";
                imgout.Save(path);
                imgout.Dispose();
                MessageBox.Show("Success! successfully saved the image", "SUCCESS");
                SetLoading(false);
            }
            else
            {
                SetLoading(false);
                MessageBox.Show("Error! No image is found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormBase64ToImageConversion_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertImageToBase64_Click(object sender, EventArgs e)
        {         
            if (!string.IsNullOrEmpty(richTextBoxBase64ToImage.Text))
            {
                SetLoading(true);
                byte[] imageBytes = Convert.FromBase64String(richTextBoxBase64ToImage.Text);
                MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                ms.Write(imageBytes, 0, imageBytes.Length);
                System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
                pictureBoxBase64ToImage.Image = image;
                MessageBox.Show("Success! successfully convert the base64 into image", "SUCCESS");
                SetLoading(false);
            }
            else
            {
                SetLoading(false);
                MessageBox.Show("Error! No base64 string is selected to convert", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
