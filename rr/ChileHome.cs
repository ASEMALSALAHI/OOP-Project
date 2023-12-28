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
    public partial class ChileHome : Form
    {
        public ChileHome()
        {
            InitializeComponent();
        }
        public  string Name { get; set; }

        private void ChileHome_Load(object sender, EventArgs e)
        {
            lblCystName.Text = Name;
        }

         void lblCystName_Click(object sender, EventArgs e)
        {

        }
    }
}
