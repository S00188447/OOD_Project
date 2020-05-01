using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace JSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            string data = JsonConvert.SerializeObject(GetRandomAccounts(), Formatting.Indented);
            using (StreamWriter sw = new StreamWriter("c:/temp/accountdata.json"))
            {
                sw.Write(data);
                sw.Close();
            }
        }

        private static List<Accounts> GetRandomAccounts()
        {
            Random rand = new Random();
            List<Accounts> accounts = new List<Accounts>();

            for (int i = 0; i < 20; i++)
            {
                int accountNumber = rand.Next(1, 100000);
                decimal balance = rand.Next(10000);
                Accounts acc = new Accounts()
                {
                    AccountNumber = accountNumber.ToString("DB"), //DB formats to 8 places to 123 will be 00000123
                    Balance = balance

                };

                accounts.Add(acc);

            }//end of for

            return accounts;

        }
    }

}

