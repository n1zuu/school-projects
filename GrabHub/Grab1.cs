using Microsoft.VisualBasic;

namespace GrabHub
{
    public partial class Grab1 : Form
    {
        static Boolean showed = false;
        public Grab1()
        {
            InitializeComponent();
            if (showed)
            {
                actionPanel.Show();
                mainPanel.Hide();
            }
            showed = true;
        }

        private void mainBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void actionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            actionPanel.Show();
            mainPanel.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void returnMainBtn_Click(object sender, EventArgs e)
        {
            actionPanel.Hide();
            mainPanel.Show();
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Owner = this;
            this.Hide();
            add.ShowDialog();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            Remove remove = new Remove();
            remove.Owner = this;
            this.Hide();
            remove.ShowDialog();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.Owner = this;
            this.Hide();
            view.ShowDialog();
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            Finalize finalize = new Finalize();
            finalize.Owner = this;
            this.Hide();
            finalize.ShowDialog();
        }
        private void Grab1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
