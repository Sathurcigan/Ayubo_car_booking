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
    public partial class Vehicle : Form
    {
        public Vehicle()
        {
            InitializeComponent();
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            new Vehicle_class(this).loadComboBox();
            new Vehicle_class(this).view_fun();
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idText.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                veh_typeBox.SelectedValue = loadTable.Rows[index].Cells[1].Value.ToString();
                veh_noBox.Text = loadTable.Rows[index].Cells[2].Value.ToString();
                last_serBox.SelectedValue = loadTable.Rows[index].Cells[3].Value.ToString();
                veh_colourBox.Text = loadTable.Rows[index].Cells[4].Value.ToString();
                nightRate_box.Text = loadTable.Rows[index].Cells[5].Value.ToString();
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            new Vehicle_class(this).Save_fun();
            clean_fun();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            new Vehicle_class(this).Update_fun();
            clean_fun();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            new Vehicle_class(this).Delete_fun();
            clean_fun();
        }

        public void clean_fun() 
        {
            idText.Text = "";
            veh_typeBox.Text = "";
            veh_colourBox.Text = "";
            veh_noBox.Text = "";
            last_serBox.Text = "";
            nightRate_box.Text = "";
        }
    }
}
