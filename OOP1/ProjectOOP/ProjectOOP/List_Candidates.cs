
using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProjectOOP
{
    public partial class List_Candidates : Form
    {
        public List_Candidates()
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
            if (this.Owner != null)
            {
                this.Owner.Show();
                this.Close();
            }
        }

        private void CastAVote_Click(object sender, EventArgs e)
        {
            OpenPage(new CastVotes());
        }

        private void ViewResult_Click(object sender, EventArgs e)
        {
            OpenPage(new Results());
        }

        private void VoterStatus_Click(object sender, EventArgs e)
        {
            OpenPage(new VoterStatus());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(C1.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(C1.Width - radius, C1.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, C1.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            C1.Region = new Region(path);
        }

        private void C2_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(C2.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(C2.Width - radius, C2.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, C2.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            C2.Region = new Region(path);
        }

        private void C3_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(C3.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(C3.Width - radius, C3.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, C3.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            C3.Region = new Region(path);
        }
    }
}



