namespace TraderBeta_02
{
    partial class TransactionsControl
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
            confirm_btn = new Button();
            exit = new Label();
            label1 = new Label();
            amountInvested_txtbox = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            unitsAmt_lbl = new Label();
            pictureBox1 = new PictureBox();
            stockname_lbl = new Label();
            fullname_lbl = new Label();
            balance_lbl = new Label();
            label3 = new Label();
            label4 = new Label();
            price_lbl = new Label();
            label6 = new Label();
            label5 = new Label();
            insfFunds = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // confirm_btn
            // 
            confirm_btn.BackColor = Color.SeaGreen;
            confirm_btn.Cursor = Cursors.Hand;
            confirm_btn.FlatAppearance.BorderSize = 0;
            confirm_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 57, 57);
            confirm_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 57, 57);
            confirm_btn.FlatStyle = FlatStyle.Flat;
            confirm_btn.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            confirm_btn.ForeColor = Color.White;
            confirm_btn.Location = new Point(86, 471);
            confirm_btn.Name = "confirm_btn";
            confirm_btn.Padding = new Padding(5);
            confirm_btn.Size = new Size(301, 50);
            confirm_btn.TabIndex = 3;
            confirm_btn.Text = "CONFIRM";
            confirm_btn.UseVisualStyleBackColor = false;
            confirm_btn.Click += confirm_btn_Click;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exit.Location = new Point(445, 16);
            exit.Name = "exit";
            exit.Size = new Size(22, 22);
            exit.TabIndex = 4;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(13, 20);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 5;
            label1.Text = "Amount :";
            // 
            // amountInvested_txtbox
            // 
            amountInvested_txtbox.BorderStyle = BorderStyle.None;
            amountInvested_txtbox.Cursor = Cursors.IBeam;
            amountInvested_txtbox.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            amountInvested_txtbox.Location = new Point(211, 14);
            amountInvested_txtbox.Name = "amountInvested_txtbox";
            amountInvested_txtbox.PlaceholderText = "10,000";
            amountInvested_txtbox.Size = new Size(152, 33);
            amountInvested_txtbox.TabIndex = 6;
            amountInvested_txtbox.TextAlign = HorizontalAlignment.Right;
            amountInvested_txtbox.TextChanged += amountInvested_txtbox_TextChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(amountInvested_txtbox);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(48, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 66);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(363, 20);
            label2.Name = "label2";
            label2.Size = new Size(21, 23);
            label2.TabIndex = 7;
            label2.Text = "$";
            // 
            // unitsAmt_lbl
            // 
            unitsAmt_lbl.AutoSize = true;
            unitsAmt_lbl.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            unitsAmt_lbl.Location = new Point(142, 324);
            unitsAmt_lbl.Name = "unitsAmt_lbl";
            unitsAmt_lbl.Size = new Size(0, 32);
            unitsAmt_lbl.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(48, 249);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 70);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // stockname_lbl
            // 
            stockname_lbl.AutoSize = true;
            stockname_lbl.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            stockname_lbl.Location = new Point(128, 260);
            stockname_lbl.Name = "stockname_lbl";
            stockname_lbl.Size = new Size(130, 23);
            stockname_lbl.TabIndex = 5;
            stockname_lbl.Text = "Stock Name";
            // 
            // fullname_lbl
            // 
            fullname_lbl.AutoSize = true;
            fullname_lbl.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            fullname_lbl.Location = new Point(128, 283);
            fullname_lbl.Name = "fullname_lbl";
            fullname_lbl.Size = new Size(84, 21);
            fullname_lbl.TabIndex = 5;
            fullname_lbl.Text = "Full name";
            // 
            // balance_lbl
            // 
            balance_lbl.AutoSize = true;
            balance_lbl.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            balance_lbl.Location = new Point(365, 170);
            balance_lbl.Name = "balance_lbl";
            balance_lbl.Size = new Size(72, 19);
            balance_lbl.TabIndex = 5;
            balance_lbl.Text = "$100000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(48, 170);
            label3.Name = "label3";
            label3.Size = new Size(161, 21);
            label3.TabIndex = 5;
            label3.Text = "Available Balance :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(48, 322);
            label4.Name = "label4";
            label4.Size = new Size(88, 33);
            label4.TabIndex = 5;
            label4.Text = "Units :";
            // 
            // price_lbl
            // 
            price_lbl.AutoSize = true;
            price_lbl.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            price_lbl.Location = new Point(360, 296);
            price_lbl.Name = "price_lbl";
            price_lbl.Size = new Size(76, 23);
            price_lbl.TabIndex = 5;
            price_lbl.Text = "100000";
            price_lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(363, 275);
            label6.Name = "label6";
            label6.Size = new Size(55, 21);
            label6.TabIndex = 5;
            label6.Text = "Price :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(435, 299);
            label5.Name = "label5";
            label5.Size = new Size(16, 17);
            label5.TabIndex = 7;
            label5.Text = "$";
            // 
            // insfFunds
            // 
            insfFunds.AutoSize = true;
            insfFunds.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            insfFunds.ForeColor = Color.Red;
            insfFunds.Location = new Point(164, 524);
            insfFunds.Name = "insfFunds";
            insfFunds.Size = new Size(151, 21);
            insfFunds.TabIndex = 5;
            insfFunds.Text = "Insufficient Funds !";
            insfFunds.Visible = false;
            // 
            // TransactionsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(stockname_lbl);
            Controls.Add(fullname_lbl);
            Controls.Add(label3);
            Controls.Add(balance_lbl);
            Controls.Add(insfFunds);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(price_lbl);
            Controls.Add(unitsAmt_lbl);
            Controls.Add(exit);
            Controls.Add(confirm_btn);
            ForeColor = SystemColors.ControlText;
            Name = "TransactionsControl";
            Size = new Size(478, 558);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected internal Button confirm_btn;
        private Label exit;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        protected internal PictureBox pictureBox1;
        protected internal Label stockname_lbl;
        protected internal Label fullname_lbl;
        protected internal TextBox amountInvested_txtbox;
        private Label label6;
        private Label label5;
        protected internal Label price_lbl;
        private Label insfFunds;
        protected internal Label balance_lbl;
        protected internal Label unitsAmt_lbl;
    }
}
