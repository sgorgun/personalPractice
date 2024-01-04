using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesStockOnliner
{
    public class StockExchangeMonitor
    {
        public delegate void PriceChange(int price);

        public PriceChange PriceChangeHandler { get; set; }

        public void Start()
        {
            while(true)
            {
                int  bankOfAmericaPrice = (new Random()).Next(100);

                PriceChangeHandler(bankOfAmericaPrice);
                Thread.Sleep(2000);
            }
        }
    }
}
