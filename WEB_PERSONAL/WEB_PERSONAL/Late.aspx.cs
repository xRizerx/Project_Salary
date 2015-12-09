using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;
using System.Drawing;
using WEB_PERSONAL.Class;

namespace WEB_PERSONAL {
    public partial class Late : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if(!IsPostBack) {
                Util.RunScript(this, "$(function () { foggle('1'); });");
            }
            BindAllData();
        }

        protected void LinkButton20_Click(object sender, EventArgs e) {
            Util.RunScript(this, "$(function () { foggle('1'); });");
            Person person = new Person(TextBox21.Text);
            Label45.Text = person.Exist ? person.NameAndLastname : "ไม่พบรหัสพนักงาน!!";
        }

        protected void LinkButton11_Click(object sender, EventArgs e) {
            Util.RunScript(this, "$(function () { foggle('1'); });");
            try {
                if (Int32.Parse(TextBox22.Text) < 0 || Int32.Parse(TextBox22.Text) > 23) {
                    Util.Alert(this, "ชั่วโมงเข้าไม่ถูกต้อง");
                    return;
                }
                if (Int32.Parse(TextBox24.Text) < 0 || Int32.Parse(TextBox24.Text) > 23) {
                    Util.Alert(this, "ชั่วโมงออกไม่ถูกต้อง");
                    return;
                }
                if (Int32.Parse(TextBox23.Text) < 0 || Int32.Parse(TextBox23.Text) > 59) {
                    Util.Alert(this, "นาทีเข้าไม่ถูกต้อง");
                    return;
                }
                if (Int32.Parse(TextBox25.Text) < 0 || Int32.Parse(TextBox25.Text) > 59) {
                    Util.Alert(this, "นาทีออกไม่ถูกต้อง");
                    return;
                }
            } catch {
                Util.Alert(this, "เกิดข้อผิดพลาด");
                return;
            }


            //try {
                using (OracleConnection con = Util.OC()) {
                    {
                        string sql = "INSERT INTO TB_WORK_CHECK_IN VALUES(SEQ_WORK_CHECK_IN_ID.NEXTVAL,:1,:2,:3,:4,:5,:6)";

                        using (OracleCommand command = new OracleCommand(sql, con)) {
                            command.Parameters.AddWithValue("1", Util.ODT(TextBox11.Text));
                            command.Parameters.AddWithValue("2", TextBox21.Text);
                            command.Parameters.AddWithValue("3", TextBox22.Text);
                            command.Parameters.AddWithValue("4", TextBox23.Text);
                            command.Parameters.AddWithValue("5", TextBox24.Text);
                            command.Parameters.AddWithValue("6", TextBox25.Text);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            //} catch (Exception e2) {
            //    Util.Alert(this, "เกิดข้อผิดพลาด! " + e2.Message);
            //}
            GridView1.SelectedIndex = -1;
            BindAllData();
        }
        private void BindAllData() {
            GridView1.DataBind();
            GridView2.DataBind();
        }
  
   
        protected void LinkButton21_Click(object sender, EventArgs e) {
            Util.RunScript(this, "$(function () { foggle('2'); });");
            GridView1.SelectedIndex = -1;
            clearEdit();
            using (OracleConnection con = Util.OC()) {
                using(OracleCommand command = new OracleCommand("SELECT TO_CHAR(TB_WORK_CHECK_IN.DDATE,'DD MON YYYY','NLS_DATE_LANGUAGE = THAI'), TB_WORK_CHECK_IN.CITIZEN_ID, TB_PERSON.PERSON_NAME || ' ' || TB_PERSON.PERSON_LASTNAME, TB_WORK_CHECK_IN.HOUR_IN, TB_WORK_CHECK_IN.MINUTE_IN, TB_WORK_CHECK_IN.HOUR_OUT, TB_WORK_CHECK_IN.MINUTE_OUT FROM TB_WORK_CHECK_IN, TB_PERSON WHERE TB_WORK_CHECK_IN.ID = :1 AND TB_PERSON.CITIZEN_ID = TB_WORK_CHECK_IN.CITIZEN_ID", con)) {
                    command.Parameters.AddWithValue("1", TextBox27.Text);
                    using(OracleDataReader reader = command.ExecuteReader()) {
                        if(reader.HasRows) {
                            reader.Read();
                            TextBox26.Text = TextBox27.Text;
                            TextBox1.Text = Util.NDT(reader.GetString(0));
                            TextBox2.Text = reader.GetString(1);
                            Label5.Text = reader.GetString(2);
                            TextBox3.Text = reader.GetInt32(3).ToString();
                            TextBox4.Text = reader.GetInt32(4).ToString();
                            TextBox5.Text = reader.GetInt32(5).ToString();
                            TextBox6.Text = reader.GetInt32(6).ToString();
                        } else {
                            Label50.Text = "ไม่พบรหัสเอกสาร";
                            return;
                        }
                        
                    }
                }
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e) {
            Util.RunScript(this, "$(function () { foggle('2'); });");
            using (OracleConnection con = Util.OC()) {
                using(OracleCommand command = new OracleCommand("UPDATE TB_WORK_CHECK_IN SET DDATE = :1, CITIZEN_ID = :2, HOUR_IN = :3, MINUTE_IN = :4, HOUR_OUT = :5, MINUTE_OUT = :6 WHERE ID = :7", con)) {
                    command.Parameters.AddWithValue("1", Util.ODT(TextBox1.Text));
                    command.Parameters.AddWithValue("2", TextBox2.Text);
                    command.Parameters.AddWithValue("3", TextBox3.Text);
                    command.Parameters.AddWithValue("4", TextBox4.Text);
                    command.Parameters.AddWithValue("5", TextBox5.Text);
                    command.Parameters.AddWithValue("6", TextBox6.Text);
                    command.Parameters.AddWithValue("7", TextBox26.Text);
                    command.ExecuteNonQuery();
                    BindAllData();
                }
            }
        }

        protected void GridView1_PageIndexChanged(object sender, EventArgs e) {
            GridView1.SelectedIndex = -1;
            clearEdit();
        }

        private void clearEdit() {
            Label50.Text = "";
            TextBox26.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            Label5.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            Label50.Text = "";
        }

        protected void LinkButton1_Click(object sender, EventArgs e) {
            Util.RunScript(this, "$(function () { foggle('2'); });");
            Person person = new Person(TextBox2.Text);
            Label5.Text = person.Exist ? person.NameAndLastname : "ไม่พบรหัสพนักงาน!!";
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e) {
            if (!Person.IsAdmin(Session["login_id"].ToString())) {
                e.Cancel = true;
                Util.Alert(this, "คุณไม่มีสิทธิใช้งานในส่วนนี้");
            }
        }

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e) {
            Util.RunScript(this, "$(function () { foggle('3'); });");
        }
    }
}