using GrabHub.Cards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabHub
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void returnActionPnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();  // Close AddProduct form
            if (this.Owner != null) // If the original MainMenu exists
            {
                this.Owner.Show();  // Show the original MainMenu instead of creating a new one
            }
        }

        private void fruitVegeBtn_Click(object sender, EventArgs e)
        {
            FruitsandVegetables fruitsandVegetables = new FruitsandVegetables();
            itemsSectPanel.Controls.Clear();
            itemsSectPanel.Controls.Add(fruitsandVegetables);
            fruitsandVegetables.Dock = DockStyle.Fill;
        }

        private void itemsSectPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dairyItemsBtn_Click(object sender, EventArgs e)
        {
            DairyItems dairyItems = new DairyItems();
            itemsSectPanel.Controls.Clear();
            itemsSectPanel.Controls.Add(dairyItems);
            dairyItems.Dock = DockStyle.Fill;
        }
    }
}
