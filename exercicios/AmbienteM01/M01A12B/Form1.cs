namespace M01A12B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lblMsg.Text = $"O ano atual � {DateTime.Now.Year}!!!";
        }
    }
}