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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\rr\rr\Database1.mdf;Integrated Security=True");
        SqlDataAdapter adpt = new SqlDataAdapter();
        SqlCommand comand = new SqlCommand();
        SqlCommand comandAdmin = new SqlCommand();
        

        private void TxtBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        Home hm = new Home();
        private void LoginBtn_Click(object sender, EventArgs e)
        {

            if (TxtBoxUserName.Text == "" && TxtBoxPassword.Text == "")
            {
                MessageBox.Show("Username and Password  are empty");
            }
            else if (ChekBoxAdmin.Checked)
            {
                try
                {
                    conn.Open();
                    string stringgg = "select * from Reg_Admin where Admin_Name = '" + TxtBoxUserName.Text + "' and Admin_Pass = '" + TxtBoxPassword.Text + "' ";
                    SqlDataAdapter sda = new SqlDataAdapter(stringgg, conn);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);
                    if (dtable.Rows.Count > 0)
                    {
                        //if (ChekBoxAdmin.Checked)
                        //{

                        //}

                        new AdminHome().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login details", " Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtBoxUserName.Clear();
                        TxtBoxPassword.Clear();

                    }


                }
                catch
                {

                    MessageBox.Show("Error");
                }
                finally
                {
                    conn.Close();
                }

            }
            else  
            {
                try
                {
                    conn.Open();
                    string stringg = "select * from Reg_Users where UserName = '" + TxtBoxUserName.Text + "' and Password = '" + TxtBoxPassword.Text + "' ";
                    comand = new SqlCommand(stringg, conn);
                    SqlDataReader userread;
                    userread = comand.ExecuteReader();
                    if (userread.Read() == true)
                    {
                        //if (ChekBoxAdmin.Checked)
                        //{

                        //}

                        hm._Customer.Cost_Name = TxtBoxUserName.Text;
                        hm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login details", " Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtBoxUserName.Clear();
                        TxtBoxPassword.Clear();

                    }
                }
                catch
                {

                    MessageBox.Show("Error");
                }
                finally
                {
                    conn.Close();
                }


            }

           // conn.Open();
           // string stringg = "select * from Reg_Users where UserName = '" + TxtBoxUserName.Text + "' and Password = '" + TxtBoxPassword.Text + "' ";
           // string stringgg = "select * from Reg_Admin where UserName = '" + TxtBoxUserName.Text + "' and Password = '" + TxtBoxPassword.Text + "' ";
           // comand = new SqlCommand(stringg, conn);
            //comandAdmin = new SqlCommand(stringgg, conn);
            //SqlDataReader reaad;
            //reaad = comand.ExecuteReader();
            
            //if(reaad.Read() == true)
            //{
            //    //if (ChekBoxAdmin.Checked)
            //    //{
                    
            //    //}

            //    new Home().Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("your username or password are incorrect");
            //}
            //conn.Close();
        }

        private void CreateAccountLbl_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void ChekBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ChekBoxShowPassword.Checked)
            {
                TxtBoxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                TxtBoxPassword.UseSystemPasswordChar = false;
            }
            

            

        }

        private void ChekBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
