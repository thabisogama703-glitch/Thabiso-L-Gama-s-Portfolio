namespace Home_Screen
{
    public partial class frmHomeScreen : Form
    {
        public frmHomeScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAboutMe aboutMe = new frmAboutMe();

            aboutMe.Show();

            this.Hide();
        }
    }
}
