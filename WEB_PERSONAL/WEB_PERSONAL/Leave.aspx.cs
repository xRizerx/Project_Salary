﻿using System;
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

        protected void Page_Load(object sender, EventArgs e) {

        }

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
                        command.Parameters.AddWithValue("2", Util.ODT(TextBox2.Text));
                        command.Parameters.AddWithValue("3", TextBox3.Text);
                        command.Parameters.AddWithValue("4", DropDownList1.SelectedValue);
                        command.Parameters.AddWithValue("5", Util.ODT(TextBox5.Text));
                        command.Parameters.AddWithValue("6", Util.ODT(TextBox6.Text));
                        command.Parameters.AddWithValue("7", DropDownList2.SelectedValue);
                        command.Parameters.AddWithValue("8", TextBox8.Text);
                        command.Parameters.AddWithValue("9", Util.ODT(TextBox9.Text));
                        command.Parameters.AddWithValue("10", TextBox10.Text);
                        command.ExecuteNonQuery();
                        Util.Alert(this, "บันทึกสำเร็จ!");
                        GridView2.DataBind();
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
                        string sql = "SELECT PERSON_NAME || ' ' || PERSON_LASTNAME FROM TB_PERSON WHERE CITIZEN_ID = '" + TextBox3.Text + "'";
                        using (OracleCommand command = new OracleCommand(sql, con)) {
                            using (OracleDataReader reader = command.ExecuteReader()) {
                                if (reader.HasRows) {
                                    while (reader.Read()) {
                                        Label31.Text = reader.GetString(0);
                                    }
                                } else {
                                    Util.Alert(this, "ไม่พบรหัสพนักงาน!");
                                }

                            }


                        }
                    }
                }
            } catch (Exception e2) {
                Util.Alert(this, "เกิดข้อผิดพลาด!" + e2.Message);
            }
        }

        protected void LinkButton15_Click(object sender, EventArgs e) {
            try {
                using (OracleConnection con = Util.OC()) {
                    {
                        string sql = "SELECT PERSON_NAME || ' ' || PERSON_LASTNAME FROM TB_PERSON WHERE CITIZEN_ID = '" + TextBox8.Text + "'";
                        using (OracleCommand command = new OracleCommand(sql, con)) {
                            using (OracleDataReader reader = command.ExecuteReader()) {
                                if (reader.HasRows) {
                                    while (reader.Read()) {
                                        Label32.Text = reader.GetString(0);
                                    }
                                } else {
                                    Util.Alert(this, "ไม่พบรหัสพนักงาน!");
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

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e) {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
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

            SqlDataSource sds = new SqlDataSource("System.Data.OracleClient", "DATA SOURCE=ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm;", sql);
            GridView1.DataSource = sds;
            GridView1.DataBind();
        }


        protected void LinkButton7_Click(object sender, EventArgs e) {
            if (TextBox4.Text == "") {
                Util.Alert(this, "กรุณาป้อนข้อมูล!");
            } else {
                pullSql("select tb_leave.PAPER_ID as \"PAPER_ID\",TO_CHAR(tb_leave.PAPER_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"PAPER_DATE\",tb_leave.CITIZEN_ID as \"CITIZEN_ID\",a.PERSON_NAME || ' ' || a.PERSON_LASTNAME as \"STF_NAME\",tb_leave_type.LEAVE_TYPE_NAME as \"LEAVE_TYPE_NAME\",TO_CHAR(tb_leave.LEAVE_FROM_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"LEAVE_FROM_DATE\",TO_CHAR(tb_leave.LEAVE_TO_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"LEAVE_TO_DATE\",TB_LEAVE_STATUS.LEAVE_STATUS_NAME as \"LEAVE_STATUS_NAME\",TB_LEAVE.APPROVER_ID as \"APPROVER_ID\",b.PERSON_NAME || ' ' || b.PERSON_LASTNAME as \"STF_NAME2\",TO_CHAR(tb_leave.APPROVE_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"APPROVE_DATE\",TB_LEAVE.REASON as \"REASON\" from tb_person a,tb_person b,tb_leave,tb_leave_type,TB_LEAVE_STATUS where tb_leave.LEAVE_TYPE_ID = TB_LEAVE_TYPE.LEAVE_TYPE_ID AND TB_LEAVE.LEAVE_STATUS_ID = TB_LEAVE_STATUS.LEAVE_STATUS_ID AND a.CITIZEN_ID = tb_leave.CITIZEN_ID AND b.CITIZEN_ID = tb_leave.APPROVER_ID AND tb_leave.CITIZEN_ID = '" + TextBox4.Text + "' order by tb_leave.paper_id desc");
            }

        }

        protected void LinkButton8_Click(object sender, EventArgs e) {
            if (TextBox7.Text == "") {
                Util.Alert(this, "กรุณาป้อนข้อมูล!");
            } else {
                pullSql("select tb_leave.PAPER_ID as \"PAPER_ID\",TO_CHAR(tb_leave.PAPER_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"PAPER_DATE\",tb_leave.CITIZEN_ID as \"CITIZEN_ID\",a.PERSON_NAME || ' ' || a.PERSON_LASTNAME as \"STF_NAME\",tb_leave_type.LEAVE_TYPE_NAME as \"LEAVE_TYPE_NAME\",TO_CHAR(tb_leave.LEAVE_FROM_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"LEAVE_FROM_DATE\",TO_CHAR(tb_leave.LEAVE_TO_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"LEAVE_TO_DATE\",TB_LEAVE_STATUS.LEAVE_STATUS_NAME as \"LEAVE_STATUS_NAME\",TB_LEAVE.APPROVER_ID as \"APPROVER_ID\",b.PERSON_NAME || ' ' || b.PERSON_LASTNAME as \"STF_NAME2\",TO_CHAR(tb_leave.APPROVE_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"APPROVE_DATE\",TB_LEAVE.REASON as \"REASON\" from tb_person a,tb_person b,tb_leave,tb_leave_type,TB_LEAVE_STATUS where tb_leave.LEAVE_TYPE_ID = TB_LEAVE_TYPE.LEAVE_TYPE_ID AND TB_LEAVE.LEAVE_STATUS_ID = TB_LEAVE_STATUS.LEAVE_STATUS_ID AND a.CITIZEN_ID = tb_leave.CITIZEN_ID AND b.CITIZEN_ID = tb_leave.APPROVER_ID AND tb_leave.APPROVER_ID = '" + TextBox7.Text + "' order by tb_leave.paper_id desc");
            }
        }

        protected void LinkButton9_Click(object sender, EventArgs e) {
            if (TextBox12.Text == "") {
                Util.Alert(this, "กรุณาป้อนข้อมูล!");
            } else {
                pullSql("select tb_leave.PAPER_ID as \"PAPER_ID\",TO_CHAR(tb_leave.PAPER_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"PAPER_DATE\",tb_leave.CITIZEN_ID as \"CITIZEN_ID\",a.PERSON_NAME || ' ' || a.PERSON_LASTNAME as \"STF_NAME\",tb_leave_type.LEAVE_TYPE_NAME as \"LEAVE_TYPE_NAME\",TO_CHAR(tb_leave.LEAVE_FROM_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"LEAVE_FROM_DATE\",TO_CHAR(tb_leave.LEAVE_TO_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"LEAVE_TO_DATE\",TB_LEAVE_STATUS.LEAVE_STATUS_NAME as \"LEAVE_STATUS_NAME\",TB_LEAVE.APPROVER_ID as \"APPROVER_ID\",b.PERSON_NAME || ' ' || b.PERSON_LASTNAME as \"STF_NAME2\",TO_CHAR(tb_leave.APPROVE_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"APPROVE_DATE\",TB_LEAVE.REASON as \"REASON\" from tb_person a,tb_person b,tb_leave,tb_leave_type,TB_LEAVE_STATUS where tb_leave.LEAVE_TYPE_ID = TB_LEAVE_TYPE.LEAVE_TYPE_ID AND TB_LEAVE.LEAVE_STATUS_ID = TB_LEAVE_STATUS.LEAVE_STATUS_ID AND a.CITIZEN_ID = tb_leave.CITIZEN_ID AND b.CITIZEN_ID = tb_leave.APPROVER_ID AND LOWER(a.PERSON_NAME) like '%" + TextBox12.Text.ToLower() + "%' order by tb_leave.paper_id desc");
            }
        }

        protected void LinkButton10_Click(object sender, EventArgs e) {
            if (TextBox14.Text == "") {
                Util.Alert(this, "กรุณาป้อนข้อมูล!");
            } else {
                pullSql("select tb_leave.PAPER_ID as \"PAPER_ID\",TO_CHAR(tb_leave.PAPER_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"PAPER_DATE\",tb_leave.CITIZEN_ID as \"CITIZEN_ID\",a.PERSON_NAME || ' ' || a.PERSON_LASTNAME as \"STF_NAME\",tb_leave_type.LEAVE_TYPE_NAME as \"LEAVE_TYPE_NAME\",TO_CHAR(tb_leave.LEAVE_FROM_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"LEAVE_FROM_DATE\",TO_CHAR(tb_leave.LEAVE_TO_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"LEAVE_TO_DATE\",TB_LEAVE_STATUS.LEAVE_STATUS_NAME as \"LEAVE_STATUS_NAME\",TB_LEAVE.APPROVER_ID as \"APPROVER_ID\",b.PERSON_NAME || ' ' || b.PERSON_LASTNAME as \"STF_NAME2\",TO_CHAR(tb_leave.APPROVE_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"APPROVE_DATE\",TB_LEAVE.REASON as \"REASON\" from tb_person a,tb_person b,tb_leave,tb_leave_type,TB_LEAVE_STATUS where tb_leave.LEAVE_TYPE_ID = TB_LEAVE_TYPE.LEAVE_TYPE_ID AND TB_LEAVE.LEAVE_STATUS_ID = TB_LEAVE_STATUS.LEAVE_STATUS_ID AND a.CITIZEN_ID = tb_leave.CITIZEN_ID AND b.CITIZEN_ID = tb_leave.APPROVER_ID AND LOWER(b.PERSON_NAME) like '%" + TextBox14.Text.ToLower() + "%' order by tb_leave.paper_id desc");
            }
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e) {
            if (DropDownList4.SelectedIndex != 0)
                pullSql("select tb_leave.PAPER_ID as \"PAPER_ID\",TO_CHAR(tb_leave.PAPER_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"PAPER_DATE\",tb_leave.CITIZEN_ID as \"CITIZEN_ID\",a.PERSON_NAME || ' ' || a.PERSON_LASTNAME as \"STF_NAME\",tb_leave_type.LEAVE_TYPE_NAME as \"LEAVE_TYPE_NAME\",TO_CHAR(tb_leave.LEAVE_FROM_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"LEAVE_FROM_DATE\",TO_CHAR(tb_leave.LEAVE_TO_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"LEAVE_TO_DATE\",TB_LEAVE_STATUS.LEAVE_STATUS_NAME as \"LEAVE_STATUS_NAME\",TB_LEAVE.APPROVER_ID as \"APPROVER_ID\",b.PERSON_NAME || ' ' || b.PERSON_LASTNAME as \"STF_NAME2\",TO_CHAR(tb_leave.APPROVE_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"APPROVE_DATE\",TB_LEAVE.REASON as \"REASON\" from tb_person a,tb_person b,tb_leave,tb_leave_type,TB_LEAVE_STATUS  where tb_leave.LEAVE_TYPE_ID = TB_LEAVE_TYPE.LEAVE_TYPE_ID AND TB_LEAVE.LEAVE_STATUS_ID = TB_LEAVE_STATUS.LEAVE_STATUS_ID AND a.CITIZEN_ID = tb_leave.CITIZEN_ID AND b.CITIZEN_ID = tb_leave.APPROVER_ID AND tb_leave.leave_type_id = " + DropDownList4.SelectedValue + " order by tb_leave.paper_id desc");
        }

        protected void Button1_Click2(object sender, EventArgs e) {
            try {

                using (OracleConnection con = Util.OC()) {
                    {
                        string sql = "SELECT PERSON_NAME || ' ' || PERSON_LASTNAME FROM TB_PERSON WHERE CITIZEN_ID = '" + TextBox16.Text + "'";
                        using (OracleCommand command = new OracleCommand(sql, con)) {
                            using (OracleDataReader reader = command.ExecuteReader()) {
                                if (reader.HasRows) {
                                    reader.Read();
                                    Label24.Text = reader.GetString(0);
                                    Label24.ForeColor = Color.White;
                                } else {
                                    Label24.Text = "ไม่พบรหัสพนักงาน";
                                    Label24.ForeColor = Color.Red;
                                }

                            }


                        }
                    }
                }
            } catch (Exception e2) {
                Util.Alert(this, "เกิดข้อผิดพลาด! " + e2.Message);
            }
        }

        protected void LinkButton16_Click(object sender, EventArgs e) {

            if (Session["login_id"] == null) {
                Util.Alert(this, "กรุณาเข้าสู่ระบบก่อน");
                return;
            }
            if(
                TextBox16.Text == null || TextBox16.Text == "" ||
                DropDownList5.SelectedIndex == 0 || DropDownList6.SelectedIndex == 0 ||
                TextBox17.Text == null || TextBox17.Text == "" ||
                TextBox18.Text == null || TextBox18.Text == "") {
                Util.Alert(this, "กรุณาเลือกข้อมูลให้ครบถ้วน");
                return;
            }

            // try {
            using (OracleConnection con = new OracleConnection("DATA SOURCE=ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm;")) {
                con.Open();
                {
                    string sql = "INSERT INTO TB_LEAVE VALUES(SEQ_LEAVE_ID.NEXTVAL,:2,:3,:4,:5,:6,:7,:8,:9,:10)";

                    using (OracleCommand command = new OracleCommand(sql, con)) {
                        //command.Parameters.AddWithValue("1", "SEQ_LEAVE_ID.NEXTVAL");
                        command.Parameters.AddWithValue("2", Util.ODTT());
                        command.Parameters.AddWithValue("3", TextBox16.Text);
                        command.Parameters.AddWithValue("4", DropDownList5.SelectedValue);
                        command.Parameters.AddWithValue("5", Util.ODT(TextBox17.Text));
                        command.Parameters.AddWithValue("6", Util.ODT(TextBox18.Text));
                        command.Parameters.AddWithValue("7", DropDownList6.SelectedValue);
                        command.Parameters.AddWithValue("8", Session["login_id"].ToString());
                        command.Parameters.AddWithValue("9", Util.ODTT());
                        command.Parameters.AddWithValue("10", TextBox19.Text);
                        command.ExecuteNonQuery();
                        Util.Alert(this, "เพิ่มข้อมูลสำเร็จ!");
                        GridView2.DataBind();
                    }
                }




            }
            //} catch (Exception e2) {
            //    Util.Alert(this,"เกิดข้อผิดพลาด! " + e2.Message);
            //}

        }

        //pull paper from id
        protected void LinkButton18_Click(object sender, EventArgs e) {

            Label33.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            Label31.Text = "";
            TextBox8.Text = "";
            Label32.Text = "";
            TextBox9.Text = "";
            DropDownList1.SelectedIndex = 0;
            DropDownList2.SelectedIndex = 0;
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox10.Text = "";
            Label20.Text = "";

            if (TextBox15.Text == "") {
                Label20.Text = "กรุณากรอกรหัสเอกสาร!";
                return;
            }

            //try {
            using (OracleConnection con = Util.OC()) {
                {
                    using (OracleCommand command = new OracleCommand("SELECT COUNT(*) FROM TB_LEAVE WHERE PAPER_ID = :1", con)) {
                        command.Parameters.AddWithValue("1", TextBox15.Text);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                if (reader.GetInt32(0) == 0) {
                                    Label20.Text = "ไม่พบรหัสเอกสาร!";
                                    return;
                                }
                            }
                        }
                    }
                    
                }

                {
                    using (OracleCommand command = new OracleCommand(
                    "SELECT TB_LEAVE.Leave_type_id, TB_PERSON.CITIZEN_ID, TB_PERSON.PERSON_NAME, TB_PERSON.PERSON_LASTNAME, NVL(TB_LEAVE.Reason,''), TO_CHAR(TB_LEAVE.LEAVE_FROM_DATE,'dd MON yyyy','NLS_DATE_LANGUAGE = THAI'), TO_CHAR(TB_LEAVE.LEAVE_TO_DATE,'dd MON yyyy','NLS_DATE_LANGUAGE = THAI'), TO_CHAR(TB_LEAVE.PAPER_DATE,'dd MON yyyy','NLS_DATE_LANGUAGE = THAI'), TB_LEAVE.LEAVE_STATUS_ID, TB_LEAVE.PAPER_ID FROM TB_LEAVE, TB_PERSON WHERE TB_LEAVE.PAPER_ID = " + TextBox15.Text + " AND TB_PERSON.CITIZEN_ID = TB_LEAVE.CITIZEN_ID", con))
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            DropDownList1.SelectedValue = reader.GetInt32(0).ToString();
                            TextBox3.Text = reader.GetString(1);
                            Label31.Text = reader.GetString(2) + " " + reader.GetString(3);
                            TextBox10.Text = reader.IsDBNull(4) ? "" : reader.GetString(4);
                            TextBox5.Text = Util.NDT(reader.GetString(5));
                            TextBox6.Text = Util.NDT(reader.GetString(6));
                            TextBox2.Text = Util.NDT(reader.GetString(7));
                            DropDownList2.SelectedValue = reader.GetInt32(8).ToString();
                            Label33.Text = "" + reader.GetInt32(9);
                        }
                    }
                }

                {
                    using (OracleCommand command = new OracleCommand(
                    "SELECT TB_LEAVE.APPROVER_ID, TB_PERSON.PERSON_NAME, TB_PERSON.PERSON_LASTNAME, TO_CHAR(TB_LEAVE.APPROVE_DATE,'dd MON yyyy','NLS_DATE_LANGUAGE = THAI') FROM TB_LEAVE, TB_PERSON WHERE TB_LEAVE.PAPER_ID = " + TextBox15.Text + " AND TB_PERSON.CITIZEN_ID = TB_LEAVE.APPROVER_ID", con))
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            TextBox8.Text = reader.GetString(0);
                            Label32.Text = reader.GetString(1) + " " + reader.GetString(2);
                            TextBox9.Text = Util.NDT(reader.GetString(3));
                        }
                    }
                }

                LinkButton13.Enabled = true;

            }


            //} catch (Exception e2) {
            //   string script = "alert(\"เกิดข้อผิดพลาด! " + e2.Message + "\");";
            //   ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            // }

        }

        protected void LinkButton3_Click(object sender, EventArgs e) {
            pullSql("select tb_leave.PAPER_ID as \"PAPER_ID\",TO_CHAR(tb_leave.PAPER_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"PAPER_DATE\",tb_leave.CITIZEN_ID as \"CITIZEN_ID\",a.PERSON_NAME || ' ' || a.PERSON_LASTNAME as \"STF_NAME\",tb_leave_type.LEAVE_TYPE_NAME as \"LEAVE_TYPE_NAME\",TO_CHAR(tb_leave.LEAVE_FROM_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"LEAVE_FROM_DATE\",TO_CHAR(tb_leave.LEAVE_TO_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"LEAVE_TO_DATE\",TB_LEAVE_STATUS.LEAVE_STATUS_NAME as \"LEAVE_STATUS_NAME\",TB_LEAVE.APPROVER_ID as \"APPROVER_ID\",b.PERSON_NAME || ' ' || b.PERSON_LASTNAME as \"STF_NAME2\",TO_CHAR(tb_leave.APPROVE_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"APPROVE_DATE\",TB_LEAVE.REASON as \"REASON\" from tb_person a,tb_person b,tb_leave,tb_leave_type,TB_LEAVE_STATUS where tb_leave.LEAVE_TYPE_ID = TB_LEAVE_TYPE.LEAVE_TYPE_ID AND TB_LEAVE.LEAVE_STATUS_ID = TB_LEAVE_STATUS.LEAVE_STATUS_ID AND a.CITIZEN_ID = tb_leave.CITIZEN_ID AND b.CITIZEN_ID = tb_leave.APPROVER_ID order by tb_leave.paper_id desc");
        }

        

        protected void DropDownList4_DataBound(object sender, EventArgs e) {
            DropDownList4.Items.Insert(0, new ListItem("--กรุณาเลือกประเภทการลา--", String.Empty));
            DropDownList4.SelectedIndex = 0;
        }

        protected void DropDownList5_DataBound(object sender, EventArgs e) {
            DropDownList5.Items.Insert(0, new ListItem("--กรุณาเลือกประเภทการลา--", String.Empty));
            DropDownList5.SelectedIndex = 0;
        }

        protected void DropDownList6_DataBound(object sender, EventArgs e) {
            DropDownList6.Items.Insert(0, new ListItem("--กรุณาเลือกสถานะการลา--", String.Empty));
            DropDownList6.SelectedIndex = 0;
        }

        protected void DropDownList1_DataBound(object sender, EventArgs e) {
            DropDownList1.Items.Insert(0, new ListItem("--กรุณาเลือกประเภทการลา--", String.Empty));
            DropDownList1.SelectedIndex = 0;
        }

        protected void DropDownList2_DataBound(object sender, EventArgs e) {
            DropDownList2.Items.Insert(0, new ListItem("--กรุณาเลือกสถานะการลา--", String.Empty));
            DropDownList2.SelectedIndex = 0;

        }

        protected void DropDownList7_SelectedIndexChanged(object sender, EventArgs e) {
            if(DropDownList7.SelectedIndex != 0)
                pullSql("select tb_leave.PAPER_ID as \"PAPER_ID\",TO_CHAR(tb_leave.PAPER_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"PAPER_DATE\",tb_leave.CITIZEN_ID as \"CITIZEN_ID\",a.PERSON_NAME || ' ' || a.PERSON_LASTNAME as \"STF_NAME\",tb_leave_type.LEAVE_TYPE_NAME as \"LEAVE_TYPE_NAME\",TO_CHAR(tb_leave.LEAVE_FROM_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"LEAVE_FROM_DATE\",TO_CHAR(tb_leave.LEAVE_TO_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"LEAVE_TO_DATE\",TB_LEAVE_STATUS.LEAVE_STATUS_NAME as \"LEAVE_STATUS_NAME\",TB_LEAVE.APPROVER_ID as \"APPROVER_ID\",b.PERSON_NAME || ' ' || b.PERSON_LASTNAME as \"STF_NAME2\",TO_CHAR(tb_leave.APPROVE_DATE, 'dd MON yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"APPROVE_DATE\",TB_LEAVE.REASON as \"REASON\" from tb_person a,tb_person b,tb_leave,tb_leave_type,TB_LEAVE_STATUS where tb_leave.LEAVE_TYPE_ID = TB_LEAVE_TYPE.LEAVE_TYPE_ID AND TB_LEAVE.LEAVE_STATUS_ID = TB_LEAVE_STATUS.LEAVE_STATUS_ID AND a.CITIZEN_ID = tb_leave.CITIZEN_ID AND b.CITIZEN_ID = tb_leave.APPROVER_ID AND tb_leave.leave_status_id = " + DropDownList7.SelectedValue + " order by tb_leave.paper_id desc");
        }

        protected void DropDownList7_DataBound(object sender, EventArgs e) {
            DropDownList7.Items.Insert(0, new ListItem("--กรุณาเลือกสถานะการลา--", String.Empty));
            DropDownList7.SelectedIndex = 0;
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e) {

           

            GridViewRow row = GridView2.SelectedRow;

            Label33.Text = row.Cells[0].Text;
            TextBox2.Text = Util.NDT(row.Cells[1].Text);
            TextBox3.Text = row.Cells[2].Text;
            DropDownList1.ClearSelection();
            DropDownList1.Items.FindByText(row.Cells[4].Text).Selected = true;
            TextBox5.Text = Util.NDT(row.Cells[5].Text);
            TextBox6.Text = Util.NDT(row.Cells[6].Text);
            DropDownList2.ClearSelection();
            DropDownList2.Items.FindByText(row.Cells[7].Text).Selected = true;
            TextBox8.Text = row.Cells[8].Text;
            TextBox9.Text = Util.NDT(row.Cells[10].Text);
            TextBox10.Text = row.Cells[11].Text == "&nbsp;" ? "":row.Cells[11].Text;
            using(OracleConnection con = Util.OC()) {
                using(OracleCommand command = new OracleCommand("SELECT PERSON_NAME || ' ' || PERSON_LASTNAME FROM TB_PERSON WHERE CITIZEN_ID = :1", con)) {
                    command.Parameters.AddWithValue("1", TextBox3.Text);
                    using(OracleDataReader reader = command.ExecuteReader()) {
                        reader.Read();
                        Label31.Text = reader.GetString(0);
                    }
                }
                using (OracleCommand command = new OracleCommand("SELECT PERSON_NAME || ' ' || PERSON_LASTNAME FROM TB_PERSON WHERE CITIZEN_ID = :1", con)) {
                    command.Parameters.AddWithValue("1", TextBox8.Text);
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        reader.Read();
                        Label32.Text = reader.GetString(0);
                    }
                }
            }
 
        }

        protected void GridView2_PageIndexChanged(object sender, EventArgs e) {
            GridView2.SelectedIndex = -1;
            Label33.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            Label31.Text = "";
            TextBox8.Text = "";
            Label32.Text = "";
            TextBox9.Text = "";
            DropDownList1.SelectedIndex = 0;
            DropDownList2.SelectedIndex = 0;
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox10.Text = "";
            Label20.Text = "";
            TextBox15.Text = "";
        }
    }
    
}