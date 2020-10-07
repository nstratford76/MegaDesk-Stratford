﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Stratford
{
    //enum for delevery 
    public enum DeliveryType
    {
        Rush3Days,
        Rush5Days,
        Rush7Days,
        NoRush
    }

    public class DeskQuote
    {
        public const short BASE_DESK_COST = 200;
        public Desk D { get; set; }
 
        public string Name { get; set; }
        public string Shipping { get; set; }
        public int NumDesks { get; set; }

        private int _numDeskCost;
        


        private float _shippingCost;
        public float ShippingCost
        {
            get {
                switch (Shipping)
                {
                    case "3 Day":
                        if (D.Area < 1000)
                            _shippingCost = 60;
                        else if (D.Area >= 1000 && D.Area <= 2000)
                            _shippingCost = 70;
                        else
                            _shippingCost = 80;
                        break;
                    case "5 Day":
                        if (D.Area < 1000)
                            _shippingCost = 40;
                        else if (D.Area >= 1000 && D.Area <= 2000)
                            _shippingCost = 50;
                        else
                            _shippingCost = 60;
                        break;
                    case "7 Day":
                        if (D.Area < 1000)
                            _shippingCost = 30;
                        else if (D.Area >= 1000 && D.Area <= 2000)
                            _shippingCost = 35;
                        else
                            _shippingCost = 40;
                        break;
                }
                return _shippingCost;
            }
            set { _shippingCost = value; }         
        }
        public int NumDeskCost
        {
            get { _numDeskCost = NumDesks * BASE_DESK_COST; return _numDeskCost; }
            set { _numDeskCost = value; }
        }
        private float _totalCost;
        public float totalCost
        {
            get
            {
                float totalBeforeDesks = ShippingCost + D.NumberofDrawersCost + D.MaterialCost + D.AreaCost;
                _totalCost = (totalBeforeDesks * NumDesks) + NumDeskCost;
                return _totalCost;
            }
            set
            {
                _totalCost = value;
            }
        }

        //Method for GetQuote
        public decimal GetQuote()
        {
            return 0;
        }

    }
    
}
