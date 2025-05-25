using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Rent_a_Car_Service.My_common_class;

namespace Rent_a_Car_Service.My_Rent_a_Car_System
{
    class rent_class
    {
        int id, noOfDay;
        ComboBox re_type, veh_type, dri_name;
        DateTime st_date, en_date;
        DataGridView load_box;

        public rent_class(Rent form) 
        {
            this.veh_type = form.veh_typeBox;
            this.dri_name = form.driverBox;
            this.re_type = form.re_typeBox;
            this.load_box = form.loadTable;

            if (form.idText.Text != "" && form.dayBox.Text != "" && form.st_dateBox.Text != "" && form.en_dateBox.Text != "")
            {
                this.id = Convert.ToInt32(form.idText.Text);
                this.st_date = Convert.ToDateTime(form.st_dateBox.Text);
                this.en_date = Convert.ToDateTime(form.en_dateBox.Text);
                this.noOfDay = Convert.ToInt32(form.dayBox.Text);
            }            
        }

        public void save_fun() 
        {
            string sql = "insert into Rent (Vt_id_fk,Re_days,D_id_fk,Re_startDate,Re_endDate,Rtype_fk) values ('" + this.veh_type.SelectedValue.ToString() + "','" + this.noOfDay + "','" + this.dri_name.SelectedValue.ToString() + "','" + this.st_date + "','" + this.en_date + "','" + this.re_type.SelectedValue.ToString() + "')";
            Common_code.common_fun(sql,Common_code.fun_type.Insert);
            view_fun();
        }

        public void update_fun()
        {
            string sql = "update Rent set Vt_id_fk = '" + this.veh_type.SelectedValue.ToString() + "',Re_days = '" + this.noOfDay + "',D_id_fk = '" + this.dri_name.SelectedValue.ToString() + "',Re_startDate = '" + this.st_date + "',Re_endDate = '" + this.en_date + "', Rtype_fk = '" + this.re_type.SelectedValue.ToString() + "' where Re_id = '" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Update);
            view_fun();
        }

        public void delete_fun()
        {
            string sql = "delete Rent where Re_id = '" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Delete);
            view_fun();
        }

        public void view_fun()
        {
            string sql = "select* from Rent";
            Common_code.loadTableFun(sql,this.load_box);
        }

        public void loadCombo_fun()
        {
            string sql = "select *from Vehicle_type";
            Common_code.loadComboBox_fun(sql, this.veh_type, "VT_id", "VT_name");

            string sql2 = "select *from Driver";
            Common_code.loadComboBox_fun(sql2, this.dri_name, "D_id", "D_name");

            string sql3 = "select *from Rent_type";
            Common_code.loadComboBox_fun(sql3, this.re_type, "Re_type_id", "Re_type_name");
        }
    }
}
