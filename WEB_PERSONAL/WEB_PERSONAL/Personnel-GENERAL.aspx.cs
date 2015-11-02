using WEB_PERSONAL.Entities;
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
                txtCITIZEN_ID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                txtTELEPHONE.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
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
                        txtZIPCODE.Text = "";
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
                        txtZIPCODE.Text = "";
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
                        txtZIPCODE.Text = "";

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
        protected void ClearData()
        {
            DropDownYEAR.SelectedIndex = 0;
            txtCITIZEN_ID.Text = "";
            DropDownUNIV_ID.SelectedIndex = 0;
            DropDownTITLE_ID.SelectedIndex = 0;
            txtSTF_NAME.Text = "";
            txtSTF_LNAME.Text = "";
            DropDownGENDER_ID.SelectedIndex = 0;
            txtBIRTHDAY.Text = "";
            txtHOMEADD.Text = "";
            txtMOO.Text = "";
            txtSTREET.Text = "";
            ddlPROVINCE.SelectedIndex = 0;
            ddlAMPHUR.SelectedIndex = 0;
            ddlDISTRICT.SelectedIndex = 0;
            txtZIPCODE.Text = "";
            txtTELEPHONE.Text = "";
            DropDownNATION_ID.SelectedIndex = 0;
            DropDownSTAFFTYPE_ID.SelectedIndex = 0;
            DropDownTIME_CONTACT_ID.SelectedIndex = 0;
            DropDownBUDGET_ID.SelectedIndex = 0;
            DropDownSUBSTAFFTYPE_ID.SelectedIndex = 0;
            DropDownADMIN_POSITION_ID.SelectedIndex = 0;
            DropDownPOSITION_ID.SelectedIndex = 0;
            DropDownPOSITION_WORK.SelectedIndex = 0;
            DropDownDEPARTMENT_ID.SelectedIndex = 0;
            txtDATETIME_INWORRK.Text = "";
            txtSPECIAL_NAME.Text = "";
            DropDownTEACH_ISCED_ID.SelectedIndex = 0;
            DropDownGRAD_LEV_ID.SelectedIndex = 0;
            txtGRAD_CURR.Text = "";
            DropDownGRAD_ISCED_ID.SelectedIndex = 0;
            DropDownGRAD_PROG_ID.SelectedIndex = 0;
            txtGRAD_UNIV.Text = "";
            DropDownGRAD_COUNTRY_ID.SelectedIndex = 0;
        }


        protected void btnCancelPersonnel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        protected void btnSubmitPersonnel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCITIZEN_ID.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก รหัสบัตรประชาชน')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtSTF_NAME.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ชื่อ')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtSTF_LNAME.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก นามสกุล')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtBIRTHDAY.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก นามสกุล')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtHOMEADD.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก บ้านเลขที่')", true);
                return;
            }
            Personnel P = new Personnel();
            P.YEAR = Convert.ToInt32(DropDownYEAR.SelectedValue);
            P.UNIV_ID = Convert.ToString(DropDownUNIV_ID.SelectedValue.ToString());
            P.CITIZEN_ID = txtCITIZEN_ID.Text;
            P.TITLE_ID = Convert.ToString(DropDownTITLE_ID.SelectedValue.ToString());
            P.STF_NAME = txtSTF_NAME.Text;
            P.STF_LNAME = txtSTF_LNAME.Text;
            P.GENDER_ID = Convert.ToInt32(DropDownGENDER_ID.SelectedValue.ToString());
            P.BIRTHDAY = DateTime.Parse(txtBIRTHDAY.Text);
            P.HOMEADD = txtHOMEADD.Text;
            /*  P.MOO = txtMOO.Text;
             P.STREET = txtSTREET.Text;
             P.DISTRICT_ID = Convert.ToInt32(ddlDISTRICT.SelectedValue.ToString());
             P.AMPHUR_ID = Convert.ToInt32(ddlAMPHUR.SelectedValue.ToString());
             P.PROVINCE_ID = Convert.ToInt32(ddlPROVINCE.SelectedValue.ToString());
             P.TELEPHONE = txtTELEPHONE.Text;
             P.ZIPCODE_ID = Convert.ToInt32(txtZIPCODE.Text);
             P.NATION_ID = Convert.ToString(DropDownNATION_ID.SelectedValue.ToString());
             P.STAFFTYPE_ID = Convert.ToInt32(DropDownSTAFFTYPE_ID.SelectedValue.ToString());
             P.TIME_CONTACT_ID = Convert.ToInt32(DropDownTIME_CONTACT_ID.SelectedValue.ToString());
               P.BUDGET_ID = Convert.ToInt32(DropDownBUDGET_ID.SelectedValue.ToString());
               P.SUBSTAFFTYPE_ID = Convert.ToInt32(DropDownSUBSTAFFTYPE_ID.SelectedValue.ToString());
               P.ADMIN_POSITION_ID = Convert.ToString(DropDownADMIN_POSITION_ID.SelectedValue.ToString());
               P.POSITION_ID = Convert.ToString(DropDownPOSITION_ID.SelectedValue.ToString());
               P.POSITION_WORK_ID = Convert.ToString(DropDownPOSITION_WORK.SelectedValue.ToString());
               P.DEPARTMENT_ID = Convert.ToString(DropDownDEPARTMENT_ID.SelectedValue.ToString());
               P.DATETIME_INWORK = DateTime.Parse(txtDATETIME_INWORRK.Text);
               P.SPECIAL_NAME = txtSPECIAL_NAME.Text;
               P.TEACH_ISCED_ID = Convert.ToString(DropDownTEACH_ISCED_ID.SelectedValue.ToString());
               P.GRAD_LEV_ID = Convert.ToString(DropDownGRAD_LEV_ID.SelectedValue.ToString());
               P.GRAD_CURR = txtGRAD_CURR.Text;
               P.GRAD_ISCED_ID = Convert.ToString(DropDownGRAD_ISCED_ID.SelectedValue.ToString());
               P.GRAD_PROG_ID = Convert.ToString(DropDownGRAD_PROG_ID.SelectedValue.ToString());
               P.GRAD_UNIV = txtGRAD_UNIV.Text;
               P.GRAD_COUNTRY_ID = Convert.ToInt32(DropDownGRAD_COUNTRY_ID.SelectedValue.ToString());

     */
            string[] splitDate1 = txtBIRTHDAY.Text.Split('/');
          //string[] splitDate2 = txtDATETIME_INWORRK.Text.Split('/');
            P.BIRTHDAY = new DateTime(Convert.ToInt32(splitDate1[2]), Convert.ToInt32(splitDate1[1]), Convert.ToInt32(splitDate1[0]));
          //P.DATETIME_INWORK = new DateTime(Convert.ToInt32(splitDate2[2]), Convert.ToInt32(splitDate2[1]), Convert.ToInt32(splitDate2[0]));
        
            P.InsertPersonnel();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('เพิ่มข้อมูลเรียบร้อย')", true);
            ClearData();
        }

    }
}