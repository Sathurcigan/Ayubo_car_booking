using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Rent_a_Car_Service.My_common_class;
using Rent_a_Car_Service.My_Rent_a_Car_System;

namespace Rent_a_Car_Service
{
    public partial class Vehicle_service_details : Form
    {
        public Vehicle_service_details()
        {
            InitializeComponent();
        }

        private void Vehicle_service_details_Load(object sender, EventArgs e)
        {
            new vehicleService_class(this).view_fun();
            new vehicleService_class(this).loadCombo_fun();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            new vehicleService_class(this).Save_fun();
            clean_fun();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            new vehicleService_class(this).Update_fun();
            clean_fun();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            new vehicleService_class(this).Delete_fun();
            clean_fun();
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idText.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                vehTypeBox.SelectedValue = loadTable.Rows[index].Cells[1].Value.ToString();
                ser_dateBox.Text = loadTable.Rows[index].Cells[2].Value.ToString();
                nextSer_dateBox.Text = loadTable.Rows[index].Cells[3].Value.ToString();
                ser_chargeBox.Text = loadTable.Rows[index].Cells[4].Value.ToString();
            }
        }

        public void clean_fun()
        {
            vehTypeBox.Text = "";
            ser_dateBox.Text = "";
            nextSer_dateBox.Text = "";
            ser_chargeBox.Text = "";
        }
    }
}
