namespace TraderBeta_02
{
    partial class AccountForm
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            balance_lbl = new Label();
            panel3 = new Panel();
            investedPerc_lbl = new Label();
            label5 = new Label();
            panel4 = new Panel();
            ownedstocks_lbl = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 82);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(142, 26);
            label1.TabIndex = 0;
            label1.Text = "My Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(18, 33);
            label2.Name = "label2";
            label2.Size = new Size(138, 33);
            label2.TabIndex = 0;
            label2.Text = "Balance :";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(balance_lbl);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(202, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(537, 102);
            panel2.TabIndex = 4;
            // 
            // balance_lbl
            // 
            balance_lbl.AutoSize = true;
            balance_lbl.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            balance_lbl.ForeColor = Color.SeaGreen;
            balance_lbl.Location = new Point(376, 35);
            balance_lbl.Name = "balance_lbl";
            balance_lbl.Size = new Size(119, 32);
            balance_lbl.TabIndex = 0;
            balance_lbl.Text = "$000000";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(investedPerc_lbl);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(202, 268);
            panel3.Name = "panel3";
            panel3.Size = new Size(537, 102);
            panel3.TabIndex = 5;
            // 
            // investedPerc_lbl
            // 
            investedPerc_lbl.AutoSize = true;
            investedPerc_lbl.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            investedPerc_lbl.ForeColor = Color.SeaGreen;
            investedPerc_lbl.Location = new Point(425, 35);
            investedPerc_lbl.Name = "investedPerc_lbl";
            investedPerc_lbl.Size = new Size(90, 32);
            investedPerc_lbl.TabIndex = 0;
            investedPerc_lbl.Text = "0.00%";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(18, 33);
            label5.Name = "label5";
            label5.Size = new Size(143, 33);
            label5.TabIndex = 0;
            label5.Text = "Invested :";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(ownedstocks_lbl);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(202, 401);
            panel4.Name = "panel4";
            panel4.Size = new Size(537, 102);
            panel4.TabIndex = 6;
            // 
            // ownedstocks_lbl
            // 
            ownedstocks_lbl.AutoSize = true;
            ownedstocks_lbl.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ownedstocks_lbl.ForeColor = Color.MidnightBlue;
            ownedstocks_lbl.Location = new Point(471, 35);
            ownedstocks_lbl.Name = "ownedstocks_lbl";
            ownedstocks_lbl.Size = new Size(44, 32);
            ownedstocks_lbl.TabIndex = 0;
            ownedstocks_lbl.Text = "21";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(18, 33);
            label7.Name = "label7";
            label7.Size = new Size(288, 33);
            label7.TabIndex = 0;
            label7.Text = "Total Owned Stocks :";
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(952, 575);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccountForm";
            Text = "AccountForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Label label5;
        private Panel panel4;
        private Label label7;
        protected internal Label balance_lbl;
        protected internal Label investedPerc_lbl;
        protected internal Label ownedstocks_lbl;
    }
}