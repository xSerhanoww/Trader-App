namespace TraderBeta_02
{
    partial class LoginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginControl));
            login_btn = new Button();
            panel3 = new Panel();
            exit = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            password_txtbox = new TextBox();
            panel1 = new Panel();
            username_txtbox = new TextBox();
            incorrectPass_lbl = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.SeaGreen;
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 57, 57);
            login_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 57, 57);
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(79, 458);
            login_btn.Name = "login_btn";
            login_btn.Padding = new Padding(5);
            login_btn.Size = new Size(301, 50);
            login_btn.TabIndex = 14;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Controls.Add(exit);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(476, 84);
            panel3.TabIndex = 13;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exit.ForeColor = Color.White;
            exit.Location = new Point(445, 19);
            exit.Name = "exit";
            exit.Size = new Size(22, 22);
            exit.TabIndex = 11;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(97, 51);
            label4.Name = "label4";
            label4.Size = new Size(113, 19);
            label4.TabIndex = 7;
            label4.Text = "LOGIN PANEL";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-53, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(password_txtbox);
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(44, 267);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 66);
            panel2.TabIndex = 11;
            // 
            // password_txtbox
            // 
            password_txtbox.BorderStyle = BorderStyle.None;
            password_txtbox.Cursor = Cursors.IBeam;
            password_txtbox.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            password_txtbox.Location = new Point(17, 14);
            password_txtbox.Name = "password_txtbox";
            password_txtbox.PlaceholderText = "PASSWORD";
            password_txtbox.Size = new Size(353, 33);
            password_txtbox.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(username_txtbox);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(44, 144);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 66);
            panel1.TabIndex = 12;
            // 
            // username_txtbox
            // 
            username_txtbox.BorderStyle = BorderStyle.None;
            username_txtbox.Cursor = Cursors.IBeam;
            username_txtbox.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            username_txtbox.Location = new Point(17, 14);
            username_txtbox.Name = "username_txtbox";
            username_txtbox.PlaceholderText = "USERNAME";
            username_txtbox.Size = new Size(353, 33);
            username_txtbox.TabIndex = 6;
            // 
            // incorrectPass_lbl
            // 
            incorrectPass_lbl.AutoSize = true;
            incorrectPass_lbl.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            incorrectPass_lbl.ForeColor = Color.Red;
            incorrectPass_lbl.Location = new Point(97, 347);
            incorrectPass_lbl.Name = "incorrectPass_lbl";
            incorrectPass_lbl.Size = new Size(274, 19);
            incorrectPass_lbl.TabIndex = 7;
            incorrectPass_lbl.Text = "INCORRECT USERNAME OR PASSWORD!";
            incorrectPass_lbl.Visible = false;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(login_btn);
            Controls.Add(incorrectPass_lbl);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LoginControl";
            Size = new Size(476, 556);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected internal Button login_btn;
        private Panel panel3;
        private Label exit;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel2;
        protected internal TextBox password_txtbox;
        private Panel panel1;
        protected internal TextBox username_txtbox;
        private Label incorrectPass_lbl;
    }
}
