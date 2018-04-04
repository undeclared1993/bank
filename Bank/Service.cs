using Bank.KKB.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorName;
namespace Bank
{
    public class Service
    {
        public Service()
        {

        }

        private static Random Rand = new Random();
        public static void CreateClients(ref Client Client, string IIN, string Email, string Log, string Pass, string PhoneNumber)
        {
            Generator RandName = new Generator();
            Client.FName = RandName.GenerateDefault(Gender.woman);
            Client.IIN = IIN;
            Client.DOB = DateTime.Now;
            Client.Email = Email;
            Client.Log = Log;
            Client.Pass = Pass;
            Client.PhoneNumber = PhoneNumber;
            Client.Accounts.Add(CreateAccounts());

        }
        public static Account CreateAccounts()
        {
            return  
                new Account()
            {
                AccNumb = Rand.Next(515, 51251).ToString(),
                CloseDate = DateTime.Now.AddMonths(Rand.Next(0, 12)),
                Score = decimal.Parse(Rand.Next(515, 51251).ToString()),
                CreatDate = DateTime.Today
            };
        }
        
    }
}
