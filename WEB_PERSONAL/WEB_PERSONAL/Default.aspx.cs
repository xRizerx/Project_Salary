using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_PERSONAL
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e) {
            TextBox tb = new TextBox();
            Panel1.Controls.Add(new LiteralControl("<br/>"));
            Panel1.Controls.Add(tb);
            Panel1.Controls.Add(new LiteralControl("<br/>"));
        }
    }
}