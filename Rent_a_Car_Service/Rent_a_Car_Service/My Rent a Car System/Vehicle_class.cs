using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rent_a_Car_Service.My_common_class;

namespace Rent_a_Car_Service.My_Rent_a_Car_System
{
    class Vehicle_class
    {
        int id;
        string veh_no, veh_colour;
        double night_rate;
        DataGridView load_box;
        ComboBox veh_type, last_service;

        public Vehicle_class(Vehicle form)
        {
            this.veh_no = form.veh_noBox.Text;
            this.veh_colour = form.veh_colourBox.Text;
            this.load_box = form.loadTable;
            this.veh_type = form.veh_typeBox;
            this.last_service = form.last_serBox;

            if (form.idText.Text != "" && form.nightRate_box.Text != "")
            {
                this.id = Convert.ToInt32(form.idText.Text);
                this.night_rate = Convert.ToDouble(form.nightRate_box.Text);
            }
        }

        public void Save_fun() 
        {
            string sql = "INSERT INTO Vehicle (VT_id_fk,V_No,Vsd_fk,V_colour,V_nightParkRate_perDay) VALUES ('" + this.veh_type.SelectedValue.ToString() + "','" + this.veh_no + "','" + this.last_service.SelectedValue.ToString() + "','" + this.veh_colour + "','" + this.night_rate + "')";
            Common_code.common_fun(sql, Common_code.fun_type.Insert);
            view_fun();
        }

        public void Update_fun()
        {
            string sql = "UPDATE Vehicle SET VT_id_fk = '" + this.veh_type.SelectedValue.ToString() + "',V_No = '" + this.veh_no + "',Vsd_fk = '" + this.last_service.SelectedValue.ToString() + "', V_colour = '" + this.veh_colour + "', V_nightParkRate_perDay = '" + this.night_rate + "' WHERE V_id = '" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Update);
            view_fun();
        }

        public void Delete_fun()
        {
            string sql = "DELETE Vehicle WHERE V_id = '" + this.id + "' ";
            Common_code.common_fun(sql, Common_code.fun_type.Delete);
            view_fun();
        }

        public void loadComboBox()
        {
            string sql = "select *from Vehicle_type";
            Common_code.loadComboBox_fun(sql,this.veh_type, "VT_id", "VT_name");

            string sql2 = "select *from Vehicle_serviceDetail";
            Common_code.loadComboBox_fun(sql2, this.last_service, "Vsd_id", "Vsd_date");
        }

        public void view_fun()
        {
            string sql = "select *from Vehicle";
            Common_code.loadTableFun(sql,this.load_box);
        }
    }
}
