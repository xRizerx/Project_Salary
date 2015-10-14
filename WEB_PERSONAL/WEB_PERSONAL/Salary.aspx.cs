using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_PERSONAL
{
    public partial class Salary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label15.Text = "";
            Label17.Text = "";
            Label16.Text = "";
            Label18.Text = "";
            Label19.Text = "";
            Label20.Text = "";

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TextBox32.Text); /*[3]*/
            double b = Convert.ToDouble(TextBox25.Text); /*[5]*/
            Label15.Text = "" + (a * 2.9 / 100); /*[4]=[3]*2.9%*/
            double c = Convert.ToDouble(Label15.Text);/*[6]*/
            Label17.Text = "" + (c - b); /*[6]=[4]-[5]*/
            Label16.Text = "" + (a * 0.1 / 100);/*[7]=[3]*0.1%*/
            double d = Convert.ToDouble(Label16.Text);/*[7]*/
            double ee = Convert.ToDouble(TextBox22.Text);/*[8]*/
            Label18.Text = "" + (c + d);/*[9]=[4]+[7]*/
            double f = Convert.ToDouble(Label18.Text);/*[9]*/
            Label19.Text = "" + (b + ee);/*[10]=[5]+[8]*/
            double g = Convert.ToDouble(Label19.Text);/*[10]*/
            Label20.Text = "" + (f - g);/*[11]=[9]-[10]*/
        }
    }
}