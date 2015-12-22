using System;
using System.Web.UI.WebControls;
using System.Data.OracleClient;
using System.Data;

namespace WEB_PERSONAL
{
    public partial class Salary_Salary_Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["login_system_status_id"] == null)
            {
                Response.Redirect("Default.aspx");
            }
                if (Session["login_system_status_id"].ToString() == "1")
                {
                return;
                }
                else
                {
                    Response.Redirect("Error-Member.aspx");
                }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }


    }
}