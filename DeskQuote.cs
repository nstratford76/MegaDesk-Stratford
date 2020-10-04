using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Stratford
{
    public class DeskQuote
    {
        public Desk desk;
        
        


        public string Name { get; set; }
        public string Shipping { get; set; }
        public int numDesks { get; set; }

        public int numDeskCost { 
            get { return numDeskCost; } 
            set { numDeskCost = numDesks * 200; } 
        }

       
        public float shippingCost
        {
            get {
                switch (Shipping)
                {
                    case "3 Day":
                        if (desk.Area < 1000)
                            shippingCost = 60;
                        break;
                    case "5 Day":
                        if (desk.Area >= 1000 && desk.Area <= 2000)
                            shippingCost = 70;
                        break;
                    case "7 Day":
                        if (desk.Area > 2000)
                            shippingCost = 80;
                        break;
                }
                return shippingCost;
            }
            set { this.shippingCost = shippingCost; }         
        }
    }
}
