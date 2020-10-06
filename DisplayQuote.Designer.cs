namespace MegaDesk_Stratford
{
    partial class DisplayQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.Label();
            this.deskMaterial = new System.Windows.Forms.Label();
            this.areaCost = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.Label();
            this.materialCost = new System.Windows.Forms.Label();
            this.shipping = new System.Windows.Forms.Label();
            this.shippingCost = new System.Windows.Forms.Label();
            this.numDrawers = new System.Windows.Forms.Label();
            this.numDrawerCost = new System.Windows.Forms.Label();
            this.numDesks = new System.Windows.Forms.Label();
            this.numDeskCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(516, 82);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(90, 32);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // deskMaterial
            // 
            this.deskMaterial.AutoSize = true;
            this.deskMaterial.Location = new System.Drawing.Point(516, 172);
            this.deskMaterial.Name = "deskMaterial";
            this.deskMaterial.Size = new System.Drawing.Size(117, 32);
            this.deskMaterial.TabIndex = 1;
            this.deskMaterial.Text = "Material";
            // 
            // areaCost
            // 
            this.areaCost.AutoSize = true;
            this.areaCost.Location = new System.Drawing.Point(780, 275);
            this.areaCost.Name = "areaCost";
            this.areaCost.Size = new System.Drawing.Size(73, 32);
            this.areaCost.TabIndex = 2;
            this.areaCost.Text = "Cost";
            // 
            // area
            // 
            this.area.AutoSize = true;
            this.area.Location = new System.Drawing.Point(516, 275);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(180, 32);
            this.area.TabIndex = 3;
            this.area.Text = "Surface Area";
            // 
            // materialCost
            // 
            this.materialCost.AutoSize = true;
            this.materialCost.Location = new System.Drawing.Point(780, 172);
            this.materialCost.Name = "materialCost";
            this.materialCost.Size = new System.Drawing.Size(73, 32);
            this.materialCost.TabIndex = 4;
            this.materialCost.Text = "Cost";
            // 
            // shipping
            // 
            this.shipping.AutoSize = true;
            this.shipping.Location = new System.Drawing.Point(516, 370);
            this.shipping.Name = "shipping";
            this.shipping.Size = new System.Drawing.Size(128, 32);
            this.shipping.TabIndex = 5;
            this.shipping.Text = "Shipping";
            // 
            // shippingCost
            // 
            this.shippingCost.AutoSize = true;
            this.shippingCost.Location = new System.Drawing.Point(780, 370);
            this.shippingCost.Name = "shippingCost";
            this.shippingCost.Size = new System.Drawing.Size(73, 32);
            this.shippingCost.TabIndex = 6;
            this.shippingCost.Text = "Cost";
            this.shippingCost.Click += new System.EventHandler(this.shippingCost_Click);
            // 
            // numDrawers
            // 
            this.numDrawers.AutoSize = true;
            this.numDrawers.Location = new System.Drawing.Point(516, 468);
            this.numDrawers.Name = "numDrawers";
            this.numDrawers.Size = new System.Drawing.Size(119, 32);
            this.numDrawers.TabIndex = 7;
            this.numDrawers.Text = "Drawers";
            // 
            // numDrawerCost
            // 
            this.numDrawerCost.AutoSize = true;
            this.numDrawerCost.Location = new System.Drawing.Point(780, 468);
            this.numDrawerCost.Name = "numDrawerCost";
            this.numDrawerCost.Size = new System.Drawing.Size(73, 32);
            this.numDrawerCost.TabIndex = 8;
            this.numDrawerCost.Text = "Cost";
            // 
            // numDesks
            // 
            this.numDesks.AutoSize = true;
            this.numDesks.Location = new System.Drawing.Point(516, 565);
            this.numDesks.Name = "numDesks";
            this.numDesks.Size = new System.Drawing.Size(93, 32);
            this.numDesks.TabIndex = 9;
            this.numDesks.Text = "Desks";
            // 
            // numDeskCost
            // 
            this.numDeskCost.AutoSize = true;
            this.numDeskCost.Location = new System.Drawing.Point(780, 565);
            this.numDeskCost.Name = "numDeskCost";
            this.numDeskCost.Size = new System.Drawing.Size(73, 32);
            this.numDeskCost.TabIndex = 10;
            this.numDeskCost.Text = "Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 678);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total Cost";
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.Location = new System.Drawing.Point(780, 678);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(73, 32);
            this.totalCost.TabIndex = 12;
            this.totalCost.Text = "Cost";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 789);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDeskCost);
            this.Controls.Add(this.numDesks);
            this.Controls.Add(this.numDrawerCost);
            this.Controls.Add(this.numDrawers);
            this.Controls.Add(this.shippingCost);
            this.Controls.Add(this.shipping);
            this.Controls.Add(this.materialCost);
            this.Controls.Add(this.area);
            this.Controls.Add(this.areaCost);
            this.Controls.Add(this.deskMaterial);
            this.Controls.Add(this.name);
            this.Name = "DisplayQuote";
            this.Text = "Your Quote";
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label deskMaterial;
        private System.Windows.Forms.Label areaCost;
        private System.Windows.Forms.Label area;
        private System.Windows.Forms.Label materialCost;
        private System.Windows.Forms.Label shipping;
        private System.Windows.Forms.Label shippingCost;
        private System.Windows.Forms.Label numDrawers;
        private System.Windows.Forms.Label numDrawerCost;
        private System.Windows.Forms.Label numDesks;
        private System.Windows.Forms.Label numDeskCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalCost;
    }
}