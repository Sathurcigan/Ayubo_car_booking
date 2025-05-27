using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Rent_a_Car_Service.My_Rent_a_Car_System;
using Rent_a_Car_Service.My_common_class;

namespace Rent_a_Car_Service
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void signBtn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT *FROM Customer where Cus_name = '" + userBox.Text+"'";
            
                DataTable cus_detail = Common_code.listGather_fun(sql);
           
            if (cus_detail.Rows.Count != 0)
            {
                string pass = cus_detail.Rows[0]["Cus_password"].ToString();

                if (pass.Trim() == passBox.Text)
                {
                    MessageBox.Show("Login sucessfully................!");

                    this.Hide();
                    Menu main = new Menu();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Check your Password...........!");
                }
            }
            else
            {
                MessageBox.Show("Check your Username.....!");
            }
            clean_fun();
        }

        public void clean_fun() 
        {
            userBox.Text = "";
            passBox.Text = "";
        }

        private void newAccountBtn_Click(object sender, EventArgs e)
        {
            New_account reg = new New_account();
            reg.Show();
            this.Hide();
        }
    }
}
