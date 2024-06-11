using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraderBeta_02
{
    public class Users
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }

     

    } 
    public class PortfolioData
    {
        [Key]
        public string order_num { get; set; }
        public string StockName { get; set; }

        public string? StockOwner { get; set; }

        public double Investment { get; set; }

        public double Profit { get; set; }

        public double Units { get; set; }

        public double Price { get; set; }

        public string Type { get; set; }

        public int owner_id { get; set; }

        public double BuyPrice { get; set; }

    }
    public class StockData
    {
        [Key]
        public int stock_id { get; set; }

        public string StockName { get; set; }

        public string? StockOwner { get; set; }

        public double? Investment { get; set; }

        public double? Profit { get; set; }

        public double? Units { get; set; }

        public double Price { get; set; }

        public string Type { get; set; }


    }
}
