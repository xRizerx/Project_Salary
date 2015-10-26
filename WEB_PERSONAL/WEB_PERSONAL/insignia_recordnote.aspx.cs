using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WEB_PERSONAL
{
    public partial class insignis_recordnote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           /* if (RadioButton1.Checked == true)
            { 
                TextBox1.Text = "kuy1";
            TextBox2.Text = "";
            }
            else if (RadioButton2.Checked == true)
            { 
                TextBox2.Text = "kuy2";
            TextBox1.Text = "";
            }*/

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source = 203.158.140.66; Initial Catalog = personal; Integrated Security = False; User ID = rmutto; Password = Zxcvbnm!");
                conn.Open();
                using (SqlCommand command = new SqlCommand("SELECT TB_PERSONAL.STF_NAME,TB_PERSONAL.STF_LNAME, TB_PERSONAL.DATETIME_INWORK, tb_position_work.position_work_name, tb_recordnote.date, tb_position.position_name, tb_recordnote.gazette_lam, tb_recordnote.gazette_ton ,tb_recordnote.gazette_na ,tb_recordnote.gazette_date, ISNULL(tb_recordnote.Invoice,'-')"
                    + " FROM TB_PERSONAL, tb_position_work, tb_recordnote, tb_position"
                    + " WHERE TB_PERSONAL.CITIZEN_ID = '" + TextBox1.Text + "' AND tb_position_work.POSITION_WORK_ID = tb_personal.POSITION_WORK AND tb_position.position_id = tb_personal.position_id", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            TextBox2.Text = reader.GetString(0);
                            TextBox3.Text = reader.GetString(1);
                            TextBox4.Text = reader.GetDateTime(2).ToString("dd/MM/yyyy");
                            TextBox6.Text = reader.GetString(3); /*tb_position_work.position_work_name*/
                            TextBox5.Text = reader.GetDateTime(4).ToString("dd/MM/yyyy");
                            TextBox7.Text = reader.GetString(5);
                            /*TextBox8.Text = reader.GetString(ยังไม่ได้คิด); ยังไม่ได้คิด*/
                            TextBox9.Text = reader.GetString(6);
                            TextBox10.Text = reader.GetString(7);
                            TextBox11.Text = reader.GetString(8);
                            TextBox12.Text = reader.GetDateTime(9).ToString("dd/MM/yyyy");
                            if(reader.GetString(10) != "-")
                            {
                                RadioButton2.Checked = true;
                            } else
                            {
                                RadioButton4.Checked = true;
                            }
                            /*ใบกำกับ*/
                            /*เหรียญตราฯ*/
                            /*หมายเหตุ*/
                        }

                    }
                }
                conn.Close();
            }
            catch
            {
                string script = "alert(\"ไม่พบผู้ใช้\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conn = new SqlConnection("Data Source = 203.158.140.66; Initial Catalog = personal; Integrated Security = False; User ID = rmutto; Password = Zxcvbnm!");
                conn.Open();
                using (SqlCommand command = new SqlCommand("update user_insert set วัน เดือน ปี='" + TextBox5.Text + "'ตำแหน่ง='" + TextBox6.Text  + "ระดับ=" + TextBox7.Text + "ได้รับ ชั้น/รายการ" + TextBox8.Text + "เล่ม" + TextBox9.Text + "ตอน" + TextBox10.Text + "หน้า" + TextBox11.Text + "วัน เดือน ปี" + TextBox12.Text, conn))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                string script = "alert(\"อัพเดตเรียบร้อย\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }

            //--

        }
    }
}