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
    public partial class ViewAllQuotes : Form
    {
       
        List<DeskQuote> quotes3;
        private Form _mainMenu;
        public ViewAllQuotes(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
            quotes3 = quotes;
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
