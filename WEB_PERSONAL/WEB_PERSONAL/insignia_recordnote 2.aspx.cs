using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;



namespace WEB_PERSONAL
{
    public partial class insignia_recordnote_2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=203.158.140.67;Initial Catalog=personal;Integrated Security=False;User ID=rmutto1;Password=Zxcvbnm!");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand Cmd = con.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "insert into TB_recordnote value()";
            Cmd.ExecuteNonQuery();

            con.Close();
            Response.Redirect("insignia_recordnote2.aspx");
        }
    }
}