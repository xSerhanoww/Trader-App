
using System.Data;
using TraderBeta_02.Data;
using static TraderBeta_02.StocksBar;

namespace TraderBeta_02
{
    public partial class AccountForm : Form
    {
        public static double Balance {  get; set; }

        public static double StaticBalance { get; set; }
        public AccountForm()
        {
            InitializeComponent();
            SetValues();
        }

        private void SetValues()
        {
            using (var db = new StocksDbContext())
            {
                balance_lbl.Text = "$" + (db.Users.Where(x=> x.ID == Form1.LoggedUserId).Sum(x=> x.Balance)).ToString(format:"f2");
                double investedAmount = 0;
                var currentPortfolio = db.Portfolios.Where(x => x.owner_id == Form1.LoggedUserId).ToList();
                foreach (var item in currentPortfolio)
                {
                    investedAmount += item.Investment;
                }
                investedPerc_lbl.Text = ((investedAmount/StaticBalance) * 100).ToString(format:"f2") + "%";

               var ownedStocks = db.Portfolios.Where(x => x.owner_id == Form1.LoggedUserId).Count();
               ownedstocks_lbl.Text = ownedStocks.ToString();


            }


        }
        public static void UpdateBalance()
        {
            using (var db = new StocksDbContext())
            {
                db.Users.Where(x => x.ID == Form1.LoggedUserId).ToList().ForEach((x => x.Balance = x.Balance += ((Convert.ToDouble(tempStockBar.investmentAmount_lbl.Text)) + (Convert.ToDouble(tempStockBar.profit_lbl.Text)) )));
                Balance = Balance += ((Convert.ToDouble(tempStockBar.investmentAmount_lbl.Text)) + (Convert.ToDouble(tempStockBar.profit_lbl.Text)));
                db.SaveChanges();
            }



        }
    }
}
