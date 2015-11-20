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
using System.Data.OracleClient;

namespace WEB_PERSONAL
{
    public partial class Person_ADMIN : System.Web.UI.Page
    {
        public static string strConn = @"Data Source = ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                  BindData();
               // if (Session["login_id"] == null)
               // {
               //     Session["show_login"] = "1";
                    //Response.Redirect("default.aspx");
                    //return;
               // }
                /*using (OracleConnection conn = Util.OC())
                {
                    using (OracleCommand cmd = new OracleCommand("select CITIZEN_ID,TITLE_ID,PERSON_NAME,PERSON_LASTNAME,TO_CHAR(BIRTHDATE,'dd MON yyyy','NLS_DATE_LANGUAGE = THAI'),BIRTHDATE_LONG,TO_CHAR(RETIRE_DATE,'dd MON yyyy','NLS_DATE_LANGUAGE = THAI'),RETIRE_DATE_LONG,TO_CHAR(INWORK_DATE,'dd MON yyyy','NLS_DATE_LANGUAGE = THAI'),STAFFTYPE_ID,FATHER_NAME,FATHER_LASTNAME,MOTHER_NAME,MOTHER_LASTNAME,MOTHER_OLD_LASTNAME,COUPLE_NAME,COUPLE_LASTNAME,COUPLE_OLD_LASTNAME,MINISTRY_ID,DEPARTMENT_NAME from tb_person where citizen_id = '" + Session["login_id"].ToString() + "'", conn))

                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                txtCitizen.Text = reader.GetString(0);
                                DropDownTitle.SelectedValue = reader.IsDBNull(1) ? "0" : reader.GetInt32(1).ToString();
                                txtName.Text = reader.IsDBNull(2) ? "" : reader.GetString(2);
                                txtLastName.Text = reader.IsDBNull(3) ? "" : reader.GetString(3);
                                txtBirthDayNumber.Text = reader.IsDBNull(4) ? "" : reader.GetString(4);
                                txtBirthDayChar.Text = reader.IsDBNull(5) ? "" : reader.GetString(5);
                                txtAge60Number.Text = reader.IsDBNull(6) ? "" : reader.GetString(6);
                                txtAge60Char.Text = reader.IsDBNull(7) ? "" : reader.GetString(7);
                                txtDateInWork.Text = reader.IsDBNull(8) ? "" : reader.GetString(8);
                                DropDownStaffType.SelectedValue = reader.IsDBNull(9) ? "0" : reader.GetInt32(9).ToString();
                                txtFatherName.Text = reader.IsDBNull(10) ? "" : reader.GetString(10);
                                txtFatherLastName.Text = reader.IsDBNull(11) ? "" : reader.GetString(11);
                                txtMotherName.Text = reader.IsDBNull(12) ? "" : reader.GetString(12);
                                txtMotherLastName.Text = reader.IsDBNull(13) ? "" : reader.GetString(13);
                                txtMotherLastNameOld.Text = reader.IsDBNull(14) ? "" : reader.GetString(14);
                                txtMarriedName.Text = reader.IsDBNull(15) ? "" : reader.GetString(15);
                                txtMarriedLastName.Text = reader.IsDBNull(16) ? "" : reader.GetString(16);
                                txtMarriedLastNameOld.Text = reader.IsDBNull(17) ? "" : reader.GetString(17);
                                DropDownMinistry.SelectedValue = reader.IsDBNull(18) ? "0" : reader.GetInt32(18).ToString(); ;
                                txtDepart.Text = reader.IsDBNull(19) ? "" : reader.GetString(19);
                            }
                        }
                    }
                    using (OracleCommand cmd = new OracleCommand("select GRAD_UNIV,to_char(DATE_FROM, 'Mon', 'NLS_DATE_LANGUAGE = THAI'),extract(year FROM DATE_FROM),to_char(DATE_TO, 'Mon','NLS_DATE_LANGUAGE = THAI'),extract(year FROM DATE_TO),MAJOR from TB_STUDY_HISTORY where citizen_id = '" + Session["login_id"].ToString() + "'", conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {

                            Session["StudyHis"] = new DataTable();
                            ((DataTable)(Session["StudyHis"])).Columns.Add("สถานศึกษา");
                            ((DataTable)(Session["StudyHis"])).Columns.Add("ตั้งแต่ - ถึง (เดือน ปี)");
                            ((DataTable)(Session["StudyHis"])).Columns.Add("วุฒิ(สาขาวิชาเอก)");

                            while (reader.Read())
                            {
                                DataRow dr = ((DataTable)(Session["StudyHis"])).NewRow();
                                dr[0] = reader.GetString(0);
                                dr[1] = reader.GetString(1) + "-" + reader.GetInt32(2) + " - " + reader.GetString(3) + "-" + reader.GetInt32(4);
                                dr[2] = reader.GetString(5);

                                ((DataTable)(Session["StudyHis"])).Rows.Add(dr);

                            }
                            GridView1.DataSource = ((DataTable)(Session["StudyHis"]));
                            GridView1.DataBind();
                            ClearDataGridViewNumber10();
                        }
                    }
                    using (OracleCommand cmd = new OracleCommand("select LICENCE_NAME,BRANCH,LICENCE_NO,to_char(DDATE, 'dd MON yyyy','NLS_DATE_LANGUAGE = THAI') from TB_JOB_LICENSE where citizen_id = '" + Session["login_id"].ToString() + "'", conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {

                            Session["JobLisence"] = new DataTable();
                            ((DataTable)(Session["JobLisence"])).Columns.Add("สถานศึกษา");
                            ((DataTable)(Session["JobLisence"])).Columns.Add("หน่วยงาน");
                            ((DataTable)(Session["JobLisence"])).Columns.Add("เลขที่ใบอนุญาต");
                            ((DataTable)(Session["JobLisence"])).Columns.Add("วันที่มีผลบังคับใช้ (วัน เดือน ปี)");

                            while (reader.Read())
                            {
                                DataRow dr = ((DataTable)(Session["JobLisence"])).NewRow();
                                dr[0] = reader.GetString(0);
                                dr[1] = reader.GetString(1);
                                dr[2] = reader.GetString(2);
                                dr[3] = reader.GetString(3);

                                ((DataTable)(Session["JobLisence"])).Rows.Add(dr);

                            }
                            GridView2.DataSource = ((DataTable)(Session["JobLisence"]));
                            GridView2.DataBind();
                            ClearDataGridViewNumber11();
                        }
                    }
                    using (OracleCommand cmd = new OracleCommand("select COURSE,to_char(DATE_FROM, 'Mon', 'NLS_DATE_LANGUAGE = THAI'),extract(year FROM DATE_FROM),to_char(DATE_TO, 'Mon','NLS_DATE_LANGUAGE = THAI'),extract(year FROM DATE_TO),BRANCH_TRAINING from TB_TRAINING_HISTORY where citizen_id = '" + Session["login_id"].ToString() + "'", conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {

                            Session["Trainning"] = new DataTable();
                            ((DataTable)(Session["Trainning"])).Columns.Add("หลักสูตรฝึกอบรม");
                            ((DataTable)(Session["Trainning"])).Columns.Add("ตั้งแต่ - ถึง (เดือน ปี)");
                            ((DataTable)(Session["Trainning"])).Columns.Add("หน่วยงานที่จัดฝึกอบรม");

                            while (reader.Read())
                            {
                                DataRow dr = ((DataTable)(Session["Trainning"])).NewRow();
                                dr[0] = reader.GetString(0);
                                dr[1] = reader.GetString(1) + "-" + reader.GetInt32(2) + " - " + reader.GetString(3) + "-" + reader.GetInt32(4);
                                dr[2] = reader.GetString(5);

                                ((DataTable)(Session["Trainning"])).Rows.Add(dr);

                            }
                            GridView3.DataSource = ((DataTable)(Session["Trainning"]));
                            GridView3.DataBind();
                            ClearDataGridViewNumber12();
                        }
                    }
                    using (OracleCommand cmd = new OracleCommand("select YEAR,MENU,REF_DOC from TB_DISCIPLINARY_AND_AMNESTY where citizen_id = '" + Session["login_id"].ToString() + "'", conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {

                            Session["Punished"] = new DataTable();
                            ((DataTable)(Session["Punished"])).Columns.Add("พ.ศ.");
                            ((DataTable)(Session["Punished"])).Columns.Add("รายการ");
                            ((DataTable)(Session["Punished"])).Columns.Add("เอกสารอ้างอิง");

                            while (reader.Read())
                            {
                                DataRow dr = ((DataTable)(Session["Punished"])).NewRow();
                                dr[0] = reader.GetString(0);
                                dr[1] = reader.GetString(1);
                                dr[2] = reader.GetString(2);

                                ((DataTable)(Session["Punished"])).Rows.Add(dr);

                            }
                            GridView4.DataSource = ((DataTable)(Session["Punished"]));
                            GridView4.DataBind();
                            ClearDataGridViewNumber13();
                        }
                    }
                    using (OracleCommand cmd = new OracleCommand("select to_char(DDATE, 'dd MON yyyy','NLS_DATE_LANGUAGE = THAI'),POSITION_NAME,PERSON_ID,ST_ID,POSITION_ID,SALARY,POSITION_SALARY,REFERENCE_DOCUMENT from TB_POSITION_AND_SALARY where citizen_id = '" + Session["login_id"].ToString() + "'", conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {

                            Session["PositionAndSalary"] = new DataTable();
                            ((DataTable)(Session["PositionAndSalary"])).Columns.Add("วัน เดือน ปี");
                            ((DataTable)(Session["PositionAndSalary"])).Columns.Add("ตำแหน่ง");
                            ((DataTable)(Session["PositionAndSalary"])).Columns.Add("เลขที่ตำแหน่ง");
                            ((DataTable)(Session["PositionAndSalary"])).Columns.Add("ตำแหน่งประเภท");
                            ((DataTable)(Session["PositionAndSalary"])).Columns.Add("ระดับ");
                            ((DataTable)(Session["PositionAndSalary"])).Columns.Add("เงินเดือน");
                            ((DataTable)(Session["PositionAndSalary"])).Columns.Add("เงินประจำตำแหน่ง");
                            ((DataTable)(Session["PositionAndSalary"])).Columns.Add("เอกสารอ้างอิง");

                            while (reader.Read())
                            {
                                DataRow dr = ((DataTable)(Session["PositionAndSalary"])).NewRow();
                                dr[0] = reader.GetString(0);
                                dr[1] = reader.GetString(1);
                                dr[2] = reader.GetString(2);
                                dr[3] = reader.GetString(3);
                                dr[4] = reader.GetInt32(4);
                                dr[5] = reader.GetInt32(5);
                                dr[6] = reader.GetInt32(6);
                                dr[7] = reader.GetString(7);

                                ((DataTable)(Session["PositionAndSalary"])).Rows.Add(dr);

                            }
                            GridView5.DataSource = ((DataTable)(Session["PositionAndSalary"]));
                            GridView5.DataBind();
                            ClearDataGridViewNumber14();
                        }
                    }
                    
                }*/
                DDLMisnistry();
                DDLTitle();
                DDLStaffType();
                DDLMONTH10From();
                DDLYEAR10From();
                DDLMONTH10To();
                DDLYEAR10To();
                DDLMONTH12From();
                DDLYEAR12From();
                DDLMONTH12To();
                DDLYEAR12To();
                DDLYEAR13();
                DDLSTAFFTYPE14();
                txtCitizen.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                txtSalary14.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                txtSalaryForPosition14.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");

            }
        }

        #region ViewState DataTable

        private DataTable GetViewState()
        {
            //Gets the ViewState
            return (DataTable)ViewState["PERSON10"];
        }

        private void SetViewState(DataTable data)
        {
            //Sets the ViewState
            ViewState["PERSON10"] = data;
        }

        #endregion

        void BindData()
        {
            ClassPersonStudyHistory p = new ClassPersonStudyHistory();
            DataTable dt = p.GetPersonStudyHistory("", "", "", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        protected void modEditCommand(Object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindData();
        }
        protected void modCancelCommand(Object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindData();
        }
        protected void modDeleteCommand(Object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            ClassPersonStudyHistory p = new ClassPersonStudyHistory();
            p.IDSEQ = id;
            p.DeletePersonStudyHistory();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ลบข้อมูลเรียบร้อย')", true);

            GridView1.EditIndex = -1;
            BindData();
        }
        protected void modUpdateCommand(Object sender, GridViewUpdateEventArgs e)
        {
            
            Label lblPersonStudyHistoryID = (Label)GridView1.Rows[e.RowIndex].FindControl("lblPersonStudyHistoryID");
            Label lblPersonStudyHistoryCitizenID = (Label)GridView1.Rows[e.RowIndex].FindControl("lblPersonStudyHistoryCitizenID");
            TextBox txtPersonStudyHistoryGradUNIVEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtPersonStudyHistoryGradUNIVEdit");
            TextBox lblPersonStudyHistoryDateFromEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtPersonStudyHistoryDateFromEdit");
            TextBox lblPersonStudyHistoryDateTOEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtPersonStudyHistoryDateTOEdit");
            TextBox txtPersonStudyHistoryMajorEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtPersonStudyHistoryMajorEdit");
            DateTime DATE_FROM = DateTime.Parse(lblPersonStudyHistoryDateFromEdit.Text);
            DateTime DATE_TO = DateTime.Parse(lblPersonStudyHistoryDateTOEdit.Text);

            ClassPersonStudyHistory p = new ClassPersonStudyHistory(Convert.ToInt32(lblPersonStudyHistoryID.Text), lblPersonStudyHistoryCitizenID.Text
                , txtPersonStudyHistoryGradUNIVEdit.Text
                , DATE_FROM
                , DATE_TO
                , txtPersonStudyHistoryMajorEdit.Text);

            p.UpdatePersonStudyHistory();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('อัพเดทข้อมูลเรียบร้อย')", true);
            GridView1.EditIndex = -1;
            BindData();
            
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }
        protected void myGridViewPersonStudyHistory_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }

        private void DDLMisnistry()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_MINISTRY";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownMinistry.DataSource = dt;
                        DropDownMinistry.DataValueField = "MINISTRY_ID";
                        DropDownMinistry.DataTextField = "MINISTRY_NAME";
                        DropDownMinistry.DataBind();
                        sqlConn.Close();

                        DropDownMinistry.Items.Insert(0, new ListItem("--กรุณาเลือกกระทรวง--", "0"));

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
                        DropDownTitle.DataSource = dt;
                        DropDownTitle.DataValueField = "TITLE_ID";
                        DropDownTitle.DataTextField = "TITLE_NAME_TH";
                        DropDownTitle.DataBind();
                        sqlConn.Close();

                        DropDownTitle.Items.Insert(0, new ListItem("--กรุณาเลือกคำนำหน้านาม--", "0"));

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
                        DropDownStaffType.DataSource = dt;
                        DropDownStaffType.DataValueField = "STAFFTYPE_ID";
                        DropDownStaffType.DataTextField = "STAFFTYPE_NAME";
                        DropDownStaffType.DataBind();
                        sqlConn.Close();

                        DropDownStaffType.Items.Insert(0, new ListItem("--กรุณาเลือกประเภทข้าราชการ--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLMONTH10From()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_DDLMONTH";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownMonth10From.DataSource = dt;
                        DropDownMonth10From.DataValueField = "MONTH_SHORT";
                        DropDownMonth10From.DataTextField = "MONTH_SHORT";
                        DropDownMonth10From.DataBind();
                        sqlConn.Close();

                        DropDownMonth10From.Items.Insert(0, new ListItem("--เดือน--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLMONTH10To()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_DDLMONTH";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownMonth10To.DataSource = dt;
                        DropDownMonth10To.DataValueField = "MONTH_SHORT";
                        DropDownMonth10To.DataTextField = "MONTH_SHORT";
                        DropDownMonth10To.DataBind();
                        sqlConn.Close();

                        DropDownMonth10To.Items.Insert(0, new ListItem("--เดือน--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLYEAR10From()
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
                        DropDownYear10From.DataSource = dt;
                        DropDownYear10From.DataValueField = "YEAR_NAME";
                        DropDownYear10From.DataTextField = "YEAR_NAME";
                        DropDownYear10From.DataBind();
                        sqlConn.Close();

                        DropDownYear10From.Items.Insert(0, new ListItem("--ปี--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLYEAR10To()
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
                        DropDownYear10To.DataSource = dt;
                        DropDownYear10To.DataValueField = "YEAR_NAME";
                        DropDownYear10To.DataTextField = "YEAR_NAME";
                        DropDownYear10To.DataBind();
                        sqlConn.Close();

                        DropDownYear10To.Items.Insert(0, new ListItem("--ปี--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLMONTH12From()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_DDLMONTH";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownMonth12From.DataSource = dt;
                        DropDownMonth12From.DataValueField = "MONTH_SHORT";
                        DropDownMonth12From.DataTextField = "MONTH_SHORT";
                        DropDownMonth12From.DataBind();
                        sqlConn.Close();

                        DropDownMonth12From.Items.Insert(0, new ListItem("--เดือน--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLMONTH12To()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_DDLMONTH";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownMonth12To.DataSource = dt;
                        DropDownMonth12To.DataValueField = "MONTH_SHORT";
                        DropDownMonth12To.DataTextField = "MONTH_SHORT";
                        DropDownMonth12To.DataBind();
                        sqlConn.Close();

                        DropDownMonth12To.Items.Insert(0, new ListItem("--เดือน--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLYEAR12From()
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
                        DropDownYear12From.DataSource = dt;
                        DropDownYear12From.DataValueField = "YEAR_NAME";
                        DropDownYear12From.DataTextField = "YEAR_NAME";
                        DropDownYear12From.DataBind();
                        sqlConn.Close();

                        DropDownYear12From.Items.Insert(0, new ListItem("--ปี--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLYEAR12To()
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
                        DropDownYear12To.DataSource = dt;
                        DropDownYear12To.DataValueField = "YEAR_NAME";
                        DropDownYear12To.DataTextField = "YEAR_NAME";
                        DropDownYear12To.DataBind();
                        sqlConn.Close();

                        DropDownYear12To.Items.Insert(0, new ListItem("--ปี--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLYEAR13()
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
                        DropDownYear13.DataSource = dt;
                        DropDownYear13.DataValueField = "YEAR_NAME";
                        DropDownYear13.DataTextField = "YEAR_NAME";
                        DropDownYear13.DataBind();
                        sqlConn.Close();

                        DropDownYear13.Items.Insert(0, new ListItem("--ปี--", "0"));

                    }
                }
            }
            catch { }
        }
        //
        private void DDLSTAFFTYPE14()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_STAFF";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownType_Position14.DataSource = dt;
                        DropDownType_Position14.DataValueField = "ST_ID";
                        DropDownType_Position14.DataTextField = "ST_NAME";
                        DropDownType_Position14.DataBind();
                        sqlConn.Close();

                        DropDownType_Position14.Items.Insert(0, new ListItem("--ตำแหน่งประเภท--", "0"));
                        DropDownDegree14.Items.Insert(0, new ListItem("--ระดับ--", "0"));
                    }
                }
            }
            catch { }
        }

        protected void DropDownType_Position14_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * FROM TB_POSITION_GOVERNMENT_OFFICER where ST_ID = " + DropDownType_Position14.SelectedValue + "UNION ALL select * FROM TB_POSITION_PERMANENT_EMP where ST_ID = " + DropDownType_Position14.SelectedValue;
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownDegree14.DataSource = dt;
                        DropDownDegree14.DataValueField = "ID";
                        DropDownDegree14.DataTextField = "NAME";
                        DropDownDegree14.DataBind();
                        sqlConn.Close();

                        DropDownDegree14.Items.Insert(0, new ListItem("--ระดับ--", "0"));

                    }
                }
            }
            catch { }
        }

        protected void ClearData()
        {
            DropDownMinistry.SelectedIndex = 0;
            txtDepart.Text = "มหาวิทยาลัยเทคโนโลยีราชมงคลตะวันออก";
            DropDownTitle.SelectedIndex = 0;
            txtCitizen.Text = "";
            txtName.Text = "";
            txtLastName.Text = "";
            txtFatherName.Text = "";
            txtFatherLastName.Text = "";
            txtMotherName.Text = "";
            txtMotherLastName.Text = "";
            txtMotherLastNameOld.Text = "";
            txtMarriedName.Text = "";
            txtMarriedLastName.Text = "";
            txtMarriedLastNameOld.Text = "";
            txtBirthDayNumber.Text = "";
            txtBirthDayChar.Text = "";
            txtDateInWork.Text = "";
            DropDownStaffType.SelectedIndex = 0;
            txtAge60Number.Text = "";
            txtAge60Char.Text = "";
        }

        protected void ClearDataGridViewNumber10()
        {
            txtGrad_Univ.Text = "";
            DropDownMonth10From.SelectedIndex = 0;
            DropDownYear10From.SelectedIndex = 0;
            DropDownMonth10To.SelectedIndex = 0;
            DropDownYear10To.SelectedIndex = 0;
            txtMajor.Text = "";
        }

        protected void ClearDataGridViewNumber11()
        {
            txtGrad_Univ11.Text = "";
            txtDepart11.Text = "";
            txtNolicense11.Text = "";
            txtDateEnable11.Text = "";
        }

        protected void ClearDataGridViewNumber12()
        {
            txtCourse.Text = "";
            DropDownMonth12From.SelectedIndex = 0;
            DropDownYear12From.SelectedIndex = 0;
            DropDownMonth12To.SelectedIndex = 0;
            DropDownYear12To.SelectedIndex = 0;
            txtBranchTrainning.Text = "";
        }

        protected void ClearDataGridViewNumber13()
        {
            DropDownYear13.SelectedIndex = 0;
            txtList13.Text = "";
            txtRefDoc13.Text = "";
        }

        protected void ClearDataGridViewNumber14()
        {
            txtDate14.Text = "";
            txtPosition14.Text = "";
            txtNo_Position14.Text = "";
            DropDownType_Position14.SelectedIndex = 0;
            DropDownDegree14.SelectedIndex = 0;
            txtSalary14.Text = "";
            txtSalaryForPosition14.Text = "";
            txtRefDoc14.Text = "";
        }

        public bool NeedData1To9()
        {
            if (DropDownMinistry.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก กระทรวง')", true);
                return true;
            }

            if (string.IsNullOrEmpty(txtDepart.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก กรม')", true);
                return true;
            }
            if (DropDownTitle.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก คำนำหน้านาม')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtCitizen.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก รหัสบัตรประชาชน')", true);
                return true;
            }
            if (txtCitizen.Text.Length < 13)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก รหัสบัตรประชาชนให้ครบ 13 หลัก')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ชื่อ')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก นามสกุล')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtFatherName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ชื่อบิดา')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtFatherLastName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก นามสกุลบิดา')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtMotherName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ชื่อมารดา')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtMotherLastName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก นามสกุลมารดา')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtMotherLastNameOld.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก นามสกุลมารดาเดิม')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtMarriedName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ชื่อคู่สมรส')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtMarriedLastName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก นามสกุลคู่สมรส')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtMarriedLastNameOld.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก นามสกุลเดิมคู่สมรสเดิม')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtBirthDayNumber.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก วัน เดือน ปีเกิด (dd-mm-yyyy)')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtBirthDayChar.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก วัน เดือน ปีเกิด (ตัวบรรจง เต็มบรรทัด)')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtDateInWork.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก วันที่บรรจุ (dd-mm-yyyy)')", true);
                return true;
            }
            if (DropDownStaffType.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก ประเภทข้าราชการ')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtAge60Number.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก วันครบเกษียณอายุ (dd-mm-yyyy)')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtAge60Char.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก วันครบเกษียณอายุ (ตัวบรรจง เต็มบรรทัด)')", true);
                return true;
            }
            return false;
        }

        public bool NeedData10()
        {
            if (GridView1.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก สถานศึกษา<ในส่วนประวัติการศึกษา>')", true);
                return true;
            }
            if (DropDownMonth10From.SelectedIndex == 0 && GridView1.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือกให้ครบ ตั้งแต่ - ถึง (เดือน ปี)<ในส่วนประวัติการศึกษา>')", true);
                return true;
            }
            if (DropDownYear10From.SelectedIndex == 0 && GridView1.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือกให้ครบ ตั้งแต่ - ถึง (เดือน ปี)<ในส่วนประวัติการศึกษา>')", true);
                return true;
            }
            if (DropDownMonth10To.SelectedIndex == 0 && GridView1.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือกให้ครบ ตั้งแต่ - ถึง (เดือน ปี)<ในส่วนประวัติการศึกษา>')", true);
                return true;
            }
            if (DropDownYear10To.SelectedIndex == 0 && GridView1.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือกให้ครบ ตั้งแต่ - ถึง (เดือน ปี)<ในส่วนประวัติการศึกษา>')", true);
                return true;
            }
            if (GridView1.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก วุฒิ(สาาขาาวิชาเอก)<ในส่วนประวัติการศึกษา>')", true);
                return true;
            }
            return false;
        }

        public bool NeedData11()
        {
            if (string.IsNullOrEmpty(txtGrad_Univ11.Text) && GridView2.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ชื่อใบอนุญาต<ใบอนุญาตประกอบวิชาชีพ>')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtDepart11.Text) && GridView2.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก หน่วยงาน<ใบอนุญาตประกอบวิชาชีพ>')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtNolicense11.Text) && GridView2.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก เลขที่ใบอนุญาต<ใบอนุญาตประกอบวิชาชีพ>')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtDateEnable11.Text) && GridView2.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก วันที่มีผลบังคับใช้(วัน เดือน ปี)<ใบอนุญาตประกอบวิชาชีพ>')", true);
                return true;
            }
            return false;
        }

        public bool NeedData12()
        {
            if (string.IsNullOrEmpty(txtCourse.Text) && GridView3.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก หลักสูตรฝึกอบรม<ในส่วนประวัติการฝึกอบรม>')", true);
                return true;
            }
            if (DropDownMonth12From.SelectedIndex == 0 && GridView3.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือกให้ครบ ตั้งแต่ - ถึง (เดือน ปี)<ในส่วนประวัติการฝึกอบรม>')", true);
                return true;
            }
            if (DropDownYear12From.SelectedIndex == 0 && GridView3.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือกให้ครบ ตั้งแต่ - ถึง (เดือน ปี)<ในส่วนประวัติการฝึกอบรม>')", true);
                return true;
            }
            if (DropDownMonth12To.SelectedIndex == 0 && GridView3.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือกให้ครบ ตั้งแต่ - ถึง (เดือน ปี)<ในส่วนประวัติการฝึกอบรม>')", true);
                return true;
            }
            if (DropDownYear12To.SelectedIndex == 0 && GridView3.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือกให้ครบ ตั้งแต่ - ถึง (เดือน ปี)<ในส่วนประวัติการฝึกอบรม>')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtBranchTrainning.Text) && GridView3.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก หน่วยงานที่จัดฝึกอบรม<ในส่วนประวัติการฝึกอบรม>')", true);
                return true;
            }
            return false;
        }

        public bool NeedData13()
        {
            if (DropDownYear13.SelectedIndex == 0 && GridView4.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก พ.ศ.<ในส่วนการได้รับโทษทางวินัยและการนิรโทษกรรม>')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtList13.Text) && GridView4.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก รายการ<ในส่วนการได้รับโทษทางวินัยและการนิรโทษกรรม>')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtRefDoc13.Text) && GridView4.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก เอกสารอ้างอิง<ในส่วนการได้รับโทษทางวินัยและการนิรโทษกรรม>')", true);
                return true;
            }
            return false;
        }

        public bool NeedData14()
        {
            if (string.IsNullOrEmpty(txtDate14.Text) && GridView5.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก วัน เดือน ปี<ในส่วนตำแหน่งและเงินเดือน>')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtPosition14.Text) && GridView5.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ตำแหน่ง<ในส่วนตำแหน่งและเงินเดือน>')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtNo_Position14.Text) && GridView5.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก เลขที่ตำแหน่ง<ในส่วนตำแหน่งและเงินเดือน>')", true);
                return true;
            }
            if (DropDownType_Position14.SelectedIndex == 0 && GridView5.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก ตำแหน่งประเภท<ในส่วนตำแหน่งและเงินเดือน>')", true);
                return true;
            }
            if (DropDownDegree14.SelectedIndex == 0 && GridView5.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก ระดับ<ในส่วนตำแหน่งและเงินเดือน>')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtSalary14.Text) && GridView5.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก เงินเดือน<ในส่วนตำแหน่งและเงินเดือน>')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtSalaryForPosition14.Text) && GridView5.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก เงินประจำตำแหน่ง<ในส่วนตำแหน่งและเงินเดือน>')", true);
                return true;
            }
            if (string.IsNullOrEmpty(txtRefDoc14.Text) && GridView5.Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก เอกสารอ้างอิง<ในส่วนตำแหน่งและเงินเดือน>')", true);
                return true;
            }
            return false;
        }

        protected void btnCancelPerson_Click(object sender, EventArgs e)
        {
            ClearData();
            ClearDataGridViewNumber10();
            ClearDataGridViewNumber11();
            ClearDataGridViewNumber12();
            ClearDataGridViewNumber13();
            ClearDataGridViewNumber14();

        }

        protected void btnSubmitPerson_Click(object sender, EventArgs e)
        {
            if (NeedData1To9() || NeedData10() || NeedData11() || NeedData12() || NeedData13() || NeedData14()) { return; }
            ClassPerson P = new ClassPerson();
            P.CITIZEN_ID = txtCitizen.Text;
            P.BIRTHDATE = DateTime.Parse(txtBirthDayNumber.Text);
            P.INWORK_DATE = DateTime.Parse(txtDateInWork.Text);
            P.RETIRE_DATE = DateTime.Parse(txtAge60Number.Text);
            P.DEPARTMENT_NAME = txtDepart.Text;
            P.MINISTRY_ID = Convert.ToInt32(DropDownMinistry.SelectedValue);
            P.TITLE_ID = DropDownTitle.SelectedValue;
            P.BIRTHDATE_LONG = txtBirthDayChar.Text;
            P.RETIRE_DATE_LONG = txtAge60Char.Text;
            P.STAFFTYPE_ID = Convert.ToInt32(DropDownStaffType.SelectedValue);
            P.FATHER_NAME = txtFatherName.Text;
            P.FATHER_LASTNAME = txtFatherLastName.Text;
            P.MOTHER_NAME = txtMotherName.Text;
            P.MOTHER_LASTNAME = txtMotherLastName.Text;
            P.MOTHER_OLD_LASTNAME = txtMotherLastNameOld.Text;
            P.COUPLE_NAME = txtMarriedName.Text;
            P.COUPLE_LASTNAME = txtMarriedLastName.Text;
            P.COUPLE_OLD_LASTNAME = txtMarriedLastNameOld.Text;
            P.PERSON_LASTNAME = txtLastName.Text;
            P.PERSON_NAME = txtName.Text;

            string[] splitDate1 = txtBirthDayNumber.Text.Split(' ');
            string[] splitDate2 = txtDateInWork.Text.Split(' ');
            string[] splitDate3 = txtAge60Number.Text.Split(' ');
            if (splitDate1.Length == 4)
            {
                splitDate1[2] = splitDate1[3];
            }
            if (splitDate2.Length == 4)
            {
                splitDate2[2] = splitDate2[3];
            }
            if (splitDate3.Length == 4)
            {
                splitDate3[2] = splitDate3[3];
            }
            P.BIRTHDATE = new DateTime(Convert.ToInt32(splitDate1[2]), Util.MonthToNumber(splitDate1[1]), Convert.ToInt32(splitDate1[0]));
            P.INWORK_DATE = new DateTime(Convert.ToInt32(splitDate2[2]), Util.MonthToNumber(splitDate2[1]), Convert.ToInt32(splitDate2[0]));
            P.RETIRE_DATE = new DateTime(Convert.ToInt32(splitDate3[2]), Util.MonthToNumber(splitDate3[1]), Convert.ToInt32(splitDate3[0]));

            P.UpdatePerson();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('อัพเดทข้อมูลเรียบร้อย')", true);



        }
        protected void txtBirthDayNumber_TextChanged(object sender, EventArgs e)
        {
            txtBirthDayChar.Text = Util.ToThaiWord(txtBirthDayNumber.Text);
        }

        protected void txtAge60Number_TextChanged(object sender, EventArgs e)
        {
            txtAge60Char.Text = Util.ToThaiWord(txtAge60Number.Text);
        }

        protected void ButtonPlus10_Click(object sender, EventArgs e)
        {



        }

        protected void ButtonPlus11_Click(object sender, EventArgs e)
        {



        }

        protected void ButtonPlus12_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonPlus13_Click(object sender, EventArgs e)
        {


        }

        protected void ButtonPlus14_Click(object sender, EventArgs e)
        {

        }

    }
}