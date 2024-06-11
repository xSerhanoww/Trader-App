namespace TraderBeta_02
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            login_btn = new Label();
            logout_btn = new Label();
            SidePanel = new Panel();
            acc_btn = new Button();
            portfolio_btn = new Button();
            watchlist_btn = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            welcome_lbl = new Label();
            exit = new Label();
            panel3 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(login_btn);
            panel1.Controls.Add(logout_btn);
            panel1.Controls.Add(SidePanel);
            panel1.Controls.Add(acc_btn);
            panel1.Controls.Add(portfolio_btn);
            panel1.Controls.Add(watchlist_btn);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 650);
            panel1.TabIndex = 0;
            // 
            // login_btn
            // 
            login_btn.AutoSize = true;
            login_btn.Cursor = Cursors.Hand;
            login_btn.Font = new Font("Century Gothic", 14F, FontStyle.Underline, GraphicsUnit.Point, 204);
            login_btn.ForeColor = SystemColors.ControlText;
            login_btn.Location = new Point(12, 606);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(59, 22);
            login_btn.TabIndex = 0;
            login_btn.Text = "Login";
            login_btn.Click += login_btn_Click;
            // 
            // logout_btn
            // 
            logout_btn.AutoSize = true;
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point, 204);
            logout_btn.ForeColor = SystemColors.ControlDark;
            logout_btn.Location = new Point(12, 606);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(73, 21);
            logout_btn.TabIndex = 0;
            logout_btn.Text = "Log Out";
            logout_btn.Visible = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.SeaGreen;
            SidePanel.Location = new Point(0, 222);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(10, 46);
            SidePanel.TabIndex = 2;
            // 
            // acc_btn
            // 
            acc_btn.Cursor = Cursors.Hand;
            acc_btn.FlatAppearance.BorderSize = 0;
            acc_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 57, 57);
            acc_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 57, 57);
            acc_btn.FlatStyle = FlatStyle.Flat;
            acc_btn.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            acc_btn.ForeColor = Color.White;
            acc_btn.Location = new Point(0, 326);
            acc_btn.Name = "acc_btn";
            acc_btn.Padding = new Padding(15, 0, 0, 0);
            acc_btn.Size = new Size(245, 46);
            acc_btn.TabIndex = 1;
            acc_btn.Text = "Account";
            acc_btn.TextAlign = ContentAlignment.MiddleLeft;
            acc_btn.UseVisualStyleBackColor = true;
            acc_btn.Click += acc_btn_Click;
            // 
            // portfolio_btn
            // 
            portfolio_btn.Cursor = Cursors.Hand;
            portfolio_btn.FlatAppearance.BorderSize = 0;
            portfolio_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 57, 57);
            portfolio_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 57, 57);
            portfolio_btn.FlatStyle = FlatStyle.Flat;
            portfolio_btn.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            portfolio_btn.ForeColor = Color.White;
            portfolio_btn.Location = new Point(0, 274);
            portfolio_btn.Name = "portfolio_btn";
            portfolio_btn.Padding = new Padding(15, 0, 0, 0);
            portfolio_btn.Size = new Size(245, 46);
            portfolio_btn.TabIndex = 1;
            portfolio_btn.Text = "Portfolio";
            portfolio_btn.TextAlign = ContentAlignment.MiddleLeft;
            portfolio_btn.UseVisualStyleBackColor = true;
            portfolio_btn.Click += portfolio_btn_Click;
            // 
            // watchlist_btn
            // 
            watchlist_btn.Cursor = Cursors.Hand;
            watchlist_btn.FlatAppearance.BorderSize = 0;
            watchlist_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 57, 57);
            watchlist_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 57, 57);
            watchlist_btn.FlatStyle = FlatStyle.Flat;
            watchlist_btn.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            watchlist_btn.ForeColor = Color.White;
            watchlist_btn.Location = new Point(0, 222);
            watchlist_btn.Name = "watchlist_btn";
            watchlist_btn.Padding = new Padding(15, 0, 0, 0);
            watchlist_btn.Size = new Size(245, 46);
            watchlist_btn.TabIndex = 1;
            watchlist_btn.Text = "Watchlist";
            watchlist_btn.TextAlign = ContentAlignment.MiddleLeft;
            watchlist_btn.UseVisualStyleBackColor = true;
            watchlist_btn.Click += watchlist_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(welcome_lbl);
            panel2.Controls.Add(exit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(248, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(952, 75);
            panel2.TabIndex = 1;
            // 
            // welcome_lbl
            // 
            welcome_lbl.AutoSize = true;
            welcome_lbl.Cursor = Cursors.Hand;
            welcome_lbl.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            welcome_lbl.ForeColor = SystemColors.ControlText;
            welcome_lbl.Location = new Point(21, 28);
            welcome_lbl.Name = "welcome_lbl";
            welcome_lbl.Size = new Size(206, 22);
            welcome_lbl.TabIndex = 0;
            welcome_lbl.Text = "Welcome, Username !";
            welcome_lbl.Visible = false;
            welcome_lbl.Click += login_btn_Click;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exit.Location = new Point(900, 28);
            exit.Name = "exit";
            exit.Size = new Size(22, 22);
            exit.TabIndex = 0;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(248, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(952, 575);
            panel3.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 650);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button acc_btn;
        private Button portfolio_btn;
        private Button watchlist_btn;
        private Label exit;
        private Panel SidePanel;
        protected internal Panel panel3;
        protected internal Panel panel1;
        protected internal Label welcome_lbl;
        protected internal Label login_btn;
        protected internal Label logout_btn;
        private System.Windows.Forms.Timer timer1;
    }
}
