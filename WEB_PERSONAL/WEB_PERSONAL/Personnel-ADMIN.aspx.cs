using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WEB_PERSONAL
{
    public partial class Personnel_ADMIN : System.Web.UI.Page
    {
        private SqlConnection conn = new SqlConnection("Data Source = 203.158.140.66; Initial Catalog = personal; Integrated Security = False; User ID = rmutto; Password = Zxcvbnm!");

        public void Bind_ddlPROVINCE()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from TB_PROVINCE", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            ddlPROVINCE.DataSource = dr;
            ddlPROVINCE.Items.Clear();
            ddlPROVINCE.Items.Add("--Please Select Province--");
            ddlPROVINCE.DataTextField = "PROVINCE_TH";
            ddlPROVINCE.DataValueField = "PROVINCE_ID";
            ddlPROVINCE.DataBind();
            conn.Close();
        }
        public void Bind_ddlAMPHUR()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from TB_AMPHUR where PROVINCE_ID='" + ddlPROVINCE.SelectedValue + "'", conn);

            SqlDataReader dr = cmd.ExecuteReader();
            ddlAMPHUR.DataSource = dr;
            ddlAMPHUR.Items.Clear();
            ddlAMPHUR.Items.Add("--Please Select Amphur--");
            ddlAMPHUR.DataTextField = "AMPHUR_TH";
            ddlAMPHUR.DataValueField = "AMPHUR_ID";
            ddlAMPHUR.DataBind();
            conn.Close();
        }
        public void Bind_ddlDISTRICT()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from TB_DISTRICT where AMPHUR_ID='" + ddlAMPHUR.SelectedValue + "'", conn);

            SqlDataReader dr = cmd.ExecuteReader();
            ddlDISTRICT.DataSource = dr;
            ddlDISTRICT.Items.Clear();
            ddlDISTRICT.Items.Add("--Please Select District--");
            ddlDISTRICT.DataTextField = "DISTRICT_TH";
            ddlDISTRICT.DataValueField = "DISTRICT_ID";
            ddlDISTRICT.DataBind();
            conn.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind_ddlPROVINCE();
            }
        }
        protected void ddlPROVINCE_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_ddlAMPHUR();
        }
        protected void ddlAMPHUR_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_ddlDISTRICT();
        }
    }
}