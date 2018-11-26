using System;

namespace No2
{
    public class StockInfo : EventArgs
    {
        private int usd;
        private int euro;

        public int USD { get => usd; }
        public int Euro { get => euro; }

        public StockInfo(int usd, int euro)
        {
            this.usd = usd;
            this.euro = euro;
        }
    }
}
