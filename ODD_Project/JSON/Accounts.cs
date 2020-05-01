using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    public class Accounts
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public Accounts(string accountNumber, decimal balace)
        {
            AccountNumber = accountNumber;
            Balance = balace;

        }

        public Accounts(string accountNumber) : this
            (accountNumber, 0)
        { }

        public Accounts() : this("unknown") { }

        public override string ToString()
        {
            return string.Format("[{0}] {1} {2:C}", this.GetType().Name.ToUpper(), AccountNumber, Balance);

            //GetType() give - Autumn2018.Account
        }


    }
}
