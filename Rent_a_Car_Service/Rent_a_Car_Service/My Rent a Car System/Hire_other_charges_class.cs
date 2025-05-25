using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Rent_a_Car_Service.My_common_class;

namespace Rent_a_Car_Service.My_Rent_a_Car_System
{
    class Hire_other_charges_class
    {
        int id;
        string pac_name;
        double per_hour, per_km;
        DataGridView load_box;

        public Hire_other_charges_class(Hire_other_charges form) 
        {

            if (form.idText.Text != "" && form.exHourBox.Text != "" && form.exDisBox.Text != "")
            {
                this.id = Convert.ToInt32(form.idText.Text);
                this.per_hour = Convert.ToDouble(form.exHourBox.Text);
                this.per_km = Convert.ToDouble(form.exDisBox.Text);
            }

            this.load_box = form.loadTable;
            this.pac_name = form.pac_nameBox.Text;
        }

        public void Save_fun() 
        {
            string sql = "INSERT INTO Hire_otherCharges (Hec_amountPerKm,Hec_amountPerHour,Hec_name) VALUES ('" + this.per_km + "','" + this.per_hour + "','" + this.pac_name + "')";
            Common_code.common_fun(sql,Common_code.fun_type.Insert);
            view_fun();
        }

        public void Update_fun()
        {
            string sql = "UPDATE Hire_otherCharges SET Hec_amountPerKm = '" + this.per_km + "',Hec_amountPerHour = '" + this.per_hour + "',Hec_name = '"+this.pac_name+"' WHERE Hec_id = '" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Update);
            view_fun();
        }
       
        public void Delete_fun()
        {
            string sql = "DELETE Hire_otherCharges WHERE Hec_id = '" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Delete);
            view_fun();
        }

        public void view_fun()
        {
            string sql = "select* from Hire_otherCharges";
            Common_code.loadTableFun(sql, this.load_box);
        }
    }
}
