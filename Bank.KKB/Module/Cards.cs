using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.KKB.Module
{
    public enum CardTypes { AmericanCard, MasterCard, Visa, Maestro }
    public class Cards
    {
        public String CardNumb { get; private set; }
        public DateTime ExpDate { get; set; }
        public int CCV { get; set; }
        public CardTypes CardTypes { get; set; }

        public String GetCardNub()
        {
            string[] cn = CardNumb.Split(' ');
            cn[1] = "****";
            cn[2] = "****";
            return String.Format("{0} {1} {2} {3}", cn[0], cn[1], cn[2], cn[4]);
            //return CardNumb.Substring(4, 11);
        }
           
    }
}
