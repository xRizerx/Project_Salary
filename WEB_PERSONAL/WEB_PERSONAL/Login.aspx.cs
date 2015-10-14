using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_PERSONAL.CSS
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Session["login_id"] = TextBox1.Text;
            Response.Redirect("Default.aspx");
        }
    }
}