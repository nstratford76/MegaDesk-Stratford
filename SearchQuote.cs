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
    public partial class SearchQuote : Form
    {
        private Form _menu;
        public SearchQuote(Form menu)
        {
            _menu = menu;
            InitializeComponent();
        }

        private void SearchQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form mainMenu = (Form)this.Tag;
            mainMenu.Show();
        }

        private void SearchQuote_Load(object sender, EventArgs e)
        {

        }

        private void SearchQuote_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Form mainMenu = (Form)this.Tag;
            mainMenu.Show();
        }
    }
}
