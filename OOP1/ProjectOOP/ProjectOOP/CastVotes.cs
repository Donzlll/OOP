
using System;
using System.Windows.Forms;

namespace ProjectOOP
{
    public partial class CastVotes : Form
    {
        public CastVotes()
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
            if (this.Owner != null)
            {
                this.Owner.Show();
                this.Close();
            }
        }

        private void ViewResult_Click(object sender, EventArgs e)
        {
            OpenPage(new Results());
        }

        private void VoterStatus_Click(object sender, EventArgs e)
        {
            OpenPage(new VoterStatus());
        }

        private void CastVotes_Load(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}


