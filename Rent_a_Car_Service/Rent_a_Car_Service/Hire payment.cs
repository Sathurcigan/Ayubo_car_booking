using Rent_a_Car_Service.My_common_class;
using Rent_a_Car_Service.My_Rent_a_Car_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Rent_a_Car_Service
{
    public partial class Hire_payment : Form
    {
        public Hire_payment()
        {
            InitializeComponent();
        }

        Hire_package hire_pac = new Hire_package();
        double max_km = 0;
        TimeSpan max_hours = TimeSpan.MinValue;

        public void DisCalculation_fun()
        {
            string sql = "SELECT *FROM Hire JOIN Hire_package ON Hire_package.HPac_id = Hire.HPac_id_fk JOIN Tour_type ON Tour_type.Tt_id = Hire.Tt_id_fk JOIN Vehicle ON Hire.V_id_fk = Vehicle.V_id JOIN Driver ON Hire.D_id_fk = Driver.D_id JOIN Hire_otherCharges ON Hire.H_otherCharge_fk = Hire_otherCharges.Hec_id WHERE Hire.H_id = '" + hire_idBox.Text + "'";
            DataTable hireDetail = Common_code.listGather_fun(sql);
            
            double basic_charge = Convert.ToDouble(hireDetail.Rows[0]["HPac_amount"].ToString());
            double extra_km_charge = Convert.ToDouble(hireDetail.Rows[0]["Hec_amountPerKm"].ToString());
            string tour = hireDetail.Rows[0]["Tt_name"].ToString();
            int days = Convert.ToInt32(hireDetail.Rows[0]["Hire_noOfDays"].ToString());
            max_km = Convert.ToInt32(hireDetail.Rows[0]["HPac_maxKm"].ToString());
            max_hours = TimeSpan.Parse(hireDetail.Rows[0]["HPac_maxHour"].ToString());
            double overNight = Convert.ToDouble(hireDetail.Rows[0]["D_overNightRate"].ToString());
            double waiting_chargePerHour = Convert.ToDouble(hireDetail.Rows[0]["D_waitingCharge"].ToString());
            double night_parking = Convert.ToDouble(hireDetail.Rows[0]["V_nightParkRate_perDay"].ToString());
            
            string st_reading = st_readBox.Text;
            string en_reading = en_readBox.Text;
            
            string st_hour = st_timeBox.Text;
            string en_hour = en_timeBox.Text;            

            // Total hire km calculation begin
            double stRead = 0;
            if (st_reading != "")
            {
                stRead = Convert.ToDouble(st_readBox.Text);
            }

            double enRead = 0;
            if (en_reading != "")
            {
                enRead = Convert.ToDouble(en_readBox.Text);
            }

            double total = enRead - stRead;
            noOf_readbox.Text = (total).ToString();
            //---------------------------------------------------------------------------------------------------------------------

            // Total hire Hour calculation begin

            DateTime stTime = DateTime.MinValue;
            if (st_hour != "")
            {
                if (DateTime.TryParse(en_timeBox.Text, out stTime))
                {
                    stTime = DateTime.Parse(st_timeBox.Text);
                }
            }

            DateTime enTime = DateTime.MinValue;
            if (en_hour != "") 
            {
                if (DateTime.TryParse(en_timeBox.Text, out enTime))
                {
                    enTime = DateTime.Parse(en_timeBox.Text);
                }
            }

            TimeSpan totalHour = enTime - stTime;

            noOf_hourBox.Text = totalHour.TotalHours.ToString();
            //---------------------------------------------------------------------------------------------------------------------

            baseBox.Text = basic_charge.ToString();
            tour_box.Text = tour;
            day_box.Text = days.ToString();
            double total_charge = 0;

            if (total > max_km)
            {
                double extra_km = total - max_km;                
                hireOtherBox.Text = (extra_km_charge * extra_km).ToString();

                if (days >= 2)
                {
                    double overNight_charge = (days - 1) * overNight;
                    double night_parking_charge = (days - 1) * night_parking;
                    hireOtherBox.Text = ((extra_km_charge * extra_km) + overNight_charge + night_parking_charge).ToString();
                    extra_kmDeatilBox.Text = "Charge per Extra km : '" + extra_km_charge + "' \n Over Night charge : '" + overNight + "'\n Over Night parking charge : '" + night_parking + "'";
                    total_charge = ((extra_km_charge * extra_km) + overNight_charge + night_parking_charge) + basic_charge;
                }
                else
                {
                    extra_kmDeatilBox.Text = "Charge per Extra km : '" + extra_km_charge + "'";
                }

                if (tour.Trim() != "Long Tour")
                {
                    st_timeBox.Enabled = true;
                    en_timeBox.Enabled = true;
                    noOf_hourBox.Enabled = true;
                    if (totalHour > max_hours)
                    {
                        double waitingCharge = Convert.ToDouble(waiting_chargePerHour * Convert.ToDouble((totalHour - max_hours)));
                        hireOtherBox.Text = ((extra_km_charge * extra_km) + waitingCharge).ToString();

                        if (days >= 2)
                        {
                            double overNight_charge = (days - 1) * overNight;
                            double night_parking_charge = (days - 1) * night_parking;
                            hireOtherBox.Text = ((extra_km_charge * extra_km) + overNight_charge + night_parking_charge + waitingCharge).ToString();
                            extra_kmDeatilBox.Text = "Charge per Extra km : '" + extra_km_charge + "' \n Over Night charge : '" + overNight + "' \n Waiting charge per hour : '" + waiting_chargePerHour + "' \n Over Night parking charge : '" + night_parking + "'";
                            total_charge = basic_charge + ((extra_km_charge * extra_km) + overNight_charge + night_parking_charge + waitingCharge);
                        }
                        else
                        {
                            extra_kmDeatilBox.Text = "Charge per Extra km : '" + extra_km_charge + "' \n Waiting charge per hour : '" + waiting_chargePerHour + "'";
                        }
                    }
                }
                if(extra_km == 0)
                {
                    extra_kmDeatilBox.Text = "There is no Extra charges allocated for You!.......";
                }
                totalBox.Text = total.ToString();
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            new hirePayment_class(this).save_fun();
            clean_fun();
        }

        private void Hire_payment_Load(object sender, EventArgs e)
        {
            new hirePayment_class(this).loadComboBox();
            new hirePayment_class(this).view_fun();

            dateBox.Text = DateTime.Today.ToString("yyyy-MM-dd");
        }


        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;            
            if (index > -1)
            {
                idText.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                baseBox.Text = loadTable.Rows[index].Cells[3].Value.ToString();
                hireOtherBox.Text = loadTable.Rows[index].Cells[4].Value.ToString();
                driverNameBox.SelectedItem = loadTable.Rows[index].Cells[6].Value.ToString();
                dateBox.Text = loadTable.Rows[index].Cells[5].Value.ToString();
                cusNameBox.SelectedItem = loadTable.Rows[index].Cells[2].Value.ToString();
            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            DisCalculation_fun();
        }

        private void en_readBox_TextChanged(object sender, EventArgs e)
        {
            DisCalculation_fun();
        }

        private void en_timeBox_TextChanged(object sender, EventArgs e)
        {
            DisCalculation_fun();
        }

        private void clean_fun() {
            idText.Text = "";
            baseBox.Text = "";
            hireOtherBox.Text = "";
            driverNameBox.Text = "";
            dateBox.Text = "";
            cusNameBox.Text = "";
            st_timeBox.Text = "";
            st_readBox.Text = "";
            en_readBox.Text = "";
            en_timeBox.Text = "";
            noOf_hourBox.Text = "";
            noOf_readbox.Text = "";
            totalBox.Text = "";
        }
    }
}
