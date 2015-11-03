using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.OracleClient;

namespace WEB_PERSONAL
{
    public partial class SalarybyID_Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["citizen_id"] == null)
                {
                    Response.Write("<script>alert('กรุณากดค้นหาก่อน'); self.close();</script>");
                    Response.End();
                    return;
                }
                using (OracleConnection conn = new OracleConnection("DATA SOURCE=ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm;"))
                {
                    conn.Open();
                    using (OracleCommand command = new OracleCommand("Select * FROM (Select TB_PERSONAL.STF_NAME,TB_PERSONAL.STF_LNAME,TB_POSITION.POSITION_NAME,TB_SUBSTAFFTYPE.SUBSTAFFTYPE_NAME,TB_ADMIN.ADMIN_POSITION_NAME,BASESALARY.MAXSALARY,TB_SALARY_UP.ID From TB_PERSONAL,TB_POSITION,TB_SUBSTAFFTYPE,TB_ADMIN,BASESALARY,TB_SALARY_UP WHERE TB_PERSONAL.CITIZEN_ID = '1103701005670' AND TB_PERSONAL.POSITION_ID = TB_POSITION.POSITION_ID AND TB_PERSONAL.SUBSTAFFTYPE_ID = TB_SUBSTAFFTYPE.SUBSTAFFTYPE_ID AND TB_PERSONAL.ADMIN_POSITION_ID = TB_ADMIN.ADMIN_POSITION_ID AND TB_PERSONAL.POSITION_ID = BASESALARY.POSITION_ID AND TB_PERSONAL.CITIZEN_ID = TB_SALARY_UP.CITIZEN_ID ORDER BY ID DESC) where rownum=1", conn))
                    {
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            bool found = false;
                            while (reader.Read())
                            {
                                found = true;
                                Label61.Text = Session["citizen_id"].ToString();
                                Label11.Text = reader.GetString(0);
                                Label13.Text = reader.GetString(1);
                                Label15.Text = reader.GetString(2);
                                Label17.Text = reader.GetString(3);
                                Label19.Text = reader.GetString(4);
                                Label22.Text = reader.GetInt32(5).ToString();
                                Label63.Text = reader.GetInt32(6).ToString();
                            }
                            command.Dispose();
                            reader.Close();
                            if (!found)
                            {
                                string script = "alert(\"ไม่พบผู้ใช้\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                    }




                    using (OracleCommand command = new OracleCommand("SELECT TB_SALARY_UP.DETAIL_SALARY,TB_SALARY_UP.DETAIL_BASEMONEY,TB_SALARY_UP.DETAIL_PERCENT_RATE,TB_SALARY_UP.DETAIL_MONEYNOTROUND,TB_SALARY_UP.DETAIL_MONEYROUND,TB_SALARY_UP.DETAIL_MONEYUP,TB_SALARY_UP.DETAIL_MONEYBONUS,TB_SALARY_UP.DETAIL_SUM_MONEY,TB_SALARY_UP.DETAIL_NEW_SALARY,TB_SALARY_UP.DETAIL_SCORE_TEST,TB_SALARY_UP.DETAIL_LEVEL_TEST,TB_SALARY_UP.ADMIN_RATESUM,TB_SALARY_UP.ADMIN_RATE,TB_SALARY_UP.ADMIN_MONEY_ADD,TB_SALARY_UP.SUM_PERCENT_RATE2,TB_SALARY_UP.SUM_MONEYNOTROUND,TB_SALARY_UP.SUM_MONEYROUND,TB_SALARY_UP.SUM_MONEYUP,TB_SALARY_UP.SUM_MONEYBONUS,TB_SALARY_UP.SUM_MONEYUPTOTAL,TB_SALARY_UP.SUM_NEWSALARY,TB_SALARY_UP.\"COMMENT\"  FROM TB_SALARY_UP  WHERE ID = " + Label63.Text, conn))
                    {
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TextBox2.Text = reader.GetDouble(0).ToString();
                                Label24.Text = reader.GetDouble(1).ToString();
                                TextBox3.Text = reader.GetDouble(2).ToString();
                                Label26.Text = reader.GetDouble(3).ToString();
                                Label27.Text = reader.GetDouble(4).ToString();
                                Label29.Text = reader.GetDouble(5).ToString();
                                Label31.Text = reader.GetDouble(6).ToString();
                                Label33.Text = reader.GetDouble(7).ToString();
                                Label35.Text = reader.GetDouble(8).ToString();
                                TextBox4.Text = reader.GetDouble(9).ToString();
                                TextBox5.Text = reader.GetString(10);
                                TextBox6.Text = reader.GetDouble(11).ToString();
                                TextBox7.Text = reader.GetDouble(12).ToString();
                                Label58.Text = reader.GetDouble(13).ToString();
                                Label42.Text = reader.GetDouble(14).ToString();
                                Label44.Text = reader.GetDouble(15).ToString();
                                Label46.Text = reader.GetDouble(16).ToString();
                                Label48.Text = reader.GetDouble(17).ToString();
                                Label50.Text = reader.GetDouble(18).ToString();
                                Label52.Text = reader.GetDouble(19).ToString();
                                Label54.Text = reader.GetDouble(20).ToString();
                                TextBox9.Text = reader.GetString(21);
                            }
                            command.Dispose();
                            reader.Close();
                        }

                    }
                }
            }
        }
        private int roundUp(double i)
        {
            int j = Convert.ToInt32(i);
            return (10 - j % 10) + j;
        }
        protected void LinkButton2_Click(object sender, EventArgs ee)
        {
            String a = TextBox2.Text;
            String b = Label22.Text;
            String c = Label24.Text;
            String d = TextBox3.Text;
            String e = Label26.Text;
            String f = Label27.Text;
            String g = Label29.Text;
            String h = Label31.Text;
            String i = Label33.Text;
            String j = Label35.Text;
            String k = TextBox4.Text;
            String l = TextBox5.Text;
            String m = TextBox6.Text;
            String n = TextBox7.Text;
            String o = Label58.Text;
            String p = Label42.Text;
            String q = Label44.Text;
            String r = Label46.Text;
            String s = Label48.Text;
            String t = Label50.Text;
            String u = Label52.Text;
            String v = Label54.Text;
            String w = TextBox9.Text;
            try
            {
                SqlConnection conn = new SqlConnection("Data Source = 203.158.140.66; Initial Catalog = personal; Integrated Security = False; User ID = rmutto; Password = Zxcvbnm!");
                conn.Open();
                string sql = "UPDATE TB_SALARY_UP SET TB_SALARY_UP.DETAIL_SALARY={0},TB_SALARY_UP.DETAIL_MAXSALARY={1},TB_SALARY_UP.DETAIL_BASEMONEY={2},TB_SALARY_UP.DETAIL_PERCENT_RATE={3},TB_SALARY_UP.DETAIL_MONEYNOTROUND={4},TB_SALARY_UP.DETAIL_MONEYROUND={5},TB_SALARY_UP.DETAIL_MONEYUP={6},TB_SALARY_UP.DETAIL_MONEYBONUS={7},TB_SALARY_UP.DETAIL_SUM_MONEY={8},TB_SALARY_UP.DETAIL_NEW_SALARY={9},TB_SALARY_UP.DETAIL_SCORE_TEST={10},TB_SALARY_UP.DETAIL_LEVEL_TEST='{11}',TB_SALARY_UP.ADMIN_RATESUM={12},TB_SALARY_UP.ADMIN_RATE={13},TB_SALARY_UP.ADMIN_MONEY_ADD={14},TB_SALARY_UP.SUM_PERCENT_RATE2={15},TB_SALARY_UP.SUM_MONEYNOTROUND={16},TB_SALARY_UP.SUM_MONEYROUND={17},TB_SALARY_UP.SUM_MONEYUP={18},TB_SALARY_UP.SUM_MONEYBONUS={19},TB_SALARY_UP.SUM_MONEYUPTOTAL={20},TB_SALARY_UP.SUM_NEWSALARY={21},TB_SALARY_UP.COMMENT='{22}' WHERE ID = " + Label63.Text + "";
                sql = String.Format(sql, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w);
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                Response.Write("<script>alert('SAVE SUCCESSFUL'); self.close();</script>");
                Response.End();

            }
            catch
            {
                string script = "alert(\"เกิดข้อผิดพลาด\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }

        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Write("<script>self.close();</script>");
            Response.End();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection("DATA SOURCE=ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm;");
                    conn.Open();
                OracleCommand command = new OracleCommand("Select TB_POSITION.POSITION_NAME,BASESALARY.MAXSALARY,BASESALARY.MINSALARY,BASESALARY.MAXLOWSALARY,BASESALARY.MINLOWSALARY From TB_POSITION,BASESALARY,TB_PERSONAL WHERE TB_POSITION.POSITION_NAME = '" + Label15.Text + "' AND TB_PERSONAL.POSITION_ID = TB_POSITION.POSITION_ID AND TB_POSITION.POSITION_ID = BASESALARY.POSITION_ID", conn);
                using (OracleDataReader reader = command.ExecuteReader())
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
                        if (Label15.Text == "ปฏิบัติงาน")
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
                /* จำนวนเงินที่คำนวณได้แบบไม่ปัดเศษ */
                double basesalcal = Convert.ToDouble(Label24.Text);
                double rate = Convert.ToDouble(TextBox3.Text);
                Label26.Text = String.Format("{0:.##}", basesalcal * rate / 100);

                /* จำนวนเงินที่คำนวณได้แบบปัดเศษ */
                Label27.Text = "" + roundUp(Convert.ToDouble(Label26.Text));
                /* จำนวนเงินที่ได้เลื่อน */
                Double salcalround = Convert.ToDouble(Label27.Text);

                double salary1 = Convert.ToDouble(TextBox2.Text);
                int maxbasesal = Convert.ToInt32(Label22.Text);
                Double isal = salary1 + salcalround;
                if (isal <= maxbasesal)
                {
                    Label29.Text = "" + salcalround;
                }
                else
                {
                    Label29.Text = "" + (maxbasesal - salary1);
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
                    Label31.Text = "" + ((basesalcal * rate / 100) - salup);
                }
                /* รวมใช้เลื่อน */
                double sumup = Convert.ToDouble(Label31.Text);
                Label33.Text = "" + (salup + sumup);

                /* เงินเดือนใหม่ */
                Double sumup2 = Convert.ToDouble(Label33.Text);
                if (isal <= maxbasesal)
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
            catch
            {
                string script = "alert(\"เกิดข้อผิดพลาด\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection("Data Source = 203.158.140.66; Initial Catalog = personal; Integrated Security = False; User ID = rmutto; Password = Zxcvbnm!");
            conn.Open();
            using (OracleCommand command = new OracleCommand("DELETE FROM TB_SALARY_UP WHERE ID = " + Label63.Text + "", conn))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                    }
                    Response.Write("<script>alert('Delete Successful!'); self.close();</script>");
                    Response.End();

                }
            }
            conn.Close();
        }
    }
}
