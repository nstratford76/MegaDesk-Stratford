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
        public Desk D { get; set; }
 
        public string Name { get; set; }
        public string Shipping { get; set; }
        public int NumDesks { get; set; }

        private int _numDeskCost;
        public int NumDeskCost { 
            get { return NumDesks * 200; } 
            set { _numDeskCost = value; } 
        }


        private float _shippingCost;
        public float ShippingCost
        {
            get {
                switch (Shipping)
                {
                    case "3 Day":
                        if (D.Area < 1000)
                            _shippingCost = 60;
                        break;
                    case "5 Day":
                        if (D.Area >= 1000 && D.Area <= 2000)
                            _shippingCost = 70;
                        break;
                    case "7 Day":
                        if (D.Area > 2000)
                            _shippingCost = 80;
                        break;
                }
                return _shippingCost;
            }
            set { _shippingCost = value; }         
        }
        public float totalCost
        {
            get
            {
                return ShippingCost + NumDeskCost + D.NumberofDrawersCost + D.MaterialCost + D.Area;
            }
            set
            {
                this.totalCost = totalCost;
            }
        }
    }
    
}
