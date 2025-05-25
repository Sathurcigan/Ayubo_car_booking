using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Rent_a_Car_Service.My_common_class;

namespace Rent_a_Car_Service.My_Rent_a_Car_System
{
    class rentType_class
    {
        int id;
        string rent_type;
        DataGridView load_box;

        public rentType_class(Rent_type form) 
        {
            if (form.idText.Text != "")
            {
                this.id = Convert.ToInt32(form.idText.Text);
            }
            this.rent_type = form.rentTypeBox.Text;
            this.load_box = form.loadTable;
        }

        public void save_fun() 
        {
            string sql = "insert into Rent_type(Re_type_name) values ('"+this.rent_type+"')";
            Common_code.common_fun(sql,Common_code.fun_type.Insert);
            view_fun();
        }

        public void update_fun()
        {
            string sql = "update Rent_type set Re_type_name = '" + this.rent_type + "' where Re_type_id = '"+this.id+"'";
            Common_code.common_fun(sql, Common_code.fun_type.Update);
            view_fun();
        }

        public void delete_fun()
        {
            string sql = "delete Rent_type where Re_type_id = '"+this.id+"'";
            Common_code.common_fun(sql, Common_code.fun_type.Delete);
            view_fun();
        }

        public void view_fun()
        {
            string sql = "select* from Rent_type";
            Common_code.loadTableFun(sql,this.load_box);
        }
    }
}
