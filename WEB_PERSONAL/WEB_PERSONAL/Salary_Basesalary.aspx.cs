﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using WEB_PERSONAL.Connection;

namespace WEB_PERSONAL
{
    public partial class Salary_Basesalary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection("Data Source = 203.158.140.66; Initial Catalog = personal; Integrated Security = False; User ID = rmutto; Password = Zxcvbnm!");
            conn.Open();
            String a = DropDownList1.SelectedValue;
            using (SqlCommand command = new SqlCommand("SELECT MAXSALARY,MINSALARY,MAXLOWSALARY,MINLOWSALARY FROM BASESALARY WHERE BASE_ID = " + Convert.ToInt32(a), conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TextBox1.Text = reader.GetInt32(0).ToString();
                        TextBox2.Text = reader.GetInt32(1).ToString();
                        TextBox3.Text = reader.GetInt32(2).ToString();
                        TextBox4.Text = reader.GetInt32(3).ToString();
                    }
                }

            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source = 203.158.140.66; Initial Catalog = personal; Integrated Security = False; User ID = rmutto; Password = Zxcvbnm!"))
            {
                conn.Open();
                string sql = "UPDATE BASESALARY SET MAXSALARY ={0},MINSALARY ={1},MAXLOWSALARY ={2},MINLOWSALARY ={3} WHERE BASE_ID = {4}";
                sql = String.Format(sql,TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text,DropDownList1.SelectedValue);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.ExecuteNonQuery();
                    string script = "alert(\"SAVE SUCCESSFUL.\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
        }
    }
}