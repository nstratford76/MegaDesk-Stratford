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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddNewQuote(object sender, EventArgs e)
        {
            var addQuote = new AddQuote(this);
            addQuote.Tag = this;
            addQuote.Show();
        }

        private void btnViewQuotes(object sender, EventArgs e)
        {
            var viewAllQuotes = new ViewAllQuotes(this);
            viewAllQuotes.Tag = this;
            viewAllQuotes.Show();

            //this.Hide();
        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            var searchQuotes = new SearchQuote(this);
            searchQuotes.Tag = this;
            searchQuotes.Show();

            //this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
