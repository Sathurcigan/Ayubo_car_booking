using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Windows.Forms;
using Rent_a_Car_Service.My_common_class;

namespace Rent_a_Car_Service.My_Rent_a_Car_System
{
    class Hire_package_calss
    {
        int id;
        string hire_package;
        double amount, min_km, max_km, max_hour; 
        DataGridView load_box;


        public Hire_package_calss() { }

        public Hire_package_calss(Hire_package form) 
        {            
            this.hire_package = form.hirePackageBox.Text;

            if (form.idText.Text != "" && form.amountBox.Text != "" && form.min_kmBox.Text != "" && form.max_kmBox.Text != "" && form.hourBox.Text != "")
            {
                this.id = Convert.ToInt32(form.idText.Text);
                this.amount = Convert.ToDouble(form.amountBox.Text);
                this.min_km = Convert.ToDouble(form.min_kmBox.Text);
                this.max_km = Convert.ToDouble(form.max_kmBox.Text);
                this.max_hour = Convert.ToDouble(form.hourBox.Text);
            }
            this.load_box = form.loadTable;
        }

        public void insert_fun() 
        {
            // insert function query.......................................................

            string sql = "INSERT INTO Hire_package (HPac_type,HPac_amount,HPac_minKm,HPac_maxKm,Hpac_maxHour) VALUES ('" + this.hire_package.Trim() + "','" + this.amount + "','" + this.min_km + "','" + this.max_km + "', '" + this.max_hour + "')";
            Common_code.common_fun(sql,Common_code.fun_type.Insert);
            view_fun();

            //.............................................................................
        }

        public void update_fun()
        {
            string sql = "UPDATE Hire_package SET HPac_type ='" + this.hire_package.Trim() + "',HPac_amount ='" + this.amount + "',HPac_minKm = '" + this.min_km + "', HPac_maxKm = '" + this.max_km + "', Hpac_maxHour = '" + this.max_hour + "'  WHERE HPac_id = '" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Update);
            view_fun();
        }

        public void delete_fun()
        {
            string sql = "DELETE Hire_package WHERE HPac_id = '" + this.id + "'";
            Common_code.common_fun(sql, Common_code.fun_type.Delete);
            view_fun();
        }

        public void view_fun()
        {
            string sql = "select* from Hire_package";
            Common_code.loadTableFun(sql,this.load_box);
        }

        public double gatherKm_fun(string hireID)
        {
            DataTable myHireInfo = Common_code.listGather_fun("select * from hire join Hire_package on hire.HPac_id_fk = Hire_package.HPac_id where Hire.H_id = '" + hireID + "'");
            double maxKM = Convert.ToDouble(myHireInfo.Rows[0]["HPac_maxKm"].ToString());
            return maxKM;
        }
    }
}
