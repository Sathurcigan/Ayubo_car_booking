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
    public partial class Hire_other_charges : Form
    {
        public Hire_other_charges()
        {
            InitializeComponent();
        }

        private void Hire_other_charges_Load(object sender, EventArgs e)
        {
            new Hire_other_charges_class(this).view_fun();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            new Hire_other_charges_class(this).Save_fun();
            clean_fun();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            new Hire_other_charges_class(this).Delete_fun();
            clean_fun();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            new Hire_other_charges_class(this).Update_fun();
            clean_fun();
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idText.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                exDisBox.Text = loadTable.Rows[index].Cells[1].Value.ToString();
                exHourBox.Text = loadTable.Rows[index].Cells[2].Value.ToString();
                pac_nameBox.Text = loadTable.Rows[index].Cells[3].Value.ToString();
            }
        }

        public void clean_fun() 
        {
            idText.Text = "";
            exDisBox.Text = "";
            exHourBox.Text = "";
            pac_nameBox.Text = "";
        }
    }
}
