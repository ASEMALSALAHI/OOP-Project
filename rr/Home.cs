using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rr
{
    public partial class Home : Form
    {
        public Home()
        {

            InitializeComponent();

        }
       public Customer _Customer = new Customer();
        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_Customer.Cost_Name);
        }
        
        private void Home_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoş geldiniz "+ _Customer.Cost_Name);
        }
        ChileHome child = new ChileHome();
        Products prodchil = new Products();
        private void btnHome_Click(object sender, EventArgs e)
        {
            prodchil.Hide();
            lblButtons.Text = "Home";
            
            child.MdiParent = this;
            child.Dock = DockStyle.Fill;
            child.Name = _Customer.Cost_Name;
            child.Show();
            
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            child.Hide();
            lblButtons.Text = "Products";
            prodchil.Dock = DockStyle.Fill;
            prodchil.Name = _Customer.Cost_Name;
            prodchil.MdiParent = this;
            prodchil.Show();
            //this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
