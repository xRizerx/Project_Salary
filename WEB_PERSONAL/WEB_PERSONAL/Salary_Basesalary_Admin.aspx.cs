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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            TextBox9.Text = row.Cells[1].Text;
            DropDownList2.ClearSelection();
            DropDownList2.Items.FindByText(row.Cells[2].Text).Selected = true;
            TextBox5.Text = row.Cells[3].Text;
            TextBox6.Text = row.Cells[4].Text;
            TextBox7.Text = row.Cells[5].Text;
            TextBox8.Text = row.Cells[6].Text;
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = Util.OC())
            {
                String sql = "UPDATE TB_BASESALARY SET POSITION_ID=:1,MAXSALARY=:2,MINSALARY=:3,MAXLOWSALARY=:4,MINLOWSALARY=:5 WHERE ID = :0";
                sql = String.Format(sql, DropDownList2.SelectedValue, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text);
                using (OracleCommand command = new OracleCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("0", TextBox9.Text);
                    command.Parameters.AddWithValue("1", DropDownList2.SelectedValue);
                    command.Parameters.AddWithValue("2", TextBox5.Text);
                    command.Parameters.AddWithValue("3", TextBox6.Text);
                    command.Parameters.AddWithValue("4", TextBox7.Text);
                    command.Parameters.AddWithValue("5", TextBox8.Text);
                    command.ExecuteNonQuery();
                    Util.Alert(this, "Update Successful.");
                }
            }
            Response.Redirect(Request.Url.ToString());
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Response.Redirect("https://www.google.co.th");
        }

    }
}