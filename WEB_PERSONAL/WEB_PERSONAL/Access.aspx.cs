using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;

namespace WEB_PERSONAL {
    public partial class Access : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            
        }
        protected void LinkButton1X_Click(object sender, EventArgs e) {
            Label12X.Text = "กำลังตรวจสอบ";
            //try
            {
                using (OracleConnection con = Util.OC()) {
                    {
                        string sql = "SELECT count(*) FROM TB_PERSON WHERE CITIZEN_ID = '" + TextBox1X.Text + "'";
                        using (OracleCommand command = new OracleCommand(sql, con)) {
                            using (OracleDataReader reader = command.ExecuteReader()) {
                                while (reader.Read()) {
                                    if (reader.GetInt32(0) == 0) {
                                        Label12X.Text = "ไม่พบผู้ใช้งาน!";
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "toggleLoginPopup();", true);
                                        return;
                                    }
                                }
                            }

                        }
                    }

                    {
                        string sql = "SELECT TB_PERSON.PASSWORD, TB_SYSTEM_STATUS.NAME, TB_PERSON.PERSON_NAME, TB_PERSON.PERSON_LASTNAME, TB_PERSON.SYSTEM_STATUS_ID FROM TB_PERSON, TB_SYSTEM_STATUS WHERE TB_PERSON.CITIZEN_ID = '" + TextBox1X.Text + "' AND TB_PERSON.SYSTEM_STATUS_ID = TB_SYSTEM_STATUS.ID";
                        using (OracleCommand command = new OracleCommand(sql, con)) {
                            using (OracleDataReader reader = command.ExecuteReader()) {
                                while (reader.Read()) {
                                    if (reader.GetString(0) == TextBox2X.Text) {
                                        Session["login_id"] = TextBox1X.Text;
                                        Session["login_system_status_id"] = reader.GetInt32(4).ToString();
                                        Session["login_system_status"] = reader.GetString(1);
                                        Session["login_name"] = reader.GetString(2);
                                        Session["login_lastname"] = reader.GetString(3);
                                        Session["login_date_time"] = DateTime.Now;
                                        Session["login_total_second"] = DropDownList1X.SelectedValue;

                                        

                                        if (Session["redirect_to"] == null) {
                                            //ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", "goPage('Default.aspx');", true);
                                            Response.Redirect("Default.aspx");
                                        } else {
                                            //ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", "goPage('" + Session["redirect_to"].ToString() + "');", true);
                                            Response.Redirect(Session["redirect_to"].ToString());
                                        }
                                        
                                        Session.Remove("redirect_to");
                                        //Response.Redirect("Default.aspx");
                                        //Response.Redirect(Request.Url.ToString(), true);
                                    } else {
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "toggleLoginPopup();", true);
                                        Label12X.Text = "รหัสผ่านไม่ถูกต้อง!";
                                    }
                                }
                            }

                        }
                    }
                }
            }
            //catch (Exception e2)
            //{
            //   string script = "alert(\"เกิดข้อผิดพลาด! " + e2.Message + "\");";
            //   ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            //}
        }

        protected void TextBox2X_TextChanged(object sender, EventArgs e) {
            Label12X.Text = "";
            //try
            {
                using (OracleConnection con = Util.OC()) {
                    {
                        string sql = "SELECT count(*) FROM TB_PERSON WHERE CITIZEN_ID = '" + TextBox1X.Text + "'";
                        using (OracleCommand command = new OracleCommand(sql, con)) {
                            using (OracleDataReader reader = command.ExecuteReader()) {
                                while (reader.Read()) {
                                    if (reader.GetInt32(0) == 0) {
                                        Label12X.Text = "ไม่พบผู้ใช้งาน!";
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "toggleLoginPopup();", true);
                                        return;
                                    }
                                }
                            }

                        }
                    }

                    {
                        string sql = "SELECT TB_PERSON.PASSWORD, TB_SYSTEM_STATUS.NAME, TB_PERSON.PERSON_NAME, TB_PERSON.PERSON_LASTNAME FROM TB_PERSON, TB_SYSTEM_STATUS WHERE TB_PERSON.CITIZEN_ID = '" + TextBox1X.Text + "' AND TB_PERSON.SYSTEM_STATUS_ID = TB_SYSTEM_STATUS.ID";
                        using (OracleCommand command = new OracleCommand(sql, con)) {
                            using (OracleDataReader reader = command.ExecuteReader()) {
                                while (reader.Read()) {
                                    if (reader.GetString(0) == TextBox2X.Text) {
                                        Session["login_id"] = TextBox1X.Text;
                                        Session["login_system_status"] = reader.GetString(1);
                                        Session["login_name"] = reader.GetString(2);
                                        Session["login_lastname"] = reader.GetString(3);
                                        Session["login_date_time"] = DateTime.Now;
                                        Session["login_total_second"] = DropDownList1X.SelectedValue;
                                        //Response.Redirect("Default.aspx");
                                        //Response.Redirect(Request.Url.ToString(), true);
                                    } else {
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "toggleLoginPopup();", true);
                                        Label12X.Text = "รหัสผ่านไม่ถูกต้อง!";
                                    }
                                }
                            }

                        }
                    }
                }
            }
            //catch (Exception e2)
            //{
            //   string script = "alert(\"เกิดข้อผิดพลาด! " + e2.Message + "\");";
            //   ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            //}
        }
    }
}