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

            //let us say you make your change for the Login/registration here right?
            btnAbout.Enabled = false; 

            //the above is just an example of any change i'm making on the cloned/copied project
            //the next step is to update the change and submit it to github
        }



        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAboutMe aboutMe = new frmAboutMe();

            aboutMe.Show();

            this.Hide();
        }

        private void btnSkills_Click(object sender, EventArgs e)
        {
            frmSkills skillsForm = new frmSkills();

            skillsForm.Show();

            this.Hide();

        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            frmProjects projectsForm = new frmProjects();

            projectsForm.Show();

            this.Hide();
        }

        private void btnExperience_Click(object sender, EventArgs e)
        {
            frmExperience experienceForm = new frmExperience();

            experienceForm.Show();

            this.Hide();
        }

        private void btnEducation_Click(object sender, EventArgs e)
        {
            frmEducation educationForm = new frmEducation();

            educationForm.Show();

            this.Hide();
        }

        private void btnJourney_Click(object sender, EventArgs e)
        {
            frmJourney journeyForm = new frmJourney();

            journeyForm.Show();

            this.Hide();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            frmContact contactForm = new frmContact();

            contactForm.Show();

            this.Hide();
        }

        private void btnDownloadCv_Click(object sender, EventArgs e)
        {
            frmDownloadCv DownloadCVForm = new frmDownloadCv();

            DownloadCVForm.Show();

            this.Hide();
        }

        private void btnContactMe_Click(object sender, EventArgs e)
        {
            frmContact contactMeForm = new frmContact();

            contactMeForm.Show();

            this.Hide();

        }

        private void btnViewMyProjects_Click(object sender, EventArgs e)
        {
            frmProjects viewProjects = new frmProjects();

            viewProjects.Show();

            this.Hide();
        }

        private void btnDownloadCv2_Click(object sender, EventArgs e)
        {
            frmDownloadCv downloadCv2 = new frmDownloadCv();

            downloadCv2.Show();

            this.Hide();
        }
    }
}
