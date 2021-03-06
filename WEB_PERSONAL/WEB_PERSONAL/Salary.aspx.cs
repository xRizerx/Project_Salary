﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.OracleClient;

namespace WEB_PERSONAL
{
    public partial class Salary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_id"] == null)
            {
                Response.Redirect("Error-Member.aspx");
            }
            if (!Page.IsPostBack)
            {

                TextBox31.Text = "";
                TextBox32.Text = "";
                Label15.Text = "";
                TextBox25.Text = "";
                Label17.Text = "";
                Label16.Text = "";
                TextBox22.Text = "";
                Label18.Text = "";
                Label19.Text = "";
                Label20.Text = "";
                TextBox18.Text = "";
            }

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            TextBox31.Text = "0";
            using (OracleConnection conn = new OracleConnection(Util.CS()))
            {
                conn.Open();
                using (OracleCommand command = new OracleCommand("SELECT COUNT(TB_PERSON.CITIZEN_ID)COUNT_PEPOLE FROM TB_PERSON WHERE BRANCH_ID = " + DropDownList1.SelectedValue + " GROUP BY BRANCH_ID", conn))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TextBox31.Text = reader.GetInt32(0).ToString();
                        }

                    }


                }

            }

            if (TextBox32.Text == string.Empty || TextBox32.Text == "0" || TextBox25.Text == string.Empty || TextBox25.Text == "0" || TextBox22.Text == string.Empty)
            {
                Util.Alert(this, "กรอกจำนวนเงินไม่ถูกต้อง");
            }
            else
            {
                double a = Convert.ToDouble(TextBox32.Text); /*[3]*/
                double b = Convert.ToDouble(TextBox25.Text); /*[5]*/
                Label15.Text = "" + (a * 2.9 / 100); /*[4]=[3]*2.9%*/
                double c = Convert.ToDouble(Label15.Text);/*[6]*/
                Label17.Text = String.Format("{0:.##}", c - b); /*[6]=[4]-[5]*/
                Label16.Text = String.Format("{0:.##}", a * 0.1 / 100);/*[7]=[3]*0.1%*/
                double d = Convert.ToDouble(Label16.Text);/*[7]*/
                double ee = Convert.ToDouble(TextBox22.Text);/*[8]*/
                Label18.Text = String.Format("{0:.##}", c + d);/*[9]=[4]+[7]*/
                double f = Convert.ToDouble(Label18.Text);/*[9]*/
                Label19.Text = String.Format("{0:.##}", b + ee);/*[10]=[5]+[8]*/
                double g = Convert.ToDouble(Label19.Text);/*[10]*/
                Label20.Text = String.Format("{0:.##}", f - g);/*[11]=[9]-[10]*/
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs ee)
        {
            if (Session["login_id"] != null)
            {
                if (TextBox32.Text == string.Empty || TextBox32.Text == "0")
                {

                }
                using (OracleConnection conn = new OracleConnection(Util.CS()))
                {
                    conn.Open();

                    String a = DropDownList1.SelectedValue;
                    String b = TextBox31.Text;
                    String c = TextBox32.Text;
                    String d = Label15.Text;
                    String e = TextBox25.Text;
                    String f = Label17.Text;
                    String g = Label16.Text;
                    String h = TextBox22.Text;
                    String i = Label18.Text;
                    String j = Label19.Text;
                    String k = Label20.Text;
                    String l = TextBox18.Text;
                    string sql = "INSERT INTO TB_DPIS (DPIS_ID,BRANCH_ID, COUNT_PEOPLE, SUM_SALARY, RATE_SUMSALARY, RATE_MONEY_UP, RATE_BALANCE, SUM_PRE_MONTH, ADMIN_MONEY_ADD, SUM_MONEY_UP, SUM_MONEY_TOTAL, SUM_BALANCE, \"COMMENT\") VALUES (SEQ_DPIS_ID.NEXTVAL,{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},'{11}')";
                    sql = string.Format(sql, a, b, c, d, e, f, g, h, i, j, k, l);
                    using (OracleCommand command = new OracleCommand(sql, conn))
                    {
                        command.ExecuteNonQuery();
                        Util.Alert(this,"SAVE SUCCESSFUL");
                    }
                }
            }
            else
            {
                Response.Redirect("Error-Member.aspx");
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            TextBox31.Text = "";
            TextBox32.Text = "";
            Label15.Text = "";
            TextBox25.Text = "";
            Label17.Text = "";
            Label16.Text = "";
            TextBox22.Text = "";
            Label18.Text = "";
            Label19.Text = "";
            Label20.Text = "";
            TextBox18.Text = "";
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Salary-report.aspx");
        }
    }
}