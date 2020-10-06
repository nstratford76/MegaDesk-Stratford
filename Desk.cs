﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Stratford
{
    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }
    public class Desk
    {
        public int Width { get; set; }

        public int Depth { get; set; }

        private int _area;
        public int Area { get { _area = Width * Depth;  return _area; } set { _area = value; } }

        public int NumberofDrawers { get; set; }

        private int _numberofDrawersCost;
        public int NumberofDrawersCost
        {
            get
            {
                _numberofDrawersCost = NumberofDrawers * 50;
                return _numberofDrawersCost;
            }
            set
            {
                _numberofDrawersCost = value;
            }
        }

        public string SurfaceMaterial { get; set; }

        private int _materialCost;
        public int MaterialCost
        {
            get
            {
                switch(SurfaceMaterial)
                {
                    case "Laminate":
                        return 100;
                        break;
                    case "Oak":
                        return 200;
                    case "Rosewood":
                        return 300;
                        break;
                    case "Veneer":
                        return 125;
                    case "Pine":
                        return 50;
                        break;
                   
                }
                return 0;     
            }
            set
            {
                _materialCost = value;
            }
        }

    }
}
