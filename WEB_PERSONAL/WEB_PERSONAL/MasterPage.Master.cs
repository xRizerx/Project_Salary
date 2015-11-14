using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;

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

            if (Session["login_id"] != null)
            {
                
                if ((DateTime.Now - (DateTime)Session["login_date_time"]).TotalSeconds > Int32.Parse(Session["login_total_second"].ToString())) {
                    Session["login_date_time"] = null;
                    Logout();
                    Label7.Text = "ยังไม่ได้เข้าสู่ระบบ";
                    LinkButton9.Visible = true;
                    LinkButton10.Visible = false;
                    Label7.ForeColor = System.Drawing.Color.FromArgb(128, 128, 128);
                    return;
                }
                
               
                
                /*Label7.Text = Session["login_id"].ToString();*/
                string name = Session["login_name"].ToString() + " " + Session["login_lastname"];
                string systemRank = "(" + Session["login_system_status"].ToString() + ")";
                Label7.Text = name + " " + systemRank;
                LinkButton9.Visible = false;
                LinkButton10.Visible = true;
                if(Session["login_system_status"].ToString() == "Admin")
                {
                    Label7.ForeColor = System.Drawing.Color.FromArgb(204,41,57);
                } else
                {
                    Label7.ForeColor = System.Drawing.Color.FromArgb(0, 162, 232);
                }
                
            } else
            {
                Label7.Text = "ยังไม่ได้เข้าสู่ระบบ";
                LinkButton9.Visible = true;
                LinkButton10.Visible = false;
                Label7.ForeColor = System.Drawing.Color.FromArgb(128, 128, 128);
            }

           
            if(!IsPostBack) {
                using (OracleConnection con = Util.OC()) {
                    {
                        string sql = "UPDATE TB_WEB SET COUNTER = COUNTER+1 WHERE ID = 1";
                        using (OracleCommand command = new OracleCommand(sql, con)) {
                            command.ExecuteNonQuery();
                        }
                    }
                    {
                        string sql = "SELECT COUNTER FROM TB_WEB WHERE ID = 1";
                        using (OracleCommand command = new OracleCommand(sql, con)) {
                            using (OracleDataReader reader = command.ExecuteReader()) {
                                if (reader.HasRows) {
                                    reader.Read();
                                    LabelCounter.Text = "จำนวนผู้เข้าชม : " + reader.GetInt32(0).ToString("#,###") + " ครั้ง";
                                }
                            }

                        }
                    }
                }
            }
            
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            //log out
            Logout();
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

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Personnel-GENERAL.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("Study-IN.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("M-Admin.aspx");
        }

        private void Logout() {
            Session.Remove("login_id");
            Session.Remove("login_system_status");
            Session.Remove("login_name");
            Session.Remove("login_lastname");
        }

    }
}