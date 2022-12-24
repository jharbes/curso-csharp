namespace Ex002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            lblMsg.Visible = true;
            lblMsg2.Visible = true;
            lblMsg3.Visible = true;

            await Task.Delay(1000);

            lblMsg.BackColor = Color.Blue;
            lblMsg.ForeColor = Color.White;

            await Task.Delay(1000);

            lblMsg2.BackColor = Color.Yellow;
            lblMsg2.ForeColor = Color.Green;

            await Task.Delay(1000);

            lblMsg3.BackColor = Color.Green;
            lblMsg3.ForeColor = Color.Yellow;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}