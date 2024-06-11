using System.Data;
using TraderBeta_02.Data;
using static TraderBeta_02.PortfolioForm;
using static TraderBeta_02.StocksBar;


namespace TraderBeta_02
{
    public partial class TransactionsControl : UserControl
    {

        public static TransactionsControl? Instance;
        public TransactionsControl()
        {
            InitializeComponent();
            Instance = this;
        }

        public void exit_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Instance = null;
            ownedStocks.Clear();
            Form1.Instance.panel3.Enabled = true;
            Form1.Instance.panel1.Enabled = true;



        }


        private void confirm_btn_Click(object sender, EventArgs e)
        {

            if (double.TryParse(amountInvested_txtbox.Text, out double number))
            {
                if (AccountForm.Balance >= Convert.ToDouble(amountInvested_txtbox.Text))
                {
                    InvestedAmount = Convert.ToDouble(this.amountInvested_txtbox.Text);
                    UnitsAmount = Convert.ToDouble(this.unitsAmt_lbl.Text);
                    AccountForm.Balance -= Convert.ToDouble(amountInvested_txtbox.Text);
                    using (var db = new StocksDbContext())
                    {
                        foreach (var item in db.Users.Where(x => x.ID == Form1.LoggedUserId))
                        {
                            item.Balance = AccountForm.Balance;
                        }
                        db.SaveChanges();
                    }
                    AddSelectedStocksToPortfolio();
                    ownedStocks.Clear();
                    exit_Click(sender, e);
                }
                else insfFunds.Visible = true;
            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void amountInvested_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (amountInvested_txtbox.Text == "")
            {
                unitsAmt_lbl.Text = "";
            }
            else if (double.TryParse(amountInvested_txtbox.Text, out double number))
            {
                double result = Convert.ToDouble(amountInvested_txtbox.Text) / Convert.ToDouble(tempStockBar.stockPrice_lbl.Text);
                unitsAmt_lbl.Text = result.ToString(format: "f2");
            }
        }

       
    }
}
