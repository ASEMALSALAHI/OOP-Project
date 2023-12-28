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
    public partial class Payform : Form
    {
        public Payform()
        {
            InitializeComponent();
            Customer cst = new Customer();
            order or = new order(cst);
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
        }
        

        private void Payform_Load(object sender, EventArgs e)
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
            lblPrice.Text = Price.ToString();
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
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
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
        public int SptNo { get; set; }
        public string ItemName { get; set; }
        public int ItemID { get; set; }
        public string  CustName { get; set; }
        public int Price { get; set; }
        public DateTime Dt { get; set; }
        public int TotalWeight { get; set; }
        public int Quantity { get; set; }
        
       

        
        private void btnBuy_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
