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

namespace Rent_a_Car_Service
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.Panel form_panel;
        private System.Windows.Forms.MenuStrip mainMenu_strip;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tourTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hirePaymentToolStripMenuItem;

        
               
        private void vehicleType_menu_Click(object sender, EventArgs e)
        {
            Common_code.formMoving_fun(new Vehicle_Type(), menue_panel);
        }

        private void rentPayment_menu_Click(object sender, EventArgs e)
        {
            Common_code.formMoving_fun(new Rent_payment(), menue_panel);
        }

        private void hirePayment_menu_Click(object sender, EventArgs e)
        {
            Common_code.formMoving_fun(new Hire_payment(), menue_panel);
        }

        private void rentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Common_code.formMoving_fun(new Rent(), menue_panel);
        }

        private void driverToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Common_code.formMoving_fun(new Driver(), menue_panel);
        }

        private void rentTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common_code.formMoving_fun(new Rent_type(), menue_panel);
        }

        private void vehicleServiceInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Common_code.formMoving_fun(new Vehicle_service_details(), menue_panel);
        }

        private void rateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Common_code.formMoving_fun(new Rate(), menue_panel);
        }

        private void tourTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Common_code.formMoving_fun(new Tour_type(), menue_panel);
        }

        private void hireToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Common_code.formMoving_fun(new Hire(), menue_panel);
        }

        private void hirePackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common_code.formMoving_fun(new Hire_package(), menue_panel);
        }

        private void hireOtherChargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common_code.formMoving_fun(new Hire_other_charges(), menue_panel);
        }

        private void vehicleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Common_code.formMoving_fun(new Vehicle(), menue_panel);
        }

        private void vehicleTypeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Common_code.formMoving_fun(new Vehicle_Type(), menue_panel);
        }

        private void vehicleServiceInfoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Common_code.formMoving_fun(new Vehicle_service_details(), menue_panel);
        }

        private void createNewAccountToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Common_code.formMoving_fun(new New_account(), menue_panel);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common_code.formMoving_fun(new Login(), menue_panel);
        }
    }
}
