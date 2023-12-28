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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {

            InitializeComponent();
        }
        

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\rr\rr\Database1.mdf;Integrated Security=True");
        SqlDataAdapter adpt = new SqlDataAdapter();
        SqlCommand comand = new SqlCommand();
        SqlCommand comandAdmin = new SqlCommand();
       
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if(TxtBoxUserName.Text == "" || TxtBoxPassword.Text == "" || TxtBoxConfirmPassword.Text == "" )
            {
                MessageBox.Show("Error");
            }
            else if(TxtBoxPassword.Text != TxtBoxConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match");
            }

             else if(TxtBoxPassword.Text == TxtBoxConfirmPassword.Text && TxtBoxUserName.Text != "")
            {

                string strring = "insert into Reg_Users values ('" + TxtBoxUserName.Text + "','" + TxtBoxPassword.Text + "') ";
                string strringAdmin = "insert into Reg_Admin values ('" + TxtBoxUserName.Text + "','" + TxtBoxPassword.Text + "') ";
                comand = new SqlCommand(strring, conn);
              
               comandAdmin = new SqlCommand(strringAdmin, conn);

                try
                {
                    if (ChekBoxAdmin.Checked)
                    {

                        conn.Open();
                        comandAdmin.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Administrator registration completed");
                        AdminHome AAdminHome = new AdminHome();
                        AAdminHome.NameCost = TxtBoxUserName.Text;
                        //AAdminHome.Show();
                      //  this.Hide();
                    }
                    else
                    {

                        
                        conn.Open();
                        comand.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Customer registration completed");
                        //new Home().Show();
                        //this.Hide();
                        Home HHome = new Home();
                        HHome.Name = TxtBoxUserName.Text;
                       // HHome.Show();
                        //this.Hide();

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error" + ex);
                    TxtBoxUserName.Clear();
                    TxtBoxPassword.Clear();
                    TxtBoxConfirmPassword.Clear();
                    conn.Close();

                }

                //finally
                //{
                //    conn.Close();
                //}
                    
                
                
            }

            

        }

        private void ChekBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BackToLoginLbl_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
