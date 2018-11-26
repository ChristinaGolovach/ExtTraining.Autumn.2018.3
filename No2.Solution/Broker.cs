using System;

namespace No2
{
    public class Broker
    {     

        public string Name { get; set; }

        public Broker(string name)
        {
            this.Name = name;
        }

        public Broker(string name, Stock stock)
        {
            this.Name = name;
            stock.ChangeStockInfo += Update;
        }

        public void Update(StockInfo stockInfo)
        {
            Console.WriteLine(
                stockInfo.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {stockInfo.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {stockInfo.USD}");
        }

        public void StartTrade(Stock stock)
        {
            stock.ChangeStockInfo += Update;
        }

        public void StopTrade(Stock stock)
        {
            stock.ChangeStockInfo -= Update;
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
