namespace Home_Screen
{
    partial class frmHomeScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomeScreen));
            btnAbout = new Button();
            btnSkills = new Button();
            btnProjects = new Button();
            btnExperience = new Button();
            btnEducation = new Button();
            btnJourney = new Button();
            btnContact = new Button();
            btnDownloadCv = new Button();
            lblPortfolioName = new Label();
            lblCourseandInstitution = new Label();
            txtCourseName = new TextBox();
            txtPosition = new Label();
            textBox1 = new TextBox();
            btnViewMyProjects = new Button();
            btnContactMe = new Button();
            btnDownloadCv2 = new Button();
            SuspendLayout();
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(185, 12);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(94, 29);
            btnAbout.TabIndex = 0;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnSkills
            // 
            btnSkills.Location = new Point(329, 12);
            btnSkills.Name = "btnSkills";
            btnSkills.Size = new Size(94, 29);
            btnSkills.TabIndex = 1;
            btnSkills.Text = "Skills";
            btnSkills.UseVisualStyleBackColor = true;
            btnSkills.Click += btnSkills_Click;
            // 
            // btnProjects
            // 
            btnProjects.Location = new Point(460, 12);
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(94, 29);
            btnProjects.TabIndex = 2;
            btnProjects.Text = "Projects";
            btnProjects.UseVisualStyleBackColor = true;
            btnProjects.Click += btnProjects_Click;
            // 
            // btnExperience
            // 
            btnExperience.Location = new Point(590, 12);
            btnExperience.Name = "btnExperience";
            btnExperience.Size = new Size(94, 29);
            btnExperience.TabIndex = 3;
            btnExperience.Text = "Experience";
            btnExperience.UseVisualStyleBackColor = true;
            btnExperience.Click += btnExperience_Click;
            // 
            // btnEducation
            // 
            btnEducation.Location = new Point(711, 12);
            btnEducation.Name = "btnEducation";
            btnEducation.Size = new Size(94, 29);
            btnEducation.TabIndex = 4;
            btnEducation.Text = "Education";
            btnEducation.UseVisualStyleBackColor = true;
            btnEducation.Click += btnEducation_Click;
            // 
            // btnJourney
            // 
            btnJourney.Location = new Point(843, 12);
            btnJourney.Name = "btnJourney";
            btnJourney.Size = new Size(94, 29);
            btnJourney.TabIndex = 5;
            btnJourney.Text = "Journey";
            btnJourney.UseVisualStyleBackColor = true;
            btnJourney.Click += btnJourney_Click;
            // 
            // btnContact
            // 
            btnContact.Location = new Point(974, 12);
            btnContact.Name = "btnContact";
            btnContact.Size = new Size(94, 29);
            btnContact.TabIndex = 6;
            btnContact.Text = "Contact";
            btnContact.UseVisualStyleBackColor = true;
            btnContact.Click += btnContact_Click;
            // 
            // btnDownloadCv
            // 
            btnDownloadCv.Location = new Point(1117, 12);
            btnDownloadCv.Name = "btnDownloadCv";
            btnDownloadCv.Size = new Size(124, 29);
            btnDownloadCv.TabIndex = 7;
            btnDownloadCv.Text = "Download CV";
            btnDownloadCv.UseVisualStyleBackColor = true;
            btnDownloadCv.Click += btnDownloadCv_Click;
            // 
            // lblPortfolioName
            // 
            lblPortfolioName.AutoSize = true;
            lblPortfolioName.Location = new Point(18, 18);
            lblPortfolioName.Name = "lblPortfolioName";
            lblPortfolioName.Size = new Size(66, 20);
            lblPortfolioName.TabIndex = 8;
            lblPortfolioName.Text = "Portfolio";
            // 
            // lblCourseandInstitution
            // 
            lblCourseandInstitution.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCourseandInstitution.ForeColor = Color.Black;
            lblCourseandInstitution.Location = new Point(59, 95);
            lblCourseandInstitution.Name = "lblCourseandInstitution";
            lblCourseandInstitution.Size = new Size(475, 53);
            lblCourseandInstitution.TabIndex = 9;
            lblCourseandInstitution.Text = "Business Information technology  . UJ";
            // 
            // txtCourseName
            // 
            txtCourseName.BorderStyle = BorderStyle.None;
            txtCourseName.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCourseName.ForeColor = Color.FromArgb(0, 0, 192);
            txtCourseName.Location = new Point(18, 131);
            txtCourseName.Multiline = true;
            txtCourseName.Name = "txtCourseName";
            txtCourseName.ReadOnly = true;
            txtCourseName.Size = new Size(553, 324);
            txtCourseName.TabIndex = 11;
            txtCourseName.Text = "Business Information Technology";
            // 
            // txtPosition
            // 
            txtPosition.AutoSize = true;
            txtPosition.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPosition.Location = new Point(59, 458);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(140, 46);
            txtPosition.TabIndex = 12;
            txtPosition.Text = "Student";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(59, 521);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(421, 128);
            textBox1.TabIndex = 13;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // btnViewMyProjects
            // 
            btnViewMyProjects.Location = new Point(59, 655);
            btnViewMyProjects.Name = "btnViewMyProjects";
            btnViewMyProjects.Size = new Size(149, 50);
            btnViewMyProjects.TabIndex = 14;
            btnViewMyProjects.Text = "View My Projects";
            btnViewMyProjects.UseVisualStyleBackColor = true;
            btnViewMyProjects.Click += btnViewMyProjects_Click;
            // 
            // btnContactMe
            // 
            btnContactMe.Location = new Point(234, 655);
            btnContactMe.Name = "btnContactMe";
            btnContactMe.Size = new Size(147, 50);
            btnContactMe.TabIndex = 15;
            btnContactMe.Text = "Contact Me";
            btnContactMe.UseVisualStyleBackColor = true;
            btnContactMe.Click += btnContactMe_Click;
            // 
            // btnDownloadCv2
            // 
            btnDownloadCv2.FlatStyle = FlatStyle.System;
            btnDownloadCv2.Location = new Point(410, 666);
            btnDownloadCv2.Name = "btnDownloadCv2";
            btnDownloadCv2.Size = new Size(124, 29);
            btnDownloadCv2.TabIndex = 16;
            btnDownloadCv2.Text = "Download CV";
            btnDownloadCv2.UseVisualStyleBackColor = true;
            btnDownloadCv2.Click += btnDownloadCv2_Click;
            // 
            // frmHomeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1253, 812);
            Controls.Add(btnDownloadCv2);
            Controls.Add(btnContactMe);
            Controls.Add(btnViewMyProjects);
            Controls.Add(textBox1);
            Controls.Add(txtPosition);
            Controls.Add(txtCourseName);
            Controls.Add(lblCourseandInstitution);
            Controls.Add(lblPortfolioName);
            Controls.Add(btnDownloadCv);
            Controls.Add(btnContact);
            Controls.Add(btnJourney);
            Controls.Add(btnEducation);
            Controls.Add(btnExperience);
            Controls.Add(btnProjects);
            Controls.Add(btnSkills);
            Controls.Add(btnAbout);
            ForeColor = Color.Black;
            Name = "frmHomeScreen";
            Text = "Home Screen Portfolio";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbout;
        private Button btnSkills;
        private Button btnProjects;
        private Button btnExperience;
        private Button btnEducation;
        private Button btnJourney;
        private Button btnContact;
        private Button btnDownloadCv;
        private Label lblPortfolioName;
        private Label lblCourseandInstitution;
        private TextBox txtCourseName;
        private Label txtPosition;
        private TextBox textBox1;
        private Button btnViewMyProjects;
        private Button btnContactMe;
        private Button btnDownloadCv2;
    }
}
