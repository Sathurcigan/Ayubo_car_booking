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
    public partial class Tour_type : Form
    {
        public Tour_type()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            new tourType_class(this).save_fun();
            clean_fun();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            new tourType_class(this).update_fun();
            clean_fun();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            new tourType_class(this).delete_fun();
            clean_fun();
        }

        private void Tour_type_Load(object sender, EventArgs e)
        {
            new tourType_class(this).view_fun();
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idText.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                tourDisBox.Text = loadTable.Rows[index].Cells[2].Value.ToString();
                tour_nameBox.Text = loadTable.Rows[index].Cells[1].Value.ToString();
            }
        }

        public void clean_fun() 
        {
            idText.Text = "";
            tour_nameBox.Text = "";
            tourDisBox.Text = "";
        }
    }
}
