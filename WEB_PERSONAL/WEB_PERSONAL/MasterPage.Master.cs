using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;
using WEB_PERSONAL.Class;

namespace WEB_PERSONAL {
    public partial class MasterPage : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void LinkButton4_Click(object sender, EventArgs e) {
            /*Response.Redirect("Salary.aspx");*/
        }

        protected void LinkButton5_Click(object sender, EventArgs e) {
            Response.Redirect("Default.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e) {
            Response.Redirect("Leave.aspx");
        }

        protected void LinkButton6_Click(object sender, EventArgs e) {
            Response.Redirect("SEMINAR-GENERAL.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e) {
            Response.Redirect("insignia_citizen.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e) {
            Response.Redirect("Login.aspx");
        }

        protected void form1_Load(object sender, EventArgs e) {
            if (Session["login_id"] == null) {
                Session["redirect_to"] = Request.Url.ToString();
                Response.Redirect("Access.aspx");
                return;
            } else {
                Session.Timeout = 3600;
                if ((DateTime.Now - (DateTime)Session["login_date_time"]).TotalSeconds > Int32.Parse(Session["login_total_second"].ToString())) {
                    Session["login_date_time"] = null;
                    Logout();

                    Session["redirect_to"] = Request.Url.ToString();
                    Response.Redirect("Access.aspx");
                    return;
                }
                Person person = ((Person)Session["login_person"]);

                /*Label7.Text = Session["login_id"].ToString();*/
                //string name = Session["login_name"].ToString() + " " + Session["login_lastname"];
                string name = person.NameAndLastname;
                //string systemRank = "(" + Session["login_system_status"].ToString() + ")";
                LinkButton1.Text = name;
                //Label7.Text = systemRank;
                LinkButton10.Visible = true;
                if (Session["login_system_status_id"].ToString() == "1") {
                    LinkButton1.ForeColor = System.Drawing.Color.FromArgb(204, 41, 57);
                    //Label7.ForeColor = System.Drawing.Color.FromArgb(204, 41, 57);
                } else {
                    LinkButton1.ForeColor = System.Drawing.Color.FromArgb(0, 162, 232);
                    //Label7.ForeColor = System.Drawing.Color.FromArgb(0, 162, 232);
                }

            }

            if (!IsPostBack) {
                using (OracleConnection con = Util.OC()) {
                    using (OracleCommand command = new OracleCommand("UPDATE TB_WEB SET COUNTER = COUNTER+1 WHERE ID = 1", con)) {
                        command.ExecuteNonQuery();
                    }
                    using (OracleCommand command = new OracleCommand("SELECT COUNTER FROM TB_WEB WHERE ID = 1", con)) {
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

        protected void LinkButton10_Click(object sender, EventArgs e) {
            //log out
            Logout();

            Response.Redirect("Access.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e) {
            Response.Redirect("Salary.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e) {
            Response.Redirect("SalarybyID.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e) {
            Response.Redirect("Personnel-GENERAL.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e) {
            Response.Redirect("Study-IN.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e) {
            Response.Redirect("M-Admin.aspx");
        }

        private void Logout() {
            Session.Remove("login_person");
            Session.Remove("login_id");
            Session.Remove("login_system_status");
            Session.Remove("login_name");
            Session.Remove("login_lastname");
            Session.Remove("redirect_to");
            Session.Remove("login_system_status_id");
        }

        protected void LinkButton13_Click(object sender, EventArgs e) {
            Response.Redirect("Personnel-General.aspx");
        }

        protected void LinkButton14_Click(object sender, EventArgs e) {
            Response.Redirect("Person-General.aspx");
        }



        protected void LinkButton1_Click1(object sender, EventArgs e) {
            Response.Redirect("Profile.aspx");
        }

        protected void LinkButton2_Click1(object sender, EventArgs e) {
            Response.Redirect(Request.Url.ToString());
        }

        protected void LinkButton3_Click1(object sender, EventArgs e) {
            Response.Redirect("Default.aspx");
        }

    }
}