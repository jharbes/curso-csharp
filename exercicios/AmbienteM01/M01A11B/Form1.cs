namespace M01A11B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "Ol�";

            await Task.Delay(2000);

            lblMsg.Text+=", tudo bem?";
        }
    }
}