using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WEB_PERSONAL
{
    public partial class Study_IN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton15_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=203.158.140.66;Initial Catalog=personal;Integrated Security=FALSE;User ID=rmutto;Password=Zxcvbnm!";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    {
                        {
                            string sql = "select ID, DATE, CITIZEN_ID, LEVEL, BRANCH_NAME, LOCATION_NAME, FROM_DATE, TO_DATE, CONTRACT_GIVER_NAME, CONTRACT_RECEIVER_NAME, CONTRACT_WITNESS1_NAME, CONTRACT_WITNESS2_NAME, MATE_NAME, MATE_WITNESS1_NAME, MATE_WITNESS2_NAME, LAWYER_NAME, DEPARTMENT_OFFICIAL_NAME, DIRECTOR_NAME, DEPUTY_DIRECTOR_NAME, TYPE_ID, ISNULL(FUND_TYPE,''), ISNULL(COUNTRY_NAME,'') from TB_STUDY where id = " + TextBox1.Text;
                            using (SqlCommand command = new SqlCommand(sql, con))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        TextBox1.Text = reader.GetInt32(0).ToString();
                                        TextBox2.Text = reader.GetDateTime(1).ToString("dd/MM/yyyy");
                                        TextBox3.Text = reader.GetString(2);
                                        TextBox4.Text = reader.GetString(3);
                                        TextBox5.Text = reader.GetString(4);
                                        TextBox6.Text = reader.GetString(5);
                                        TextBox7.Text = reader.GetDateTime(6).ToString("dd/MM/yyyy");
                                        TextBox8.Text = reader.GetDateTime(7).ToString("dd/MM/yyyy");
                                        TextBox9.Text = reader.GetString(8);
                                        TextBox10.Text = reader.GetString(9);
                                        TextBox11.Text = reader.GetString(10);
                                        TextBox12.Text = reader.GetString(11);
                                        TextBox13.Text = reader.GetString(12);
                                        TextBox14.Text = reader.GetString(13);
                                        TextBox15.Text = reader.GetString(14);
                                        TextBox16.Text = reader.GetString(15);
                                        TextBox17.Text = reader.GetString(16);
                                        TextBox18.Text = reader.GetString(17);
                                        TextBox19.Text = reader.GetString(18);
                                        DropDownList1.SelectedValue = reader.GetInt32(19).ToString();
                                        TextBox20.Text = reader.GetString(20);
                                        TextBox21.Text = reader.GetString(21);

                                    }
                                }

                            }
                        }

                        {
                            string sql = "SELECT STF_NAME + ' ' + STF_LNAME FROM TB_PERSONAL WHERE CITIZEN_ID = '" + TextBox3.Text + "'";
                            using (SqlCommand command = new SqlCommand(sql, con))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if(reader.HasRows)
                                    {
                                        while (reader.Read())
                                        {
                                            TextBox22.Text = reader.GetString(0);
                                        }
                                    } else
                                    {
                                        string script = "alert('ไม่พบรหัสพนักงาน')";
                                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                    }
                                    
                                }

                            }
                        }


                    }
                }
            }
            catch (Exception e2)
            {
                string script = "alert('เกิดข้อผิดพลาด! " + e2.Message + "');";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void LinkButton16_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=203.158.140.66;Initial Catalog=personal;Integrated Security=FALSE;User ID=rmutto;Password=Zxcvbnm!";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    {
                        string sql = "insert into TB_STUDY values({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}',{19},'{20}','{21}')";
                        sql = String.Format(sql, TextBox1.Text, toDate(TextBox2.Text), TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, toDate(TextBox7.Text), toDate(TextBox8.Text), TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text, TextBox13.Text, TextBox14.Text, TextBox15.Text, TextBox16.Text, TextBox17.Text, TextBox18.Text, TextBox19.Text, DropDownList1.SelectedValue, TextBox20.Text, TextBox21.Text);
                        using (SqlCommand command = new SqlCommand(sql, con))
                        {
                            command.ExecuteNonQuery();
                            string script = "alert('เพิ่มข้อมูลสำเร็จ!');";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                }
            }
            catch (Exception e2)
            {
                string script = "alert('เกิดข้อผิดพลาด! " + e2.Message + "');";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        private string toDate(String str)
        {
            string[] paper_date_s = str.Split('/');
            int paper_date_y = Convert.ToInt32(paper_date_s[2]) - 543;
            return paper_date_y + paper_date_s[1] + paper_date_s[0];
        }

        protected void LinkButton17_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=203.158.140.66;Initial Catalog=personal;Integrated Security=FALSE;User ID=rmutto;Password=Zxcvbnm!";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    {
                        string sql = "update TB_STUDY set ID={0}, DATE='{1}', CITIZEN_ID='{2}', LEVEL='{3}', BRANCH_NAME='{4}', LOCATION_NAME='{5}', FROM_DATE='{6}', TO_DATE='{7}', CONTRACT_GIVER_NAME='{8}', CONTRACT_RECEIVER_NAME='{9}', CONTRACT_WITNESS1_NAME='{10}', CONTRACT_WITNESS2_NAME='{11}', MATE_NAME='{12}', MATE_WITNESS1_NAME='{13}', MATE_WITNESS2_NAME='{14}', LAWYER_NAME='{15}', DEPARTMENT_OFFICIAL_NAME='{16}', DIRECTOR_NAME='{17}', DEPUTY_DIRECTOR_NAME='{18}', TYPE_ID={19}, FUND_TYPE='{20}', COUNTRY_NAME='{21}' WHERE ID = " + TextBox1.Text;
                        sql = String.Format(sql, TextBox1.Text, toDate(TextBox2.Text), TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, toDate(TextBox7.Text), toDate(TextBox8.Text), TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text, TextBox13.Text, TextBox14.Text, TextBox15.Text, TextBox16.Text, TextBox17.Text, TextBox18.Text, TextBox19.Text, DropDownList1.SelectedValue, TextBox20.Text, TextBox21.Text);
                        using (SqlCommand command = new SqlCommand(sql, con))
                        {
                            command.ExecuteNonQuery();
                            string script = "alert('แก้ไขข้อมูลสำเร็จ!');";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                }
            }
            catch (Exception e2)
            {
                string script = "alert('เกิดข้อผิดพลาด! " + e2.Message + "');";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void LinkButton18_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=203.158.140.66;Initial Catalog=personal;Integrated Security=FALSE;User ID=rmutto;Password=Zxcvbnm!";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    {
                        string sql = "SELECT STF_NAME + ' ' + STF_LNAME FROM TB_PERSONAL WHERE CITIZEN_ID = '" + TextBox3.Text + "'";
                        using (SqlCommand command = new SqlCommand(sql, con))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        TextBox22.Text = reader.GetString(0);
                                    }
                                }
                                else
                                {
                                    string script = "alert('ไม่พบรหัสพนักงาน')";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }

                            }

                        }
                    }
                }
            }
            catch (Exception e2)
            {
                string script = "alert('เกิดข้อผิดพลาด! " + e2.Message + "');";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }
    }
}