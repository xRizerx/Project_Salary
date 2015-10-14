using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WEB_PERSONAL
{
    public partial class Leave : System.Web.UI.Page
    {
        protected void LinkButton11_Click(object sender, EventArgs e)
        {
           // try
            //{
                string connectionString = "Data Source=203.158.140.66;Initial Catalog=personal;Integrated Security=FALSE;User ID=rmutto;Password=Zxcvbnm!";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(
                        "SELECT TB_LEAVE.Leave_type_id, TB_PERSONAL.CITIZEN_ID, TB_PERSONAL.STF_NAME, TB_PERSONAL.STF_LNAME, TB_LEAVE.Reason, TB_LEAVE.LEAVE_FROM_DATE, TB_LEAVE.LEAVE_TO_DATE, TB_LEAVE.PAPER_DATE, TB_LEAVE.LEAVE_STATUS_ID FROM TB_LEAVE, TB_PERSONAL WHERE TB_LEAVE.PAPER_ID = " + TextBox1.Text + " AND TB_PERSONAL.CITIZEN_ID = TB_LEAVE.CITIZEN_ID", con))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DropDownList1.SelectedValue = reader.GetInt32(0).ToString();
                            TextBox3.Text = reader.GetString(1);
                            TextBox11.Text = reader.GetString(2);
                            TextBox12.Text = reader.GetString(3);
                            TextBox10.Text = reader.GetString(4);
                            TextBox5.Text = reader.GetDateTime(5).ToString("dd/MM/yyyy");
                            TextBox6.Text = reader.GetDateTime(6).ToString("dd/MM/yyyy");
                            TextBox2.Text = reader.GetDateTime(7).ToString("dd/MM/yyyy");
                            DropDownList2.SelectedValue = reader.GetInt32(8).ToString();
                    }
                    }
                }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(
                    "SELECT TB_LEAVE.APPROVER_ID, TB_PERSONAL.STF_NAME, TB_PERSONAL.STF_FNAME FROM TB_LEAVE, TB_PERSONAL WHERE TB_LEAVE.APPROVER_ID = " + TextBox8.Text + " AND TB_PERSONAL.CITIZEN_ID = TB_LEAVE.CITIZEN_ID", con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TextBox13.Text = reader.GetString(1) + " " + reader.GetString(2);
                        
                    }
                }
            }
            // } catch(Exception e2)
            //{
            //    string script = "alert(\"เกิดข้อผิดพลาด!\");";
            //    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            // }

        }
    }
}