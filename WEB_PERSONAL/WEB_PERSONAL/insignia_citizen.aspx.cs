using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;

namespace WEB_PERSONAL
{
    public partial class insignia_main : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("insignia_citizen.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=ORCL_RMUTTO;User ID=rmutto;Password=Zxcvbnm";
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    using (OracleCommand command = new OracleCommand(
                        "SELECT count(*) FROM TB_PERSONAL WHERE CITIZEN_ID = '" + TextBox1.Text + "'", con))
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if(reader.GetInt32(0) == 1)
                            {
                                Session["insignia_citizen_id"] = TextBox1.Text;
                                if (Session["login_system_status"] != null && Session["login_system_status"].ToString() == "Admin")
                                {
                                    Response.Redirect("insignia_admin.aspx");
                                }
                                else
                                {
                                    Response.Redirect("insignia_user.aspx");
                                }
                                
                            } else
                            {
                                string script = "alert(\"ไม่พบผู้ใช้งาน\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
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

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextBox1.Text.Contains("\n"))
            {
                Util.Alert(this, "55");
            }
        }
    }
}