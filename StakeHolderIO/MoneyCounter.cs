using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StakeHolderIO
{
    internal class MoneyCounter
    {
        private static int _cashMoney = 10000;

        public static int CashMoney
        {
            get { return _cashMoney; }
            set { _cashMoney = value; }
        }

        public static void AddCashMoney(int amount)
        {
            _cashMoney += amount;
        }

        public static void RemoveCashMoney(int amount)
        {
            _cashMoney -= amount;
        }
    }
}
