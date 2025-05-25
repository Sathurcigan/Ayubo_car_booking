using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Rent_a_Car_Service.My_common_class;

namespace Rent_a_Car_Service.My_Rent_a_Car_System
{
    class tourType_class
    {
        int id;
        string tour_distance, tour_name;
        DataGridView load_box;

        public tourType_class(Tour_type form) 
        {
            if (form.idText.Text != "")
            {
                this.id = Convert.ToInt32(form.idText.Text);
            }
            this.tour_name = form.tour_nameBox.Text;
            this.tour_distance = form.tourDisBox.Text;
            this.load_box = form.loadTable;
        }

        public void save_fun() 
        {
            string sql = "insert into Tour_type(Tt_name,Tt_distance) values ('"+this.tour_name+"','" + this.tour_distance + "')";
            Common_code.common_fun(sql,Common_code.fun_type.Insert);
            view_fun();
        }

        public void update_fun()
        {
            string sql = "update Tour_type set Tt_name = '"+this.tour_name+"',Tt_distance = '" + this.tour_distance + "' where Tt_id = '" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Update);
            view_fun();
        }

        public void delete_fun()
        {
            string sql = "delete Tour_type where Tt_id = '" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Delete);
            view_fun();
        }

        public void view_fun()
        {
            string sql = "select* from Tour_type";
            Common_code.loadTableFun(sql,this.load_box);
        }
    }
}
