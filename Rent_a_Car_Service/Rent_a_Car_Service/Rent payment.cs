using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Rent_a_Car_Service.My_Rent_a_Car_System;
using Rent_a_Car_Service.My_common_class;

namespace Rent_a_Car_Service
{
    public partial class Rent_payment : Form
    {
        public Rent_payment()
        {
            InitializeComponent();
        }
        
        private void Rent_payment_Load(object sender, EventArgs e)
        {
            new rentPayment_class(this).view_fun();
            new rentPayment_class(this).loadCombo_fun();
            dateBox.Text = DateTime.Today.ToString("yyyy-MM-dd");
        }

        private void fillBtn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT *FROM Rent JOIN Vehicle ON Rent.Vt_id_fk = Vehicle.V_id JOIN Vehicle_type ON Vehicle.VT_id_fk = Vehicle_type.VT_id JOIN Rate ON Rate.VT_id_fk = Vehicle_type.VT_id JOIN Driver on Rent.D_id_fk = Driver.D_id WHERE Re_id = '" + rent_idBox.SelectedValue.ToString() + "'";
            DataTable rentDetail = Common_code.listGather_fun(sql);
            string veh_typeId = rentDetail.Rows[0]["VT_id"].ToString();
            string dri_id = rentDetail.Rows[0]["D_id"].ToString();

            DataTable DriverRow = null;

            if (dri_id != "")
            {
                DriverRow = Common_code.listGather_fun("select * from Driver where D_id =" + dri_id);
            }

            int days = Convert.ToInt32(rentDetail.Rows[0]["Re_days"]);
            noOf_dayBox.Text = days.ToString();
            int tempDay = days;

            double perDay = Convert.ToDouble(rentDetail.Rows[0]["day_rate"].ToString());
            double perWeek = Convert.ToDouble(rentDetail.Rows[0]["weekly_rate"].ToString());
            double perMonth = Convert.ToDouble(rentDetail.Rows[0]["monthly_rate"].ToString());

            noOf_dayBox.Text = days.ToString();

            // Basic charge calculation is begin---------------------------------------------------------------
                        
            int month = 0, week = 0, day = 0;
            
            if(days >= 30)
            {
                month = days / 30;
                tempDay = tempDay - (month * 30);
            }

            if (days >= 7)
            {
                week = days / 7;
                tempDay = tempDay - (week * 7);
            }

            day = tempDay;

            double baseCharge = (month * perMonth) + (week * perWeek) + (day * perDay);

            //--------------------------------------------------------------------------------------------------

            double driverPayment = 0;

            if (DriverRow != null)
            {
                double DriverRate = Convert.ToDouble(DriverRow.Rows[0]["D_rate"].ToString());
                driverPayment = days * DriverRate;
                detailBox.Text = "Charge per Day : '" + perDay + "'\nCharge per Week : '" + perWeek + "'\nCharge per Month : '" + perMonth + "'\n Driver Charge per Day : '" + DriverRate + "'";
            }
            else
            {
                detailBox.Text = "Charge per Day : '" + perDay + "'|Charge per Week : '" + perWeek + "'\nCharge per Month : '" + perMonth + "'\n Driver Charge per Day : 0.00";
            }

            double totalPayment = baseCharge + driverPayment;

            totalChargeBox.Text = totalPayment.ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            new rentPayment_class(this).save_fun();
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idText.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                rent_idBox.SelectedValue = loadTable.Rows[index].Cells[3].Value.ToString();
                bas_amountBox.Text = loadTable.Rows[index].Cells[5].Value.ToString();
                pay_typeBox.SelectedValue = loadTable.Rows[index].Cells[6].Value.ToString();
                driver_chargeBox.Text = loadTable.Rows[index].Cells[1].Value.ToString();
                totalChargeBox.Text = loadTable.Rows[index].Cells[7].Value.ToString();
                cusNameBox.SelectedValue = loadTable.Rows[index].Cells[2].Value.ToString();
                dateBox.Text = loadTable.Rows[index].Cells[4].Value.ToString();
            }
        }

    }
}
