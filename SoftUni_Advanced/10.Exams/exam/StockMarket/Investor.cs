using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        public Investor(string full,string email,decimal moneyToInvest,string brokerName)
        {
            FullName = full;
            EmailAddress = email;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
            Portfolio = new List<Stock>();


        }


        private List<Stock> Portfolio;

        public string FullName { get; set; }

        public string EmailAddress { get; set; }

        public decimal MoneyToInvest { get; set; }

        public string BrokerName { get; set; }

        public int Count => Portfolio.Count;

        public void BuyStock(Stock stock)
        {

            if (stock.MarketCapitalization>10000 && MoneyToInvest >stock.PricePerShare)//!!!!
            {
                Portfolio.Add(stock);
                MoneyToInvest = MoneyToInvest - stock.PricePerShare;
            }
            
        }

        public string SellStock(string companyName, decimal sellPrice)
        {
            var tempStock = Portfolio.FirstOrDefault(x => x.CompanyName==companyName);
            if (tempStock==null)
            {
                return ($"{companyName} does not exist.");
            }

            if (sellPrice<tempStock.PricePerShare)
            {
                return $"Cannot sell {companyName}.";
            }

            MoneyToInvest += sellPrice;
            Portfolio.Remove(tempStock);
            return $"{companyName} was sold.";
        }

        public Stock FindStock(string companyName)
        {

            var tempStock = Portfolio.FirstOrDefault(x => x.CompanyName == companyName);
            return tempStock;
        }

        public Stock FindBiggestCompany()
        {
            var tempStock = Portfolio.OrderByDescending(x=>x.MarketCapitalization).FirstOrDefault();
            return tempStock;


        }

        public string InvestorInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks:");
            if (Portfolio.Count>0)
            {
                foreach (var stock in Portfolio)
                {
                    sb.AppendLine(stock.ToString());
                }
            }
           

            return sb.ToString().TrimEnd();
        }
    }
}
