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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }
        public string NameCost { get; set; }
        Customer _Customer = new Customer();
        private void AdminHome_Load(object sender, EventArgs e)
        {
            _Customer.Cost_Name = NameCost;
           // MessageBox.Show("");
        }
        Admin AAdmin = new Admin();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AAdmin.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Orders().Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
