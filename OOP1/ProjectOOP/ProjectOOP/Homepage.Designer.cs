namespace ProjectOOP
{
    partial class Homepage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            contextMenuStrip1 = new ContextMenuStrip(components);
            Left_menu_panel = new Panel();
            pictureBox1 = new PictureBox();
            Description_2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            Exit = new Button();
            Status = new Button();
            Results = new Button();
            CastAVote = new Button();
            ListCandidates = new Button();
            Title = new Label();
            Candidates = new Panel();
            candidates_label = new Label();
            Registered_Voters = new Panel();
            registered_label = new Label();
            Voters_cast = new Panel();
            votes_label = new Label();
            Remaining_voters = new Panel();
            remaining_voters_label = new Label();
            Description_1 = new Panel();
            label19 = new Label();
            label18 = new Label();
            Description_4 = new Panel();
            label21 = new Label();
            Description_3 = new Panel();
            label20 = new Label();
            List_candidates = new Panel();
            label10 = new Label();
            label6 = new Label();
            Cast_votes = new Panel();
            label11 = new Label();
            label7 = new Label();
            View_result = new Panel();
            label12 = new Label();
            label8 = new Label();
            Voter_Status = new Panel();
            label13 = new Label();
            label9 = new Label();
            label2 = new Label();
            label3 = new Label();
            Left_menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Description_2.SuspendLayout();
            Candidates.SuspendLayout();
            Registered_Voters.SuspendLayout();
            Voters_cast.SuspendLayout();
            Remaining_voters.SuspendLayout();
            Description_1.SuspendLayout();
            Description_4.SuspendLayout();
            Description_3.SuspendLayout();
            List_candidates.SuspendLayout();
            Cast_votes.SuspendLayout();
            View_result.SuspendLayout();
            Voter_Status.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Left_menu_panel
            // 
            Left_menu_panel.BackColor = Color.White;
            Left_menu_panel.Controls.Add(pictureBox1);
            Left_menu_panel.Controls.Add(Description_2);
            Left_menu_panel.Controls.Add(Exit);
            Left_menu_panel.Controls.Add(Status);
            Left_menu_panel.Controls.Add(Results);
            Left_menu_panel.Controls.Add(CastAVote);
            Left_menu_panel.Controls.Add(ListCandidates);
            Left_menu_panel.Controls.Add(Title);
            Left_menu_panel.Location = new Point(-1, -1);
            Left_menu_panel.Name = "Left_menu_panel";
            Left_menu_panel.Size = new Size(263, 721);
            Left_menu_panel.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // Description_2
            // 
            Description_2.BackColor = Color.FromArgb(14, 36, 66);
            Description_2.Controls.Add(label5);
            Description_2.Controls.Add(label4);
            Description_2.Location = new Point(13, 565);
            Description_2.Name = "Description_2";
            Description_2.Size = new Size(231, 133);
            Description_2.TabIndex = 19;
            Description_2.Paint += Description_2_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 44);
            label5.Name = "label5";
            label5.Size = new Size(198, 66);
            label5.TabIndex = 22;
            label5.Text = "Not an official election system.\r\nAll voters and candidates are \r\nfictional and nothing is saved.\r\n";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 14);
            label4.Name = "label4";
            label4.Size = new Size(159, 18);
            label4.TabIndex = 21;
            label4.Text = "Classroom simulation";
            label4.Click += label4_Click;
            // 
            // Exit
            // 
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatAppearance.MouseDownBackColor = Color.White;
            Exit.FlatAppearance.MouseOverBackColor = Color.White;
            Exit.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.FromArgb(14, 36, 66);
            Exit.Image = (Image)resources.GetObject("Exit.Image");
            Exit.ImageAlign = ContentAlignment.MiddleLeft;
            Exit.Location = new Point(26, 318);
            Exit.Name = "Exit";
            Exit.Padding = new Padding(0, 0, 110, 0);
            Exit.Size = new Size(207, 37);
            Exit.TabIndex = 14;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Status
            // 
            Status.FlatAppearance.BorderSize = 0;
            Status.FlatAppearance.MouseDownBackColor = Color.White;
            Status.FlatAppearance.MouseOverBackColor = Color.White;
            Status.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Status.ForeColor = Color.FromArgb(14, 36, 66);
            Status.Image = (Image)resources.GetObject("Status.Image");
            Status.ImageAlign = ContentAlignment.MiddleLeft;
            Status.Location = new Point(26, 262);
            Status.Name = "Status";
            Status.Padding = new Padding(0, 0, 50, 0);
            Status.Size = new Size(207, 37);
            Status.TabIndex = 16;
            Status.Text = "Voter status";
            Status.UseVisualStyleBackColor = true;
            Status.Click += Status_Click;
            // 
            // Results
            // 
            Results.FlatAppearance.BorderSize = 0;
            Results.FlatAppearance.MouseDownBackColor = Color.White;
            Results.FlatAppearance.MouseOverBackColor = Color.White;
            Results.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Results.ForeColor = Color.FromArgb(14, 36, 66);
            Results.Image = (Image)resources.GetObject("Results.Image");
            Results.ImageAlign = ContentAlignment.MiddleLeft;
            Results.Location = new Point(26, 207);
            Results.Name = "Results";
            Results.Padding = new Padding(0, 0, 52, 0);
            Results.Size = new Size(207, 37);
            Results.TabIndex = 15;
            Results.Text = "View Result";
            Results.UseVisualStyleBackColor = true;
            Results.Click += button3_Click;
            // 
            // CastAVote
            // 
            CastAVote.FlatAppearance.BorderColor = Color.White;
            CastAVote.FlatAppearance.BorderSize = 0;
            CastAVote.FlatAppearance.MouseDownBackColor = Color.White;
            CastAVote.FlatAppearance.MouseOverBackColor = Color.White;
            CastAVote.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CastAVote.ForeColor = Color.FromArgb(14, 36, 66);
            CastAVote.Image = (Image)resources.GetObject("CastAVote.Image");
            CastAVote.ImageAlign = ContentAlignment.MiddleLeft;
            CastAVote.Location = new Point(26, 151);
            CastAVote.Name = "CastAVote";
            CastAVote.Padding = new Padding(0, 0, 55, 0);
            CastAVote.Size = new Size(207, 37);
            CastAVote.TabIndex = 14;
            CastAVote.Text = "Cast a vote";
            CastAVote.UseVisualStyleBackColor = true;
            CastAVote.Click += CastAVote_Click;
            // 
            // ListCandidates
            // 
            ListCandidates.BackColor = Color.Transparent;
            ListCandidates.BackgroundImageLayout = ImageLayout.None;
            ListCandidates.FlatAppearance.BorderColor = Color.White;
            ListCandidates.FlatAppearance.BorderSize = 0;
            ListCandidates.FlatAppearance.MouseDownBackColor = Color.White;
            ListCandidates.FlatAppearance.MouseOverBackColor = Color.White;
            ListCandidates.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListCandidates.ForeColor = Color.FromArgb(14, 36, 66);
            ListCandidates.Image = (Image)resources.GetObject("ListCandidates.Image");
            ListCandidates.ImageAlign = ContentAlignment.MiddleLeft;
            ListCandidates.Location = new Point(26, 98);
            ListCandidates.Name = "ListCandidates";
            ListCandidates.Size = new Size(207, 37);
            ListCandidates.TabIndex = 13;
            ListCandidates.Text = "List candidates";
            ListCandidates.TextImageRelation = TextImageRelation.ImageBeforeText;
            ListCandidates.UseVisualStyleBackColor = false;
            ListCandidates.Click += button1_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.FromArgb(14, 36, 66);
            Title.Location = new Point(56, 39);
            Title.Name = "Title";
            Title.Size = new Size(184, 48);
            Title.TabIndex = 0;
            Title.Text = "Barangay Election \r\nSimulation";
            Title.Click += label1_Click;
            // 
            // Candidates
            // 
            Candidates.BackColor = Color.White;
            Candidates.Controls.Add(candidates_label);
            Candidates.Location = new Point(288, 97);
            Candidates.Name = "Candidates";
            Candidates.Padding = new Padding(5);
            Candidates.Size = new Size(182, 74);
            Candidates.TabIndex = 13;
            Candidates.Paint += panel1_Paint;
            // 
            // candidates_label
            // 
            candidates_label.AutoSize = true;
            candidates_label.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            candidates_label.ForeColor = Color.FromArgb(14, 36, 66);
            candidates_label.Location = new Point(8, 41);
            candidates_label.Name = "candidates_label";
            candidates_label.Size = new Size(88, 18);
            candidates_label.TabIndex = 0;
            candidates_label.Text = "Candidates";
            candidates_label.Click += label14_Click;
            // 
            // Registered_Voters
            // 
            Registered_Voters.BackColor = Color.White;
            Registered_Voters.Controls.Add(registered_label);
            Registered_Voters.Location = new Point(490, 97);
            Registered_Voters.Name = "Registered_Voters";
            Registered_Voters.Padding = new Padding(5);
            Registered_Voters.Size = new Size(182, 74);
            Registered_Voters.TabIndex = 14;
            Registered_Voters.Paint += Registered_Voters_Paint;
            // 
            // registered_label
            // 
            registered_label.AutoSize = true;
            registered_label.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registered_label.ForeColor = Color.FromArgb(14, 36, 66);
            registered_label.Location = new Point(10, 41);
            registered_label.Name = "registered_label";
            registered_label.Size = new Size(137, 18);
            registered_label.TabIndex = 1;
            registered_label.Text = "Registered voters";
            registered_label.Click += registered_label_Click;
            // 
            // Voters_cast
            // 
            Voters_cast.BackColor = Color.White;
            Voters_cast.Controls.Add(votes_label);
            Voters_cast.Location = new Point(693, 97);
            Voters_cast.Name = "Voters_cast";
            Voters_cast.Padding = new Padding(5);
            Voters_cast.Size = new Size(182, 74);
            Voters_cast.TabIndex = 14;
            Voters_cast.Paint += Voters_cast_Paint;
            // 
            // votes_label
            // 
            votes_label.AutoSize = true;
            votes_label.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            votes_label.ForeColor = Color.FromArgb(14, 36, 66);
            votes_label.Location = new Point(10, 41);
            votes_label.Name = "votes_label";
            votes_label.Size = new Size(86, 18);
            votes_label.TabIndex = 2;
            votes_label.Text = "Voters cast";
            // 
            // Remaining_voters
            // 
            Remaining_voters.BackColor = Color.White;
            Remaining_voters.Controls.Add(remaining_voters_label);
            Remaining_voters.Location = new Point(896, 97);
            Remaining_voters.Name = "Remaining_voters";
            Remaining_voters.Padding = new Padding(5);
            Remaining_voters.Size = new Size(182, 74);
            Remaining_voters.TabIndex = 14;
            Remaining_voters.Paint += Remaining_voters_Paint;
            // 
            // remaining_voters_label
            // 
            remaining_voters_label.AutoSize = true;
            remaining_voters_label.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remaining_voters_label.ForeColor = Color.FromArgb(14, 36, 66);
            remaining_voters_label.Location = new Point(10, 41);
            remaining_voters_label.Name = "remaining_voters_label";
            remaining_voters_label.Size = new Size(133, 18);
            remaining_voters_label.TabIndex = 3;
            remaining_voters_label.Text = "Remaining voters";
            // 
            // Description_1
            // 
            Description_1.BackColor = Color.White;
            Description_1.Controls.Add(label19);
            Description_1.Controls.Add(label18);
            Description_1.Controls.Add(Description_4);
            Description_1.Controls.Add(Description_3);
            Description_1.Location = new Point(288, 363);
            Description_1.Name = "Description_1";
            Description_1.Padding = new Padding(5);
            Description_1.Size = new Size(790, 169);
            Description_1.TabIndex = 18;
            Description_1.Paint += Description_1_Paint;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(20, 38);
            label19.Name = "label19";
            label19.Size = new Size(624, 20);
            label19.TabIndex = 3;
            label19.Text = "Who has voted and what was chosen are kept in two separate lists. Nothing connects a voter ID to a candidate ID.";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(20, 14);
            label18.Name = "label18";
            label18.Size = new Size(300, 24);
            label18.TabIndex = 2;
            label18.Text = "How ballot secrecy works here\r\n";
            // 
            // Description_4
            // 
            Description_4.BackColor = Color.FromArgb(244, 241, 234);
            Description_4.Controls.Add(label21);
            Description_4.Location = new Point(405, 73);
            Description_4.Name = "Description_4";
            Description_4.Size = new Size(367, 76);
            Description_4.TabIndex = 1;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(10, 9);
            label21.Name = "label21";
            label21.Size = new Size(234, 20);
            label21.TabIndex = 1;
            label21.Text = "Anonymous ballot box · choices only";
            // 
            // Description_3
            // 
            Description_3.BackColor = Color.FromArgb(244, 241, 234);
            Description_3.Controls.Add(label20);
            Description_3.Location = new Point(20, 73);
            Description_3.Name = "Description_3";
            Description_3.Size = new Size(364, 76);
            Description_3.TabIndex = 0;
            Description_3.Paint += Description_3_Paint;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(6, 9);
            label20.Name = "label20";
            label20.Size = new Size(187, 20);
            label20.TabIndex = 0;
            label20.Text = "Voter registry · who has voted\r\n";
            // 
            // List_candidates
            // 
            List_candidates.BackColor = Color.White;
            List_candidates.Controls.Add(label10);
            List_candidates.Controls.Add(label6);
            List_candidates.Location = new Point(288, 197);
            List_candidates.Name = "List_candidates";
            List_candidates.Size = new Size(182, 136);
            List_candidates.TabIndex = 19;
            List_candidates.Paint += List_candidates_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(14, 36, 66);
            label10.Location = new Point(10, 79);
            label10.Name = "label10";
            label10.Size = new Size(120, 40);
            label10.TabIndex = 23;
            label10.Text = "See every candidate\r\nand their platform\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(14, 36, 66);
            label6.Location = new Point(10, 55);
            label6.Name = "label6";
            label6.Size = new Size(154, 24);
            label6.TabIndex = 22;
            label6.Text = "List candidates";
            // 
            // Cast_votes
            // 
            Cast_votes.BackColor = Color.White;
            Cast_votes.Controls.Add(label11);
            Cast_votes.Controls.Add(label7);
            Cast_votes.Location = new Point(490, 197);
            Cast_votes.Name = "Cast_votes";
            Cast_votes.Size = new Size(182, 136);
            Cast_votes.TabIndex = 15;
            Cast_votes.Paint += Cast_votes_Paint_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(14, 36, 66);
            label11.Location = new Point(10, 79);
            label11.Name = "label11";
            label11.Size = new Size(141, 40);
            label11.TabIndex = 24;
            label11.Text = "Record one anonymous\r\nballot.";
            label11.Click += label11_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(14, 36, 66);
            label7.Location = new Point(10, 55);
            label7.Name = "label7";
            label7.Size = new Size(117, 24);
            label7.TabIndex = 23;
            label7.Text = "Cast a vote";
            label7.Click += label7_Click;
            // 
            // View_result
            // 
            View_result.BackColor = Color.White;
            View_result.Controls.Add(label12);
            View_result.Controls.Add(label8);
            View_result.Location = new Point(693, 197);
            View_result.Name = "View_result";
            View_result.Size = new Size(182, 136);
            View_result.TabIndex = 20;
            View_result.Paint += View_result_Paint_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(14, 36, 66);
            label12.Location = new Point(10, 79);
            label12.Name = "label12";
            label12.Size = new Size(131, 40);
            label12.TabIndex = 25;
            label12.Text = "Total and percentage \r\nper candidate\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(14, 36, 66);
            label8.Location = new Point(10, 55);
            label8.Name = "label8";
            label8.Size = new Size(114, 24);
            label8.TabIndex = 24;
            label8.Text = "View result";
            label8.Click += label8_Click;
            // 
            // Voter_Status
            // 
            Voter_Status.BackColor = Color.White;
            Voter_Status.Controls.Add(label13);
            Voter_Status.Controls.Add(label9);
            Voter_Status.Location = new Point(896, 197);
            Voter_Status.Name = "Voter_Status";
            Voter_Status.Size = new Size(182, 136);
            Voter_Status.TabIndex = 21;
            Voter_Status.Paint += Voter_Status_Paint_1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(14, 36, 66);
            label13.Location = new Point(10, 79);
            label13.Name = "label13";
            label13.Size = new Size(139, 40);
            label13.TabIndex = 26;
            label13.Text = "Who has voted and who\r\nremains.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(14, 36, 66);
            label9.Location = new Point(10, 55);
            label9.Name = "label9";
            label9.Size = new Size(125, 24);
            label9.TabIndex = 25;
            label9.Text = "Voter status";
            label9.Click += label9_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(14, 36, 66);
            label2.Location = new Point(288, 21);
            label2.Name = "label2";
            label2.Size = new Size(600, 48);
            label2.TabIndex = 21;
            label2.Text = "Barangay Chairperson election";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(14, 36, 66);
            label3.Location = new Point(296, 66);
            label3.Name = "label3";
            label3.Size = new Size(443, 20);
            label3.TabIndex = 21;
            label3.Text = "One position, three candidates, ten registered voters. Choose an option to begin\r\n";
            label3.Click += label3_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 241, 234);
            ClientSize = new Size(1100, 720);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Voter_Status);
            Controls.Add(View_result);
            Controls.Add(Cast_votes);
            Controls.Add(List_candidates);
            Controls.Add(Description_1);
            Controls.Add(Remaining_voters);
            Controls.Add(Voters_cast);
            Controls.Add(Registered_Voters);
            Controls.Add(Candidates);
            Controls.Add(Left_menu_panel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Homepage";
            Text = "Barangay ";
            Load += Form1_Load;
            Left_menu_panel.ResumeLayout(false);
            Left_menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Description_2.ResumeLayout(false);
            Description_2.PerformLayout();
            Candidates.ResumeLayout(false);
            Candidates.PerformLayout();
            Registered_Voters.ResumeLayout(false);
            Registered_Voters.PerformLayout();
            Voters_cast.ResumeLayout(false);
            Voters_cast.PerformLayout();
            Remaining_voters.ResumeLayout(false);
            Remaining_voters.PerformLayout();
            Description_1.ResumeLayout(false);
            Description_1.PerformLayout();
            Description_4.ResumeLayout(false);
            Description_4.PerformLayout();
            Description_3.ResumeLayout(false);
            Description_3.PerformLayout();
            List_candidates.ResumeLayout(false);
            List_candidates.PerformLayout();
            Cast_votes.ResumeLayout(false);
            Cast_votes.PerformLayout();
            View_result.ResumeLayout(false);
            View_result.PerformLayout();
            Voter_Status.ResumeLayout(false);
            Voter_Status.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Panel Left_menu_panel;
        private Label Title;
        private Panel Description_2;
        private Button Exit;
        private Button Status;
        private Button Results;
        private Button CastAVote;
        private Button ListCandidates;
        private Panel Candidates;
        private Panel Registered_Voters;
        private Panel Voters_cast;
        private Panel Remaining_voters;
        private Panel Description_1;
        private Panel List_candidates;
        private Panel Cast_votes;
        private Panel View_result;
        private Panel Voter_Status;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label candidates_label;
        private Label registered_label;
        private Label votes_label;
        private Label remaining_voters_label;
        private Panel Description_4;
        private Panel Description_3;
        private Label label18;
        private Label label19;
        private Label label21;
        private Label label20;
    }
}
