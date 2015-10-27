using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WEB_PERSONAL
{
    public partial class Leave : System.Web.UI.Page
    {
        //pull from paper_id
        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Label20.Text = "";
            if (TextBox1.Text == "")
            {
                Label20.Text = "กรุณากรอกรหัสเอกสาร!";
                return;
            }

            try
            {
                string connectionString = "Data Source=203.158.140.66;Initial Catalog=personal;Integrated Security=FALSE;User ID=rmutto;Password=Zxcvbnm!";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    {
                        using (SqlCommand command = new SqlCommand(
                        "SELECT COUNT(*) FROM TB_LEAVE WHERE PAPER_ID = " + TextBox1.Text, con))
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader.GetInt32(0) == 0)
                                {
                                    Label20.Text = "ไม่พบรหัสเอกสาร!";
                                    return;
                                }
                            }
                        }
                    }

                    {
                        using (SqlCommand command = new SqlCommand(
                        "SELECT TB_LEAVE.Leave_type_id, TB_PERSONAL.CITIZEN_ID, TB_PERSONAL.STF_NAME, TB_PERSONAL.STF_LNAME, TB_LEAVE.Reason, TB_LEAVE.LEAVE_FROM_DATE, TB_LEAVE.LEAVE_TO_DATE, TB_LEAVE.PAPER_DATE, TB_LEAVE.LEAVE_STATUS_ID FROM TB_LEAVE, TB_PERSONAL WHERE TB_LEAVE.PAPER_ID = " + TextBox1.Text + " AND TB_PERSONAL.CITIZEN_ID = TB_LEAVE.CITIZEN_ID", con))
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DropDownList1.SelectedValue = reader.GetInt32(0).ToString();
                                TextBox3.Text = reader.GetString(1);
                                TextBox11.Text = reader.GetString(2) + " " + reader.GetString(3);
                                TextBox10.Text = reader.GetString(4);
                                TextBox5.Text = reader.GetDateTime(5).ToString("dd/MM/yyyy");
                                TextBox6.Text = reader.GetDateTime(6).ToString("dd/MM/yyyy");
                                TextBox2.Text = reader.GetDateTime(7).ToString("dd/MM/yyyy");
                                DropDownList2.SelectedValue = reader.GetInt32(8).ToString();
                            }
                        }
                    }

                    {
                        using (SqlCommand command = new SqlCommand(
                        "SELECT TB_LEAVE.APPROVER_ID, TB_PERSONAL.STF_NAME, TB_PERSONAL.STF_LNAME, TB_LEAVE.APPROVE_DATE FROM TB_LEAVE, TB_PERSONAL WHERE TB_LEAVE.PAPER_ID = " + TextBox1.Text + " AND TB_PERSONAL.CITIZEN_ID = TB_LEAVE.APPROVER_ID", con))
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TextBox8.Text = reader.GetString(0);
                                TextBox13.Text = reader.GetString(1) + " " + reader.GetString(2);
                                TextBox9.Text = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                            }
                        }
                    }

                }


            }
            catch (Exception e2)
            {
                string script = "alert(\"เกิดข้อผิดพลาด! " + e2.Message + "\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }

        }

        //insert
        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=203.158.140.66;Initial Catalog=personal;Integrated Security=FALSE;User ID=rmutto;Password=Zxcvbnm!";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    {
                        string sql = "SELECT count(*) FROM TB_LEAVE WHERE PAPER_ID = " + TextBox1.Text;
                        using (SqlCommand command = new SqlCommand(sql, con))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    if (reader.GetInt32(0) == 1)
                                    {
                                        string script2 = "alert(\"รหัสนี้มีอยู่ในระบบแล้ว!\");";
                                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script2, true);
                                        return;
                                    }
                                }
                            }
                        }
                    }

                    {
                        string sql = "INSERT INTO TB_LEAVE VALUES(" +
                        TextBox1.Text + ",'" +
                        toDate(TextBox2.Text) + "','" +
                        TextBox3.Text + "'," +
                        DropDownList1.SelectedValue + ",'" +
                        toDate(TextBox5.Text) + "', '" +
                        toDate(TextBox6.Text) + "'," +
                        DropDownList2.SelectedValue + ",'" +
                        TextBox8.Text + "', '" +
                        toDate(TextBox9.Text) + "','" +
                        TextBox10.Text + "')";
                        using (SqlCommand command = new SqlCommand(sql, con))
                        {
                            command.ExecuteNonQuery();
                            string script2 = "alert(\"เพิ่มข้อมูลสำเร็จ!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script2, true);
                        }
                    }




                }
            }
            catch (Exception e2)
            {
                string script = "alert(\"เกิดข้อผิดพลาด! " + e2.Message + "\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        private string toDate(String str)
        {
            string[] paper_date_s = str.Split('/');
            int paper_date_y = Convert.ToInt32(paper_date_s[2]) - 543;
            return paper_date_y + paper_date_s[1] + paper_date_s[0];
        }

        //save - update
        protected void LinkButton13_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=203.158.140.66;Initial Catalog=personal;Integrated Security=FALSE;User ID=rmutto;Password=Zxcvbnm!";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    {
                        string sql = "UPDATE TB_LEAVE SET " +
                        "PAPER_ID = " + TextBox1.Text + "," +
                        "PAPER_DATE = '" + toDate(TextBox2.Text) + "'," +
                        "CITIZEN_ID = '" + TextBox3.Text + "'," +
                        "LEAVE_TYPE_ID = " + DropDownList1.SelectedValue + "," +
                        "LEAVE_FROM_DATE = '" + toDate(TextBox5.Text) + "'," +
                        "LEAVE_TO_DATE = '" + toDate(TextBox6.Text) + "'," +
                        "LEAVE_STATUS_ID = " + DropDownList2.SelectedValue + "," +
                        "APPROVER_ID = '" + TextBox8.Text + "'," +
                        "APPROVE_DATE = '" + toDate(TextBox9.Text) + "'," +
                        "REASON = '" + TextBox10.Text + "' " +
                        "WHERE PAPER_ID = " + TextBox1.Text;
                        using (SqlCommand command = new SqlCommand(sql, con))
                        {
                            command.ExecuteNonQuery();
                            string script2 = "alert(\"บันทึกสำเร็จ!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script2, true);
                        }
                    }
                }
            }
            catch (Exception e2)
            {
                string script = "alert(\"เกิดข้อผิดพลาด! " + e2.Message + "\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double d = 1234.5678;
            d = RoundUp(d);
            string script2 = "alert(\"" + d + "\");";
            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script2, true);
        }

        int RoundUp(double i)
        {
            int j = Convert.ToInt32(i);
            return (10 - j % 10) + j;
        }

        protected void LinkButton14_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=203.158.140.66;Initial Catalog=personal;Integrated Security=FALSE;User ID=rmutto;Password=Zxcvbnm!";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    {
                        string sql = "SELECT STF_NAME + ' ' + STF_LNAME FROM TB_PERSONAL WHERE CITIZEN_ID = '" + TextBox3.Text + "'";
                        using (SqlCommand command = new SqlCommand(sql, con))
                        {
                            using(SqlDataReader reader = command.ExecuteReader())
                            {
                                if(reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        TextBox11.Text = reader.GetString(0);
                                    }
                                } else
                                {
                                    string script2 = "alert('ไม่พบรหัสพนักงาน!');";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script2, true);
                                }
                                
                            }
                           
                            
                        }
                    }
                }
            }
            catch (Exception e2)
            {
                string script = "alert(\"เกิดข้อผิดพลาด! " + e2.Message + "\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void LinkButton15_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=203.158.140.66;Initial Catalog=personal;Integrated Security=FALSE;User ID=rmutto;Password=Zxcvbnm!";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    {
                        string sql = "SELECT STF_NAME + ' ' + STF_LNAME FROM TB_PERSONAL WHERE CITIZEN_ID = '" + TextBox8.Text + "'";
                        using (SqlCommand command = new SqlCommand(sql, con))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        TextBox13.Text = reader.GetString(0);
                                    }
                                }
                                else
                                {
                                    string script2 = "alert('ไม่พบรหัสพนักงาน!');";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script2, true);
                                }

                            }


                        }
                    }
                }
            }
            catch (Exception e2)
            {
                string script = "alert(\"เกิดข้อผิดพลาด! " + e2.Message + "\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Leave-Report1.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=203.158.140.66;Initial Catalog=personal;Integrated Security=FALSE;User ID=rmutto;Password=Zxcvbnm!";
            string sql = "select citizen_id, stf_name from tb_personal";

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
                test.DataField = "STF_NAME";
                test.HeaderText = "NAME";
                GridView1.Columns.Add(test);
            }
            SqlDataSource sds = new SqlDataSource(connectionString, sql);
            GridView1.DataSource = sds;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=203.158.140.66;Initial Catalog=personal;Integrated Security=FALSE;User ID=rmutto;Password=Zxcvbnm!";
            string sql = "select tb_leave.PAPER_ID as 'รหัสเอกสาร',tb_leave.PAPER_DATE as 'วันที่เอกสาร',tb_leave.CITIZEN_ID as 'รหัสผู้ลา',a.stf_name + ' ' + a.STF_LNAME as 'ชื่อผู้ลา',tb_leave_type.LEAVE_TYPE_NAME as 'ประเภท',tb_leave.LEAVE_FROM_DATE as 'จากวันที่',tb_leave.LEAVE_TO_DATE as 'ถึงวันที่',TB_LEAVE_STATUS.LEAVE_STATUS_NAME as 'สถานะ',TB_LEAVE.APPROVER_ID as 'รหัสผู้อนุมัติ',b.stf_name + ' ' + b.STF_LNAME as 'ชื่อผู้อนุมัติ',TB_LEAVE.APPROVE_DATE as 'วันที่อนุมัติ',TB_LEAVE.REASON as 'เหตุผล' from tb_personal a,tb_personal b,tb_leave,tb_leave_type,TB_LEAVE_STATUS where tb_leave.LEAVE_TYPE_ID = TB_LEAVE_TYPE.LEAVE_TYPE_ID AND TB_LEAVE.LEAVE_STATUS_ID = TB_LEAVE_STATUS.LEAVE_STATUS_ID AND a.CITIZEN_ID = tb_leave.CITIZEN_ID AND b.CITIZEN_ID = tb_leave.APPROVER_ID;";

            GridView1.AutoGenerateColumns = false;
            GridView1.Controls.Clear();
            GridView1.Columns.Clear();
            {
                BoundField test = new BoundField();
                test.DataField = "รหัสเอกสาร";
                test.HeaderText = "รหัสเอกสาร";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "วันที่เอกสาร";
                test.HeaderText = "วันที่เอกสาร";
                test.DataFormatString = "{0:dd/MM/yyyy}";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "รหัสผู้ลา";
                test.HeaderText = "รหัสผู้ลา";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "ชื่อผู้ลา";
                test.HeaderText = "ชื่อผู้ลา";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "ประเภท";
                test.HeaderText = "ประเภท";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "จากวันที่";
                test.HeaderText = "จากวันที่";
                test.DataFormatString = "{0:dd/MM/yyyy}";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "ถึงวันที่";
                test.HeaderText = "ถึงวันที่";
                test.DataFormatString = "{0:dd/MM/yyyy}";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "สถานะ";
                test.HeaderText = "สถานะ";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "รหัสผู้อนุมัติ";
                test.HeaderText = "รหัสผู้อนุมัติ";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "ชื่อผู้อนุมัติ";
                test.HeaderText = "ชื่อผู้อนุมัติ";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "รหัสผู้อนุมัติ";
                test.HeaderText = "รหัสผู้อนุมัติ";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "วันที่อนุมัติ";
                test.HeaderText = "วันที่อนุมัติ";
                test.DataFormatString = "{0:dd/MM/yyyy}";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "เหตุผล";
                test.HeaderText = "เหตุผล";
                GridView1.Columns.Add(test);
            }

            SqlDataSource sds = new SqlDataSource(connectionString, sql);
            GridView1.DataSource = sds;
            GridView1.DataBind();

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
}