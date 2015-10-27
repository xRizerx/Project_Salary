using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WEB_PERSONAL
{
    public partial class Personnel_GENERAL : System.Web.UI.Page
    {
        public static string strConn = @"Data Source = 203.158.140.66; Initial Catalog = personal; Integrated Security = False; User ID = rmutto; Password = Zxcvbnm!";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindPROVINCEList();
            }
        }

        private void BindPROVINCEList()
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(strConn))
                {
                    using (SqlCommand sqlCmd = new SqlCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_PROVINCE";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        ddlPROVINCE.DataSource = dt;
                        ddlPROVINCE.DataValueField = "PROVINCE_ID";
                        ddlPROVINCE.DataTextField = "PROVINCE_TH";
                        ddlPROVINCE.DataBind();
                        sqlConn.Close();

                        ddlPROVINCE.Items.Insert(0, new ListItem("--กรุณาเลือกจังหวัด--", "0"));
                        ddlAMPHUR.Items.Insert(0, new ListItem("--กรุณาเลือกอำเภอ--", "0"));
                        ddlDISTRICT.Items.Insert(0, new ListItem("--กรุณาเลือกตำบล--", "0"));
                    }
                }
            }
            catch { }
        }

        protected void ddlPROVINCE_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(strConn))
                {
                    using (SqlCommand sqlCmd = new SqlCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_AMPHUR where PROVINCE_ID=@PROVINCE_ID";
                        sqlCmd.Parameters.AddWithValue("@PROVINCE_ID", ddlPROVINCE.SelectedValue);
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        ddlAMPHUR.DataSource = dt;
                        ddlAMPHUR.DataValueField = "AMPHUR_ID";
                        ddlAMPHUR.DataTextField = "AMPHUR_TH";
                        ddlAMPHUR.DataBind();
                        sqlConn.Close();

                        ddlAMPHUR.Items.Insert(0, new ListItem("--กรุณาเลือกอำเภอ--", "0"));
                        ddlDISTRICT.Items.Clear();
                        ddlDISTRICT.Items.Insert(0, new ListItem("--กรุณาเลือกตำบล--", "0"));
                    }
                }
            }
            catch { }
        }

        protected void ddlAMPHUR_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(strConn))
                {
                    using (SqlCommand sqlCmd = new SqlCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_DISTRICT where AMPHUR_ID=@DISTRICT_ID";
                        sqlCmd.Parameters.AddWithValue("@DISTRICT_ID", ddlAMPHUR.SelectedValue);
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        ddlDISTRICT.DataSource = dt;
                        ddlDISTRICT.DataValueField = "DISTRICT_ID";
                        ddlDISTRICT.DataTextField = "DISTRICT_TH";
                        ddlDISTRICT.DataBind();
                        sqlConn.Close();

                        ddlDISTRICT.Items.Insert(0, new ListItem("--กรุณาเลือกตำบล--", "0"));

                       
                    }
                }
            }
            catch { }
        }

        protected void ddlDISTRICT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ZIPCODE = "select POST_CODE from TB_DISTRICT where DISTRICT_ID = " + ddlDISTRICT.SelectedValue + "";

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Connectionstring"].ConnectionString);

            conn.Open();

            SqlCommand SC = new SqlCommand(ZIPCODE, conn);
            string ZIPCODE2 = SC.ExecuteScalar().ToString();
            
            txtZIPCODE.Text = ZIPCODE2;
        }


        protected void btnCancelPersonnel_Click(object sender, EventArgs e)
        {

        }

        protected void btnSubmitPersonnel_Click(object sender, EventArgs e)
        {

        }

        
    }
}