using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Rent_a_Car_Service.My_common_class;

namespace Rent_a_Car_Service.My_Rent_a_Car_System
{
    class Driver_class
    {
        int id;
        string name, address, phoneNo, licenceNo;
        double rate, overNightRate, waiting_charge;
        DataGridView load_box;

        public Driver_class(Driver form) 
        {
            this.name = form.nameBox.Text;
            this.address = form.addressBox.Text;
            this.phoneNo = form.phoneNoBox.Text;
            this.licenceNo = form.licanceNoBox.Text;

            if (form.idText.Text != "" && form.rateBox.Text != "" && form.waitingCharge_box.Text != "" && form.overNightChargeBox.Text != "")
            {
                this.id = Convert.ToInt32(form.idText.Text);
                this.rate = Convert.ToDouble(form.rateBox.Text);
                this.waiting_charge = Convert.ToDouble(form.waitingCharge_box.Text);
                this.overNightRate = Convert.ToDouble(form.overNightChargeBox.Text);
            }
            
            this.load_box = form.loadTable;
        }

        public void save_fun() 
        {
            string sql = "insert into Driver (D_name,D_address,D_phoneNo,D_licenceNo,D_rate,D_overNightRate,D_waitingCharge) values ('" + this.name + "','" + this.address + "','" + this.phoneNo + "','" + this.licenceNo + "','" + this.rate + "','" + this.overNightRate + "', '" + this.waiting_charge + "')";
            Common_code.common_fun(sql,Common_code.fun_type.Insert);
            view_fun();
        }

        public void update_fun() 
        {
            string sql = "update Driver set D_name = '" + this.name + "',D_address = '" + this.address + "',D_phoneNo = '" + this.phoneNo + "',D_licenceNo = '" + this.licenceNo + "',D_rate = '" + this.rate + "',D_overNightRate = '" + this.overNightRate + "', D_waitingCharge = '" + this.waiting_charge + "' where D_id ='" + this.id + "'";
            Common_code.common_fun(sql,Common_code.fun_type.Update);
            view_fun();
        }

        public void delete_fun()
        {
            string sql = "delete Driver where D_id = '" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Delete);
            view_fun();
        }

        public void view_fun()
        {
            string sql = "select* from Driver";
            Common_code.loadTableFun(sql,this.load_box);
        }
    }
}
