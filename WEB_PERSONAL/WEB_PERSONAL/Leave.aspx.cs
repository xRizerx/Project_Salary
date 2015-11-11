using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.OracleClient;
using System.Globalization;
using System.Drawing;

namespace WEB_PERSONAL {
    public partial class Leave : System.Web.UI.Page {
        //pull from paper_id

        private string toDate(String str) {
            string[] paper_date_s = str.Split('/');
            int paper_date_y = Convert.ToInt32(paper_date_s[2]) - 543;
            return paper_date_y + paper_date_s[1] + paper_date_s[0];
        }

        //save - update
        protected void LinkButton13_Click(object sender, EventArgs e) {
            //try {
            using (OracleConnection con = Util.OC()) {
                {
                    string sql = "UPDATE TB_LEAVE SET PAPER_ID = :1, PAPER_DATE = :2, CITIZEN_ID = :3, LEAVE_TYPE_ID = :4, LEAVE_FROM_DATE = :5, LEAVE_TO_DATE = :6, LEAVE_STATUS_ID = :7, APPROVER_ID = :8, APPROVE_DATE = :9, REASON = :10 WHERE PAPER_ID = :1";
                    using (OracleCommand command = new OracleCommand(sql, con)) {
                        command.Parameters.AddWithValue("1", Label33.Text);
                        command.Parameters.AddWithValue("2", Util.toOracleDateTime(TextBox2.Text));
                        command.Parameters.AddWithValue("3", TextBox3.Text);
                        command.Parameters.AddWithValue("4", DropDownList1.SelectedValue);
                        command.Parameters.AddWithValue("5", Util.toOracleDateTime(TextBox5.Text));
                        command.Parameters.AddWithValue("6", Util.toOracleDateTime(TextBox6.Text));
                        command.Parameters.AddWithValue("7", DropDownList2.SelectedValue);
                        command.Parameters.AddWithValue("8", TextBox8.Text);
                        command.Parameters.AddWithValue("9", Util.toOracleDateTime(TextBox9.Text));
                        command.Parameters.AddWithValue("10", TextBox10.Text);
                        command.ExecuteNonQuery();
                        Util.Alert(this, "บันทึกสำเร็จ!");
                    }
                }
            }
            //} catch (Exception e2) {
            // string script = "alert(\"เกิดข้อผิดพลาด! " + e2.Message + "\");";
            // ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            //}
        }

        protected void Button1_Click(object sender, EventArgs e) {
            double d = 1234.5678;
            d = RoundUp(d);
            string script2 = "alert(\"" + d + "\");";
            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script2, true);
        }

        int RoundUp(double i) {
            int j = Convert.ToInt32(i);
            return (10 - j % 10) + j;
        }

        protected void LinkButton14_Click(object sender, EventArgs e) {

            try {
                using (OracleConnection con = Util.OC()) {
                    {
                        string sql = "SELECT STF_NAME || ' ' || STF_LNAME FROM TB_PERSONAL WHERE CITIZEN_ID = '" + TextBox3.Text + "'";
                        using (OracleCommand command = new OracleCommand(sql, con)) {
                            using (OracleDataReader reader = command.ExecuteReader()) {
                                if (reader.HasRows) {
                                    while (reader.Read()) {
                                        Label31.Text = reader.GetString(0);
                                    }
                                } else {
                                    string script2 = "alert('ไม่พบรหัสพนักงาน!');";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script2, true);
                                }

                            }


                        }
                    }
                }
            } catch (Exception e2) {
                string script = "alert(\"เกิดข้อผิดพลาด! " + e2.Message + "\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void LinkButton15_Click(object sender, EventArgs e) {
            try {
                using (OracleConnection con = Util.OC()) {
                    con.Open();
                    {
                        string sql = "SELECT STF_NAME || ' ' || STF_LNAME FROM TB_PERSONAL WHERE CITIZEN_ID = '" + TextBox8.Text + "'";
                        using (OracleCommand command = new OracleCommand(sql, con)) {
                            using (OracleDataReader reader = command.ExecuteReader()) {
                                if (reader.HasRows) {
                                    while (reader.Read()) {
                                        Label32.Text = reader.GetString(0);
                                    }
                                } else {
                                    string script2 = "alert('ไม่พบรหัสพนักงาน!');";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script2, true);
                                }

                            }


                        }
                    }
                }
            } catch (Exception e2) {
                string script = "alert(\"เกิดข้อผิดพลาด! " + e2.Message + "\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e) {
            Response.Redirect("Leave-Report1.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e) {
            string sql = "select citizen_id, stf_name || stf_lname as \"x\" from tb_personal";

            GridView1.AutoGenerateColumns = false;
            GridView1.Controls.Clear();
            GridView1.Columns.Clear();
            {
                BoundField test = new BoundField();
                test.DataField = "CITIZEN_ID";
                test.HeaderText = "CITIZEN ID";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "x";
                test.HeaderText = "กำ";
                GridView1.Columns.Add(test);
            }
            SqlDataSource sds = new SqlDataSource("System.Data.OracleClient", "DATA SOURCE=ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm;", sql);
            GridView1.DataSource = sds;
            GridView1.DataBind();
        }



        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e) {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e) {
            pullSql("select tb_leave.PAPER_ID as 'รหัสเอกสาร',tb_leave.PAPER_DATE as 'PAPER_DATE',tb_leave.CITIZEN_ID as 'CITIZEN_ID',a.stf_name + ' ' + a.STF_LNAME as 'STF_NAME',tb_leave_type.LEAVE_TYPE_NAME as 'LEAVE_TYPE_NAME',tb_leave.LEAVE_FROM_DATE as 'LEAVE_FROM_DATE',tb_leave.LEAVE_TO_DATE as 'LEAVE_TO_DATE',TB_LEAVE_STATUS.LEAVE_STATUS_NAME as 'LEAVE_STATUS',TB_LEAVE.APPROVER_ID as 'APPROVER_ID',b.stf_name + ' ' + b.STF_LNAME as 'STF_NAME2',TB_LEAVE.APPROVE_DATE as 'APPROVE_DATE',TB_LEAVE.REASON as 'REASON' from tb_personal a,tb_personal b,tb_leave,tb_leave_type,TB_LEAVE_STATUS where tb_leave.LEAVE_TYPE_ID = TB_LEAVE_TYPE.LEAVE_TYPE_ID AND TB_LEAVE.LEAVE_STATUS_ID = TB_LEAVE_STATUS.LEAVE_STATUS_ID AND a.CITIZEN_ID = tb_leave.CITIZEN_ID AND b.CITIZEN_ID = tb_leave.APPROVER_ID AND tb_leave.leave_status_id = 1 order by tb_leave.paper_id desc;");
        }

        private void pullSql(string sql) {

            GridView1.AutoGenerateColumns = false;
            GridView1.Controls.Clear();
            GridView1.Columns.Clear();
            {
                BoundField test = new BoundField();
                test.DataField = "PAPER_ID";
                test.HeaderText = "รหัสเอกสาร";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "PAPER_DATE";
                test.HeaderText = "วันที่เอกสาร";
                test.DataFormatString = "{0:dd/MM/yyyy}";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "CITIZEN_ID";
                test.HeaderText = "รหัสผู้ลา";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "STF_NAME";
                test.HeaderText = "ชื่อผู้ลา";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "LEAVE_TYPE_NAME";
                test.HeaderText = "ประเภท";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "LEAVE_FROM_DATE";
                test.HeaderText = "จากวันที่";
                test.DataFormatString = "{0:dd/MM/yyyy}";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "LEAVE_TO_DATE";
                test.HeaderText = "ถึงวันที่";
                test.DataFormatString = "{0:dd/MM/yyyy}";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "LEAVE_STATUS_NAME";
                test.HeaderText = "สถานะ";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "APPROVER_ID";
                test.HeaderText = "รหัสผู้อนุมัติ";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "STF_NAME2";
                test.HeaderText = "ชื่อผู้อนุมัติ";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "APPROVE_DATE";
                test.HeaderText = "วันที่อนุมัติ";
                test.DataFormatString = "{0:dd/MM/yyyy}";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "REASON";
                test.HeaderText = "เหตุผล";
                GridView1.Columns.Add(test);
            }

            SqlDataSource sds = new SqlDataSource("System.Data.OracleClient","DATA SOURCE=ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm;", sql);
            GridView1.DataSource = sds;
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e) {
            pullSql("select tb_leave.PAPER_ID as 'รหัสเอกสาร',tb_leave.PAPER_DATE as 'วันที่เอกสาร',tb_leave.CITIZEN_ID as 'รหัสผู้ลา',a.stf_name + ' ' + a.STF_LNAME as 'ชื่อผู้ลา',tb_leave_type.LEAVE_TYPE_NAME as 'ประเภท',tb_leave.LEAVE_FROM_DATE as 'จากวันที่',tb_leave.LEAVE_TO_DATE as 'ถึงวันที่',TB_LEAVE_STATUS.LEAVE_STATUS_NAME as 'สถานะ',TB_LEAVE.APPROVER_ID as 'รหัสผู้อนุมัติ',b.stf_name + ' ' + b.STF_LNAME as 'ชื่อผู้อนุมัติ',TB_LEAVE.APPROVE_DATE as 'วันที่อนุมัติ',TB_LEAVE.REASON as 'เหตุผล' from tb_personal a,tb_personal b,tb_leave,tb_leave_type,TB_LEAVE_STATUS where tb_leave.LEAVE_TYPE_ID = TB_LEAVE_TYPE.LEAVE_TYPE_ID AND TB_LEAVE.LEAVE_STATUS_ID = TB_LEAVE_STATUS.LEAVE_STATUS_ID AND a.CITIZEN_ID = tb_leave.CITIZEN_ID AND b.CITIZEN_ID = tb_leave.APPROVER_ID AND tb_leave.leave_status_id = 2 order by tb_leave.paper_id desc;");
        }

        protected void Button5_Click(object sender, EventArgs e) {
            pullSql("select tb_leave.PAPER_ID as 'รหัสเอกสาร',tb_leave.PAPER_DATE as 'วันที่เอกสาร',tb_leave.CITIZEN_ID as 'รหัสผู้ลา',a.stf_name + ' ' + a.STF_LNAME as 'ชื่อผู้ลา',tb_leave_type.LEAVE_TYPE_NAME as 'ประเภท',tb_leave.LEAVE_FROM_DATE as 'จากวันที่',tb_leave.LEAVE_TO_DATE as 'ถึงวันที่',TB_LEAVE_STATUS.LEAVE_STATUS_NAME as 'สถานะ',TB_LEAVE.APPROVER_ID as 'รหัสผู้อนุมัติ',b.stf_name + ' ' + b.STF_LNAME as 'ชื่อผู้อนุมัติ',TB_LEAVE.APPROVE_DATE as 'วันที่อนุมัติ',TB_LEAVE.REASON as 'เหตุผล' from tb_personal a,tb_personal b,tb_leave,tb_leave_type,TB_LEAVE_STATUS where tb_leave.LEAVE_TYPE_ID = TB_LEAVE_TYPE.LEAVE_TYPE_ID AND TB_LEAVE.LEAVE_STATUS_ID = TB_LEAVE_STATUS.LEAVE_STATUS_ID AND a.CITIZEN_ID = tb_leave.CITIZEN_ID AND b.CITIZEN_ID = tb_leave.APPROVER_ID AND tb_leave.leave_status_id = 3 order by tb_leave.paper_id desc;");
        }

        protected void LinkButton7_Click(object sender, EventArgs e) {
            if (TextBox4.Text == "") {
                string script = "alert('กรุณาป้อนข้อมูล!');";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            } else {
                pullSql("select tb_leave.PAPER_ID as 'รหัสเอกสาร',tb_leave.PAPER_DATE as 'วันที่เอกสาร',tb_leave.CITIZEN_ID as 'รหัสผู้ลา',a.stf_name + ' ' + a.STF_LNAME as 'ชื่อผู้ลา',tb_leave_type.LEAVE_TYPE_NAME as 'ประเภท',tb_leave.LEAVE_FROM_DATE as 'จากวันที่',tb_leave.LEAVE_TO_DATE as 'ถึงวันที่',TB_LEAVE_STATUS.LEAVE_STATUS_NAME as 'สถานะ',TB_LEAVE.APPROVER_ID as 'รหัสผู้อนุมัติ',b.stf_name + ' ' + b.STF_LNAME as 'ชื่อผู้อนุมัติ',TB_LEAVE.APPROVE_DATE as 'วันที่อนุมัติ',TB_LEAVE.REASON as 'เหตุผล' from tb_personal a,tb_personal b,tb_leave,tb_leave_type,TB_LEAVE_STATUS where tb_leave.LEAVE_TYPE_ID = TB_LEAVE_TYPE.LEAVE_TYPE_ID AND TB_LEAVE.LEAVE_STATUS_ID = TB_LEAVE_STATUS.LEAVE_STATUS_ID AND a.CITIZEN_ID = tb_leave.CITIZEN_ID AND b.CITIZEN_ID = tb_leave.APPROVER_ID AND tb_leave.CITIZEN_ID = '" + TextBox4.Text + "' order by tb_leave.paper_id desc;");
            }

        }

        protected void LinkButton8_Click(object sender, EventArgs e) {
            pullSql("select tb_leave.PAPER_ID as 'รหัสเอกสาร',tb_leave.PAPER_DATE as 'วันที่เอกสาร',tb_leave.CITIZEN_ID as 'รหัสผู้ลา',a.stf_name + ' ' + a.STF_LNAME as 'ชื่อผู้ลา',tb_leave_type.LEAVE_TYPE_NAME as 'ประเภท',tb_leave.LEAVE_FROM_DATE as 'จากวันที่',tb_leave.LEAVE_TO_DATE as 'ถึงวันที่',TB_LEAVE_STATUS.LEAVE_STATUS_NAME as 'สถานะ',TB_LEAVE.APPROVER_ID as 'รหัสผู้อนุมัติ',b.stf_name + ' ' + b.STF_LNAME as 'ชื่อผู้อนุมัติ',TB_LEAVE.APPROVE_DATE as 'วันที่อนุมัติ',TB_LEAVE.REASON as 'เหตุผล' from tb_personal a,tb_personal b,tb_leave,tb_leave_type,TB_LEAVE_STATUS where tb_leave.LEAVE_TYPE_ID = TB_LEAVE_TYPE.LEAVE_TYPE_ID AND TB_LEAVE.LEAVE_STATUS_ID = TB_LEAVE_STATUS.LEAVE_STATUS_ID AND a.CITIZEN_ID = tb_leave.CITIZEN_ID AND b.CITIZEN_ID = tb_leave.APPROVER_ID AND tb_leave.APPROVER_ID = '" + TextBox7.Text + "' order by tb_leave.paper_id desc;");
        }

        protected void LinkButton9_Click(object sender, EventArgs e) {
            pullSql("select tb_leave.PAPER_ID as 'รหัสเอกสาร',tb_leave.PAPER_DATE as 'วันที่เอกสาร',tb_leave.CITIZEN_ID as 'รหัสผู้ลา',a.stf_name + ' ' + a.STF_LNAME as 'ชื่อผู้ลา',tb_leave_type.LEAVE_TYPE_NAME as 'ประเภท',tb_leave.LEAVE_FROM_DATE as 'จากวันที่',tb_leave.LEAVE_TO_DATE as 'ถึงวันที่',TB_LEAVE_STATUS.LEAVE_STATUS_NAME as 'สถานะ',TB_LEAVE.APPROVER_ID as 'รหัสผู้อนุมัติ',b.stf_name + ' ' + b.STF_LNAME as 'ชื่อผู้อนุมัติ',TB_LEAVE.APPROVE_DATE as 'วันที่อนุมัติ',TB_LEAVE.REASON as 'เหตุผล' from tb_personal a,tb_personal b,tb_leave,tb_leave_type,TB_LEAVE_STATUS where tb_leave.LEAVE_TYPE_ID = TB_LEAVE_TYPE.LEAVE_TYPE_ID AND TB_LEAVE.LEAVE_STATUS_ID = TB_LEAVE_STATUS.LEAVE_STATUS_ID AND a.CITIZEN_ID = tb_leave.CITIZEN_ID AND b.CITIZEN_ID = tb_leave.APPROVER_ID AND a.STF_NAME like '%" + TextBox12.Text + "%' order by tb_leave.paper_id desc;");
        }

        protected void LinkButton10_Click(object sender, EventArgs e) {
            pullSql("select tb_leave.PAPER_ID as 'รหัสเอกสาร',tb_leave.PAPER_DATE as 'วันที่เอกสาร',tb_leave.CITIZEN_ID as 'รหัสผู้ลา',a.stf_name + ' ' + a.STF_LNAME as 'ชื่อผู้ลา',tb_leave_type.LEAVE_TYPE_NAME as 'ประเภท',tb_leave.LEAVE_FROM_DATE as 'จากวันที่',tb_leave.LEAVE_TO_DATE as 'ถึงวันที่',TB_LEAVE_STATUS.LEAVE_STATUS_NAME as 'สถานะ',TB_LEAVE.APPROVER_ID as 'รหัสผู้อนุมัติ',b.stf_name + ' ' + b.STF_LNAME as 'ชื่อผู้อนุมัติ',TB_LEAVE.APPROVE_DATE as 'วันที่อนุมัติ',TB_LEAVE.REASON as 'เหตุผล' from tb_personal a,tb_personal b,tb_leave,tb_leave_type,TB_LEAVE_STATUS where tb_leave.LEAVE_TYPE_ID = TB_LEAVE_TYPE.LEAVE_TYPE_ID AND TB_LEAVE.LEAVE_STATUS_ID = TB_LEAVE_STATUS.LEAVE_STATUS_ID AND a.CITIZEN_ID = tb_leave.CITIZEN_ID AND b.CITIZEN_ID = tb_leave.APPROVER_ID AND b.STF_NAME like '%" + TextBox14.Text + "%' order by tb_leave.paper_id desc;");
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e) {
            pullSql("select tb_leave.PAPER_ID as 'รหัสเอกสาร',tb_leave.PAPER_DATE as 'วันที่เอกสาร',tb_leave.CITIZEN_ID as 'รหัสผู้ลา',a.stf_name + ' ' + a.STF_LNAME as 'ชื่อผู้ลา',tb_leave_type.LEAVE_TYPE_NAME as 'ประเภท',tb_leave.LEAVE_FROM_DATE as 'จากวันที่',tb_leave.LEAVE_TO_DATE as 'ถึงวันที่',TB_LEAVE_STATUS.LEAVE_STATUS_NAME as 'สถานะ',TB_LEAVE.APPROVER_ID as 'รหัสผู้อนุมัติ',b.stf_name + ' ' + b.STF_LNAME as 'ชื่อผู้อนุมัติ',TB_LEAVE.APPROVE_DATE as 'วันที่อนุมัติ',TB_LEAVE.REASON as 'เหตุผล' from tb_personal a,tb_personal b,tb_leave,tb_leave_type,TB_LEAVE_STATUS where tb_leave.LEAVE_TYPE_ID = TB_LEAVE_TYPE.LEAVE_TYPE_ID AND TB_LEAVE.LEAVE_STATUS_ID = TB_LEAVE_STATUS.LEAVE_STATUS_ID AND a.CITIZEN_ID = tb_leave.CITIZEN_ID AND b.CITIZEN_ID = tb_leave.APPROVER_ID AND tb_leave.leave_type_id = " + DropDownList4.SelectedValue + " order by tb_leave.paper_id desc;");
        }

        protected void Button1_Click2(object sender, EventArgs e) {
            try {

                using (OracleConnection con = Util.OC()) {
                    {
                        string sql = "SELECT STF_NAME || ' ' || STF_LNAME FROM TB_PERSONAL WHERE CITIZEN_ID = '" + TextBox16.Text + "'";
                        using (OracleCommand command = new OracleCommand(sql, con)) {
                            using (OracleDataReader reader = command.ExecuteReader()) {
                                if (reader.HasRows) {
                                    reader.Read();
                                    Label24.Text = reader.GetString(0);
                                    Label24.ForeColor = Color.Black;
                                } else {
                                    Label24.Text = "ไม่พบรหัสพนักงาน";
                                    Label24.ForeColor = Color.Red;
                                    //string script2 = "alert('ไม่พบรหัสพนักงาน!');";
                                    //ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script2, true);
                                }

                            }


                        }
                    }
                }
            } catch (Exception e2) {
                string script = "alert(\"เกิดข้อผิดพลาด! " + e2.Message + "\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void LinkButton16_Click(object sender, EventArgs e) {

            if (Session["login_id"] == null) {
                Util.Alert(this, "กรุณาเข้าสู่ระบบก่อน");
                return;
            }

            // try {
            using (OracleConnection con = new OracleConnection("DATA SOURCE=ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm;")) {
                con.Open();
                {
                    string sql = "INSERT INTO TB_LEAVE VALUES(SEQ_LEAVE_ID.NEXTVAL,:2,:3,:4,:5,:6,:7,:8,:9,:10)";

                    using (OracleCommand command = new OracleCommand(sql, con)) {
                        //command.Parameters.AddWithValue("1", "SEQ_LEAVE_ID.NEXTVAL");
                        command.Parameters.AddWithValue("2", Util.toOracleDateTime(DateTime.Today.AddYears(-543)));
                        command.Parameters.AddWithValue("3", TextBox16.Text);
                        command.Parameters.AddWithValue("4", DropDownList5.SelectedValue);
                        command.Parameters.AddWithValue("5", Util.toOracleDateTime(TextBox17.Text));
                        command.Parameters.AddWithValue("6", Util.toOracleDateTime(TextBox18.Text));
                        command.Parameters.AddWithValue("7", DropDownList6.SelectedValue);
                        command.Parameters.AddWithValue("8", Session["login_id"].ToString());
                        command.Parameters.AddWithValue("9", Util.toOracleDateTime(DateTime.Today.AddYears(-543)));
                        command.Parameters.AddWithValue("10", TextBox19.Text);

                        command.ExecuteNonQuery();
                        Util.Alert(this, "เพิ่มข้อมูลสำเร็จ!");
                    }
                }




            }
            //} catch (Exception e2) {
            //    Util.Alert(this,"เกิดข้อผิดพลาด! " + e2.Message);
            //}

        }

        //pull paper from id
        protected void LinkButton18_Click(object sender, EventArgs e) {
            Label20.Text = "";
            if (TextBox15.Text == "") {
                Label20.Text = "กรุณากรอกรหัสเอกสาร!";
                return;
            }

            //try {
            using (OracleConnection con = Util.OC()) {
                {
                    using (OracleCommand command = new OracleCommand(
                    "SELECT COUNT(*) FROM TB_LEAVE WHERE PAPER_ID = " + TextBox15.Text, con))
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            if (reader.GetInt32(0) == 0) {
                                Label20.Text = "ไม่พบรหัสเอกสาร!";
                                return;
                            }
                        }
                    }
                }

                {
                    using (OracleCommand command = new OracleCommand(
                    "SELECT TB_LEAVE.Leave_type_id, TB_PERSONAL.CITIZEN_ID, TB_PERSONAL.STF_NAME, TB_PERSONAL.STF_LNAME, NVL(TB_LEAVE.Reason,''), TO_CHAR(TB_LEAVE.LEAVE_FROM_DATE,'dd MON yyyy','NLS_DATE_LANGUAGE = THAI'), TO_CHAR(TB_LEAVE.LEAVE_TO_DATE,'dd MON yyyy','NLS_DATE_LANGUAGE = THAI'), TO_CHAR(TB_LEAVE.PAPER_DATE,'dd MON yyyy','NLS_DATE_LANGUAGE = THAI'), TB_LEAVE.LEAVE_STATUS_ID, TB_LEAVE.PAPER_ID FROM TB_LEAVE, TB_PERSONAL WHERE TB_LEAVE.PAPER_ID = " + TextBox15.Text + " AND TB_PERSONAL.CITIZEN_ID = TB_LEAVE.CITIZEN_ID", con))
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            DropDownList1.SelectedValue = reader.GetInt32(0).ToString();
                            TextBox3.Text = reader.GetString(1);
                            Label31.Text = reader.GetString(2) + " " + reader.GetString(3);
                            TextBox10.Text = reader.IsDBNull(4) ? "" : reader.GetString(4);
                            TextBox5.Text = reader.GetString(5);
                            TextBox6.Text = reader.GetString(6);
                            TextBox2.Text = reader.GetString(7);
                            DropDownList2.SelectedValue = reader.GetInt32(8).ToString();
                            Label33.Text = "" + reader.GetInt32(9);
                        }
                    }
                }

                {
                    using (OracleCommand command = new OracleCommand(
                    "SELECT TB_LEAVE.APPROVER_ID, TB_PERSONAL.STF_NAME, TB_PERSONAL.STF_LNAME, TO_CHAR(TB_LEAVE.APPROVE_DATE,'dd MON yyyy','NLS_DATE_LANGUAGE = THAI') FROM TB_LEAVE, TB_PERSONAL WHERE TB_LEAVE.PAPER_ID = " + TextBox15.Text + " AND TB_PERSONAL.CITIZEN_ID = TB_LEAVE.APPROVER_ID", con))
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            TextBox8.Text = reader.GetString(0);
                            Label32.Text = reader.GetString(1) + " " + reader.GetString(2);
                            TextBox9.Text = reader.GetString(3);
                        }
                    }
                }

            }


            //} catch (Exception e2) {
            //   string script = "alert(\"เกิดข้อผิดพลาด! " + e2.Message + "\");";
            //   ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            // }

        }

        protected void LinkButton3_Click(object sender, EventArgs e) {
            pullSql("select tb_leave.PAPER_ID as \"PAPER_ID\",tb_leave.PAPER_DATE as \"PAPER_DATE\",tb_leave.CITIZEN_ID as \"CITIZEN_ID\",a.stf_name || ' ' || a.STF_LNAME as \"STF_NAME\",tb_leave_type.LEAVE_TYPE_NAME as \"LEAVE_TYPE_NAME\",tb_leave.LEAVE_FROM_DATE as \"LEAVE_FROM_DATE\",tb_leave.LEAVE_TO_DATE as \"LEAVE_TO_DATE\",TB_LEAVE_STATUS.LEAVE_STATUS_NAME as \"LEAVE_STATUS_NAME\",TB_LEAVE.APPROVER_ID as \"APPROVER_ID\",b.stf_name || ' ' || b.STF_LNAME as \"STF_NAME2\",TB_LEAVE.APPROVE_DATE as \"APPROVE_DATE\",TB_LEAVE.REASON as \"REASON\" from tb_personal a,tb_personal b,tb_leave,tb_leave_type,TB_LEAVE_STATUS where tb_leave.LEAVE_TYPE_ID = TB_LEAVE_TYPE.LEAVE_TYPE_ID AND TB_LEAVE.LEAVE_STATUS_ID = TB_LEAVE_STATUS.LEAVE_STATUS_ID AND a.CITIZEN_ID = tb_leave.CITIZEN_ID AND b.CITIZEN_ID = tb_leave.APPROVER_ID order by tb_leave.paper_id desc");
        }

        protected void LinkButton20_Click(object sender, EventArgs e) {
            try {

                using (OracleConnection con = Util.OC()) {
                    {
                        string sql = "SELECT STF_NAME || ' ' || STF_LNAME FROM TB_PERSONAL WHERE CITIZEN_ID = '" + TextBox21.Text + "'";
                        using (OracleCommand command = new OracleCommand(sql, con)) {
                            using (OracleDataReader reader = command.ExecuteReader()) {
                                if (reader.HasRows) {
                                    reader.Read();
                                    Label45.Text = reader.GetString(0);
                                    Label45.ForeColor = Color.Black;
                                } else {
                                    Label45.Text = "ไม่พบรหัสพนักงาน";
                                    Label45.ForeColor = Color.Red;
                                    //string script2 = "alert('ไม่พบรหัสพนักงาน!');";
                                    //ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script2, true);
                                }

                            }


                        }
                    }
                }
            } catch (Exception e2) {
                string script = "alert(\"เกิดข้อผิดพลาด! " + e2.Message + "\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void LinkButton11_Click(object sender, EventArgs e) {
            if (Session["login_id"] == null) {
                Util.Alert(this, "กรุณาเข้าสู่ระบบก่อน");
                return;
            }

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
            

            try {
            using (OracleConnection con = new OracleConnection("DATA SOURCE=ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm;")) {
                con.Open();
                {
                    string sql = "INSERT INTO TB_WORK_CHECK_IN VALUES(SEQ_WORK_CHECK_IN_ID.NEXTVAL,:1,:2,:3,:4,:5,:6)";

                    using (OracleCommand command = new OracleCommand(sql, con)) {
                        command.Parameters.AddWithValue("1", Util.toOracleDateTime(TextBox11.Text));
                        command.Parameters.AddWithValue("2", TextBox21.Text);
                        command.Parameters.AddWithValue("3", TextBox22.Text);
                        command.Parameters.AddWithValue("4", TextBox23.Text);
                        command.Parameters.AddWithValue("5", TextBox24.Text);
                        command.Parameters.AddWithValue("6", TextBox25.Text);
                        command.ExecuteNonQuery();
                        Util.Alert(this, "เพิ่มข้อมูลสำเร็จ!");
                    }
                }
            }
            } catch (Exception e2) {
                Util.Alert(this,"เกิดข้อผิดพลาด! " + e2.Message);
            }
        }

        protected void LinkButton21_Click(object sender, EventArgs e) {
            GridView2.AutoGenerateColumns = false;
            GridView2.Controls.Clear();
            GridView2.Columns.Clear();
            {
                BoundField test = new BoundField();
                test.DataField = "ID";
                test.HeaderText = "รหัส";
                GridView2.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "DDATE";
                test.HeaderText = "วันที่";
                GridView2.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "CITIZEN_ID";
                test.HeaderText = "รหัสพนักงาน";
                GridView2.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "NAME";
                test.HeaderText = "ชื่อพนักงาน";
                GridView2.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "TIME_IN";
                test.HeaderText = "เวลาเข้า";
                GridView2.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "TIME_OUT";
                test.HeaderText = "เวลาออก";
                GridView2.Columns.Add(test);
            }
           
            SqlDataSource sds = new SqlDataSource("System.Data.OracleClient", "DATA SOURCE=ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm;", "select tb_work_check_in.id , to_char(tb_work_check_in.ddate,'dd mon yyyy','NLS_DATE_LANGUAGE=THAI') as \"ddate\", tb_work_check_in.citizen_id, tb_personal.stf_name || ' ' || tb_personal.stf_lname as \"name\", tb_work_check_in.hour_in || ':' || tb_work_check_in.minute_in as \"time_in\", tb_work_check_in.hour_out || ':' || tb_work_check_in.minute_out as \"time_out\" from tb_work_check_in, tb_personal where tb_work_check_in.citizen_id = tb_personal.citizen_id");
            GridView2.DataSource = sds;
            GridView2.DataBind();

            //Util.Alert(this, GridView2.Rows[1].Cells[5].Controls.Count + "");

        }

        protected void LinkButton1_Click1(object sender, EventArgs e) {
            GridView3.AutoGenerateColumns = false;
            GridView3.AllowPaging = true;
            
            GridView3.Controls.Clear();
            GridView3.Columns.Clear();
            {
                BoundField test = new BoundField();
                test.DataField = "ID";
                test.HeaderText = "รหัส";
                GridView3.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "DDATE";
                test.HeaderText = "วันที่";
                GridView3.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "CITIZEN_ID";
                test.HeaderText = "รหัสพนักงาน";
                GridView3.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "NAME";
                test.HeaderText = "ชื่อพนักงาน";
                GridView3.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "TIME_IN";
                test.HeaderText = "เวลาเข้า";
                GridView3.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "TIME_OUT";
                test.HeaderText = "เวลาออก";
                GridView3.Columns.Add(test);
            }

            SqlDataSource sds = new SqlDataSource("System.Data.OracleClient", "DATA SOURCE=ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm;", "select tb_work_check_in.id , to_char(tb_work_check_in.ddate,'dd mon yyyy','NLS_DATE_LANGUAGE=THAI') as \"ddate\", tb_work_check_in.citizen_id, tb_personal.stf_name || ' ' || tb_personal.stf_lname as \"name\", tb_work_check_in.hour_in || ':' || tb_work_check_in.minute_in as \"time_in\", tb_work_check_in.hour_out || ':' || tb_work_check_in.minute_out as \"time_out\" from tb_work_check_in, tb_personal where tb_work_check_in.citizen_id = tb_personal.citizen_id AND tb_work_check_in.hour_in*60 + tb_work_check_in.minute_in > 510");
            GridView3.DataSource = sds;
            GridView3.DataBind();
        }
    }
}