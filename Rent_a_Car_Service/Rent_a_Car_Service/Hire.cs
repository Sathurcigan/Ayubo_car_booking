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
    public partial class Hire : Form
    {
        public Hire()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            new hire_class(this).save_fun();
            clean_fun();
        }

        private void Hire_Load(object sender, EventArgs e)
        {
            new hire_class(this).loadComboBox();
            new hire_class(this).view_fun();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            new hire_class(this).update_fun();
            clean_fun();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            new hire_class(this).delete_fun();
            clean_fun();
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idText.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                veh_Box.SelectedValue = loadTable.Rows[index].Cells[3].Value.ToString();
                tourBox.SelectedValue = loadTable.Rows[index].Cells[1].Value.ToString();
                hire_pacBox.SelectedValue = loadTable.Rows[index].Cells[2].Value.ToString();
                dri_Box.SelectedValue = loadTable.Rows[index].Cells[4].Value.ToString();
                st_dateBox.Text = loadTable.Rows[index].Cells[5].Value.ToString();
                en_dateBox.Text = loadTable.Rows[index].Cells[6].Value.ToString();
                noOfDayBox.Text = loadTable.Rows[index].Cells[7].Value.ToString();
                hire_otherBox.SelectedValue = loadTable.Rows[index].Cells[8].Value.ToString();
            }
        }



        public void clean_fun()
        {
            idText.Text = "";
            veh_Box.Text = "";
            tourBox.Text = "";
            hire_pacBox.Text = "";
            dri_Box.Text = "";
            st_dateBox.Text = "";
            en_dateBox.Text = "";
            noOfDayBox.Text = "";
            hire_otherBox.Text = "";
        }
    }
}
