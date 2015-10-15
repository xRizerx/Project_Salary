using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WEB_PERSONAL
{
    public partial class SalaryByID : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source = 203.158.140.66; Initial Catalog = personal; Integrated Security = False; User ID = rmutto; Password = Zxcvbnm!");
                conn.Open();
                SqlCommand command = new SqlCommand("Select TB_PERSONAL.STF_NAME,TB_PERSONAL.STF_LNAME,TB_POSITION.POSITION_NAME,TB_SUBSTAFFTYPE.SUBSTAFFTYPE_NAME,TB_ADMIN.ADMIN_POSITION_NAME,BASESALARY.MAXSALARY From TB_PERSONAL,TB_POSITION,TB_SUBSTAFFTYPE,TB_ADMIN,BASESALARY WHERE CITIZEN_ID = " + TextBox1.Text + "AND TB_PERSONAL.POSITION_ID = TB_POSITION.POSITION_ID AND TB_PERSONAL.SUBSTAFFTYPE_ID = TB_SUBSTAFFTYPE.SUBSTAFFTYPE_ID AND TB_PERSONAL.ADMIN_POSITION_ID = TB_ADMIN.ADMIN_POSITION_ID AND TB_PERSONAL.POSITION_ID = BASESALARY.POSITION_ID", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Label11.Text = reader.GetString(0);
                        Label13.Text = reader.GetString(1);
                        Label15.Text = reader.GetString(2);
                        Label17.Text = reader.GetString(3);
                        Label19.Text = reader.GetString(4);
                        Label22.Text = reader.GetInt32(5).ToString();
                    }



                    command.Dispose();
                    reader.Close();
                    conn.Close();
                }
            }
            catch
            {
                string script = "alert(\"เกิดข้อผิดพลาด\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source = 203.158.140.66; Initial Catalog = personal; Integrated Security = False; User ID = rmutto; Password = Zxcvbnm!");
                conn.Open();
                SqlCommand command = new SqlCommand("Select TB_POSITION.POSITION_NAME,BASESALARY.MAXSALARY,BASESALARY.MINSALARY,BASESALARY.MAXLOWSALARY,BASESALARY.MINLOWSALARY From TB_POSITION,BASESALARY,TB_PERSONAL WHERE TB_POSITION.POSITION_NAME = '" + Label15.Text + "' AND TB_PERSONAL.POSITION_ID = TB_POSITION.POSITION_ID AND TB_POSITION.POSITION_ID = BASESALARY.POSITION_ID", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String position = reader.GetString(0);
                        int maxsal = reader.GetInt32(1);
                        int minsal = reader.GetInt32(2);
                        int maxlowsal = reader.GetInt32(3);
                        int minlowsal = reader.GetInt32(4);
                        double salary = Convert.ToDouble(TextBox2.Text);
                        /* วิชาการ */
                        if (Label15.Text == "ศาสตราจารย์")
                        {
                            if (salary <= maxlowsal)
                            {
                                Label24.Text = "62210";
                            }
                            else
                                Label24.Text = "66700";
                        }
                        if (Label15.Text == "รองศาสตราจารย์")
                        {
                            if (salary <= maxlowsal)
                            {
                                Label24.Text = "52320";
                            }
                            else
                                Label24.Text = "60990";
                        }
                        if (Label15.Text == "ผู้ช่วยศาสตราจารย์")
                        {
                            if (salary <= maxlowsal)
                            {
                                Label24.Text = "37830";
                            }
                            else
                                Label24.Text = "51290";
                        }
                        if (Label15.Text == "ผู้ช่วยศาสตราจารย์")
                        {
                            if (salary <= maxlowsal)
                            {
                                Label24.Text = "37830";
                            }
                            else
                                Label24.Text = "51290";
                        }
                        if (Label15.Text == "อาจารย์")
                        {
                            if (salary <= maxlowsal)
                            {
                                Label24.Text = "24030";
                            }
                            else
                                Label24.Text = "37080";
                        }
                        /* บริหาร */
                        if (Label15.Text == "ผู้อำนวยการสำนักงานอธิการบดีหรือเทียบเท่า")
                        {
                            if (salary <= maxlowsal)
                            {
                                Label24.Text = "37830";
                            }
                            else
                                Label24.Text = "51290";
                        }
                        if (Label15.Text == "ผู้อำนวยการกองหรือเทียบเท่า")
                        {
                            if (salary <= maxlowsal)
                            {
                                Label24.Text = "52320";
                            }
                            else
                                Label24.Text = "60990";
                        }
                        /* วิชาชีพเฉพาะหรือเชียวชาญเฉพาะ */
                        if (Label15.Text == "เชี่ยวชาญพิเศษ")
                        {
                            if (salary <= maxlowsal)
                            {
                                Label24.Text = "60830";
                            }
                            else
                                Label24.Text = "66700";
                        }
                        if (Label15.Text == "เชี่ยวชาญ")
                        {
                            if (salary <= maxlowsal)
                            {
                                Label24.Text = "50320";
                            }
                            else
                                Label24.Text = "59630";
                        }
                        if (Label15.Text == "ชำนาญการพิเศษ")
                        {
                            if (salary <= maxlowsal)
                            {
                                Label24.Text = "37200";
                            }
                            else
                                Label24.Text = "49330";
                        }
                        if (Label15.Text == "ชำนาญการ")
                        {
                            if (salary <= maxlowsal)
                            {
                                Label24.Text = "24410";
                            }
                            else
                                Label24.Text = "36470";
                        }
                        if (Label15.Text == "ปฏิบัตการ")
                        {
                            if (salary <= maxlowsal)
                            {
                                Label24.Text = "17980";
                            }
                            else
                                Label24.Text = "23930";
                        }
                        /* ทั่วไป */
                        if (Label15.Text == "ชำนาญงานพิเศษ")
                        {
                            if (salary <= maxlowsal)
                            {
                                Label24.Text = "32250";
                            }
                            else
                                Label24.Text = "44970";
                        }
                        if (Label15.Text == "ชำนาญงาน")
                        {
                            if (salary <= maxlowsal)
                            {
                                Label24.Text = "18480";
                            }
                            else
                                Label24.Text = "31610";
                        }
                        if (Label15.Text == "ปฏิบัตงาน")
                        {
                            if (salary <= maxlowsal)
                            {
                                Label24.Text = "12310";
                            }
                            else
                                Label24.Text = "18110";
                        }


                    }



                    command.Dispose();
                    reader.Close();
                    conn.Close();
                }
            }
            catch
            {
                string script = "alert(\"เกิดข้อผิดพลาด\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            /* จำนวนเงินที่คำนวณได้แบบไม่ปัดเศษ */
            double basesalcal = Convert.ToDouble(Label24.Text);
            double rate = Convert.ToDouble(TextBox3.Text);
            Label26.Text = String.Format("{0:.##}", basesalcal * rate/100);

            /* จำนวนเงินที่คำนวณได้แบบปัดเศษ */
            Label27.Text = ""+ roundUp(Convert.ToDouble(Label26.Text));
            /* จำนวนเงินที่ได้เลื่อน */
            Double salcalround = Convert.ToDouble(Label27.Text);

            double salary1 = Convert.ToDouble(TextBox2.Text);
            int maxbasesal = Convert.ToInt32(Label22.Text);
            Double isal = salary1 + salcalround;
            if(isal <= maxbasesal)
            {
                Label29.Text = "" + salcalround;
            }
            else
            {
                Label29.Text = "" + (maxbasesal-salary1);
            }

            /* เงินตอบแทนพิเศษ */
            double mbonus = salary1 + salcalround;
            Double salup = Convert.ToDouble(Label29.Text);
            if (mbonus <= maxbasesal)
            {
                Label31.Text = "0";
            }
            else
            {
                Label31.Text = ""+((basesalcal * rate / 100) - salup);
            }
            /* รวมใช้เลื่อน */
            double sumup = Convert.ToDouble(Label31.Text);
            Label33.Text = "" + (salup+sumup);

            /* เงินเดือนใหม่ */
            Double sumup2 = Convert.ToDouble(Label33.Text);
            if (isal<=maxbasesal)
            {
                Label35.Text = "" + (salary1 + sumup2);
                
            }
            else
            {
                Label35.Text = "" + maxbasesal;
            }
            /* ร้อยละที่ได้เลื่อน */
            Double Rateup = Convert.ToDouble(TextBox6.Text);
            Double Rateup2 = Convert.ToDouble(TextBox7.Text);
            Label42.Text = "" + (rate + Rateup + Rateup2);
            /* จำนวนเงินที่คำนวณได้แบบไม่ปัดเศษ รวมได้เลื่อนทั้งสิ้น */
            Double Ratesum = Convert.ToDouble(Label42.Text);
            Label44.Text = "" + (basesalcal * Ratesum / 100);
            /* จำนวนเงินที่คำนวณได้แบบปัดเศษ รวมได้เลื่อนทั้งสิ้น */
            Label46.Text = "" + roundUp(Convert.ToDouble(Label44.Text));
            /* จำนวนเงินที่ได้เลื่อน รวมได้เลื่อนทั้งสิ้น */
            Double salcalround2 = Convert.ToDouble(Label44.Text);
            Double isal2 = salary1 + salcalround2;
            if (isal <= maxbasesal)
            {
                Label48.Text = Label46.Text;
            }
            else
            {
                Label48.Text = "" + (maxbasesal - salary1);
            }
            /* เงินตอบแทนพิเศษ */
            Double salup2 = Convert.ToDouble(Label48.Text);
            double mbonus2 = salary1 + salcalround2;

            if (mbonus2 <= maxbasesal)
            {
                Label50.Text = "0";
            }
            else
            {
                Label50.Text = "" + ((basesalcal * Ratesum / 100) - salup2);
            }
            /* รวมใช้เลื่อน */
            Double sumup4 = Convert.ToDouble(Label50.Text);
            Label52.Text = "" + (salup2 + sumup4);
            /* เงินเดือนใหม่ รวมได้เลื่อนทั้งสิ้น */
            Double salcalround3 = Convert.ToDouble(Label46.Text);
            if (mbonus2 <= maxbasesal)
            {
                Label54.Text = "" + (salary1 + salcalround3);

            }
            else
            {
                Label54.Text = "" + maxbasesal;
            }

            Label58.Text = "" + (Convert.ToDouble(Label52.Text) - sumup2);

        }
        private int roundUp(double i)
        {
            int j = Convert.ToInt32(i);
            return (10 - j % 10) + j;
        }
    }
}
