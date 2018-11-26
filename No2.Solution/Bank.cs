using System;

namespace No2
{
    public class Bank
    { 
        public string Name { get; set; }

        public Bank(string name, Stock stock)
        {
            this.Name = name;
            stock.ChangeStockInfo += Update;
        }

        public void Update(object info)
        {
            var stockInfo = (StockInfo)info;

            Console.WriteLine(
                stockInfo.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{stockInfo.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {stockInfo.Euro}");
        }

        private void Update(object sender, StockInfo stockInfo)
        {
            if (ReferenceEquals(sender, null))
            {
                throw new ArgumentNullException($"The {nameof(sender)} can not be null.");
            }

            if (ReferenceEquals(stockInfo, null))
            {
                throw new ArgumentNullException($"The {nameof(stockInfo)} can not be null.");
            }

            Update(stockInfo);
        }
    }
}
