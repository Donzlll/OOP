using System.ComponentModel.Design;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
namespace ProjectOOP
{
    public partial class Homepage : Form
    {

        public Homepage()
        {
            InitializeComponent();

            this.Activated += Homepage_Activated;
        }


        private void Homepage_Activated(object? sender, EventArgs e)
        {
            LoadElectionStatistics();
        }

        private void LoadElectionStatistics()
        {
            try
            {
                int totalVoters = ElectionService.TotalVoters();
                int votesCast = ElectionService.VotesCast();
                int remaining = ElectionService.RemainingVoters();

                UpdateStatistic(Registered_Voters, totalVoters.ToString());
                UpdateStatistic(Voters_cast, votesCast.ToString());
                UpdateStatistic(Remaining_voters, remaining.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database error: " + ex.Message,
                    "Database Connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void UpdateStatistic(Control container, string value)
        {
            foreach (Control control in container.Controls)
            {
                if (control is Label label)
                {
                    label.Text = value;
                    return;
                }
            }
        }


        private void OpenPage(Form page)
        {
            page.StartPosition = FormStartPosition.Manual;
            page.Location = this.Location;
            page.Size = this.Size;
            page.WindowState = this.WindowState;

            page.Owner = this;
            page.Show();
            this.Hide();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Candidates.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Candidates.Width - radius, Candidates.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Candidates.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            Candidates.Region = new Region(path);


        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(List_candidates.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(List_candidates.Width - radius, List_candidates.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, List_candidates.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            Candidates.Region = new Region(path);
        }

        private void Registered_Voters_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Registered_Voters.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Registered_Voters.Width - radius, Registered_Voters.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Registered_Voters.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            Registered_Voters.Region = new Region(path);
        }

        private void Voters_cast_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Voters_cast.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Voters_cast.Width - radius, Voters_cast.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Voters_cast.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            Voters_cast.Region = new Region(path);
        }

        private void Remaining_voters_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Remaining_voters.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Remaining_voters.Width - radius, Remaining_voters.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Remaining_voters.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            Remaining_voters.Region = new Region(path);
        }

        private void Description_1_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Description_1.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Description_1.Width - radius, Description_1.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Description_1.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            Description_1.Region = new Region(path);
        }

        private void Description_2_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Description_2.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Description_2.Width - radius, Description_2.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Description_2.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            Description_2.Region = new Region(path);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public class NoBorderGroupBox : GroupBox
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                e.Graphics.Clear(this.BackColor);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ListCandidates.FlatStyle = FlatStyle.Flat;
            ListCandidates.FlatAppearance.BorderSize = 0;

            OpenPage(new List_Candidates());
        }



        private void CastAVote_Click(object sender, EventArgs e)
        {
            CastAVote.FlatStyle = FlatStyle.Flat;
            CastAVote.FlatAppearance.BorderSize = 0;

            OpenPage(new CastVotes());
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Results.FlatStyle = FlatStyle.Flat;
            Results.FlatAppearance.BorderSize = 0;

            OpenPage(new Results());
        }



        private void Status_Click(object sender, EventArgs e)
        {
            Status.FlatStyle = FlatStyle.Flat;
            Status.FlatAppearance.BorderSize = 0;

            OpenPage(new VoterStatus());
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.FlatAppearance.BorderSize = 0;
        }

        private void List_candidates_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(List_candidates.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(List_candidates.Width - radius, List_candidates.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, List_candidates.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            List_candidates.Region = new Region(path);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Cast_votes_Paint_1(object sender, PaintEventArgs e)
        {
            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Cast_votes.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Cast_votes.Width - radius, Cast_votes.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Cast_votes.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            Cast_votes.Region = new Region(path);
        }

        private void View_result_Paint_1(object sender, PaintEventArgs e)
        {
            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(View_result.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(View_result.Width - radius, View_result.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, View_result.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            View_result.Region = new Region(path);
        }

        private void Voter_Status_Paint_1(object sender, PaintEventArgs e)
        {
            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Voter_Status.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Voter_Status.Width - radius, Voter_Status.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Voter_Status.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            Voter_Status.Region = new Region(path);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Description_3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void registered_label_Click(object sender, EventArgs e)
        {

        }
    }
}
