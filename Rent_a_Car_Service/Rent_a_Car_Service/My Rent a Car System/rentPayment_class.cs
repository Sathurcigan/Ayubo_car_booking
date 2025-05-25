using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Rent_a_Car_Service.My_common_class;

namespace Rent_a_Car_Service.My_Rent_a_Car_System
{
    class rentPayment_class
    {
        int id;
        string pay_type;
        DateTime date;
        double bas_amount, driver_charge, total;
        DataGridView load_box;
        ComboBox rent_type, rent_id, Cus_name;

        public rentPayment_class(Rent_payment form) 
        {
            if (form.idText.Text != "" && form.bas_amountBox.Text != "" && form.driver_chargeBox.Text != "" && form.dateBox.Text != "" && form.totalChargeBox.Text != "")
            {
                this.id = Convert.ToInt32(form.idText.Text);
                this.bas_amount= Convert.ToDouble(form.bas_amountBox.Text);
                this.driver_charge = Convert.ToDouble(form.driver_chargeBox.Text);
                this.date = Convert.ToDateTime(form.dateBox.Text);
                this.total = Convert.ToDouble(form.totalChargeBox.Text);
            }

            this.rent_type = form.rent_typeBox;
            this.load_box = form.loadTable;
            this.rent_id = form.rent_idBox;
            this.Cus_name = form.cusNameBox;
            this.pay_type = form.pay_typeBox.Text;
        }

        public void save_fun() 
        {
            string sql = "insert into Rent_payment(Rp_driverCharge,Cus_id_fk,Rp_date,Re_basicCharge,Rp_type,Re_totalCharge) values ('" + this.driver_charge + "','" + this.Cus_name.SelectedValue.ToString() + "','" + this.date + "','" + this.bas_amount + "','" + this.pay_type + "', '" + this.total + "')";
            Common_code.common_fun(sql,Common_code.fun_type.Insert);
            view_fun();
        }

        public void update_fun()
        {
            string sql = "update Rent_payment set Rp_driverCharge = '" + this.driver_charge + "',Cus_id_fk = '" + this.Cus_name.SelectedValue.ToString() + "',Rp_date = '" + this.date + "',Re_basicCharge = '" + this.bas_amount + "',Rp_type = '" + this.pay_type + "',Re_totalCharge = '" + this.total + "' where Rp_id = '" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Update);
            view_fun();
        }

        public void delete_fun()
        {
            string sql = "delete Rent_payment where Rp_id = '" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Delete);
            view_fun();
        }

        public void view_fun()
        {
            string sql = "select* from Rent_payment";
            Common_code.loadTableFun(sql,this.load_box);
        }
       
        public void loadCombo_fun()
        {
            string sql = "select *from Rent_type";
            Common_code.loadComboBox_fun(sql, this.rent_type, "Re_type_id", "Re_type_name");

            string sql2 = "select *from Rent";
            Common_code.loadComboBox_fun(sql2, this.rent_id, "Re_id", "Re_id");

            string sql3 = "select *from Customer";
            Common_code.loadComboBox_fun(sql3, this.Cus_name, "Cus_id", "Cus_name");
        }
    }
}
