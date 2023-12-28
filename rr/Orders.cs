using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace rr
{
    public partial class Orders : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\rr\rr\Database1.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adp = new SqlDataAdapter();
        public Orders()
        {
            InitializeComponent();

          
        }
        Customer _Customer = new Customer();



        

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet4.ItemsTbl' table. You can move, or remove it, as needed.
           //this.itemsTblTableAdapter.Fill(this.usersDataSet4.ItemsTbl);
            veri_goster();
            txtBoxOrderID.Enabled = false;
            btnDetails.Enabled = false;
            textBox1.Enabled = false;
            btnSearch.Enabled = false;
        }
        public void veri_goster()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select OrderID,CustName,Date from Orders", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void txtBoxOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            order Orrders = new order(_Customer);
            SqlDataReader Reaad;
            string sql = "select * from Orders where OrderID = '" + txtBoxOrderID.Text + "'";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            Reaad = cmd.ExecuteReader();
            txtBoxOrderID.Clear();
            listView1.Items.Clear();

            while (Reaad.Read())
            {
               
                Orrders.Order_Details.I_tems.ItemId = Reaad.GetInt32(1);
                Orrders.Order_Details.I_tems.ItemName = Reaad.GetString(2);
                Orrders.OrderCust.Cost_Name = Reaad.GetString(3);
                Orrders.Order_Details.OrderQuantity = Reaad.GetInt32(4);
                Orrders.Order_Details.TotalItemPrice = Reaad.GetInt32(5);
                Orrders.Order_Details.I_tems.ItemWeight = Reaad.GetInt32(7);
                Orrders.Order_Details.OrderWeight = Orrders.Order_Details.CalcWeight();
                //MessageBox.Show(Orrders.Order_Details.OrderWeight.ToString());


                ListViewItem lv = new ListViewItem(Orrders.Order_Details.I_tems.ItemId.ToString());
                lv.SubItems.Add(Orrders.Order_Details.I_tems.ItemName);
                lv.SubItems.Add(Orrders.OrderCust.Cost_Name);
                lv.SubItems.Add(Orrders.Order_Details.OrderQuantity.ToString());
                lv.SubItems.Add(Orrders.Order_Details.TotalItemPrice.ToString());
                lv.SubItems.Add(Orrders.Order_Details.OrderWeight.ToString());
                listView1.Items.Add(lv);

               // listView1.Items.Add(Orrders.Order_Details.I_tems.ItemId.ToString());
               //listView1.SubItems.Add(Orrders.Order_Details.I_tems.ItemName);
            }
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            order o2 = new order(_Customer);
            SqlDataReader Reaad;
            string sql = "select * from Orders where CustName = '" + textBox1.Text + "'";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            Reaad = cmd.ExecuteReader();
            txtBoxOrderID.Clear();
            listView1.Items.Clear();

            while (Reaad.Read())
            {

                o2.Order_Details.I_tems.ItemId = Reaad.GetInt32(1);
                o2.Order_Details.I_tems.ItemName = Reaad.GetString(2);
                o2.OrderCust.Cost_Name = Reaad.GetString(3);
                o2.Order_Details.OrderQuantity = Reaad.GetInt32(4);
                o2.Order_Details.TotalItemPrice = Reaad.GetInt32(5);
                o2.Order_Details.I_tems.ItemWeight = Reaad.GetInt32(7);
                o2.Order_Details.OrderWeight = o2.Order_Details.CalcWeight();
                //MessageBox.Show(Orrders.Order_Details.OrderWeight.ToString());


                ListViewItem lv = new ListViewItem(o2.Order_Details.I_tems.ItemId.ToString());
                lv.SubItems.Add(o2.Order_Details.I_tems.ItemName);
                lv.SubItems.Add(o2.OrderCust.Cost_Name);
                lv.SubItems.Add(o2.Order_Details.OrderQuantity.ToString());
                lv.SubItems.Add(o2.Order_Details.TotalItemPrice.ToString());
                lv.SubItems.Add(o2.Order_Details.OrderWeight.ToString());
                listView1.Items.Add(lv);

                //listView1.Items.Add(o2.Order_Details.I_tems.ItemId.ToString());
                //listView1.SubItems.Add(o2.Order_Details.I_tems.ItemName);
            }
            conn.Close();

        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminHome().Show();


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxOrderID.Enabled = false;
            btnDetails.Enabled = false;
            textBox1.Enabled = true;
            btnSearch.Enabled = true;

            txtBoxOrderID.Clear();
            textBox1.Clear();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxOrderID.Enabled = true;
            btnDetails.Enabled = true;
            textBox1.Enabled = false;
            btnSearch.Enabled = false;

            txtBoxOrderID.Clear();
            textBox1.Clear();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
