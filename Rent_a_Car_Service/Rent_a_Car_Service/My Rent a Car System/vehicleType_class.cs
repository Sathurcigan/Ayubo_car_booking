using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Rent_a_Car_Service.My_common_class;

namespace Rent_a_Car_Service.My_Rent_a_Car_System
{
    class vehicleType_class
    {
        int id;
        string veh_type;
        DataGridView load_box;

        public vehicleType_class( Vehicle_Type form) 
        {
            if (form.idText.Text != "")
            {
                this.id = Convert.ToInt32(form.idText.Text);
            }
            this.veh_type = form.veh_typeBox.Text;
            this.load_box = form.loadTable;
        }

        public void save_fun() 
        {
            string sql = "insert into Vehicle_type(VT_name) values ('" + this.veh_type + "')";
            Common_code.common_fun(sql,Common_code.fun_type.Insert);
            view_fun();
        }

        public void update_fun()
        {
            string sql = "update Vehicle_type set VT_name = '" + this.veh_type + "' where VT_id = '" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Update);
            view_fun();
        }

        public void delete_fun()
        {
            string sql = "delete Vehicle_type where VT_id = '" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Delete);
            view_fun();
        }

        public void view_fun()
        {
            string sql = "select * from Vehicle_type ";
            Common_code.loadTableFun(sql,this.load_box);
        }

    }
}
