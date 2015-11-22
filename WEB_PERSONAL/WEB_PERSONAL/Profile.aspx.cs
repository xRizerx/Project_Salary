using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;

namespace WEB_PERSONAL {
    public partial class Profile : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if(Session["login_id"] == null) {
                return;
            }
            using(OracleConnection con = Util.OC()) {
                using (OracleCommand command = new OracleCommand("SELECT TB_PERSON.PERSON_NAME, TB_PERSON.PERSON_LASTNAME, TB_SYSTEM_STATUS.NAME FROM TB_PERSON, TB_SYSTEM_STATUS WHERE CITIZEN_ID = :1 AND TB_PERSON.SYSTEM_STATUS_ID = TB_SYSTEM_STATUS.ID", con)) {
                    command.Parameters.AddWithValue("1", Session["login_id"].ToString());
                    using(OracleDataReader reader = command.ExecuteReader()) {
                        if(reader.HasRows) {
                            reader.Read();
                            Label14.Text = Session["login_id"].ToString();
                            Label15.Text = reader.GetString(0);
                            Label17.Text = reader.GetString(1);
                            Label22.Text = reader.GetString(2);
                        }
                    }
                }
                using (OracleCommand command = new OracleCommand("SELECT TB_POSITION_AND_SALARY.POSITION_NAME FROM TB_POSITION_AND_SALARY WHERE CITIZEN_ID = :1 ORDER BY ID", con)) {
                    command.Parameters.AddWithValue("1", Session["login_id"].ToString());
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            reader.Read();
                            Label24.Text = reader.GetString(0);
                        }
                    }
                }
            }
            
        }

        protected void LinkButton12_Click(object sender, EventArgs e) {
            string password = "";
            using(OracleConnection conn = Util.OC()) {
                using(OracleCommand command = new OracleCommand("SELECT PASSWORD FROM TB_PERSON WHERE CITIZEN_ID = '" + Session["login_id"].ToString() + "'" ,conn)) {
                    using(OracleDataReader reader = command.ExecuteReader()) {
                        if(reader.HasRows) {
                            reader.Read();
                            password = reader.GetString(0);
                        }
                    }
                }
            }
            if(TextBox1.Text != password) {
                Util.Alert(this, "รหัสผ่านเก่าไม่ถูกต้อง");
                return;
            }
            if (TextBox2.Text == null || TextBox3.Text == null || TextBox2.Text == "" || TextBox3.Text == "") {
                Util.Alert(this, "กรุณากรอกรหัสผ่านใหม่ให้ครบถ้วน");
                return;
            }
            if (TextBox2.Text != TextBox3.Text) {
                Util.Alert(this, "รหัสผ่านใหม่ไม่ตรงกัน");
                return;
            }
            
            if (TextBox2.Text == password) {
                Util.Alert(this, "รหัสผ่านใหม่ต้องไม่ซ้ำกับรหัสผ่านเก่า");
                return;
            }

            using (OracleConnection conn = Util.OC()) {
                using (OracleCommand command = new OracleCommand("UPDATE TB_PERSON SET PASSWORD = :1 WHERE CITIZEN_ID = :2", conn)) {
                    command.Parameters.AddWithValue("1", TextBox2.Text);
                    command.Parameters.AddWithValue("2", Session["login_id"].ToString());
                    command.ExecuteNonQuery();
                    Util.Alert(this, "แก้ไขข้อมูลสำเร็จ");
                }
            }

        }

        protected void LinkButton11_Click(object sender, EventArgs e) {
            Response.Redirect("Person-ADMIN.aspx");
        }
    }
}