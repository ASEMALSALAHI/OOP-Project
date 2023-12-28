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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            
            
        }
        
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\rr\rr\Database1.mdf;Integrated Security=True");
        SqlCommand cmd =new SqlCommand();
        SqlDataAdapter adp = new SqlDataAdapter();
        Items Item = new Items();
        public string  Name { get; set; }
        Customer _Customer = new Customer();
        
       

        private void btnBuy_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            TxtBoxItemID.Enabled = false;
            TxtBoxQuantity.Enabled = false;
            btnAdd.Enabled = false;
            btnSearch.Enabled = false;



            //DateTime t1 = new DateTime();
            //t1 = DTExpDate.Value;
            //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            //{
                

            //    cmd = new SqlCommand(@"INSERT INTO Orders (OrderID,ItemName,ItemID,CustName,Quantity,Price,Date,TotalWeight)VALUES('" + TxtBoxSpeteNo.Text + "','" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','"
            //        + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value +
            //        "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + t1 + "','" + Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value) + "')", conn);


            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    conn.Close();

            //}


            //dataGridView1.Rows.Clear();
       
           
            
        }





        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void Products_Load(object sender, EventArgs e)
        {
            lblBankID.Visible = false;
            lblCartNumber.Visible = false;
            lblExpDate.Visible = false;
            lblName.Visible = false;
            lblType.Visible = false;
            TxtBoxBankID.Visible = false;
            TxtBoxCartNumber.Visible = false;
            TxtBoxName.Visible = false;
            TxtBoxType.Visible = false;
            DTExpDate.Visible = false;
            txbox_amount.Visible = false;
            label10.Visible = false;
            SepeteNo();
            lblTax.Text = "0";
            //this.itemsTblTableAdapter.Fill(this.usersDataSet11.ItemsTbl);
           // this.itemsTblTableAdapter.Fill(this.Database1Dataset11.ItemTbl);
            veri_goster();

           _Customer.Cost_Name = Name;

            //_Customer.Cost_Name = this.TxtBoxUserName.t;
            TxtBoxCustName.Text=_Customer.Cost_Name;
            TxtBoxCustName.Enabled = false;
            TxtBoxItemName.Enabled = false;
            

        }





        public void veri_goster()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from ItemsTbl", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            conn.Close();
        }





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            float TaxPrice;
            order Orr = new order(_Customer);
            if (TxtBoxQuantity.Text=="")
            {
                MessageBox.Show("Lütfen Quantity Doldur");
            }
            else if (TxtBoxQuantity.Text !=null)
            {
                

                string[] add = { TxtBoxItemName.Text, TxtBoxItemID.Text, _Customer.Cost_Name, TxtBoxQuantity.Text, Convert.ToString(Item.getPriceForQuantity(Convert.ToInt32(TxtBoxQuantity.Text))),TxtBoxItemWeight.Text };
                dataGridView1.Rows.Add(add);
                CalcTotalPrice();
                TaxPrice = Orr.CalcTax(Convert.ToInt32(lblPrice.Text));
                lblTax.Text = TaxPrice.ToString();
                TxtBoxItemID.Clear();
                TxtBoxItemName.Clear();
                TxtBoxItemWeight.Clear();
                TxtBoxQuantity.Clear();

                
              


            }
            
            


        }



        SqlDataReader read;




        public void CalcTotalPrice()
        {
            int totalPrice = 0;
            for (int i = 0; i < dataGridView1.Rows.Count -1 ; i++)
            {
                totalPrice += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            lblPrice.Text = Convert.ToString(totalPrice);
        }




        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            string str = "select * from ItemsTbl where ItemID = '" + TxtBoxItemID.Text + "' ";

            cmd = new SqlCommand(str, conn);
            
            read = cmd.ExecuteReader();
            if (read.Read() == true)
            {
                Item.ItemPrice = read.GetInt32(3);
                TxtBoxItemName.Text = read.GetString(0);
                TxtBoxItemWeight.Text = Convert.ToString(read.GetInt32(4));


                

                //dataGridView1.Rows.Add(read.GetString(0), read.GetString(2), TxtBoxOrderId.Text, TxtBoxCustName.Text, TxtBoxQuantity.Text, Item.getPriceForQuantity(Convert.ToInt32(TxtBoxQuantity.Text)));
                conn.Close();
            }
            else
            {
                MessageBox.Show("urun bulunmamaktadir!");
                conn.Close();
            }
            
        }


        
        public void SepeteNo()
        {
           
            
            try
            {
                string sql = "select MAX(OrderID) from Orders";
                cmd = new SqlCommand(sql, conn);
                
                conn.Open();
                var MaxID = cmd.ExecuteScalar() as string;
                
                if (MaxID == null)
                {
                    
                    TxtBoxSpeteNo.Text = "1";
                    
                   
                }
                else
                {

                    int maxid = Convert.ToInt32(MaxID);
                    maxid++;
                    TxtBoxSpeteNo.Text = Convert.ToString(maxid);
                    
                    
                }
                conn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                
                
            }
            


        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtBoxCustName_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdioCredit_CheckedChanged(object sender, EventArgs e)
        {
            lblBankID.Visible = false;
            lblName.Visible = false;
            TxtBoxName.Visible = false;
            TxtBoxBankID.Visible = false;
            lblCartNumber.Visible = true;
            lblExpDate.Visible = true;
            lblType.Visible = true;
            TxtBoxType.Visible = true;
            TxtBoxCartNumber.Visible = true;
            DTExpDate.Visible = true;
            txbox_amount.Visible = false;
            label10.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblCartNumber.Visible = false;
            lblExpDate.Visible = false;
            lblType.Visible = false;
            TxtBoxType.Visible = false;
            TxtBoxCartNumber.Visible = false;
            DTExpDate.Visible = false;
            lblBankID.Visible = true;
            lblName.Visible = true;
            TxtBoxName.Visible = true;
            TxtBoxBankID.Visible = true;
            txbox_amount.Visible = false;
            label10.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txbox_amount.Visible = true;
            label10.Visible = true;
            lblCartNumber.Visible = false;
            lblExpDate.Visible = false;
            lblType.Visible = false;
            TxtBoxType.Visible = false;
            TxtBoxCartNumber.Visible = false;
            TxtBoxCartNumber.Visible = false;
            DTExpDate.Visible = false;
            lblBankID.Visible = false;
            lblName.Visible = false;
            TxtBoxName.Visible = false;
            TxtBoxBankID.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime t1 = new DateTime();
            t1 = DTExpDate.Value;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {


                cmd = new SqlCommand(@"INSERT INTO Orders (OrderID,ItemName,ItemID,CustName,Quantity,Price,Date,TotalWeight)VALUES('" + TxtBoxSpeteNo.Text + "','" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','"
                    + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value +
                    "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + t1 + "','" + Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value) + "')", conn);


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }


            dataGridView1.Rows.Clear();


            frmLogin fr1 = new frmLogin();
            fr1.Show();
            Application.Restart();

                   }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void lblTax_Click(object sender, EventArgs e)
        {

        }
    }
}
