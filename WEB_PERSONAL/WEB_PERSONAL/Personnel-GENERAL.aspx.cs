using WEB_PERSONAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;
using System.Data;
using System.Configuration;

namespace WEB_PERSONAL
{
    public partial class Personnel_GENERAL : System.Web.UI.Page
    {
      //  public static string strConn = @"Data Source = 203.158.140.67; Initial Catalog = personal; Integrated Security = False; User ID = rmutto; Password = Zxcvbnm!";
        public static string strConn = @"Data Source = ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindPROVINCEList();
                DDLYear();
                DDLUniv();
                DDLTitle();
                DDLGender();
                DDLNation();
                DDLStaffType();
                DDLTimeContact();
                DDLBudget();
                DDLSubStaffType();
                DDLAdminPosition();
                DDLPosition();
                DDLPositionWork();
                DDLDepartment();
                DDLTeachISCED();
                DDLGradLEV();
                DDLISCED();
                DDLGradProg();
                DDLGradCountry();
                txtCITIZEN_ID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                txtTELEPHONE.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                
            }

        }

        private void DDLYear()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_YEAR";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownYEAR.DataSource = dt;
                        DropDownYEAR.DataValueField = "YEAR_NAME";
                        DropDownYEAR.DataTextField = "YEAR_NAME";
                        DropDownYEAR.DataBind();
                        sqlConn.Close();

                        DropDownYEAR.Items.Insert(0, new ListItem("--กรุณาเลือก ปีการศึกษา--", "0"));

                    }
                }
            }
            catch { }
        }
        

        private void DDLUniv()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_UNIVERSITY_V2";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownUNIV.DataSource = dt;
                        DropDownUNIV.DataValueField = "UNIV_ID";
                        DropDownUNIV.DataTextField = "UNIV_NAME";
                        DropDownUNIV.DataBind();
                        sqlConn.Close();

                        DropDownUNIV.Items.Insert(0, new ListItem("--กรุณาเลือก มหาวิทยาลัย--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLTitle()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_TITLENAME";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownTITLE.DataSource = dt;
                        DropDownTITLE.DataValueField = "TITLE_ID";
                        DropDownTITLE.DataTextField = "TITLE_NAME_TH";
                        DropDownTITLE.DataBind();
                        sqlConn.Close();

                        DropDownTITLE.Items.Insert(0, new ListItem("--กรุณาเลือก คำนำหน้าชื่อ--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLGender()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_GENDER";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownGENDER.DataSource = dt;
                        DropDownGENDER.DataValueField = "GENDER_ID";
                        DropDownGENDER.DataTextField = "GENDER_NAME";
                        DropDownGENDER.DataBind();
                        sqlConn.Close();

                        DropDownGENDER.Items.Insert(0, new ListItem("--กรุณเลือก เพศ--", "0"));

                    }
                }
            }
            catch { }
        }


        private void BindPROVINCEList()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_PROVINCE";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        ddlPROVINCE.DataSource = dt;
                        ddlPROVINCE.DataValueField = "PROVINCE_ID";
                        ddlPROVINCE.DataTextField = "PROVINCE_TH";
                        ddlPROVINCE.DataBind();
                        sqlConn.Close();

                        ddlPROVINCE.Items.Insert(0, new ListItem("--กรุณาเลือก จังหวัด--", "0"));
                        ddlAMPHUR.Items.Insert(0, new ListItem("--กรุณาเลือก อำเภอ--", "0"));
                        ddlDISTRICT.Items.Insert(0, new ListItem("--กรุณาเลือก ตำบล--", "0"));
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
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_AMPHUR where PROVINCE_ID=:PROVINCE_ID";
                        sqlCmd.Parameters.AddWithValue(":PROVINCE_ID", ddlPROVINCE.SelectedValue);
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        ddlAMPHUR.DataSource = dt;
                        ddlAMPHUR.DataValueField = "AMPHUR_ID";
                        ddlAMPHUR.DataTextField = "AMPHUR_TH";
                        ddlAMPHUR.DataBind();
                        sqlConn.Close();

                        ddlAMPHUR.Items.Insert(0, new ListItem("--กรุณาเลือก อำเภอ--", "0"));
                        ddlDISTRICT.Items.Clear();
                        ddlDISTRICT.Items.Insert(0, new ListItem("--กรุณาเลือก ตำบล--", "0"));
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
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_DISTRICT where AMPHUR_ID=:DISTRICT_ID";
                        sqlCmd.Parameters.AddWithValue(":DISTRICT_ID", ddlAMPHUR.SelectedValue);
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        ddlDISTRICT.DataSource = dt;
                        ddlDISTRICT.DataValueField = "DISTRICT_ID";
                        ddlDISTRICT.DataTextField = "DISTRICT_TH";
                        ddlDISTRICT.DataBind();
                        sqlConn.Close();

                        ddlDISTRICT.Items.Insert(0, new ListItem("--กรุณาเลือก ตำบล--", "0"));
                        txtZIPCODE.Text = "";

                    }
                }
            }
            catch { }
        }

        protected void ddlDISTRICT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ZIPCODE = "select POST_CODE from TB_DISTRICT where DISTRICT_ID = " + ddlDISTRICT.SelectedValue + "";

            OracleConnection conn = new OracleConnection(ConfigurationManager.ConnectionStrings["RMUTTOORCL"].ConnectionString);

            conn.Open();

            OracleCommand SC = new OracleCommand(ZIPCODE, conn);
            string ZIPCODE2 = SC.ExecuteScalar().ToString();

            txtZIPCODE.Text = ZIPCODE2;
        }
        
        private void DDLNation()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_NATIONAL";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownNATION.DataSource = dt;
                        DropDownNATION.DataValueField = "NATION_ID";
                        DropDownNATION.DataTextField = "NATION_THA";
                        DropDownNATION.DataBind();
                        sqlConn.Close();

                        DropDownNATION.Items.Insert(0, new ListItem("--กรุณาเลือก สัญชาติ--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLStaffType()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_STAFFTYPE";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownSTAFFTYPE.DataSource = dt;
                        DropDownSTAFFTYPE.DataValueField = "STAFFTYPE_ID";
                        DropDownSTAFFTYPE.DataTextField = "STAFFTYPE_NAME";
                        DropDownSTAFFTYPE.DataBind();
                        sqlConn.Close();

                        DropDownSTAFFTYPE.Items.Insert(0, new ListItem("--กรุณาเลือก ประเภทบุคลากร--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLTimeContact()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_TIME_CONTACT";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownTIME_CONTACT.DataSource = dt;
                        DropDownTIME_CONTACT.DataValueField = "TIME_CONTACT_ID";
                        DropDownTIME_CONTACT.DataTextField = "TIME_CONTACT_NAME";
                        DropDownTIME_CONTACT.DataBind();
                        sqlConn.Close();

                        DropDownTIME_CONTACT.Items.Insert(0, new ListItem("--กรุณาเลือก ระยะเวลาจ้าง--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLBudget()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_BUDGET";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownBUDGET.DataSource = dt;
                        DropDownBUDGET.DataValueField = "BUDGET_ID";
                        DropDownBUDGET.DataTextField = "BUDGET_NAME";
                        DropDownBUDGET.DataBind();
                        sqlConn.Close();

                        DropDownBUDGET.Items.Insert(0, new ListItem("--กรุณาเลือก ประเภทเงินจ้าง--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLSubStaffType()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_SUBSTAFFTYPE";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownSUBSTAFFTYPE.DataSource = dt;
                        DropDownSUBSTAFFTYPE.DataValueField = "SUBSTAFFTYPE_ID";
                        DropDownSUBSTAFFTYPE.DataTextField = "SUBSTAFFTYPE_NAME";
                        DropDownSUBSTAFFTYPE.DataBind();
                        sqlConn.Close();

                        DropDownSUBSTAFFTYPE.Items.Insert(0, new ListItem("--กรุณาเลือก ประเภทบุคลากรย่อย--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLAdminPosition()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_ADMIN_POSITION";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownADMIN_POSITION.DataSource = dt;
                        DropDownADMIN_POSITION.DataValueField = "ADMIN_POSITION_ID";
                        DropDownADMIN_POSITION.DataTextField = "ADMIN_POSITION_NAME";
                        DropDownADMIN_POSITION.DataBind();
                        sqlConn.Close();

                        DropDownADMIN_POSITION.Items.Insert(0, new ListItem("--กรุณาเลือก ตำแหน่งบริหาร--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLPosition()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_POSITION";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownPOSITION.DataSource = dt;
                        DropDownPOSITION.DataValueField = "POSITION_ID";
                        DropDownPOSITION.DataTextField = "POSITION_NAME";
                        DropDownPOSITION.DataBind();
                        sqlConn.Close();

                        DropDownPOSITION.Items.Insert(0, new ListItem("--กรุณาเลือก ตำแหน่งทางวิชาการ--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLPositionWork()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_POSITION_WORK";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownPOSITION_WORK.DataSource = dt;
                        DropDownPOSITION_WORK.DataValueField = "POSITION_WORK_ID";
                        DropDownPOSITION_WORK.DataTextField = "POSITION_WORK_NAME";
                        DropDownPOSITION_WORK.DataBind();
                        sqlConn.Close();

                        DropDownPOSITION_WORK.Items.Insert(0, new ListItem("--กรุณาเลือก ตำแหน่งในสายงาน--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLDepartment()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_DEPARTMENT";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownDEPARTMENT.DataSource = dt;
                        DropDownDEPARTMENT.DataValueField = "DEPARTMENT_ID";
                        DropDownDEPARTMENT.DataTextField = "DEPARTMENT_NAME";
                        DropDownDEPARTMENT.DataBind();
                        sqlConn.Close();

                        DropDownDEPARTMENT.Items.Insert(0, new ListItem("--กรุณาเลือก คณะ/หน่วยงานที่สังกัด หรือเทียบเท่า--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLTeachISCED()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_TEACH_ISCED";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownTEACH_ISCED.DataSource = dt;
                        DropDownTEACH_ISCED.DataValueField = "ISCED_ID";
                        DropDownTEACH_ISCED.DataTextField = "ISCED_NAME_TH";
                        DropDownTEACH_ISCED.DataBind();
                        sqlConn.Close();

                        DropDownTEACH_ISCED.Items.Insert(0, new ListItem("--กรุณาเลือก กลุ่มสาขาวิชาที่สอน(ISCED)--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLGradLEV()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_LEV";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownGRAD_LEV.DataSource = dt;
                        DropDownGRAD_LEV.DataValueField = "LEV_ID";
                        DropDownGRAD_LEV.DataTextField = "LEV_NAME";
                        DropDownGRAD_LEV.DataBind();
                        sqlConn.Close();

                        DropDownGRAD_LEV.Items.Insert(0, new ListItem("--กรุณาเลือก ระดับการศึกษาที่จบสูงสุด--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLISCED()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_ISCED";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownGRAD_ISCED.DataSource = dt;
                        DropDownGRAD_ISCED.DataValueField = "ISCED_ID";
                        DropDownGRAD_ISCED.DataTextField = "ISCED_NAME";
                        DropDownGRAD_ISCED.DataBind();
                        sqlConn.Close();

                        DropDownGRAD_ISCED.Items.Insert(0, new ListItem("--กรุณาเลือก กลุ่มสาขาวิชาที่จบสูงสุด(ISCED)--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLGradProg()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_PROGRAM";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownGRAD_PROG.DataSource = dt;
                        DropDownGRAD_PROG.DataValueField = "GRAD_PROG_ID";
                        DropDownGRAD_PROG.DataTextField = "GRAD_PROG_NAME";
                        DropDownGRAD_PROG.DataBind();
                        sqlConn.Close();

                        DropDownGRAD_PROG.Items.Insert(0, new ListItem("--กรุณาเลือก สาขาวิชาที่จบสูงสุด--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLGradCountry()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_COUNTRY order by SHORT_NAME asc";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownGRAD_COUNTRY.DataSource = dt;
                        DropDownGRAD_COUNTRY.DataValueField = "COUNTRY_ID";
                        DropDownGRAD_COUNTRY.DataTextField = "SHORT_NAME";
                        DropDownGRAD_COUNTRY.DataBind();
                        sqlConn.Close();

                        DropDownGRAD_COUNTRY.Items.Insert(0, new ListItem("--กรุณาเลือก ประเทศที่จบการศึกษาสูงสุด--", "0"));

                    }
                }
            }
            catch { }
        }

        protected void ClearData()
        {
            DropDownYEAR.SelectedIndex = 0;
            txtCITIZEN_ID.Text = "";
            DropDownUNIV.SelectedIndex = 0;
            DropDownTITLE.SelectedIndex = 0;
            txtSTF_NAME.Text = "";
            txtSTF_LNAME.Text = "";
            DropDownGENDER.SelectedIndex = 0;
            txtBIRTHDAY.Text = "";
            txtHOMEADD.Text = "";
            txtMOO.Text = "";
            txtSTREET.Text = "";
            ddlPROVINCE.SelectedIndex = 0;
            ddlAMPHUR.SelectedIndex = 0;
            ddlDISTRICT.SelectedIndex = 0;
            txtZIPCODE.Text = "";
            txtTELEPHONE.Text = "";
            DropDownNATION.SelectedIndex = 0;
            DropDownSTAFFTYPE.SelectedIndex = 0;
            DropDownTIME_CONTACT.SelectedIndex = 0;
            DropDownBUDGET.SelectedIndex = 0;
            DropDownSUBSTAFFTYPE.SelectedIndex = 0;
            DropDownADMIN_POSITION.SelectedIndex = 0;
            DropDownPOSITION.SelectedIndex = 0;
            DropDownPOSITION_WORK.SelectedIndex = 0;
            DropDownDEPARTMENT.SelectedIndex = 0;
            txtDATETIME_INWORRK.Text = "";
            txtSPECIAL_NAME.Text = "";
            DropDownTEACH_ISCED.SelectedIndex = 0;
            DropDownGRAD_LEV.SelectedIndex = 0;
            txtGRAD_CURR.Text = "";
            DropDownGRAD_ISCED.SelectedIndex = 0;
            DropDownGRAD_PROG.SelectedIndex = 0;
            txtGRAD_UNIV.Text = "";
            DropDownGRAD_COUNTRY.SelectedIndex = 0;
        }


        protected void btnCancelPersonnel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        protected void btnSubmitPersonnel_Click(object sender, EventArgs e)
        {
            /*if (DropDownYEAR.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก ข้อมูลปีการศึกษา')", true);
                return;
            }
            if (DropDownUNIV.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก ข้อมูลมหาวิทยาลัย')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtCITIZEN_ID.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก รหัสบัตรประชาชน')", true);
                return;
            }
            if (txtCITIZEN_ID.Text.Length < 13)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก รหัสบัตรประชาชนให้ครบ 13 หลัก')", true);
                return;
            }
            if (DropDownTITLE.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก คำนำหน้าชื่อ')", true);
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
            if (DropDownGENDER.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก ข้อมูลเพศ')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtBIRTHDAY.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก วันเกิด')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtHOMEADD.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก บ้านเลขที่')", true);
                return;
            }
            if (ddlPROVINCE.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก ข้อมูลจังหวัด')", true);
                return;
            }
            if (ddlAMPHUR.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก ข้อมูลอำเภอ')", true);
                return;
            }
            if (ddlDISTRICT.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก ข้อมูลตำบล')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtZIPCODE.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก รหัสไปรษณีย์')", true);
                return;
            }
            if (DropDownNATION.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก สัญชาติ')", true);
                return;
            }
            if (DropDownSTAFFTYPE.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก ประเภทบุคลากร')", true);
                return;
            }
            if (DropDownTIME_CONTACT.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก ระยะเวลาจ้าง')", true);
                return;
            }
            if (DropDownBUDGET.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก ประเภทเงินจ้าง')", true);
                return;
            }
            if (DropDownSTAFFTYPE.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก ประเภทบุคลากรย่อย')", true);
                return;
            }
            if (DropDownADMIN_POSITION.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก ตำแหน่งบริหาร')", true);
                return;
            }
            if (DropDownPOSITION.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก ตำแหน่งทางวิชาการ')", true);
                return;
            }
            if (DropDownPOSITION_WORK.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก ตำแหน่งในสายงาน')", true);
                return;
            }
            if (DropDownDEPARTMENT.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก คณะ/หน่วยงานที่สังกัด หรือเทียบเท่า')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtDATETIME_INWORRK.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก วันที่เข้าทำงาน ณ สถานที่ปัจจุบัน')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtSPECIAL_NAME.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก สาขางานที่เชี่ยวชาญ')", true);
                return;
            }
            if (DropDownTEACH_ISCED.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก กลุ่มสาขาวิชาที่สอน(ISCED)')", true);
                return;
            }
            if (DropDownGRAD_LEV.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก ระดับการศึกษาที่จบสูงสุด')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtGRAD_CURR.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก หลักสูตรที่จบการศึกษาสูงสุด')", true);
                return;
            }
            if (DropDownGRAD_ISCED.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก กลุ่มสาขาวิชาที่จบสูงสุด(ISCED)')", true);
                return;
            }
            if (DropDownGRAD_PROG.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก สาขาวิชาที่จบสูงสุด')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtGRAD_UNIV.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ชื่อสถาบันที่จบการศึกษาสูงสุด')", true);
                return;
            }
            if (DropDownGRAD_COUNTRY.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก ประเทศที่จบการศึกษาสูงสุด')", true);
                return;
            }*/

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
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก วันเกิด')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtZIPCODE.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก รหัสไปรษณีย์')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtDATETIME_INWORRK.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก วันที่เข้าทำงาน ณ สถานที่ปัจจุบัน')", true);
                return;
            }


            Personnel P = new Personnel(); 
            P.YEAR = Convert.ToInt32(DropDownYEAR.SelectedValue);
            P.UNIV_ID = Convert.ToString(DropDownUNIV.SelectedValue.ToString());
            P.CITIZEN_ID = txtCITIZEN_ID.Text;
            P.TITLE_ID = Convert.ToString(DropDownTITLE.SelectedValue.ToString());
            P.STF_NAME = txtSTF_NAME.Text;
            P.STF_LNAME = txtSTF_LNAME.Text;
            P.GENDER_ID = Convert.ToInt32(DropDownGENDER.SelectedValue.ToString());
            P.BIRTHDAY = DateTime.Parse(txtBIRTHDAY.Text);
            P.HOMEADD = txtHOMEADD.Text;
            P.MOO = txtMOO.Text;
            P.STREET = txtSTREET.Text;
            P.DISTRICT_ID = Convert.ToInt32(ddlDISTRICT.SelectedValue.ToString());
            P.AMPHUR_ID = Convert.ToInt32(ddlAMPHUR.SelectedValue.ToString());
            P.PROVINCE_ID = Convert.ToInt32(ddlPROVINCE.SelectedValue.ToString());
            P.TELEPHONE = txtTELEPHONE.Text;
            P.ZIPCODE_ID = Convert.ToInt32(txtZIPCODE.Text);
            P.NATION_ID = Convert.ToString(DropDownNATION.SelectedValue.ToString());
            P.STAFFTYPE_ID = Convert.ToInt32(DropDownSTAFFTYPE.SelectedValue.ToString());
            P.TIME_CONTACT_ID = Convert.ToInt32(DropDownTIME_CONTACT.SelectedValue.ToString());
            P.BUDGET_ID = Convert.ToInt32(DropDownBUDGET.SelectedValue.ToString());
            P.SUBSTAFFTYPE_ID = Convert.ToInt32(DropDownSUBSTAFFTYPE.SelectedValue.ToString());
            P.ADMIN_POSITION_ID = Convert.ToString(DropDownADMIN_POSITION.SelectedValue.ToString());
            P.POSITION_ID = Convert.ToString(DropDownPOSITION.SelectedValue.ToString());
            P.POSITION_WORK_ID = Convert.ToString(DropDownPOSITION_WORK.SelectedValue.ToString());
            P.DEPARTMENT_ID = Convert.ToString(DropDownDEPARTMENT.SelectedValue.ToString());
            P.DATETIME_INWORK = DateTime.Parse(txtDATETIME_INWORRK.Text);
            P.SPECIAL_NAME = txtSPECIAL_NAME.Text;
            P.TEACH_ISCED_ID = Convert.ToString(DropDownTEACH_ISCED.SelectedValue.ToString());
            P.GRAD_LEV_ID = Convert.ToString(DropDownGRAD_LEV.SelectedValue.ToString());
            P.GRAD_CURR = txtGRAD_CURR.Text;
            P.GRAD_ISCED_ID = Convert.ToString(DropDownGRAD_ISCED.SelectedValue.ToString());
            P.GRAD_PROG_ID = Convert.ToString(DropDownGRAD_PROG.SelectedValue.ToString());
            P.GRAD_UNIV = txtGRAD_UNIV.Text;
            P.GRAD_COUNTRY_ID = Convert.ToInt32(DropDownGRAD_COUNTRY.SelectedValue.ToString());

            string[] splitDate1 = txtBIRTHDAY.Text.Split('/');
            string[] splitDate2 = txtDATETIME_INWORRK.Text.Split('/');
            P.BIRTHDAY = new DateTime(Convert.ToInt32(splitDate1[2]), Convert.ToInt32(splitDate1[1]), Convert.ToInt32(splitDate1[0]));
            P.DATETIME_INWORK = new DateTime(Convert.ToInt32(splitDate2[2]), Convert.ToInt32(splitDate2[1]), Convert.ToInt32(splitDate2[0]));

            if (P.CheckUseCitizenID())
            {
                P.InsertPersonnel();
                ClearData();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('เพิ่มข้อมูลเรียบร้อย')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('มีรหัสประจำตัวประชาชนอยู่ในระบบแล้ว !')", true);
            }
        }
    }

    
}