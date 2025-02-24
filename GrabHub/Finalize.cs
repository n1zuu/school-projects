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
    public partial class Finalize : Form
    {
        public Finalize()
        {
            InitializeComponent();
        }

        private void checkoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void returnCheckoutPnlBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(this.Owner != null)
            {
                this.Owner.Show();
            }
        }
    }
}
