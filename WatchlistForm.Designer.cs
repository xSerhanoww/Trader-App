namespace TraderBeta_02
{
    partial class WatchlistForm
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
            ShowIndexes_btn = new RadioButton();
            showCrypto_btn = new RadioButton();
            showStocks_btn = new RadioButton();
            showAll_btn = new RadioButton();
            ShowCommodities_btn = new RadioButton();
            label1 = new Label();
            panel2 = new Panel();
            type_lbl = new Label();
            price_lbl = new Label();
            label5 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ShowIndexes_btn);
            panel1.Controls.Add(showCrypto_btn);
            panel1.Controls.Add(showStocks_btn);
            panel1.Controls.Add(showAll_btn);
            panel1.Controls.Add(ShowCommodities_btn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 82);
            panel1.TabIndex = 0;
            // 
            // ShowIndexes_btn
            // 
            ShowIndexes_btn.AutoSize = true;
            ShowIndexes_btn.Font = new Font("Century Gothic", 10F);
            ShowIndexes_btn.Location = new Point(726, 47);
            ShowIndexes_btn.Name = "ShowIndexes_btn";
            ShowIndexes_btn.Size = new Size(79, 23);
            ShowIndexes_btn.TabIndex = 5;
            ShowIndexes_btn.TabStop = true;
            ShowIndexes_btn.Text = "Indexes";
            ShowIndexes_btn.UseVisualStyleBackColor = true;
            ShowIndexes_btn.CheckedChanged += ShowIndexes_btn_CheckedChanged;
            // 
            // showCrypto_btn
            // 
            showCrypto_btn.AutoSize = true;
            showCrypto_btn.Font = new Font("Century Gothic", 10F);
            showCrypto_btn.Location = new Point(646, 46);
            showCrypto_btn.Name = "showCrypto_btn";
            showCrypto_btn.Size = new Size(74, 23);
            showCrypto_btn.TabIndex = 4;
            showCrypto_btn.TabStop = true;
            showCrypto_btn.Text = "Crypto";
            showCrypto_btn.UseVisualStyleBackColor = true;
            showCrypto_btn.CheckedChanged += showCrypto_btn_CheckedChanged;
            // 
            // showStocks_btn
            // 
            showStocks_btn.AutoSize = true;
            showStocks_btn.Font = new Font("Century Gothic", 10F);
            showStocks_btn.Location = new Point(571, 46);
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
            showAll_btn.Location = new Point(523, 46);
            showAll_btn.Name = "showAll_btn";
            showAll_btn.Size = new Size(42, 23);
            showAll_btn.TabIndex = 2;
            showAll_btn.TabStop = true;
            showAll_btn.Text = "All";
            showAll_btn.UseVisualStyleBackColor = true;
            showAll_btn.CheckedChanged += showAll_btn_CheckedChanged;
            // 
            // ShowCommodities_btn
            // 
            ShowCommodities_btn.AutoSize = true;
            ShowCommodities_btn.Font = new Font("Century Gothic", 10F);
            ShowCommodities_btn.Location = new Point(810, 47);
            ShowCommodities_btn.Name = "ShowCommodities_btn";
            ShowCommodities_btn.Size = new Size(117, 23);
            ShowCommodities_btn.TabIndex = 1;
            ShowCommodities_btn.TabStop = true;
            ShowCommodities_btn.Text = "Commodities";
            ShowCommodities_btn.UseVisualStyleBackColor = true;
            ShowCommodities_btn.CheckedChanged += ShowCommodities_btn_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(205, 26);
            label1.TabIndex = 0;
            label1.Text = "Trending Watchlist";
            // 
            // panel2
            // 
            panel2.Controls.Add(type_lbl);
            panel2.Controls.Add(price_lbl);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(952, 51);
            panel2.TabIndex = 1;
            // 
            // type_lbl
            // 
            type_lbl.AutoSize = true;
            type_lbl.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            type_lbl.ForeColor = SystemColors.ControlDarkDark;
            type_lbl.Location = new Point(602, 29);
            type_lbl.Name = "type_lbl";
            type_lbl.Size = new Size(41, 19);
            type_lbl.TabIndex = 0;
            type_lbl.Text = "Type";
            // 
            // price_lbl
            // 
            price_lbl.AutoSize = true;
            price_lbl.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            price_lbl.ForeColor = SystemColors.ControlDarkDark;
            price_lbl.Location = new Point(510, 29);
            price_lbl.Name = "price_lbl";
            price_lbl.Size = new Size(42, 19);
            price_lbl.TabIndex = 0;
            price_lbl.Text = "Price";
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
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(952, 442);
            panel3.TabIndex = 2;
            // 
            // WatchlistForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(952, 575);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WatchlistForm";
            Text = "WatchlistForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private RadioButton ShowCommodities_btn;
        private Label label5;
        private RadioButton ShowIndexes_btn;
        private RadioButton showCrypto_btn;
        private RadioButton showStocks_btn;
        private RadioButton showAll_btn;
        private Label type_lbl;
        private Label price_lbl;
    }
}