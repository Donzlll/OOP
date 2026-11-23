namespace ProjectOOP
{
    partial class VoterStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoterStatus));
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
            dataGridView1 = new DataGridView();
            VOTER_ID = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            STATS = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            Left_menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Description_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            Left_menu_panel.Location = new Point(0, 0);
            Left_menu_panel.Name = "Left_menu_panel";
            Left_menu_panel.Size = new Size(263, 721);
            Left_menu_panel.TabIndex = 13;
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
            Description_2.Location = new Point(13, 572);
            Description_2.Name = "Description_2";
            Description_2.Size = new Size(231, 126);
            Description_2.TabIndex = 19;
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
            Results.Click += Results_Click;
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
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.FromArgb(14, 36, 66);
            Title.Location = new Point(56, 39);
            Title.Name = "Title";
            Title.Size = new Size(178, 48);
            Title.TabIndex = 0;
            Title.Text = "Barangay Election\r\nSimulation";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { VOTER_ID, NAME, STATS });
            dataGridView1.Location = new Point(296, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(756, 421);
            dataGridView1.TabIndex = 0;
            // 
            // VOTER_ID
            // 
            VOTER_ID.HeaderText = "VOTER ID";
            VOTER_ID.MinimumWidth = 6;
            VOTER_ID.Name = "VOTER_ID";
            VOTER_ID.Width = 125;
            // 
            // NAME
            // 
            NAME.HeaderText = "NAME";
            NAME.MinimumWidth = 6;
            NAME.Name = "NAME";
            NAME.Width = 125;
            // 
            // STATS
            // 
            STATS.HeaderText = "STATUS";
            STATS.MinimumWidth = 6;
            STATS.Name = "STATS";
            STATS.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(14, 36, 66);
            label2.Location = new Point(288, 21);
            label2.Name = "label2";
            label2.Size = new Size(600, 48);
            label2.TabIndex = 22;
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
            label3.TabIndex = 23;
            label3.Text = "One position, three candidates, ten registered voters. Choose an option to begin\r\n";
            // 
            // VoterStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 241, 234);
            ClientSize = new Size(1100, 720);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Left_menu_panel);
            Name = "VoterStatus";
            Text = "Form1";
            Left_menu_panel.ResumeLayout(false);
            Left_menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Description_2.ResumeLayout(false);
            Description_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Left_menu_panel;
        private PictureBox pictureBox1;
        private Panel Description_2;
        private Label label5;
        private Label label4;
        private Button Exit;
        private Button Status;
        private Button Results;
        private Button CastAVote;
        private Button ListCandidates;
        private Label Title;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn VOTER_ID;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn STATS;
        private Label label2;
        private Label label3;
    }
}