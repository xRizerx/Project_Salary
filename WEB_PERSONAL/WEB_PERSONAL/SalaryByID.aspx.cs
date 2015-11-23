using System;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data.OracleClient;

namespace WEB_PERSONAL
{
    public partial class SalaryByID : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_id"] == null)
            {
                return;
            }
            if (Session["login_system_status_id"].ToString() == "1")
            {
                LinkButton11.Visible = true;
            }
            else
            {
                LinkButton11.Visible = false;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection("DATA SOURCE=ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm;"))
                //using (SqlConnection conn = new SqlConnection("Data Source = 203.158.140.66; Initial Catalog = personal; Integrated Security = False; User ID = rmutto; Password = Zxcvbnm!"))
                {
                    conn.Open();
                    int m = 3;
                    switch (DateTime.Now.Month)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 10:
                        case 11:
                        case 12:
                            m = 9;
                            break;
                    }
                    {

                    }
                    using (OracleCommand command = new OracleCommand("Select TB_PERSONAL.STF_NAME,TB_PERSONAL.STF_LNAME,TB_POSITION.POSITION_NAME,TB_SUBSTAFFTYPE.SUBSTAFFTYPE_NAME,TB_ADMIN_POSITION.ADMIN_POSITION_NAME,BASESALARY.MAXSALARY,TB_SALARY.SALARY From TB_PERSONAL,TB_POSITION,TB_SUBSTAFFTYPE,TB_ADMIN_POSITION,BASESALARY,TB_SALARY WHERE TB_PERSONAL.CITIZEN_ID = '" + TextBox1.Text + "' AND TB_PERSONAL.POSITION_ID = TB_POSITION.POSITION_ID AND TB_PERSONAL.SUBSTAFFTYPE_ID = TB_SUBSTAFFTYPE.SUBSTAFFTYPE_ID AND TB_PERSONAL.ADMIN_POSITION_ID = TB_ADMIN_POSITION.ADMIN_POSITION_ID AND TB_PERSONAL.POSITION_ID = BASESALARY.POSITION_ID AND TB_SALARY.MONTH = " + m, conn))
                    {
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Label11.Text = reader.GetString(0);
                                    Label13.Text = reader.GetString(1);
                                    Label15.Text = reader.GetString(2);
                                    Label17.Text = reader.GetString(3);
                                    Label19.Text = reader.GetString(4);
                                    Label22.Text = reader.GetInt32(5).ToString();
                                    TextBox2.Text = reader.GetInt32(6).ToString();
                                }
                                Session["citizen_id"] = TextBox1.Text;
                            }
                            else
                            {
                                string script = "alert(\"ไม่พบผู้ใช้\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                    }
                }
            }
            catch
            {
                string script = "alert(\"เกิดข้อผิดพลาด\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
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
                Label33.Text = String.Format("{0:.##}", salup + sumup);

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
                Label52.Text = String.Format("{0:.##}", salup2 + sumup4);
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
        private int roundUp(double i)
        {
            int j = Convert.ToInt32(i);
            return (10 - j % 10) + j;
        }

        protected void LinkButton2_Click(object sender, EventArgs ee)
        {
            String a = TextBox1.Text;
            String b = TextBox2.Text;
            String c = Label22.Text;
            String d = Label24.Text;
            String e = TextBox3.Text;
            String f = Label26.Text;
            String g = Label27.Text;
            String h = Label29.Text;
            String i = Label31.Text;
            String j = Label33.Text;
            String k = Label35.Text;
            String l = TextBox4.Text;
            String m = TextBox5.Text;
            String n = TextBox6.Text;
            String o = TextBox7.Text;
            String p = Label58.Text;
            String q = Label42.Text;
            String r = Label44.Text;
            String s = Label46.Text;
            String t = Label48.Text;
            String u = Label50.Text;
            String v = Label52.Text;
            String w = Label54.Text;
            String x = TextBox9.Text;
            DateTime dt = DateTime.Now;
            String y = Util.ToOracleDate(dt);

            using (OracleConnection conn = new OracleConnection("DATA SOURCE=ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm;"))
            {
                conn.Open();
                string sql = "INSERT INTO TB_SALARY_UP VALUES (SEQ_SALUP_ID.NEXTVAL,'{0}', {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, '{12}', {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22},'{23}', SYSDATE)";
                sql = String.Format(sql, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x);
                using (OracleCommand command = new OracleCommand(sql, conn))
                {
                    command.ExecuteNonQuery();
                    string script = "alert(\"SAVE SUCCESSFUL.\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }


            }



        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("SalarybyID_Edit");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("SalaryByID-Report.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("Salary_Basesalary_Admin.aspx");
        }
    }
}
