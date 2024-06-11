namespace TraderBeta_02
{
    partial class SellControl
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
            stockname_lbl = new Label();
            fullname_lbl = new Label();
            label6 = new Label();
            price_lbl = new Label();
            label1 = new Label();
            PL_lbl = new Label();
            confirm_btn = new Button();
            exit = new Label();
            dollarSign_lbl = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(16, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 70);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // stockname_lbl
            // 
            stockname_lbl.AutoSize = true;
            stockname_lbl.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            stockname_lbl.Location = new Point(96, 37);
            stockname_lbl.Name = "stockname_lbl";
            stockname_lbl.Size = new Size(130, 23);
            stockname_lbl.TabIndex = 9;
            stockname_lbl.Text = "Stock Name";
            // 
            // fullname_lbl
            // 
            fullname_lbl.AutoSize = true;
            fullname_lbl.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            fullname_lbl.Location = new Point(96, 60);
            fullname_lbl.Name = "fullname_lbl";
            fullname_lbl.Size = new Size(84, 21);
            fullname_lbl.TabIndex = 10;
            fullname_lbl.Text = "Full name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(374, 41);
            label6.Name = "label6";
            label6.Size = new Size(55, 21);
            label6.TabIndex = 11;
            label6.Text = "Price :";
            // 
            // price_lbl
            // 
            price_lbl.AutoSize = true;
            price_lbl.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            price_lbl.Location = new Point(371, 62);
            price_lbl.Name = "price_lbl";
            price_lbl.Size = new Size(76, 23);
            price_lbl.TabIndex = 12;
            price_lbl.Text = "100000";
            price_lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(135, 114);
            label1.Name = "label1";
            label1.Size = new Size(102, 23);
            label1.TabIndex = 9;
            label1.Text = "Total P/L :";
            // 
            // PL_lbl
            // 
            PL_lbl.AutoSize = true;
            PL_lbl.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PL_lbl.ForeColor = Color.DodgerBlue;
            PL_lbl.Location = new Point(251, 114);
            PL_lbl.Name = "PL_lbl";
            PL_lbl.Size = new Size(76, 23);
            PL_lbl.TabIndex = 12;
            PL_lbl.Text = "100000";
            PL_lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // confirm_btn
            // 
            confirm_btn.BackColor = Color.Crimson;
            confirm_btn.Cursor = Cursors.Hand;
            confirm_btn.FlatAppearance.BorderSize = 0;
            confirm_btn.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            confirm_btn.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            confirm_btn.FlatStyle = FlatStyle.Flat;
            confirm_btn.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            confirm_btn.ForeColor = Color.White;
            confirm_btn.Location = new Point(84, 156);
            confirm_btn.Name = "confirm_btn";
            confirm_btn.Padding = new Padding(5);
            confirm_btn.Size = new Size(301, 50);
            confirm_btn.TabIndex = 15;
            confirm_btn.Text = "CONFIRM";
            confirm_btn.UseVisualStyleBackColor = false;
            confirm_btn.Click += confirm_btn_Click;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exit.Location = new Point(450, 8);
            exit.Name = "exit";
            exit.Size = new Size(19, 21);
            exit.TabIndex = 16;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // dollarSign_lbl
            // 
            dollarSign_lbl.AutoSize = true;
            dollarSign_lbl.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dollarSign_lbl.ForeColor = Color.DodgerBlue;
            dollarSign_lbl.Location = new Point(235, 114);
            dollarSign_lbl.Name = "dollarSign_lbl";
            dollarSign_lbl.Size = new Size(20, 22);
            dollarSign_lbl.TabIndex = 17;
            dollarSign_lbl.Text = "$";
            dollarSign_lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(356, 62);
            label2.Name = "label2";
            label2.Size = new Size(20, 22);
            label2.TabIndex = 17;
            label2.Text = "$";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SellControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label2);
            Controls.Add(dollarSign_lbl);
            Controls.Add(exit);
            Controls.Add(confirm_btn);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(stockname_lbl);
            Controls.Add(fullname_lbl);
            Controls.Add(label6);
            Controls.Add(PL_lbl);
            Controls.Add(price_lbl);
            Name = "SellControl";
            Size = new Size(476, 224);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        protected internal PictureBox pictureBox1;
        protected internal Label stockname_lbl;
        protected internal Label fullname_lbl;
        private Label label6;
        protected internal Label price_lbl;
        protected internal Label label1;
        protected internal Label PL_lbl;
        protected internal Button confirm_btn;
        private Label exit;
        protected internal Label dollarSign_lbl;
        protected internal Label label2;
    }
}
