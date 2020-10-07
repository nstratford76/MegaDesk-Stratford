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
    
    public partial class AddQuote : Form
    {
        //public static string SetValueForWidth = "";
        //public static string SetValueForDepth = "";
        //public static string SetValueForMaterial = "";
        //public static string SetValueForShipping = "";
        //public static string SetValueForName = "";
        //public static string SetValueFor = "";
        public DeskQuote dq;
        private Form _addMenu;
        public AddQuote(Form addMenu)
        {
            InitializeComponent();

            _addMenu = addMenu;
            //List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();

            //populate surface material

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            dq = new DeskQuote();
            dq.D = new Desk();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form mainMenu = (Form)this.Tag;
            mainMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dq.Name = this.nameText.Text;
            dq.NumDesks = int.Parse(deskText.Text);
            dq.Shipping = (string)shippingMenu.SelectedItem;
            dq.D.NumberofDrawers = int.Parse(drawerText.Text);
            dq.D.Width = (int)numericUpDown1.Value;
            dq.D.Depth = (int)numericUpDown2.Value;
            dq.D.SurfaceMaterial = (string)materialMenu.SelectedItem;

            var displayQuote = new DisplayQuote(this, dq);
            displayQuote.Show();
        }

        //private void widthText_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(widthText.Text))
        //    {
        //        e.Cancel = true;
        //        widthText.Focus();
        //        errorProvider1.SetError(widthText, "Please enter width");
        //    }
            
        //    else
        //    {
        //        int width = int.Parse(widthText.Text);
        //        if (width < 24 || width > 96)
        //        {
        //            e.Cancel = true;
        //            widthText.Focus();
        //            errorProvider1.SetError(widthText, "Please enter a width between 24 and 96");
        //        }
        //        e.Cancel = false;
        //        errorProvider1.SetError(widthText, "");
        //    }
        //}

        //private void depthText_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(depthText.Text))
        //    {
        //        e.Cancel = true;
        //        depthText.Focus();
        //        errorProvider2.SetError(widthText, "Please enter depth");
        //    }

        //    else
        //    {
        //        int depth = int.Parse(depthText.Text);
        //        if (depth < 12 || depth > 48)
        //        {
        //            e.Cancel = true;
        //            depthText.Focus();
        //            errorProvider2.SetError(depthText, "Please enter a depth between 12 and 48");
        //        }
        //        e.Cancel = false;
        //        errorProvider2.SetError(widthText, "");
        //    }
        //}
    }
}
