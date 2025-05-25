using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Rent_a_Car_Service.My_common_class;

namespace Rent_a_Car_Service.My_Rent_a_Car_System
{
    class hirePayment_class
    {
        int id;
        ComboBox cusName, drivreName, hire, hire_id;
        double basAmount, hireOther, st_raed, en_read, read_count;
        DateTime date;
        DataGridView load_box;

        public hirePayment_class(Hire_payment form) 
        {
            if (form.idText.Text != "" && form.baseBox.Text != "" && form.hireOtherBox.Text != "" && form.dateBox.Text != "" && form.st_readBox.Text != "" && form.en_readBox.Text != "" && form.noOf_readbox.Text != "")
            {
                this.id = Convert.ToInt32(form.idText.Text);
                this.basAmount = Convert.ToDouble(form.baseBox.Text);
                this.hireOther = Convert.ToDouble(form.hireOtherBox.Text);                
                this.date = Convert.ToDateTime(form.dateBox.Text);
                this.st_raed = Convert.ToDouble(form.st_readBox.Text);
                this.en_read = Convert.ToDouble(form.en_readBox.Text);
                this.read_count = Convert.ToDouble(form.noOf_readbox.Text);
            }
            this.cusName = form.cusNameBox;            
            this.load_box = form.loadTable;
            this.drivreName = form.driverNameBox;
            this.hire = form.hire_idBox;
            this.hire_id = form.hire_idBox;
        }

        public void save_fun() 
        {
            string sql = "insert into Hire_payment(H_id_fk,Cus_id_fk,Hp_basicCharge,Hp_date,dri_id_fk,Hp_stRead,Hp_enRead,Hp_noOfReading,Hp_otherChareges) values ('"+this.hire_id+"','" + this.cusName + "','" + this.basAmount + "','" + this.date + "','" + this.drivreName + "','" + this.st_raed + "','" + this.en_read + "','" + this.read_count + "','" + this.hireOther + "')";
            Common_code.common_fun(sql,Common_code.fun_type.Insert);
            view_fun();
        }

        public void update_fun()
        {
            string sql = "update Hire_payment set H_id_fk = '"+this.hire_id+"' ,Cus_id_fk = '" + this.cusName + "',Hp_basicCharge = '" + this.basAmount + "',Hp_date = '" + this.date + "',dri_id_fk = '" + this.drivreName + "',Hp_stRead = '" + this.st_raed + "',Hp_enRead = '" + this.en_read + "',Hp_noOfReading = '" + this.read_count + "', Hp_otherChareges = '" + this.hireOther + "' where Hp_id = '" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Update);
            view_fun();
        }

        public void delete_fun()
        {
            string sql = "delete Hire_payment where Hp_id = '" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Delete);
            view_fun();
        }

        public void loadComboBox()
        {
            string sql = "select *from Customer";
            Common_code.loadComboBox_fun(sql, this.cusName, "Cus_id", "Cus_name");

            string sql2 = "select *from Driver";
            Common_code.loadComboBox_fun(sql2, this.drivreName, "D_id", "D_name");
            
            string sql3 = "select *from Hire";
            Common_code.loadComboBox_fun(sql3, this.hire, "H_id", "H_id");
        }

        public void view_fun()
        {
            string sql = "select *from Hire_payment";
            Common_code.loadTableFun(sql,this.load_box);
        }
    }
}
