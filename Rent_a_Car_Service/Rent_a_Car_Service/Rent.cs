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
    public partial class Rent : Form
    {
        public Rent()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            new rent_class(this).save_fun();
            clean_fun(); 
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            new rent_class(this).update_fun();
            clean_fun(); 
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            new rent_class(this).delete_fun();
            clean_fun(); 
        }

        private void Rent_Load(object sender, EventArgs e)
        {
            new rent_class(this).view_fun();
            new rent_class(this).loadCombo_fun();
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idText.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                veh_typeBox.SelectedValue = loadTable.Rows[index].Cells[1].Value.ToString();
                re_typeBox.SelectedValue = loadTable.Rows[index].Cells[6].Value.ToString();
                driverBox.SelectedValue = loadTable.Rows[index].Cells[3].Value.ToString();
                st_dateBox.Text = loadTable.Rows[index].Cells[4].Value.ToString();
                en_dateBox.Text = loadTable.Rows[index].Cells[5].Value.ToString();
                dayBox.Text = loadTable.Rows[index].Cells[2].Value.ToString();
            }
        }

        public void clean_fun()
        {
            veh_typeBox.Text = "";
            re_typeBox.Text = "";
            driverBox.Text = "";
            st_dateBox.Text = "";
            en_dateBox.Text = "";
            dayBox.Text = "";
        }

        private void re_typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (re_typeBox.Text == "Without Driver")
            {
                this.driverBox.Enabled = false;
                this.driverBox.Text = "Null";
            }
            else
            {
                this.driverBox.Enabled = true;

            }
        }

        private void en_dateBox_TextChanged(object sender, EventArgs e)
        {
            date_calculation_fun();
        }

        public void date_calculation_fun() 
        {           

        }
    }
}
