using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_PERSONAL
{
    public partial class insignis_recordnote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            { 
                TextBox1.Text = "kuy1";
            TextBox2.Text = "";
            }
            else if (RadioButton2.Checked == true)
            { 
                TextBox2.Text = "kuy2";
            TextBox1.Text = "";
            }

        }
    }
}