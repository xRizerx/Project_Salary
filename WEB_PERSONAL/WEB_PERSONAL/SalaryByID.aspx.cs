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
            Label11.Text = "";
            Label13.Text = "";
            Label15.Text = "";
            Label17.Text = "";
            Label19.Text = "";
            Label22.Text = "";
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
                SqlCommand command = new SqlCommand("Select TB_POSITION.POSITION_NAME,BASESALARY.MAXSALARY,BASESALARY.MINSALARY,BASESALARY.MAXLOWSALARY,BASESALARY.MINSALARY From TB_POSITION,BASESALARY,TB_PERSONAL WHERE TB_PERSONAL.POSITION_ID = "+ Label15.Text +" AND TB_POSITION.POSITION_ID = BASESALARY.POSITION_ID", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String position = reader.GetString(0);
                        int maxsal = reader.GetInt32(1);
                        int minsal = reader.GetInt32(2);
                        int maxlowsal = reader.GetInt32(3);
                        int minlowsal = reader.GetInt32(4);
                        if (Label15.Text == "อาจารย์")
                        {
                            if (Convert.ToInt32(TextBox2.Text) >= maxsal)
                            {
                                Label24.Text = "37080";
                            }
                                Label24.Text = "24030";
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
            
            
        }
    }
}
