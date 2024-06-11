namespace TraderBeta_02
{
    partial class StocksBar
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
            pictureBox1 = new PictureBox();
            stockName_lbl = new Label();
            stockFN_lbl = new Label();
            stockType_lbl = new Label();
            stockPrice_lbl = new Label();
            buy_btn = new Button();
            investmentAmount_lbl = new Label();
            units_lbl = new Label();
            profit_lbl = new Label();
            sell_btn = new Button();
            ordernum_lbl = new Label();
            buyPrice_lbl = new Label();
            dollarSign_lbl = new Label();
            dollarSign2_lbl = new Label();
            dollarSign3_lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(9, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // stockName_lbl
            // 
            stockName_lbl.AutoSize = true;
            stockName_lbl.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            stockName_lbl.Location = new Point(75, 15);
            stockName_lbl.Name = "stockName_lbl";
            stockName_lbl.Size = new Size(103, 19);
            stockName_lbl.TabIndex = 1;
            stockName_lbl.Text = "Stock Name";
            // 
            // stockFN_lbl
            // 
            stockFN_lbl.AutoSize = true;
            stockFN_lbl.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            stockFN_lbl.ForeColor = SystemColors.ControlDarkDark;
            stockFN_lbl.Location = new Point(77, 37);
            stockFN_lbl.Name = "stockFN_lbl";
            stockFN_lbl.Size = new Size(81, 16);
            stockFN_lbl.TabIndex = 1;
            stockFN_lbl.Text = "Stock Owner";
            // 
            // stockType_lbl
            // 
            stockType_lbl.AutoSize = true;
            stockType_lbl.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            stockType_lbl.Location = new Point(599, 26);
            stockType_lbl.Name = "stockType_lbl";
            stockType_lbl.Size = new Size(72, 19);
            stockType_lbl.TabIndex = 1;
            stockType_lbl.Text = "0000000";
            stockType_lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // stockPrice_lbl
            // 
            stockPrice_lbl.AutoSize = true;
            stockPrice_lbl.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            stockPrice_lbl.Location = new Point(522, 26);
            stockPrice_lbl.Name = "stockPrice_lbl";
            stockPrice_lbl.Size = new Size(72, 19);
            stockPrice_lbl.TabIndex = 1;
            stockPrice_lbl.Text = "0000000";
            stockPrice_lbl.TextAlign = ContentAlignment.BottomRight;
            // 
            // buy_btn
            // 
            buy_btn.BackColor = Color.SeaGreen;
            buy_btn.Cursor = Cursors.Hand;
            buy_btn.FlatAppearance.BorderSize = 0;
            buy_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 57, 57);
            buy_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 57, 57);
            buy_btn.FlatStyle = FlatStyle.Flat;
            buy_btn.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buy_btn.ForeColor = Color.White;
            buy_btn.Location = new Point(729, 15);
            buy_btn.Name = "buy_btn";
            buy_btn.Padding = new Padding(5);
            buy_btn.Size = new Size(201, 38);
            buy_btn.TabIndex = 2;
            buy_btn.Text = "BUY";
            buy_btn.TextAlign = ContentAlignment.MiddleRight;
            buy_btn.UseVisualStyleBackColor = false;
            buy_btn.Click += buy_btn_Click;
            // 
            // investmentAmount_lbl
            // 
            investmentAmount_lbl.AutoSize = true;
            investmentAmount_lbl.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            investmentAmount_lbl.Location = new Point(265, 26);
            investmentAmount_lbl.Name = "investmentAmount_lbl";
            investmentAmount_lbl.Size = new Size(72, 19);
            investmentAmount_lbl.TabIndex = 1;
            investmentAmount_lbl.Text = "0000000";
            investmentAmount_lbl.TextAlign = ContentAlignment.MiddleRight;
            investmentAmount_lbl.Visible = false;
            // 
            // units_lbl
            // 
            units_lbl.AutoSize = true;
            units_lbl.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            units_lbl.Location = new Point(436, 26);
            units_lbl.Name = "units_lbl";
            units_lbl.Size = new Size(72, 19);
            units_lbl.TabIndex = 1;
            units_lbl.Text = "0000000";
            units_lbl.TextAlign = ContentAlignment.MiddleRight;
            units_lbl.Visible = false;
            // 
            // profit_lbl
            // 
            profit_lbl.AutoSize = true;
            profit_lbl.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            profit_lbl.Location = new Point(356, 26);
            profit_lbl.Name = "profit_lbl";
            profit_lbl.Size = new Size(72, 19);
            profit_lbl.TabIndex = 1;
            profit_lbl.Text = "0000000";
            profit_lbl.TextAlign = ContentAlignment.MiddleRight;
            profit_lbl.Visible = false;
            // 
            // sell_btn
            // 
            sell_btn.BackColor = Color.Crimson;
            sell_btn.Cursor = Cursors.Hand;
            sell_btn.FlatAppearance.BorderSize = 0;
            sell_btn.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            sell_btn.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            sell_btn.FlatStyle = FlatStyle.Flat;
            sell_btn.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sell_btn.ForeColor = Color.White;
            sell_btn.Location = new Point(729, 14);
            sell_btn.Name = "sell_btn";
            sell_btn.Padding = new Padding(5);
            sell_btn.Size = new Size(201, 38);
            sell_btn.TabIndex = 2;
            sell_btn.Text = "SELL";
            sell_btn.TextAlign = ContentAlignment.MiddleRight;
            sell_btn.UseVisualStyleBackColor = false;
            sell_btn.Visible = false;
            sell_btn.Click += sell_btn_Click;
            // 
            // ordernum_lbl
            // 
            ordernum_lbl.AutoSize = true;
            ordernum_lbl.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ordernum_lbl.Location = new Point(0, 0);
            ordernum_lbl.Name = "ordernum_lbl";
            ordernum_lbl.Size = new Size(193, 19);
            ordernum_lbl.TabIndex = 1;
            ordernum_lbl.Text = "order_num_visible_false";
            ordernum_lbl.TextAlign = ContentAlignment.MiddleRight;
            ordernum_lbl.Visible = false;
            // 
            // buyPrice_lbl
            // 
            buyPrice_lbl.AutoSize = true;
            buyPrice_lbl.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buyPrice_lbl.Location = new Point(199, 0);
            buyPrice_lbl.Name = "buyPrice_lbl";
            buyPrice_lbl.Size = new Size(176, 19);
            buyPrice_lbl.TabIndex = 1;
            buyPrice_lbl.Text = "buyPrice_visible_false";
            buyPrice_lbl.TextAlign = ContentAlignment.MiddleRight;
            buyPrice_lbl.Visible = false;
            // 
            // dollarSign_lbl
            // 
            dollarSign_lbl.AutoSize = true;
            dollarSign_lbl.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dollarSign_lbl.Location = new Point(252, 27);
            dollarSign_lbl.Name = "dollarSign_lbl";
            dollarSign_lbl.Size = new Size(16, 17);
            dollarSign_lbl.TabIndex = 1;
            dollarSign_lbl.Text = "$";
            dollarSign_lbl.TextAlign = ContentAlignment.MiddleRight;
            dollarSign_lbl.Visible = false;
            // 
            // dollarSign2_lbl
            // 
            dollarSign2_lbl.AutoSize = true;
            dollarSign2_lbl.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dollarSign2_lbl.Location = new Point(343, 27);
            dollarSign2_lbl.Name = "dollarSign2_lbl";
            dollarSign2_lbl.Size = new Size(16, 17);
            dollarSign2_lbl.TabIndex = 1;
            dollarSign2_lbl.Text = "$";
            dollarSign2_lbl.TextAlign = ContentAlignment.MiddleRight;
            dollarSign2_lbl.Visible = false;
            // 
            // dollarSign3_lbl
            // 
            dollarSign3_lbl.AutoSize = true;
            dollarSign3_lbl.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dollarSign3_lbl.Location = new Point(510, 27);
            dollarSign3_lbl.Name = "dollarSign3_lbl";
            dollarSign3_lbl.Size = new Size(16, 17);
            dollarSign3_lbl.TabIndex = 1;
            dollarSign3_lbl.Text = "$";
            dollarSign3_lbl.TextAlign = ContentAlignment.MiddleRight;
            dollarSign3_lbl.Visible = false;
            // 
            // StocksBar
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(sell_btn);
            Controls.Add(buy_btn);
            Controls.Add(stockFN_lbl);
            Controls.Add(profit_lbl);
            Controls.Add(units_lbl);
            Controls.Add(stockPrice_lbl);
            Controls.Add(buyPrice_lbl);
            Controls.Add(ordernum_lbl);
            Controls.Add(dollarSign3_lbl);
            Controls.Add(dollarSign2_lbl);
            Controls.Add(dollarSign_lbl);
            Controls.Add(investmentAmount_lbl);
            Controls.Add(stockType_lbl);
            Controls.Add(stockName_lbl);
            Controls.Add(pictureBox1);
            Name = "StocksBar";
            Size = new Size(952, 70);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        protected internal PictureBox pictureBox1;
        protected internal Label stockName_lbl;
        protected internal Label stockFN_lbl;
        protected internal Label stockType_lbl;
        protected internal Label stockPrice_lbl;
        protected internal Button buy_btn;
        protected internal Label investmentAmount_lbl;
        protected internal Label units_lbl;
        protected internal Label profit_lbl;
        protected internal Button sell_btn;
        protected internal Label ordernum_lbl;
        protected internal Label buyPrice_lbl;
        protected internal Label dollarSign_lbl;
        protected internal Label dollarSign2_lbl;
        protected internal Label dollarSign3_lbl;
    }
}
