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
    public partial class SalarybyID : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=203.158.140.66;Initial Catalog=personal;Integrated Security=False;User ID=rmutto;Password=Zxcvbnm!");
            conn.Open();
            String strSQL = "SELECT STF_NAME,STF_LNAME FROM TB_PERSONAL WHERE CITIZEN_ID = Textbox11.text";
            SqlCommand sqlcomm = new SqlCommand(strSQL,conn);
            SqlDataReader reader;



            conn.Close();
     
            
            /*
            DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            DataRowView drv = dv[0];
            Label11.Text = drv["STF_NAME"].ToString();
            Label13.Text = drv["STF_LNAME"].ToString();*/
        }

    }
}
