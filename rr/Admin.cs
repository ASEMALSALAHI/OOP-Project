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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\rr\rr\Database1.mdf;Integrated Security=True");

        private void btnHome_Click(object sender, EventArgs e)
        {
            new AdminHome().Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.ItemsTbl' table. You can move, or remove it, as needed.
           // this.itemsTblTableAdapter1.Fill(this.database1DataSet.ItemsTbl);
            // TODO: This line of code loads data into the 'usersDataSet.ItemsTbl' table. You can move, or remove it, as needed.
            //this.itemsTblTableAdapter.Fill(this.usersDataSet.ItemsTbl);
            //this.itemsTblTableAdapter.Fill(this.usersDataSet.ItemsTbl);
            veri_goster();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox2.Text ==""  || textBox4.Text =="" || textBox5.Text == "")
            {
                MessageBox.Show("Please fill data!!");
            }
            else if (textBox1.Text !=null && textBox2.Text != null && textBox4.Text != null && textBox5.Text != null)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\rr\rr\Database1.mdf;Integrated Security=True");
                    string insertitem = "insert into ItemsTbl(ItemName,ItemDesc,ItemPrice,ItemWeight) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "') ";
                    SqlCommand comm = new SqlCommand(insertitem, conn);
                    conn.Open();
                    comm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data successfully added");
                    txbox_sil();
                    veri_goster();
                }
                catch (Exception urun_ex)
                {


                    MessageBox.Show("Error" + urun_ex);
                }
                finally
                {
                    conn.Close();
                }

            }
        }
       

       
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "" && textBox5.Text == "")
            {
                MessageBox.Show("please enter id !!");
            }
            else if(textBox1.Text != "")
            {
                string deletitem = "DELETE FROM ItemsTbl WHERE ItemName='" + textBox1.Text + "'";
                SqlCommand comm1 = new SqlCommand(deletitem, conn);
                conn.Open();
                comm1.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data deleted successfully");
                txbox_sil();
                veri_goster();

            }
        }
      
        public void txbox_sil()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        public void veri_goster()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from ItemsTbl", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
        
        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            

        }
//        UPDATE Customers
//SET ContactName = 'Alfred Schmidt', City = 'Frankfurt'
//WHERE CustomerID = 1;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string updateitem = @"UPDATE ItemsTbl SET ItemName='" + textBox1.Text + "',ItemDesc='"+ textBox2.Text + "',ItemPrice='" + textBox4.Text + "',ItemWeight='" + textBox5.Text + "' WHERE ItemID='" + textBox3.Text + "' ";
            SqlCommand comm = new SqlCommand(updateitem, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            
            txbox_sil();
            MessageBox.Show(" DATA edited successfully");
            veri_goster();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
