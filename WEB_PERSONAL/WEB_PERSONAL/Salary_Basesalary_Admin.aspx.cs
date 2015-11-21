using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Rmutto.Connection;
using System.Data.OracleClient;
using System.Data;

namespace WEB_PERSONAL
{
    public partial class Salary_Basesalary_Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //method for binding GridView

        protected void BindGridView()

        {
            using (OracleConnection con = Util.OC())
            {
                DataTable dt = new DataTable();

                OracleDataAdapter da = new OracleDataAdapter("SELECT TB_BASESALARY.ID,TB_POSITION.NAME, TB_BASESALARY.MAXSALARY, TB_BASESALARY.MINSALARY, TB_BASESALARY.MAXLOWSALARY, TB_BASESALARY.MINLOWSALARY FROM TB_BASESALARY, TB_POSITION WHERE TB_BASESALARY.POSITION_ID = TB_POSITION.ID", con);

                con.Open();

                da.Fill(dt);

                con.Close();



                if (dt.Rows.Count > 0)

                {

                    GridView1.DataSource = dt;

                    GridView1.DataBind();

                }
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // find values for update
            using (OracleConnection con = Util.OC())
            {
                TextBox MAXSALARY = (TextBox)GridView1.FooterRow.FindControl("MAXSALARY");
                TextBox MINSALARY = (TextBox)GridView1.FooterRow.FindControl("MINSALARY");
                TextBox MAXLOWSALARY = (TextBox)GridView1.FooterRow.FindControl("MAXLOWSALARY");
                TextBox MINLOWSALARY = (TextBox)GridView1.FooterRow.FindControl("MINLOWSALARY");



                // insert values into database

                OracleCommand cmd = new OracleCommand("INSERT INTO TB_BASESALARY (MAXSALARY,MINSALARY,MAXLOWSALARY,MINLOWSALARY)"+
    
                                  "values('" + MAXSALARY.Text + "', '" + MINSALARY.Text + "', '" + MAXLOWSALARY.Text + "', '" + MINLOWSALARY.Text + "')", con);
    

                cmd.ExecuteNonQuery();


            }
                



            BindGridView();
        }
    }
}