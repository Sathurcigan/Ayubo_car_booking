using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Rent_a_Car_Service.My_common_class;

namespace Rent_a_Car_Service.My_Rent_a_Car_System
{
    class Customer_class
    {
        int id;
        string name, address, phoneNo, pass;
        DataGridView load_box;

        public Customer_class(New_account form) 
        {
            if (form.idText.Text != "")
            {
                this.id = Convert.ToInt32(form.idText.Text);
            }
            this.name = form.nameBox.Text;
            this.address = form.addressBox.Text;
            this.phoneNo = form.phoneNoBox.Text;
            this.pass = form.newPass_box.Text;
            this.load_box = form.loadTable;
        }

        public void save_fun() 
        {
            string sql = "insert into Customer (Cus_name,Cus_address,Cus_phoneNo,Cus_password) values ('" + this.name + "','" + this.address + "','" + this.phoneNo + "','" + this.pass + "')";
            Common_code.common_fun(sql,Common_code.fun_type.Insert);
            view_fun();
        }

        public void update_fun()
        {
            string sql = "update Customer set Cus_name = '" + this.name + "',Cus_address ='" + this.address + "' ,Cus_phoneNo = '" + this.phoneNo + "', Cus_password ='"+this.pass+"' where Cus_id ='" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Update);
            view_fun();
        }

        public void delete_fun()
        {
            string sql = "delete Customer where Cus_id = '"+this.id+"'";
            Common_code.common_fun(sql, Common_code.fun_type.Delete);
            view_fun();
        }

        public void view_fun()
        {
            string sql = "select* from Customer";
            Common_code.loadTableFun(sql,this.load_box);
        }
    }
}
