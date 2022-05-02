namespace base64_image_conversion
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void btnGoToBase64ToImageConversion_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formBase64ToImageConversion = new FormBase64ToImageConversion();
            formBase64ToImageConversion.Show();
        }

        private void btnGoToImageToBase64Conversion_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formImageToBase64Conversion = new FormImageToBase64Conversion();
            formImageToBase64Conversion.Show();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formClose = new FormClose();
            formClose.Show();
        }
    }
}
