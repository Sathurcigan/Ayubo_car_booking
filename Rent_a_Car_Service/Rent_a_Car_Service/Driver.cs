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
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            new Driver_class(this).save_fun();
            clean_fun();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            new Driver_class(this).update_fun();
            clean_fun();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            new Driver_class(this).delete_fun();
            clean_fun();
        }

        private void Driver_Load(object sender, EventArgs e)
        {
            new Driver_class(this).view_fun();
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
                licanceNoBox.Text = loadTable.Rows[index].Cells[4].Value.ToString();
                rateBox.Text = loadTable.Rows[index].Cells[5].Value.ToString();
                overNightChargeBox.Text = loadTable.Rows[index].Cells[6].Value.ToString();
                waitingCharge_box.Text = loadTable.Rows[index].Cells[7].Value.ToString();
            }
        }

        public void clean_fun() 
        {
            idText.Text = "";
            nameBox.Text = "";
            addressBox.Text = "";
            phoneNoBox.Text = "";
            licanceNoBox.Text = "";
            rateBox.Text = "";
            overNightChargeBox.Text = "";
            waitingCharge_box.Text = "";
        }
    }
}
