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
    public partial class Rate : Form
    {
        public Rate()
        {
            InitializeComponent();
        }

        private void insBtn_Click(object sender, EventArgs e)
        {
            new rate_class(this).save_fun();
            clean_fun();
        }

        private void Rate_Load(object sender, EventArgs e)
        {
            new rate_class(this).loadComboBox();
            new rate_class(this).view_fun();
        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            new rate_class(this).update_fun();
            clean_fun();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            new rate_class(this).delete_fun();
            clean_fun();
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idText.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                vehicleTypeBox.SelectedValue = loadTable.Rows[index].Cells[1].Value.ToString();
                mo_rateBox.Text = loadTable.Rows[index].Cells[2].Value.ToString();
                week_rateBox.Text = loadTable.Rows[index].Cells[3].Value.ToString();
                day_rateBox.Text = loadTable.Rows[index].Cells[4].Value.ToString();
            }
        }

        public void clean_fun() 
        {
            vehicleTypeBox.Text = "";
            mo_rateBox.Text = "";
            week_rateBox.Text = "";
            day_rateBox.Text = "";
        }
    }
}
