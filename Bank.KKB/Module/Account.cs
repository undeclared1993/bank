using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.KKB.Module
{
    public class Account
    {
        public Account()
        {
            ClientsCard = new List<Cards>();
        }
        public DateTime CreatDate { get; set; }
        public DateTime CloseDate { get; set; }
        public Decimal Score { get; set; } = 0M;
        public String AccNumb { get; set; }
        public IList<Cards> ClientsCard;
        public void PrintCardsInfo()
        {
            foreach (var item in ClientsCard)
                Console.WriteLine (String.Format("{0}\t ({1}) - {2}", item.CardNumb, item.GetCardNub(), item.ExpDate));
               
        }


    }
}
