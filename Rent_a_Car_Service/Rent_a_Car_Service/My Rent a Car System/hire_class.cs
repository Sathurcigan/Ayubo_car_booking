using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Rent_a_Car_Service.My_common_class;

namespace Rent_a_Car_Service.My_Rent_a_Car_System
{
    class hire_class
    {
        int id,noOfDays;
        DateTime st_date, en_date;
        ComboBox vehicle, hire_pac, Driver, tour, hire_other;
        DataGridView load_box;

        public hire_class(Hire form) 
        {

            if (form.idText.Text != "" && form.noOfDayBox.Text != "" && form.st_dateBox.Text != "" && form.en_dateBox.Text != "")
            {
                this.id = Convert.ToInt32(form.idText.Text);
                this.noOfDays = Convert.ToInt32(form.noOfDayBox.Text);
                this.st_date = Convert.ToDateTime(form.st_dateBox.Text);
                this.en_date = Convert.ToDateTime(form.en_dateBox.Text);
            }
            
            this.vehicle = form.veh_Box;
            this.Driver = form.dri_Box;
            this.hire_pac = form.hire_pacBox;
            this.tour = form.tourBox;
            this.hire_other = form.hire_otherBox;
            this.load_box = form.loadTable;
        }

        public void save_fun()
        {
            string sql = "insert into Hire (Tt_id_fk,HPac_id_fk,V_id_fk,D_id_fk,H_startDate,H_endDate,Hire_noOfDays,H_otherCharge_fk) values ('" + this.tour.SelectedValue.ToString() + "','" + this.hire_pac.SelectedValue.ToString() + "', '" + this.vehicle.SelectedValue.ToString() + "','" + this.Driver.SelectedValue.ToString() + "','" + this.st_date + "','" + this.en_date + "','" + this.noOfDays + "', '" + this.hire_other.SelectedValue.ToString() + "')";
            Common_code.common_fun(sql, Common_code.fun_type.Insert);
            view_fun();
        }

        public void update_fun()
        {
            string sql = "update Hire set Tt_id_fk ='" + this.tour.SelectedValue.ToString() + "',HPac_id_fk ='" + this.hire_pac.SelectedValue.ToString() + "', V_id_fk = '" + this.vehicle.SelectedValue.ToString() + "',D_id_fk ='" + this.Driver.SelectedValue.ToString() + "',H_startDate ='" + this.st_date + "',H_endDate ='" + this.en_date + "',Hire_noOfDays ='" + this.noOfDays + "', H_otherCharge_fk = '"+this.hire_other.SelectedValue.ToString()+"' where H_id = '" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Update);
            view_fun();
        }

        public void delete_fun()
        {
            string sql = "delete Hire where H_id = '" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Delete);
            view_fun();
        }

        public void view_fun()
        {
            string sql = "SELECT *FROM Hire";
            Common_code.loadTableFun(sql,this.load_box);
        }

        public void loadComboBox()
        {
            string sql = "SELECT *FROM Vehicle JOIN Vehicle_type ON Vehicle.VT_id_fk = Vehicle_type.VT_id";
            Common_code.loadComboBox_fun(sql, this.vehicle, "V_id", "VT_name");
            
            string sql2 = "SELECT *FROM  Driver";
            Common_code.loadComboBox_fun(sql2, this.Driver, "D_id", "D_name");

            string sql3 = "SELECT *FROM Tour_type";
            Common_code.loadComboBox_fun(sql3, this.tour, "Tt_id", "Tt_name");

            string sql4 = "SELECT *FROM Hire_package";
            Common_code.loadComboBox_fun(sql4, this.hire_pac, "HPac_id", "HPac_type");

            string sql5 = "SELECT *FROM Hire_otherCharges";
            Common_code.loadComboBox_fun(sql5, this.hire_other, "Hec_id", "Hec_name");
        }        
    }
}
