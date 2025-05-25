using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Rent_a_Car_Service.My_common_class;

namespace Rent_a_Car_Service.My_Rent_a_Car_System
{
    class vehicleService_class
    {
        int id;
        DateTime st_date, en_date;
        Double charge;
        ComboBox veh_type;
        DataGridView load_box;

        public vehicleService_class(Vehicle_service_details form) 
        {
            if (form.idText.Text != "" && form.ser_dateBox.Text != "" && form.nextSer_dateBox.Text != "" && form.ser_chargeBox.Text != "")
            {
                this.id = Convert.ToInt32(form.idText.Text);
                this.st_date = Convert.ToDateTime(form.ser_dateBox.Text);
                this.en_date = Convert.ToDateTime(form.nextSer_dateBox.Text);
                this.charge = Convert.ToDouble(form.ser_chargeBox.Text);               
            }

            this.veh_type = form.vehTypeBox;
            this.load_box = form.loadTable;
        }

        public void Save_fun() 
        {
            string sql = "INSERT INTO Vehicle_serviceDetail (VT_id_fk,Vsd_date,Vsd_nextDate,Vsd_amount) VALUES ('" + this.veh_type.SelectedValue.ToString() + "','" + this.st_date + "','" + this.en_date + "','" + this.charge + "')";
            Common_code.common_fun(sql, Common_code.fun_type.Insert);
            view_fun();
        }

        public void Update_fun()
        {
            string sql = "UPDATE Vehicle_serviceDetail SET VT_id_fk = '" + this.veh_type.SelectedValue.ToString() + "', Vsd_date = '" + this.st_date + "', Vsd_nextDate = '" + this.en_date + "', Vsd_amount = '" + this.charge + "' WHERE Vsd_id = '" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Update);
            view_fun();
        }

        public void Delete_fun()
        {
            string sql = "DELETE Vehicle_serviceDetail WHERE Vsd_id = '"+this.id+"'";
            Common_code.common_fun(sql, Common_code.fun_type.Delete);
            view_fun();
        }

        public void view_fun()
        {
            string sql = "SELECT* FROM Vehicle_serviceDetail";
            Common_code.loadTableFun(sql, this.load_box);
        }

        public void loadCombo_fun()
        {
            string sql = "SELECT* FROM Vehicle_type";
            Common_code.loadComboBox_fun(sql, this.veh_type, "VT_id", "VT_name");
        }
    }
}
