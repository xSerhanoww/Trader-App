using static TraderBeta_02.PortfolioForm;
using static TraderBeta_02.StocksBar;

namespace TraderBeta_02
{
    public partial class SellControl : UserControl
    {
        public static SellControl? InstanceSellControl;
        public SellControl()
        {
            InitializeComponent();
            InstanceSellControl = this;
        }

        public void exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            InstanceSellControl = null;
            Form1.Instance.panel3.Enabled = true;
            Form1.Instance.panel1.Enabled = true;
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {

            AccountForm.UpdateBalance();
            SellStocks();
            Instance.panel3.Controls.Remove(tempStockBar);
            exit_Click(sender, e);
        }
    }
}
