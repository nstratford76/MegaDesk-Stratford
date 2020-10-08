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

            //populate surface material
            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial))
                .Cast<DesktopMaterial>()
                 .ToList();

            materialMenu.DataSource = materials;

            //set default value to empty
            materialMenu.SelectedIndex = -1;

            this.numDepth.Maximum = Desk.MAX_DEPTH;
            this.numDepth.Minimum = Desk.MIN_DEPTH;

            this.numWidth.Maximum = Desk.MAX_WIDTH;
            this.numWidth.Minimum = Desk.MIN_WIDTH;

            this.NumDrawers.Maximum = Desk.MAX_DESK_DRAWERS;
            
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
            dq.D.NumberofDrawers = (int)NumDrawers.Value;
            dq.D.Width = (int)numWidth.Value;
            dq.D.Depth = (int)numDepth.Value;
            dq.D.SurfaceMaterial = (DesktopMaterial)materialMenu.SelectedItem;

            var displayQuote = new DisplayQuote(this, dq);
            displayQuote.Show();
        }

        private void materialMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
