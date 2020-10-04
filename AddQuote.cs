﻿using System;
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
        public Desk desk;
        private Form _mainMenu;
        public AddQuote(Form _mainMenu)
        {
            InitializeComponent();

            // _mainMenu = mainMenu;
            //List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();

            //populate surface material

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form mainMenu = (Form)this.Tag;
            mainMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dq.Name = nameText.Text;
            dq.numDesks = int.Parse(deskText.Text);
            dq.Shipping = (string)shippingMenu.SelectedItem;
            desk.Width = int.Parse(widthText.Text);
            desk.Depth = int.Parse(depthText.Text);
            desk.SurfaceMaterial = (string)materialMenu.SelectedItem;
            
        }
    }
}