using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Rent_a_Car_Service.My_Rent_a_Car_System;

namespace Rent_a_Car_Service.My_common_class
{
    class Common_code
    {
        public enum fun_type
        {
            Insert,Update,Delete
        }
        public static void common_fun(string SQL, fun_type _fun) 
        {
            string sql = SQL;
            SqlConnection con = new SqlConnection(Common_class.con);
            con.Open();
            SqlCommand comand = new SqlCommand(sql, con);
            int count = comand.ExecuteNonQuery();
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("Data " + _fun + " sucessfully..............!");
            }
            else
            {
                MessageBox.Show("Please contact with your IT department...................!");
            }
        
        }

        public static void loadTableFun(string sql, DataGridView load_table) 
        {
            SqlConnection con = new SqlConnection(Common_class.con);
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            load_table.DataSource = dt;
        }

        public static void loadComboBox_fun(string sql,ComboBox myBox, string _valueMember, string _displayMember) 
        {
            SqlConnection con = new SqlConnection(Common_class.con);
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            myBox.DataSource = dt;
            myBox.DisplayMember = _displayMember;
            myBox.ValueMember = _valueMember;
        }

        public static DataTable listGather_fun(string sql) 
        {
            SqlConnection con = new SqlConnection(Common_class.con);
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void formMoving_fun(Form form_name, Panel panel_name)
        {
            panel_name.Controls.Clear();

            form_name.TopLevel = false;
            form_name.AutoScroll = true;
            panel_name.Controls.Add(form_name);
            form_name.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form_name.Dock = DockStyle.Fill;
            form_name.Show();

        }

        public static void dateSelection_fun(DateTimePicker[] _dateTimeGetBox_list)
        {
            foreach (DateTimePicker selection in _dateTimeGetBox_list)
            {
                selection.Format = DateTimePickerFormat.Short;
            }
        }
    }
}
