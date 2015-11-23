using System;
using System.Web.UI.WebControls;
using System.Data.OracleClient;
using System.Data;

namespace WEB_PERSONAL
{
    public partial class Salary_Basesalary_Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn  = Util.OC())
            {
                String sql = "INSERT INTO TB_BASESALARY VALUES (SEQ_BASESALARY_ID.NEXTVAL,:1,:2,:3,:4,:5)";
                sql = String.Format(sql, DropDownList1.SelectedValue, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
                using (OracleCommand command = new OracleCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("1", DropDownList1.SelectedValue);
                    command.Parameters.AddWithValue("2", TextBox1.Text);
                    command.Parameters.AddWithValue("3", TextBox2.Text);
                    command.Parameters.AddWithValue("4", TextBox3.Text);
                    command.Parameters.AddWithValue("5", TextBox4.Text);
                    command.ExecuteNonQuery();
                    Util.Alert(this,"Insert Successful.");
                }
            }
            Response.Redirect(Request.Url.ToString());
        }
    }
}