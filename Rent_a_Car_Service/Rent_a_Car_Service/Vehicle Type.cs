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
    public partial class Vehicle_Type : Form
    {
        public Vehicle_Type()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            new vehicleType_class(this).save_fun();
            clean_fun();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            new vehicleType_class(this).update_fun();
            clean_fun();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            new vehicleType_class(this).delete_fun();
            clean_fun(); 
        }

        private void Vehicle_Type_Load(object sender, EventArgs e)
        {
            new vehicleType_class(this).view_fun();
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index > -1)
            {
                idText.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                veh_typeBox.Text = loadTable.Rows[index].Cells[1].Value.ToString();
            }
        }

        public void clean_fun() 
        {
            idText.Text = "";
            veh_typeBox.Text = "";
        }
    }
}
