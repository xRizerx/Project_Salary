using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_PERSONAL
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            /*Response.Redirect("Salary.aspx");*/
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Leave.aspx");
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("SEMINAR-GENERAL.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("insignia_citizen.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void form1_Load(object sender, EventArgs e)
        {
            
            if(Session["login_id"] != null)
            {
                Label7.Text = Session["login_id"].ToString();
                LinkButton9.Visible = false;
                LinkButton10.Visible = true;
            } else
            {
                Label7.Text = "ยังไม่ได้เข้าสู่ระบบ";
                LinkButton9.Visible = true;
                LinkButton10.Visible = false;
            }

            if (Session["login_system_status"] != null)
            {
                Label8.Text = "(" + Session["login_system_status"].ToString() + ")";
            }
            else
            {
                Label8.Text = "";
            }
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            //log out
            Session.Remove("login_id");
            Session.Remove("login_system_status");
            Response.Redirect("Default.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Salary.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("SalarybyID.aspx");
        }
    }
}