using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Ex5
{
    public class Rate
    {
        public Rate(int amount, string Currency)
        {
            this.Amount = amount;
            this.Currency = Currency;
        }

        public int Amount { get; set; }

        public string Currency { get; set; }
    }
}
