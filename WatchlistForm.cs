using System.Data;
using TraderBeta_02.Data;
using static TraderBeta_02.StocksBar;

namespace TraderBeta_02
{
    public partial class WatchlistForm : Form
    {


        public WatchlistForm()
        {

            InitializeComponent();
            LoadStockData();

        }
        private void LoadStockData()
        {
            using (var db = new StocksDbContext())
            {
                var stocks = db.Stocks.ToList();
                foreach (var stock in stocks)
                {
                    StocksBar stocksBar = new StocksBar(System.Drawing.Image.FromFile(SetImage(stock.StockName)), stock.StockName, stock.StockOwner, stock.Investment, stock.Profit, stock.Units, stock.Price, stock.Type);
                    panel3.Controls.Add(stocksBar);
                }


            }
        }

        private void showStocks_btn_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            using (var db = new StocksDbContext())
            {
                foreach (var stock in db.Stocks.Where(x => x.Type == "Stock"))
                {
                    StocksBar stocksBar = new StocksBar(System.Drawing.Image.FromFile(SetImage(stock.StockName)), stock.StockName, stock.StockOwner, stock.Investment, stock.Profit, stock.Units, stock.Price, stock.Type);
                    panel3.Controls.Add(stocksBar);
                }

            }

        }

        private void showCrypto_btn_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            using (var db = new StocksDbContext())
            {
                foreach (var stock in db.Stocks.Where(x => x.Type == "Crypto"))
                {
                    StocksBar stocksBar = new StocksBar(System.Drawing.Image.FromFile(SetImage(stock.StockName)), stock.StockName, stock.StockOwner, stock.Investment, stock.Profit, stock.Units, stock.Price, stock.Type);
                    panel3.Controls.Add(stocksBar);
                }

            }
        }

        private void ShowIndexes_btn_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            using (var db = new StocksDbContext())
            {
                foreach (var stock in db.Stocks.Where(x => x.Type == "Index"))
                {
                    StocksBar stocksBar = new StocksBar(System.Drawing.Image.FromFile(SetImage(stock.StockName)), stock.StockName, stock.StockOwner, stock.Investment, stock.Profit, stock.Units, stock.Price, stock.Type);
                    panel3.Controls.Add(stocksBar);
                }

            }
        }

        private void ShowCommodities_btn_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            using (var db = new StocksDbContext())
            {
                foreach (var stock in db.Stocks.Where(x => x.Type == "Commodity"))
                {
                    StocksBar stocksBar = new StocksBar(System.Drawing.Image.FromFile(SetImage(stock.StockName)), stock.StockName, stock.StockOwner, stock.Investment, stock.Profit, stock.Units, stock.Price, stock.Type);
                    panel3.Controls.Add(stocksBar);
                }

            }
        }

        private void showAll_btn_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            LoadStockData();
        }
    }
}
