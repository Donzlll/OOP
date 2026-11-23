using System;
using System.Collections.Generic;

using System;
using System.Windows.Forms;

namespace ProjectOOP
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        private void OpenPage(Form page)
        {
            Form home = this.Owner ?? this;

            page.StartPosition = FormStartPosition.Manual;
            page.Location = this.Location;
            page.Size = this.Size;
            page.WindowState = this.WindowState;

            if (this.Owner != null)
                page.Owner = home;

            page.Show();

            if (this.Owner != null)
                this.Close();
            else
                this.Hide();
        }


        private void ListCandidates_Click(object sender, EventArgs e)
        {
            OpenPage(new List_Candidates());
        }

        private void CastAVote_Click(object sender, EventArgs e)
        {
            OpenPage(new CastVotes());
        }

        private void ViewResult_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
                this.Close();
            }
        }

        private void VoterStatus_Click(object sender, EventArgs e)
        {
            OpenPage(new VoterStatus());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
                this.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

