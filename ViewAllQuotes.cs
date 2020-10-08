using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MegaDesk_Stratford
{
    public partial class ViewAllQuotes : Form
    {
        DeskQuote q;
        List<DeskQuote> quotes;
        private Form _mainMenu;
        public ViewAllQuotes(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
        }

        private void loadGrid()
        {
            var quotesFile = @"quotes.json";
            using (StreamReader reader = new StreamReader(quotesFile))
            {
                var stuff = reader.ReadToEnd();

                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(stuff);

                //dataGridView1.DataSource = deskQuotes
                //    .Select(d => new
                //    {
                //       // Date = d.QuoteDate,
                //        Customer = d.Name,
                //        Depth = d.D.Depth,
                //        Width = d.D.Width,
                //        Drawers = d.D.NumberofDrawers,
                //        SurfaceMaterial = d.D.SurfaceMaterial,
                //       // DeliveryType = d.D.DeliveryType
                //    })
            }
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form mainMenu = (Form)this.Tag;
            mainMenu.Show();
        }
    }
}
