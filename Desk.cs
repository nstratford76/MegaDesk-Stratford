using System;
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

        public int Area { get { return Width * Depth; } set { this.Area = Area; } }

        public int NumberofDrawers { get; set; }

        public string SurfaceMaterial { get; set; }

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
                this.MaterialCost = MaterialCost;
            }
        }

    }
}
