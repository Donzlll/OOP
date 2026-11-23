
using System;
using System.Windows.Forms;

namespace ProjectOOP
{
    public partial class VoterStatus : Form
    {
        public VoterStatus()
        {
            InitializeComponent();
        }

        // Open another form

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


        // List Candidates
        private void ListCandidates_Click(object sender, EventArgs e)
        {
            OpenPage(new List_Candidates());
        }

        // Cast a Vote
        private void CastAVote_Click(object sender, EventArgs e)
        {
            OpenPage(new CastVotes());
        }

        // View Result

        private void Results_Click(object sender, EventArgs e)
        {

            OpenPage(new Results());
        }


        // Voter Status - Return Home
        private void VoterStatus_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
                this.Close();
            }
        }

        // DataGridView event
        private void dataGridView1_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
