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
        Pine,
        Redwood
    }
    public class Desk
    {
        public int Width { get; set; }

        public int Depth { get; set; }

        public int NumberofDrawers { get; set; }

        public string SurfaceMaterial { get; set; }

    }
}
