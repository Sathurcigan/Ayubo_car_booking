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
    public partial class Hire_package : Form
    {
        public Hire_package()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            new Hire_package_calss(this).insert_fun();
            clean_fun();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            new Hire_package_calss(this).update_fun();
            clean_fun();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            new Hire_package_calss(this).delete_fun();
            clean_fun();
        }

        private void Hire_package_Load(object sender, EventArgs e)
        {
            new Hire_package_calss(this).view_fun();
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idText.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                hirePackageBox.Text = loadTable.Rows[index].Cells[1].Value.ToString();
                amountBox.Text = loadTable.Rows[index].Cells[2].Value.ToString();
                min_kmBox.Text = loadTable.Rows[index].Cells[3].Value.ToString();
                max_kmBox.Text = loadTable.Rows[index].Cells[4].Value.ToString();
                hourBox.Text = loadTable.Rows[index].Cells[5].Value.ToString();
            }
        }

        public void clean_fun() 
        {
            hirePackageBox.Text = "";
            amountBox.Text = "";
            min_kmBox.Text = "";
            max_kmBox.Text = "";
            idText.Text = "";
            hourBox.Text = "";
        }
    }
}
