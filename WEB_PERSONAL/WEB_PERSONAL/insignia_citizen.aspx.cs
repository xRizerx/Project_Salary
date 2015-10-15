using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_PERSONAL
{
    public partial class insignia_main : System.Web.UI.Page
    {
        private object c;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("insignia_citizen.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("insignia_user.aspx");
        }
    }
}