using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;
using WEB_PERSONAL.Class;

namespace WEB_PERSONAL {
    public partial class Access : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }
        protected void LinkButton1X_Click(object sender, EventArgs e) {
            Label12X.Text = "กำลังตรวจสอบ";
            using (OracleConnection con = Util.OC()) {
                using (OracleCommand command = new OracleCommand("SELECT count(*) FROM TB_PERSON WHERE CITIZEN_ID = :1", con)) {
                    command.Parameters.AddWithValue("1", TextBox1X.Text);
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            reader.Read();
                            if (reader.GetInt32(0) == 0) {
                                Label12X.Text = "ไม่พบผู้ใช้งาน!";
                                return;
                            }
                        } else {
                            Label12X.Text = "ไม่พบผู้ใช้งาน!";
                        }
                    }
                }
                using (OracleCommand command = new OracleCommand("SELECT TB_PERSON.PASSWORD, TB_SYSTEM_STATUS.NAME, TB_PERSON.PERSON_NAME, TB_PERSON.PERSON_LASTNAME, TB_PERSON.SYSTEM_STATUS_ID FROM TB_PERSON, TB_SYSTEM_STATUS WHERE TB_PERSON.CITIZEN_ID = :1 AND TB_PERSON.SYSTEM_STATUS_ID = TB_SYSTEM_STATUS.ID", con)) {
                    command.Parameters.AddWithValue("1", TextBox1X.Text);
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        reader.Read();
                        if (reader.GetString(0) == TextBox2X.Text) {
                            Session["login_person"] = new Person(TextBox1X.Text);
                            Session["login_id"] = TextBox1X.Text;
                            Session["login_system_status_id"] = reader.GetInt32(4).ToString();
                            Session["login_system_status"] = reader.GetString(1);
                            Session["login_name"] = reader.GetString(2);
                            Session["login_lastname"] = reader.GetString(3);
                            Session["login_date_time"] = DateTime.Now;
                            Session["login_total_second"] = DropDownList1X.SelectedValue;
                            if (Session["redirect_to"] == null) {
                                Response.Redirect("Default.aspx");
                            } else {
                                Response.Redirect(Session["redirect_to"].ToString());
                            }
                            Session.Remove("redirect_to");
            
                        } else {
                            Label12X.Text = "รหัสผ่านไม่ถูกต้อง!";
                        }
                    }
                }
            }
        }

    }
}