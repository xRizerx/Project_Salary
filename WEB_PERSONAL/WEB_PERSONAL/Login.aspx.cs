using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WEB_PERSONAL.CSS
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=203.158.140.66;Initial Catalog=personal;Integrated Security=FALSE;User ID=rmutto;Password=Zxcvbnm!";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    {
                        string sql = "SELECT count(*) FROM TB_PERSONAL WHERE CITIZEN_ID = '" + TextBox1.Text + "'";
                        using (SqlCommand command = new SqlCommand(sql, con))
                        {
                            using(SqlDataReader reader = command.ExecuteReader())
                            {
                                while(reader.Read())
                                {
                                    if(reader.GetInt32(0) == 0)
                                    {
                                        string script2 = "alert(\"ไม่พบผู้ใช้งาน!\");";
                                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script2, true);
                                        return;
                                    }
                                }
                            }
                            
                        }
                    }

                    {
                        string sql = "SELECT TB_PERSONAL.PASSWORD, TB_SYSTEM_STATUS.NAME FROM TB_PERSONAL, TB_SYSTEM_STATUS WHERE TB_PERSONAL.CITIZEN_ID = '" + TextBox1.Text + "' AND TB_PERSONAL.SYSTEM_STATUS_ID = TB_SYSTEM_STATUS.ID";
                        using (SqlCommand command = new SqlCommand(sql, con))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    if (reader.GetString(0) == TextBox2.Text)
                                    {
                                        Session["login_id"] = TextBox1.Text;
                                        Session["login_system_status"] = reader.GetString(1);
                                        Response.Redirect("Default.aspx");
                                    }
                                    else
                                    {
                                        string script2 = "alert(\"รหัสผ่านไม่ถูกต้อง!\");";
                                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script2, true);
                                    }
                                }
                            }

                        }
                    }
                }
            }
            catch (Exception e2)
            {
                string script = "alert(\"เกิดข้อผิดพลาด! " + e2.Message + "\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            
        }
    }
}