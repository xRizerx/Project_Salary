﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;
using System.Drawing;

namespace WEB_PERSONAL {
    public partial class Late : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            BindGridView2();
            BindGridView3();
        }

        protected void LinkButton20_Click(object sender, EventArgs e) {
            try {

                using (OracleConnection con = Util.OC()) {
                    {
                        string sql = "SELECT PERSON_NAME || ' ' || PERSON_LASTNAME FROM TB_PERSON WHERE CITIZEN_ID = '" + TextBox21.Text + "'";
                        using (OracleCommand command = new OracleCommand(sql, con)) {
                            using (OracleDataReader reader = command.ExecuteReader()) {
                                if (reader.HasRows) {
                                    reader.Read();
                                    Label45.Text = reader.GetString(0);
                                    Label45.ForeColor = Color.White;
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


            //try {
                using (OracleConnection con = new OracleConnection("DATA SOURCE=ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm;")) {
                    con.Open();
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
                            Util.Alert(this, "เพิ่มข้อมูลสำเร็จ!");
                        }
                    }
                }
            //} catch (Exception e2) {
            //    Util.Alert(this, "เกิดข้อผิดพลาด! " + e2.Message);
            //}
        }

        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e) {
            GridView2.PageIndex = e.NewPageIndex;
            BindGridView2();
        }

        protected void GridView3_PageIndexChanging(object sender, GridViewPageEventArgs e) {
            GridView3.PageIndex = e.NewPageIndex;
            BindGridView3();
        }
        private void BindGridView2() {
            GridView2.AllowPaging = true;
            GridView2.EnableSortingAndPagingCallbacks = true;
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
        }
        private void BindGridView3() {
            GridView3.AllowPaging = true;
            GridView3.EnableSortingAndPagingCallbacks = true;
            GridView3.AutoGenerateColumns = false;
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