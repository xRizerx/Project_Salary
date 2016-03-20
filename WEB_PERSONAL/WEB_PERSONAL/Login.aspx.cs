﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.OracleClient;

namespace WEB_PERSONAL.CSS
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Label9.Text = "";
            //try
            {
                using (OracleConnection con = Util.OC())
                {
                    {
                        string sql = "SELECT count(*) FROM TB_PERSONAL WHERE CITIZEN_ID = '" + TextBox1.Text + "'";
                        using (OracleCommand command = new OracleCommand(sql, con))
                        {
                            using(OracleDataReader reader = command.ExecuteReader())
                            {
                                while(reader.Read())
                                {
                                    if(reader.GetInt32(0) == 0)
                                    {
                                        Label9.Text = "ไม่พบผู้ใช้งาน!";
                                        return;
                                    }
                                }
                            }
                            
                        }
                    }

                    {
                        string sql = "SELECT TB_PERSONAL.PASSWORD, TB_SYSTEM_STATUS.NAME, TB_PERSONAL.STF_NAME, TB_PERSONAL.STF_LNAME FROM TB_PERSONAL, TB_SYSTEM_STATUS WHERE TB_PERSONAL.CITIZEN_ID = '" + TextBox1.Text + "' AND TB_PERSONAL.SYSTEM_STATUS_ID = TB_SYSTEM_STATUS.ID";
                        using (OracleCommand command = new OracleCommand(sql, con))
                        {
                            using (OracleDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    if (reader.GetString(0) == TextBox2.Text)
                                    {
                                        Session["login_id"] = TextBox1.Text;
                                        Session["login_system_status"] = reader.GetString(1);
                                        Session["login_name"] = reader.GetString(2);
                                        Session["login_lastname"] = reader.GetString(3);
                                        Session["login_date_time"] = DateTime.Now;
                                        Response.Redirect("Default.aspx");
                                    }
                                    else
                                    {
                                        Label9.Text = "รหัสผ่านไม่ถูกต้อง!";
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