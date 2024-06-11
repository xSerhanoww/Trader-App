namespace TraderBeta_02
{
    partial class PortfolioForm
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
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            showIndexes_btn = new RadioButton();
            ShowCrypto_btn = new RadioButton();
            showStocks_btn = new RadioButton();
            showAll_btn = new RadioButton();
            showCommodities_btn = new RadioButton();
            label1 = new Label();
            panel3 = new Panel();
            aBitEmpty_lbl = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(952, 51);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(602, 29);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 5;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(255, 29);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 6;
            label3.Text = "Value";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(346, 29);
            label4.Name = "label4";
            label4.Size = new Size(29, 19);
            label4.TabIndex = 7;
            label4.Text = "P/L";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(435, 29);
            label6.Name = "label6";
            label6.Size = new Size(40, 19);
            label6.TabIndex = 8;
            label6.Text = "Units";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(510, 29);
            label7.Name = "label7";
            label7.Size = new Size(42, 19);
            label7.TabIndex = 9;
            label7.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(3, 29);
            label5.Name = "label5";
            label5.Size = new Size(62, 19);
            label5.TabIndex = 0;
            label5.Text = "Markets";
            // 
            // panel1
            // 
            panel1.Controls.Add(showIndexes_btn);
            panel1.Controls.Add(ShowCrypto_btn);
            panel1.Controls.Add(showStocks_btn);
            panel1.Controls.Add(showAll_btn);
            panel1.Controls.Add(showCommodities_btn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 82);
            panel1.TabIndex = 2;
            // 
            // showIndexes_btn
            // 
            showIndexes_btn.AutoSize = true;
            showIndexes_btn.Font = new Font("Century Gothic", 10F);
            showIndexes_btn.Location = new Point(725, 47);
            showIndexes_btn.Name = "showIndexes_btn";
            showIndexes_btn.Size = new Size(79, 23);
            showIndexes_btn.TabIndex = 5;
            showIndexes_btn.TabStop = true;
            showIndexes_btn.Text = "Indexes";
            showIndexes_btn.UseVisualStyleBackColor = true;
            showIndexes_btn.CheckedChanged += showIndexes_btn_CheckedChanged;
            // 
            // ShowCrypto_btn
            // 
            ShowCrypto_btn.AutoSize = true;
            ShowCrypto_btn.Font = new Font("Century Gothic", 10F);
            ShowCrypto_btn.Location = new Point(645, 46);
            ShowCrypto_btn.Name = "ShowCrypto_btn";
            ShowCrypto_btn.Size = new Size(74, 23);
            ShowCrypto_btn.TabIndex = 4;
            ShowCrypto_btn.TabStop = true;
            ShowCrypto_btn.Text = "Crypto";
            ShowCrypto_btn.UseVisualStyleBackColor = true;
            ShowCrypto_btn.CheckedChanged += ShowCrypto_btn_CheckedChanged;
            // 
            // showStocks_btn
            // 
            showStocks_btn.AutoSize = true;
            showStocks_btn.Font = new Font("Century Gothic", 10F);
            showStocks_btn.Location = new Point(570, 46);
            showStocks_btn.Name = "showStocks_btn";
            showStocks_btn.Size = new Size(69, 23);
            showStocks_btn.TabIndex = 3;
            showStocks_btn.TabStop = true;
            showStocks_btn.Text = "Stocks";
            showStocks_btn.UseVisualStyleBackColor = true;
            showStocks_btn.CheckedChanged += showStocks_btn_CheckedChanged;
            // 
            // showAll_btn
            // 
            showAll_btn.AutoSize = true;
            showAll_btn.Font = new Font("Century Gothic", 10F);
            showAll_btn.Location = new Point(522, 46);
            showAll_btn.Name = "showAll_btn";
            showAll_btn.Size = new Size(42, 23);
            showAll_btn.TabIndex = 2;
            showAll_btn.TabStop = true;
            showAll_btn.Text = "All";
            showAll_btn.UseVisualStyleBackColor = true;
            showAll_btn.CheckedChanged += showAll_btn_CheckedChanged;
            // 
            // showCommodities_btn
            // 
            showCommodities_btn.AutoSize = true;
            showCommodities_btn.Font = new Font("Century Gothic", 10F);
            showCommodities_btn.Location = new Point(810, 47);
            showCommodities_btn.Name = "showCommodities_btn";
            showCommodities_btn.Size = new Size(117, 23);
            showCommodities_btn.TabIndex = 1;
            showCommodities_btn.TabStop = true;
            showCommodities_btn.Text = "Commodities";
            showCommodities_btn.UseVisualStyleBackColor = true;
            showCommodities_btn.CheckedChanged += showCommodities_btn_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(135, 26);
            label1.TabIndex = 0;
            label1.Text = "My Portfolio";
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(aBitEmpty_lbl);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(952, 442);
            panel3.TabIndex = 4;
            // 
            // aBitEmpty_lbl
            // 
            aBitEmpty_lbl.AutoSize = true;
            aBitEmpty_lbl.Font = new Font("Century Gothic", 25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            aBitEmpty_lbl.ForeColor = SystemColors.Control;
            aBitEmpty_lbl.Location = new Point(247, 171);
            aBitEmpty_lbl.Name = "aBitEmpty_lbl";
            aBitEmpty_lbl.Size = new Size(445, 40);
            aBitEmpty_lbl.TabIndex = 0;
            aBitEmpty_lbl.Text = "Hmm.. a bit empty in here";
            aBitEmpty_lbl.Visible = false;
            // 
            // PortfolioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(952, 575);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PortfolioForm";
            Text = "PortfolioForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label5;
        private Panel panel1;
        private RadioButton showIndexes_btn;
        private RadioButton ShowCrypto_btn;
        private RadioButton showStocks_btn;
        private RadioButton showAll_btn;
        private RadioButton showCommodities_btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        protected internal Panel panel3;
        protected internal Label aBitEmpty_lbl;
    }
}