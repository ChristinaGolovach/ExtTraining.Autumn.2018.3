using System;
using System.Collections.Generic;

namespace No2
{
    public class Stock 
    {
        private StockInfo stocksInfo;

        public event EventHandler<StockInfo> ChangeStockInfo = delegate { };

        public Stock() { }      

        public void Market()
        {
            Random rnd = new Random();
            int usd  = rnd.Next(20, 40);
            int euro = rnd.Next(30, 50);
            stocksInfo = new StockInfo(usd, euro);
            OnChangeStockInfo(stocksInfo);
        }

        protected void OnChangeStockInfo(StockInfo stockInfo)
        {
            if (ReferenceEquals(stockInfo, null))
            {
                throw new ArgumentNullException($"The {nameof(stockInfo)} can not be null.");
            }

            ChangeStockInfo?.Invoke(this, stockInfo);
        }
    }
}
