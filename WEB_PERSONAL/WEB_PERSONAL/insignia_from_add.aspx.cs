using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;
using System.Data;
using System.Configuration;
using WEB_PERSONAL.Class;

namespace WEB_PERSONAL
{
    public partial class insignia_from_add : System.Web.UI.Page
    {

        public static string strConn = @"Data Source = ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_id"] == null)
            {
                Response.Redirect("access.aspx");
                return;

            }
            string citizen_id = Session["login_id"].ToString();

            Other.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("insignia_from_edit.aspx");
        }

        protected void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            Other.Visible = CheckBox6.Checked;
        }

        protected void DropDownList1_DataBound(object sender, EventArgs e)
        {
            DDL_Vitakad.Items.Insert(0, new ListItem(" --- กรุณาเลือก ---"));
        }

        protected void DropDownList2_DataBound(object sender, EventArgs e)
        {
            DDL_Branch.Items.Insert(0, new ListItem(" --- กรุณาเลือก ---"));
        }

        protected void DropDownList3_DataBound(object sender, EventArgs e)
        {
            DDL_Year.Items.Insert(0, new ListItem(" --- กรุณาเลือก ---"));
        }

        protected void DropDownList4_DataBound(object sender, EventArgs e)
        {
            DDL_insigclass.Items.Insert(0, new ListItem(" --- กรุณาเลือก ---"));
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label59.Text = "";
            Label61.Text = "";
            Label62.Text = "";

            if (DDL_Vitakad.SelectedIndex == 0)
            {
                Label59.Text = "*";
            }
            if (DDL_Year.SelectedIndex == 0)
            {
                Label61.Text = "*";
            }
            if (DDL_insigclass.SelectedIndex == 0)
            {
                Label62.Text = "*";
            }
        }


        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("insignia_from_add.aspx");
        }

        protected void DDL_insigclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DDL_insigclass.SelectedValue != "99")
            {
                Panel_show_detail.Visible = true;
            }
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
          
        }

    }
}


