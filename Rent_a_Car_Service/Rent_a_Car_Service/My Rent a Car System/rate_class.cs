using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Rent_a_Car_Service.My_common_class;

namespace Rent_a_Car_Service.My_Rent_a_Car_System
{
    class rate_class
    {
        int id;
        ComboBox veh_type;
        double month_rate, week_rate, day_rate;
        DataGridView load_box;

        public rate_class(Rate form) 
        {
            this.veh_type = form.vehicleTypeBox;

            if (form.idText.Text != "" && form.mo_rateBox.Text != "" && form.week_rateBox.Text != "" && form.day_rateBox.Text != "")
            {
                this.id = Convert.ToInt32(form.idText.Text);
                this.month_rate = Convert.ToDouble(form.mo_rateBox.Text);
                this.week_rate = Convert.ToDouble(form.week_rateBox.Text);
                this.day_rate = Convert.ToDouble(form.day_rateBox.Text);
            }
            this.load_box = form.loadTable;
        }

        public void save_fun() 
        {
            string sql = "insert into Rate(VT_id_fk,monthly_rate,weekly_rate,day_rate) values ('" + this.veh_type.SelectedValue.ToString() + "','" + this.month_rate + "','" + this.week_rate + "','" + this.day_rate + "')";
            Common_code.common_fun(sql,Common_code.fun_type.Insert);
            view_fun();
        }

        public void update_fun()
        {
            string sql = "update Rate set VT_id_fk = '" + this.veh_type.SelectedValue.ToString() + "',monthly_rate = '" + this.month_rate + "',weekly_rate = '" + this.week_rate + "',day_rate = '" + this.day_rate + "' where Ra_id = '" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Update);
            view_fun();
        }

        public void delete_fun()
        {
            string sql = "delete Rate where Ra_id = '" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Delete);
            view_fun();
        }

        public void loadComboBox()
        {
            string sql = "select *from Vehicle_type";
            Common_code.loadComboBox_fun(sql, this.veh_type, "VT_id", "VT_name");
        }

        public void view_fun()
        {
            string sql = "select *from Rate";
            Common_code.loadTableFun(sql,this.load_box);
        }
    }
}
