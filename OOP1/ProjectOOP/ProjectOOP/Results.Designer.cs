namespace ProjectOOP
{
    partial class Results
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Results));
            Left_menu_panel = new Panel();
            pictureBox1 = new PictureBox();
            Description_2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            Exit = new Button();
            Status = new Button();
            button1 = new Button();
            CastAVote = new Button();
            ListCandidates = new Button();
            Title = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            progressBar3 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar1 = new ProgressBar();
            Left_menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Description_2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Left_menu_panel
            // 
            Left_menu_panel.BackColor = Color.White;
            Left_menu_panel.Controls.Add(pictureBox1);
            Left_menu_panel.Controls.Add(Description_2);
            Left_menu_panel.Controls.Add(Exit);
            Left_menu_panel.Controls.Add(Status);
            Left_menu_panel.Controls.Add(button1);
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
            Description_2.Location = new Point(13, 573);
            Description_2.Name = "Description_2";
            Description_2.Size = new Size(231, 125);
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
            label5.Text = "Not an official election system.\r\nAll voters and candidates are\r\nfictional and nothing is saved.\r\n";
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
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(14, 36, 66);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(26, 207);
            button1.Name = "button1";
            button1.Padding = new Padding(0, 0, 52, 0);
            button1.Size = new Size(207, 37);
            button1.TabIndex = 15;
            button1.Text = "View Result";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            ListCandidates.Click += ListCandidates_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(14, 36, 66);
            label2.Location = new Point(288, 21);
            label2.Name = "label2";
            label2.Size = new Size(315, 48);
            label2.TabIndex = 22;
            label2.Text = "Election results";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(14, 36, 66);
            label3.Location = new Point(298, 69);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 23;
            label3.Text = "Counts of votes\r\n";
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(progressBar3);
            panel1.Controls.Add(progressBar2);
            panel1.Controls.Add(progressBar1);
            panel1.Location = new Point(288, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 357);
            panel1.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(26, 219);
            label8.Name = "label8";
            label8.Size = new Size(107, 21);
            label8.TabIndex = 5;
            label8.Text = "Teresa Lim";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 117);
            label7.Name = "label7";
            label7.Size = new Size(126, 21);
            label7.TabIndex = 4;
            label7.Text = "Ramon Dizon";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 19);
            label6.Name = "label6";
            label6.Size = new Size(156, 21);
            label6.TabIndex = 3;
            label6.Text = "Elena Villanueva";
            label6.Click += label6_Click;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(26, 160);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(717, 41);
            progressBar3.TabIndex = 2;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(26, 262);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(717, 41);
            progressBar2.TabIndex = 1;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(26, 53);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(717, 40);
            progressBar1.TabIndex = 0;
            progressBar1.Click += progressBar1_Click;
            // 
            // Results
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 241, 234);
            ClientSize = new Size(1100, 720);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Left_menu_panel);
            Name = "Results";
            Text = "Form1";
            Left_menu_panel.ResumeLayout(false);
            Left_menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Description_2.ResumeLayout(false);
            Description_2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button button1;
        private Button CastAVote;
        private Button ListCandidates;
        private Label Title;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private ProgressBar progressBar3;
        private ProgressBar progressBar2;
        private ProgressBar progressBar1;
    }
}