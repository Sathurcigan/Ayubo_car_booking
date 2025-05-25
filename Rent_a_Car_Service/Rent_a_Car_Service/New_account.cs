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

namespace Rent_a_Car_Service
{
    public partial class New_account : Form
    {
        public New_account()
        {
            InitializeComponent();
        }
        
        private void insertBtn_Click(object sender, EventArgs e)
        {
            string new_pass = newPass_box.Text;
            string con_pass = conPass_box.Text;

            if (new_pass == con_pass)
            {
                new Customer_class(this).save_fun();
            }
            else 
            {
                MessageBox.Show("Check your Personal details and Password......................!");
            }
            clean_fun();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string new_pass = newPass_box.Text;
            string con_pass = conPass_box.Text;

            if (new_pass == con_pass)
            {
                new Customer_class(this).update_fun();
            }
            else
            {
                MessageBox.Show("Check your Personal details and Password......................!");
            }
            clean_fun();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string new_pass = newPass_box.Text;
            string con_pass = conPass_box.Text;

            if (new_pass == con_pass)
            {
                new Customer_class(this).delete_fun();
            }
            else
            {
                MessageBox.Show("Check your Password......................!");
            }
            clean_fun();
        }

        private void New_account_Load(object sender, EventArgs e)
        {
            new Customer_class(this).view_fun();
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idText.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                nameBox.Text = loadTable.Rows[index].Cells[1].Value.ToString();
                addressBox.Text = loadTable.Rows[index].Cells[2].Value.ToString();
                phoneNoBox.Text = loadTable.Rows[index].Cells[3].Value.ToString();
                newPass_box.Text = loadTable.Rows[index].Cells[4].Value.ToString();
            }
        }

        public void clean_fun() 
        {
            nameBox.Text = "";
            addressBox.Text = "";
            phoneNoBox.Text = "";
            newPass_box.Text = "";
            conPass_box.Text = "";
        }
    }
}
