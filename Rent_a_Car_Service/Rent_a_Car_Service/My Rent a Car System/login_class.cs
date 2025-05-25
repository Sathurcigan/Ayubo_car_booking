using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rent_a_Car_Service.My_common_class;

namespace Rent_a_Car_Service.My_Rent_a_Car_System
{
    class login_class
    {
        string username, password;

        public login_class(Login form) 
        {
            this.username = form.userBox.Text;
            this.password = form.passBox.Text;
        }

        public void save_fun() 
        {
            string sql = "";
            Common_code.common_fun(sql,Common_code.fun_type.Insert);
        }

        public void update_fun()
        {
            string sql = "";
            Common_code.common_fun(sql, Common_code.fun_type.Update);
        }

        public void delete_fun()
        {
            string sql = "";
            Common_code.common_fun(sql, Common_code.fun_type.Delete);
        }
    }
}
