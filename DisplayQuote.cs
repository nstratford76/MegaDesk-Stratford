using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Stratford
{
    
    public partial class DisplayQuote : Form
    {
        private Form _menu;
        public DeskQuote quote;
       
        public DisplayQuote(Form menu, DeskQuote quote)
        {
            _menu = menu;
            this.quote = quote;
           
            InitializeComponent();
        }

        private void shippingCost_Click(object sender, EventArgs e)
        {

        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            name.Text = quote.Name;
            //deskMaterial.Text = quote.D.SurfaceMaterial;
            materialCost.Text = "$" + quote.D.MaterialCost.ToString();
            area.Text += ": " + quote.D.Area;
            areaCost.Text = "$" + quote.D.AreaCost.ToString();
            shipping.Text = quote.Shipping;
            shippingCost.Text = "$" + quote.ShippingCost.ToString();
            numDrawers.Text += ": " + quote.D.NumberofDrawers.ToString();
            numDrawerCost.Text = "$" + quote.D.NumberofDrawersCost.ToString();
            numDesks.Text += ": " + quote.NumDesks.ToString();
            numDeskCost.Text = "$" + quote.NumDeskCost.ToString();
            totalCost.Text = "$" + quote.totalCost.ToString();

        }
    }
}
