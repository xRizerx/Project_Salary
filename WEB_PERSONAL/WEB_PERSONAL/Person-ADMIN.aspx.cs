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

                using (OracleConnection conn = Util.OC())
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

                }
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
            if (Session["login_id"] == null)
            {
                Response.Redirect("Access.aspx");
                return;
            }

            ClassPersonStudyHistory p1 = new ClassPersonStudyHistory();
            DataTable dt1 = p1.GetPersonStudyHistory("", "", "", "", "", "", Session["login_id"].ToString());
            GridView1.DataSource = dt1;
            GridView1.DataBind();

            ClassPersonJobLisence p2 = new ClassPersonJobLisence();
            DataTable dt2 = p2.GetPersonJobLisence("", "", "", "", Session["login_id"].ToString());
            GridView2.DataSource = dt2;
            GridView2.DataBind();

            ClassPersonTraining p3 = new ClassPersonTraining();
            DataTable dt3 = p3.GetPersonTraining("", "", "", "", "", "", Session["login_id"].ToString());
            GridView3.DataSource = dt3;
            GridView3.DataBind();

            ClassPersonDISCIPLINARY p4 = new ClassPersonDISCIPLINARY();
            DataTable dt4 = p4.GetPersonDISCIPLINARY("", "", "", Session["login_id"].ToString());
            GridView4.DataSource = dt4;
            GridView4.DataBind();

            ClassPersonPosiSalary p5 = new ClassPersonPosiSalary();
            DataTable dt5 = p5.GetPersonPosiSalary("", "", "", "", 0, 0, 0, "", Session["login_id"].ToString());
            GridView5.DataSource = dt5;
            GridView5.DataBind();

            SetViewState(dt1);
            SetViewState(dt2);
            SetViewState(dt3);
            SetViewState(dt4);
            SetViewState(dt5);
        }

        protected void modEditCommand1(Object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindData();
        }
        protected void modCancelCommand1(Object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindData();
        }
        protected void modDeleteCommand1(Object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            ClassPersonStudyHistory p1 = new ClassPersonStudyHistory();
            p1.IDSEQ = id;
            p1.DeletePersonStudyHistory();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ลบข้อมูลเรียบร้อย')", true);

            GridView1.EditIndex = -1;
            BindData();
        }
        protected void modUpdateCommand1(Object sender, GridViewUpdateEventArgs e)
        {

            Label lblPersonStudyHistoryID = (Label)GridView1.Rows[e.RowIndex].FindControl("lblPersonStudyHistoryID");
            Label lblPersonStudyHistoryCitizenID = (Label)GridView1.Rows[e.RowIndex].FindControl("lblPersonStudyHistoryCitizenID");
            TextBox txtPersonStudyHistoryGradUNIVEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtPersonStudyHistoryGradUNIVEdit");
            DropDownList ddl_101 = (DropDownList)GridView1.Rows[e.RowIndex].FindControl("ddl_101");
            DropDownList ddl_102 = (DropDownList)GridView1.Rows[e.RowIndex].FindControl("ddl_102");
            DropDownList ddl_103 = (DropDownList)GridView1.Rows[e.RowIndex].FindControl("ddl_103");
            DropDownList ddl_104 = (DropDownList)GridView1.Rows[e.RowIndex].FindControl("ddl_104");
            TextBox txtPersonStudyHistoryMajorEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtPersonStudyHistoryMajorEdit");

            ClassPersonStudyHistory p1 = new ClassPersonStudyHistory(Convert.ToInt32(lblPersonStudyHistoryID.Text), lblPersonStudyHistoryCitizenID.Text
                , txtPersonStudyHistoryGradUNIVEdit.Text
                , ddl_101.SelectedValue
                , ddl_102.SelectedValue
                , ddl_103.SelectedValue
                , ddl_104.SelectedValue
                , txtPersonStudyHistoryMajorEdit.Text);


            if (ddl_101.SelectedIndex == 0 && ddl_102.SelectedIndex == 0 && ddl_103.SelectedIndex == 0 && ddl_104.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก ตั้งแต่ - ถึง (เดือน ปี) ให้ถูกต้อง')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtPersonStudyHistoryGradUNIVEdit.Text) && string.IsNullOrEmpty(txtPersonStudyHistoryMajorEdit.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอกข้อมูลให้ครบทุกช่อง')", true);
                return;
            }

            p1.UpdatePersonStudyHistory();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('อัพเดทข้อมูลเรียบร้อย')", true);
            GridView1.EditIndex = -1;
            BindData();

        }

        protected void GridView1_RowDataBound1(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton lb = (LinkButton)e.Row.FindControl("DeleteButton1");
                lb.Attributes.Add("onclick", "return confirm('คุณต้องการจะลบ " + DataBinder.Eval(e.Row.DataItem, "GRAD_UNIV") + " จริงๆใช่ไหม ?');");
                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {

                    using (OracleConnection sqlConn1 = new OracleConnection(strConn))
                    {
                        using (OracleCommand sqlCmd1 = new OracleCommand())
                        {
                            DropDownList ddl_101 = (DropDownList)e.Row.FindControl("ddl_101");

                            sqlCmd1.CommandText = "select * from TB_DDLMONTH";
                            sqlCmd1.Connection = sqlConn1;
                            sqlConn1.Open();
                            OracleDataAdapter da1 = new OracleDataAdapter(sqlCmd1);
                            DataTable dt = new DataTable();
                            da1.Fill(dt);
                            ddl_101.DataSource = dt;
                            ddl_101.SelectedValue = DataBinder.Eval(e.Row.DataItem, "MONTH_FROM").ToString();
                            ddl_101.DataValueField = "MONTH_SHORT";
                            ddl_101.DataTextField = "MONTH_SHORT";
                            ddl_101.DataBind();
                            sqlConn1.Close();

                            ddl_101.Items.Insert(0, new ListItem("--เดือน--", "0"));
                            DataRowView dr1 = e.Row.DataItem as DataRowView;
                        }

                        using (OracleConnection sqlConn2 = new OracleConnection(strConn))
                        {
                            using (OracleCommand sqlCmd2 = new OracleCommand())
                            {
                                DropDownList ddl_102 = (DropDownList)e.Row.FindControl("ddl_102");

                                sqlCmd2.CommandText = "select * from TB_YEAR";
                                sqlCmd2.Connection = sqlConn2;
                                sqlConn2.Open();
                                OracleDataAdapter da2 = new OracleDataAdapter(sqlCmd2);
                                DataTable dt = new DataTable();
                                da2.Fill(dt);
                                ddl_102.DataSource = dt;
                                ddl_102.SelectedValue = DataBinder.Eval(e.Row.DataItem, "YEAR_FROM").ToString();
                                ddl_102.DataValueField = "YEAR_NAME";
                                ddl_102.DataTextField = "YEAR_NAME";
                                ddl_102.DataBind();
                                sqlConn2.Close();

                                ddl_102.Items.Insert(0, new ListItem("--ปี--", "0"));
                                DataRowView dr2 = e.Row.DataItem as DataRowView;
                            }
                        }

                        using (OracleConnection sqlConn3 = new OracleConnection(strConn))
                        {
                            using (OracleCommand sqlCmd3 = new OracleCommand())
                            {
                                DropDownList ddl_103 = (DropDownList)e.Row.FindControl("ddl_103");

                                sqlCmd3.CommandText = "select * from TB_DDLMONTH";
                                sqlCmd3.Connection = sqlConn3;
                                sqlConn3.Open();
                                OracleDataAdapter da3 = new OracleDataAdapter(sqlCmd3);
                                DataTable dt = new DataTable();
                                da3.Fill(dt);
                                ddl_103.DataSource = dt;
                                ddl_103.SelectedValue = DataBinder.Eval(e.Row.DataItem, "MONTH_TO").ToString();
                                ddl_103.DataValueField = "MONTH_SHORT";
                                ddl_103.DataTextField = "MONTH_SHORT";
                                ddl_103.DataBind();
                                sqlConn3.Close();

                                ddl_103.Items.Insert(0, new ListItem("--เดือน--", "0"));
                                DataRowView dr3 = e.Row.DataItem as DataRowView;
                            }
                        }

                        using (OracleConnection sqlConn4 = new OracleConnection(strConn))
                        {
                            using (OracleCommand sqlCmd4 = new OracleCommand())
                            {
                                DropDownList ddl_104 = (DropDownList)e.Row.FindControl("ddl_104");

                                sqlCmd4.CommandText = "select * from TB_YEAR";
                                sqlCmd4.Connection = sqlConn4;
                                sqlConn4.Open();
                                OracleDataAdapter da4 = new OracleDataAdapter(sqlCmd4);
                                DataTable dt = new DataTable();
                                da4.Fill(dt);
                                ddl_104.DataSource = dt;
                                ddl_104.SelectedValue = DataBinder.Eval(e.Row.DataItem, "YEAR_TO").ToString();
                                ddl_104.DataValueField = "YEAR_NAME";
                                ddl_104.DataTextField = "YEAR_NAME";
                                ddl_104.DataBind();
                                sqlConn4.Close();

                                ddl_104.Items.Insert(0, new ListItem("--ปี--", "0"));
                                DataRowView dr4 = e.Row.DataItem as DataRowView;
                            }
                        }
                    }
                }
            }
        }

        protected void myGridViewPersonStudyHistory_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }

        /// <summary>
        /// /////////////////////
        /// </summary>

        protected void modEditCommand2(Object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            BindData();
        }
        protected void modCancelCommand2(Object sender, GridViewCancelEditEventArgs e)
        {
            GridView2.EditIndex = -1;
            BindData();
        }
        protected void modDeleteCommand2(Object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value);
            ClassPersonJobLisence p2 = new ClassPersonJobLisence();
            p2.ID = id;
            p2.DeletePersonJobLisence();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ลบข้อมูลเรียบร้อย')", true);

            GridView2.EditIndex = -1;
            BindData();
        }
        protected void modUpdateCommand2(Object sender, GridViewUpdateEventArgs e)
        {

            Label lblPersonJobLisenceID = (Label)GridView2.Rows[e.RowIndex].FindControl("lblPersonJobLisenceID");
            Label lblPersonJobLisenceCitizenID = (Label)GridView2.Rows[e.RowIndex].FindControl("lblPersonJobLisenceCitizenID");
            TextBox txtPersonJobLisenceNameEdit = (TextBox)GridView2.Rows[e.RowIndex].FindControl("txtPersonJobLisenceNameEdit");
            TextBox txtPersonJobLisenceBranchEdit = (TextBox)GridView2.Rows[e.RowIndex].FindControl("txtPersonJobLisenceBranchEdit");
            TextBox txtPersonJobLisenceLicenseNOEdit = (TextBox)GridView2.Rows[e.RowIndex].FindControl("txtPersonJobLisenceLicenseNOEdit");
            TextBox lblPersonJobLisenceDDATEEdit = (TextBox)GridView2.Rows[e.RowIndex].FindControl("txtPersonJobLisenceDDATEEdit");
            DateTime DDATE = DateTime.Parse(lblPersonJobLisenceDDATEEdit.Text);

            ClassPersonJobLisence p2 = new ClassPersonJobLisence(Convert.ToInt32(lblPersonJobLisenceID.Text), lblPersonJobLisenceCitizenID.Text
                , txtPersonJobLisenceNameEdit.Text
                , txtPersonJobLisenceBranchEdit.Text
                , txtPersonJobLisenceLicenseNOEdit.Text
                , DDATE);

            p2.UpdatePersonJobLisence();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('อัพเดทข้อมูลเรียบร้อย')", true);
            GridView2.EditIndex = -1;
            BindData();

        }
        protected void GridView2_RowDataBound2(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton lb = (LinkButton)e.Row.FindControl("DeleteButton2");
                lb.Attributes.Add("onclick", "return confirm('คุณต้องการจะลบ " + DataBinder.Eval(e.Row.DataItem, "LICENCE_NAME") + " จริงๆใช่ไหม ?');");

                //TextBox txt1 = (e.Row.FindControl("txtPersonJobLisenceDDATEEdit") as TextBox);
                //txt1.Attributes.Add("onfocus", "ShowDate('" + txt1.ClientID + "')");

               // var DtShmt = (TextBox)e.Row.FindControl("txtPersonJobLisenceDDATEEdit");
                //ClientScript.RegisterStartupScript(this.GetType(), "datepick",
                  //   "$(function () { $('#" + DtShmt.ClientID + "').datepicker({ dateFormat: 'dd/mm/yyyy' });  })", true);
                //$("#ContentPlaceHolder1_txtBirthDayNumber")
            }
        }
        protected void myGridViewPersonJobLisence_PageIndexChanging2(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;
            GridView2.DataSource = GetViewState();
            GridView2.DataBind();
        }

        /// <summary>
        /// /////////////////////
        /// </summary>

        protected void modEditCommand3(Object sender, GridViewEditEventArgs e)
        {
            GridView3.EditIndex = e.NewEditIndex;
            BindData();
        }
        protected void modCancelCommand3(Object sender, GridViewCancelEditEventArgs e)
        {
            GridView3.EditIndex = -1;
            BindData();
        }
        protected void modDeleteCommand3(Object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView3.DataKeys[e.RowIndex].Value);
            ClassPersonTraining p3 = new ClassPersonTraining();
            p3.ID = id;
            p3.DeletePersonTraining();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ลบข้อมูลเรียบร้อย')", true);

            GridView3.EditIndex = -1;
            BindData();
        }
        protected void modUpdateCommand3(Object sender, GridViewUpdateEventArgs e)
        {

            Label lblPersonTrainingID = (Label)GridView3.Rows[e.RowIndex].FindControl("lblPersonTrainingID");
            Label lblPersonTrainingCitizenID = (Label)GridView3.Rows[e.RowIndex].FindControl("lblPersonTrainingCitizenID");
            TextBox txtPersonTrainingCourseEdit = (TextBox)GridView3.Rows[e.RowIndex].FindControl("txtPersonTrainingCourseEdit");
            DropDownList ddl_301 = (DropDownList)GridView3.Rows[e.RowIndex].FindControl("ddl_301");
            DropDownList ddl_302 = (DropDownList)GridView3.Rows[e.RowIndex].FindControl("ddl_302");
            DropDownList ddl_303 = (DropDownList)GridView3.Rows[e.RowIndex].FindControl("ddl_303");
            DropDownList ddl_304 = (DropDownList)GridView3.Rows[e.RowIndex].FindControl("ddl_304");
            TextBox txtPersonTrainingBranchEdit = (TextBox)GridView3.Rows[e.RowIndex].FindControl("txtPersonTrainingBranchEdit");

            ClassPersonTraining p3 = new ClassPersonTraining(Convert.ToInt32(lblPersonTrainingID.Text), lblPersonTrainingCitizenID.Text
                , txtPersonTrainingCourseEdit.Text
                , ddl_301.SelectedValue
                , ddl_302.SelectedValue
                , ddl_303.SelectedValue
                , ddl_304.SelectedValue
                , txtPersonTrainingBranchEdit.Text);

            if (ddl_301.SelectedIndex == 0 && ddl_302.SelectedIndex == 0 && ddl_303.SelectedIndex == 0 && ddl_304.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก ตั้งแต่ - ถึง (เดือน ปี) ให้ถูกต้อง')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtPersonTrainingCourseEdit.Text) && string.IsNullOrEmpty(txtPersonTrainingBranchEdit.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอกข้อมูลให้ครบทุกช่อง')", true);
                return;
            }

            p3.UpdatePersonTraining();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('อัพเดทข้อมูลเรียบร้อย')", true);
            GridView3.EditIndex = -1;
            BindData();

        }
        protected void GridView3_RowDataBound3(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton lb = (LinkButton)e.Row.FindControl("DeleteButton3");
                lb.Attributes.Add("onclick", "return confirm('คุณต้องการจะลบ " + DataBinder.Eval(e.Row.DataItem, "COURSE") + " จริงๆใช่ไหม ?');");
                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {

                    using (OracleConnection sqlConn1 = new OracleConnection(strConn))
                    {
                        using (OracleCommand sqlCmd1 = new OracleCommand())
                        {
                            DropDownList ddl_301 = (DropDownList)e.Row.FindControl("ddl_301");

                            sqlCmd1.CommandText = "select * from TB_DDLMONTH";
                            sqlCmd1.Connection = sqlConn1;
                            sqlConn1.Open();
                            OracleDataAdapter da1 = new OracleDataAdapter(sqlCmd1);
                            DataTable dt = new DataTable();
                            da1.Fill(dt);
                            ddl_301.DataSource = dt;
                            ddl_301.SelectedValue = DataBinder.Eval(e.Row.DataItem, "MONTH_FROM").ToString();
                            ddl_301.DataValueField = "MONTH_SHORT";
                            ddl_301.DataTextField = "MONTH_SHORT";
                            ddl_301.DataBind();
                            sqlConn1.Close();

                            ddl_301.Items.Insert(0, new ListItem("--เดือน--", "0"));
                            DataRowView dr1 = e.Row.DataItem as DataRowView;
                        }

                        using (OracleConnection sqlConn2 = new OracleConnection(strConn))
                        {
                            using (OracleCommand sqlCmd2 = new OracleCommand())
                            {
                                DropDownList ddl_302 = (DropDownList)e.Row.FindControl("ddl_302");

                                sqlCmd2.CommandText = "select * from TB_YEAR";
                                sqlCmd2.Connection = sqlConn2;
                                sqlConn2.Open();
                                OracleDataAdapter da2 = new OracleDataAdapter(sqlCmd2);
                                DataTable dt = new DataTable();
                                da2.Fill(dt);
                                ddl_302.DataSource = dt;
                                ddl_302.SelectedValue = DataBinder.Eval(e.Row.DataItem, "YEAR_FROM").ToString();
                                ddl_302.DataValueField = "YEAR_NAME";
                                ddl_302.DataTextField = "YEAR_NAME";
                                ddl_302.DataBind();
                                sqlConn2.Close();

                                ddl_302.Items.Insert(0, new ListItem("--ปี--", "0"));
                                DataRowView dr2 = e.Row.DataItem as DataRowView;
                            }
                        }

                        using (OracleConnection sqlConn3 = new OracleConnection(strConn))
                        {
                            using (OracleCommand sqlCmd3 = new OracleCommand())
                            {
                                DropDownList ddl_303 = (DropDownList)e.Row.FindControl("ddl_303");

                                sqlCmd3.CommandText = "select * from TB_DDLMONTH";
                                sqlCmd3.Connection = sqlConn3;
                                sqlConn3.Open();
                                OracleDataAdapter da3 = new OracleDataAdapter(sqlCmd3);
                                DataTable dt = new DataTable();
                                da3.Fill(dt);
                                ddl_303.DataSource = dt;
                                ddl_303.SelectedValue = DataBinder.Eval(e.Row.DataItem, "MONTH_TO").ToString();
                                ddl_303.DataValueField = "MONTH_SHORT";
                                ddl_303.DataTextField = "MONTH_SHORT";
                                ddl_303.DataBind();
                                sqlConn3.Close();

                                ddl_303.Items.Insert(0, new ListItem("--เดือน--", "0"));
                                DataRowView dr3 = e.Row.DataItem as DataRowView;
                            }
                        }

                        using (OracleConnection sqlConn4 = new OracleConnection(strConn))
                        {
                            using (OracleCommand sqlCmd4 = new OracleCommand())
                            {
                                DropDownList ddl_304 = (DropDownList)e.Row.FindControl("ddl_304");

                                sqlCmd4.CommandText = "select * from TB_YEAR";
                                sqlCmd4.Connection = sqlConn4;
                                sqlConn4.Open();
                                OracleDataAdapter da4 = new OracleDataAdapter(sqlCmd4);
                                DataTable dt = new DataTable();
                                da4.Fill(dt);
                                ddl_304.DataSource = dt;
                                ddl_304.SelectedValue = DataBinder.Eval(e.Row.DataItem, "YEAR_TO").ToString();
                                ddl_304.DataValueField = "YEAR_NAME";
                                ddl_304.DataTextField = "YEAR_NAME";
                                ddl_304.DataBind();
                                sqlConn4.Close();

                                ddl_304.Items.Insert(0, new ListItem("--ปี--", "0"));
                                DataRowView dr4 = e.Row.DataItem as DataRowView;
                            }
                        }
                    }
                }
            }
        }
        protected void myGridViewPersonTraining_PageIndexChanging3(object sender, GridViewPageEventArgs e)
        {
            GridView3.PageIndex = e.NewPageIndex;
            GridView3.DataSource = GetViewState();
            GridView3.DataBind();
        }

        /// <summary>
        /// /////////////////////
        /// </summary>

        protected void modEditCommand4(Object sender, GridViewEditEventArgs e)
        {
            GridView4.EditIndex = e.NewEditIndex;
            BindData();
        }
        protected void modCancelCommand4(Object sender, GridViewCancelEditEventArgs e)
        {
            GridView4.EditIndex = -1;
            BindData();
        }
        protected void modDeleteCommand4(Object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView4.DataKeys[e.RowIndex].Value);
            ClassPersonDISCIPLINARY p4 = new ClassPersonDISCIPLINARY();
            p4.ID = id;
            p4.DeletePersonDISCIPLINARY();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ลบข้อมูลเรียบร้อย')", true);

            GridView4.EditIndex = -1;
            BindData();
        }
        protected void modUpdateCommand4(Object sender, GridViewUpdateEventArgs e)
        {

            Label lblPersonDISCIPLINARYID = (Label)GridView4.Rows[e.RowIndex].FindControl("lblPersonDISCIPLINARYID");
            Label lblPersonDISCIPLINARYCitizenID = (Label)GridView4.Rows[e.RowIndex].FindControl("lblPersonDISCIPLINARYCitizenID");
            DropDownList ddl_401 = (DropDownList)GridView4.Rows[e.RowIndex].FindControl("ddl_401");
            TextBox txtPersonDISCIPLINARYListEdit = (TextBox)GridView4.Rows[e.RowIndex].FindControl("txtPersonDISCIPLINARYListEdit");
            TextBox txtPersonDISCIPLINARYRefEdit = (TextBox)GridView4.Rows[e.RowIndex].FindControl("txtPersonDISCIPLINARYRefEdit");

            ClassPersonDISCIPLINARY p4 = new ClassPersonDISCIPLINARY(Convert.ToInt32(lblPersonDISCIPLINARYID.Text), lblPersonDISCIPLINARYCitizenID.Text
                , ddl_401.SelectedValue
                , txtPersonDISCIPLINARYListEdit.Text
                , txtPersonDISCIPLINARYRefEdit.Text);

            p4.UpdatePersonDISCIPLINARY();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('อัพเดทข้อมูลเรียบร้อย')", true);
            GridView4.EditIndex = -1;
            BindData();

        }
        protected void GridView4_RowDataBound4(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton lb = (LinkButton)e.Row.FindControl("DeleteButton4");
                lb.Attributes.Add("onclick", "return confirm('คุณต้องการจะลบ " + DataBinder.Eval(e.Row.DataItem, "MENU") + " จริงๆใช่ไหม ?');");
                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {

                    using (OracleConnection sqlConn2 = new OracleConnection(strConn))
                    {
                        using (OracleCommand sqlCmd2 = new OracleCommand())
                        {
                            DropDownList ddl_401 = (DropDownList)e.Row.FindControl("ddl_401");

                            sqlCmd2.CommandText = "select * from TB_YEAR";
                            sqlCmd2.Connection = sqlConn2;
                            sqlConn2.Open();
                            OracleDataAdapter da2 = new OracleDataAdapter(sqlCmd2);
                            DataTable dt = new DataTable();
                            da2.Fill(dt);
                            ddl_401.DataSource = dt;
                            ddl_401.SelectedValue = DataBinder.Eval(e.Row.DataItem, "YEAR").ToString();
                            ddl_401.DataValueField = "YEAR_NAME";
                            ddl_401.DataTextField = "YEAR_NAME";
                            ddl_401.DataBind();
                            sqlConn2.Close();

                            ddl_401.Items.Insert(0, new ListItem("--ปี--", "0"));
                            DataRowView dr2 = e.Row.DataItem as DataRowView;
                        }
                    }
                }
            }
        }
        protected void myGridViewPersonDISCIPLINARY_PageIndexChanging4(object sender, GridViewPageEventArgs e)
        {
            GridView4.PageIndex = e.NewPageIndex;
            GridView4.DataSource = GetViewState();
            GridView4.DataBind();
        }

        /// <summary>
        /// /////////////////////
        /// </summary>

        protected void modEditCommand5(Object sender, GridViewEditEventArgs e)
        {
            GridView5.EditIndex = e.NewEditIndex;
            BindData();
        }
        protected void modCancelCommand5(Object sender, GridViewCancelEditEventArgs e)
        {
            GridView5.EditIndex = -1;
            BindData();
        }
        protected void modDeleteCommand5(Object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView5.DataKeys[e.RowIndex].Value);
            ClassPersonPosiSalary p5 = new ClassPersonPosiSalary();
            p5.ID = id;
            p5.DeletePersonPosiSalary();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ลบข้อมูลเรียบร้อย')", true);

            GridView5.EditIndex = -1;
            BindData();
        }
        protected void modUpdateCommand5(Object sender, GridViewUpdateEventArgs e)
        {

            Label lblPersonPosiSalaryID = (Label)GridView5.Rows[e.RowIndex].FindControl("lblPersonPosiSalaryID");
            TextBox lblPersonPosiSalaryDateEdit = (TextBox)GridView5.Rows[e.RowIndex].FindControl("txtPersonPosiSalaryDateEdit");
            TextBox txtPersonPosiSalaryPositionEdit = (TextBox)GridView5.Rows[e.RowIndex].FindControl("txtPersonPosiSalaryPositionEdit");
            TextBox txtPersonPosiSalaryNoPositionEdit = (TextBox)GridView5.Rows[e.RowIndex].FindControl("txtPersonPosiSalaryNoPositionEdit");
            DropDownList ddl_501 = (DropDownList)GridView5.Rows[e.RowIndex].FindControl("ddl_501");
            DropDownList ddl_502 = (DropDownList)GridView5.Rows[e.RowIndex].FindControl("ddl_502");
            TextBox txtPersonPosiSalarySALARYEdit = (TextBox)GridView5.Rows[e.RowIndex].FindControl("txtPersonPosiSalarySALARYEdit");
            TextBox txtPersonPosiSalaryPositionSALARYEdit = (TextBox)GridView5.Rows[e.RowIndex].FindControl("txtPersonPosiSalaryPositionSALARYEdit");
            TextBox txtPersonPosiSalaryRefEdit = (TextBox)GridView5.Rows[e.RowIndex].FindControl("txtPersonPosiSalaryRefEdit");
            Label lblPersonPosiSalaryCitizenID = (Label)GridView5.Rows[e.RowIndex].FindControl("lblPersonPosiSalaryCitizenID");
            DateTime DDATE = DateTime.Parse(lblPersonPosiSalaryDateEdit.Text);

            ClassPersonPosiSalary p5 = new ClassPersonPosiSalary(Convert.ToInt32(lblPersonPosiSalaryID.Text)
                , DDATE
                , txtPersonPosiSalaryPositionEdit.Text
                , txtPersonPosiSalaryNoPositionEdit.Text
                , ddl_501.SelectedValue
                , Convert.ToInt32(ddl_502.SelectedValue)
                , Convert.ToInt32(txtPersonPosiSalarySALARYEdit.Text)
                , Convert.ToInt32(txtPersonPosiSalaryPositionSALARYEdit.Text)
                , txtPersonPosiSalaryRefEdit.Text
                , lblPersonPosiSalaryCitizenID.Text);

            p5.UpdatePersonPosiSalary();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('อัพเดทข้อมูลเรียบร้อย')", true);
            GridView5.EditIndex = -1;
            BindData();

        }
        protected void GridView5_RowDataBound5(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton lb = (LinkButton)e.Row.FindControl("DeleteButton5");
                lb.Attributes.Add("onclick", "return confirm('คุณต้องการจะลบ " + DataBinder.Eval(e.Row.DataItem, "POSITION_NAME") + " จริงๆใช่ไหม ?');");
                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {

                    using (OracleConnection sqlConn1 = new OracleConnection(strConn))
                    {
                        using (OracleCommand sqlCmd1 = new OracleCommand())
                        {
                            DropDownList ddl_501 = (DropDownList)e.Row.FindControl("ddl_501");

                            sqlCmd1.CommandText = "select * from TB_STAFF";
                            sqlCmd1.Connection = sqlConn1;
                            sqlConn1.Open();
                            OracleDataAdapter da1 = new OracleDataAdapter(sqlCmd1);
                            DataTable dt = new DataTable();
                            da1.Fill(dt);
                            ddl_501.DataSource = dt;
                            ddl_501.SelectedValue = DataBinder.Eval(e.Row.DataItem, "ST_ID").ToString();
                            ddl_501.DataValueField = "ST_ID";
                            ddl_501.DataTextField = "ST_NAME";
                            ddl_501.DataBind();
                            sqlConn1.Close();

                            ddl_501.Items.Insert(0, new ListItem("--ตำแหน่งประเภท--", "0"));

                            DataRowView dr1 = e.Row.DataItem as DataRowView;
                        }
                    }

                    using (OracleConnection sqlConn2 = new OracleConnection(strConn))
                    {
                        using (OracleCommand sqlCmd2 = new OracleCommand())
                        {
                            DropDownList ddl_502 = (DropDownList)e.Row.FindControl("ddl_502");

                            sqlCmd2.CommandText = "select * FROM TB_POSITION_GOVERNMENT_OFFICER UNION ALL select * FROM TB_POSITION_PERMANENT_EMP ";
                            sqlCmd2.Connection = sqlConn2;
                            sqlConn2.Open();
                            OracleDataAdapter da2 = new OracleDataAdapter(sqlCmd2);
                            DataTable dt = new DataTable();
                            da2.Fill(dt);
                            ddl_502.DataSource = dt;
                            ddl_502.SelectedValue = DataBinder.Eval(e.Row.DataItem, "POSITION_ID").ToString();
                            ddl_502.DataValueField = "ID";
                            ddl_502.DataTextField = "NAME";
                            ddl_502.DataBind();
                            sqlConn2.Close();

                            ddl_502.Items.Insert(0, new ListItem("--ระดับ--", "0"));

                            DataRowView dr1 = e.Row.DataItem as DataRowView;
                        }
                    }
                }
            }
        }
        protected void myGridViewPersonPosiSalary_PageIndexChanging5(object sender, GridViewPageEventArgs e)
        {
            GridView5.PageIndex = e.NewPageIndex;
            GridView5.DataSource = GetViewState();
            GridView5.DataBind();
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
            //if (NeedData1To9() || NeedData10() || NeedData11() || NeedData12() || NeedData13() || NeedData14()) { return; }
            if (NeedData1To9()) { return; }
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
            if (DropDownMonth10From.SelectedValue == "0" || DropDownYear10From.SelectedValue == "0" || DropDownMonth10To.SelectedValue == "0" || DropDownYear10To.SelectedValue == "0")
            {
                Util.Alert(this, "กรุณาเลือกเดือนและปีให้ถูกต้อง<ในส่วนประวัติการศึกษา>");
                return;
            }
            if (txtGrad_Univ.Text != "" && txtMajor.Text != "")
            {
                ClassPersonStudyHistory P = new ClassPersonStudyHistory();
                P.CITIZEN_ID = txtCitizen.Text;
                P.GRAD_UNIV = txtGrad_Univ.Text;
                P.MONTH_FROM = DropDownMonth10From.SelectedValue;
                P.YEAR_FROM = DropDownYear10From.SelectedValue;
                P.MONTH_TO = DropDownMonth10To.SelectedValue;
                P.YEAR_TO = DropDownYear10To.SelectedValue;
                P.MAJOR = txtMajor.Text;
                P.InsertPersonStudyHistory();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('เพิ่มข้อมูลเในส่วน<ประวัติการศึกษา>เรียบร้อย')", true);
                ClearDataGridViewNumber10();
                ClassPersonStudyHistory p1 = new ClassPersonStudyHistory();
                DataTable dt1 = p1.GetPersonStudyHistory("", "", "", "", "", "", Session["login_id"].ToString());
                GridView1.DataSource = dt1;
                GridView1.DataBind();
                SetViewState(dt1);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอกข้อมูลให้ครบถ้วน<ในส่วนประวัติการศึกษา>')", true);
            }
        }

        protected void ButtonPlus11_Click(object sender, EventArgs e)
        {
            if (txtGrad_Univ11.Text != "" && txtDepart11.Text != "" && txtNolicense11.Text != "" && txtDateEnable11.Text != "")
            {
                ClassPersonJobLisence P = new ClassPersonJobLisence();
                P.CITIZEN_ID = txtCitizen.Text;
                P.LICENCE_NAME = txtGrad_Univ11.Text;
                P.BRANCH = txtDepart11.Text;
                P.LICENCE_NO = txtNolicense11.Text;
                P.DDATE = DateTime.Parse(txtDateEnable11.Text);
                P.InsertPersonJobLisence();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('เพิ่มข้อมูลเในส่วน<ใบอนุญาตประกอบวิชาชีพ>เรียบร้อย')", true);
                ClearDataGridViewNumber11();
                ClassPersonJobLisence p2 = new ClassPersonJobLisence();
                DataTable dt2 = p2.GetPersonJobLisence("", "", "", "", Session["login_id"].ToString());
                GridView2.DataSource = dt2;
                GridView2.DataBind();
                SetViewState(dt2);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอกข้อมูลให้ครบถ้วน<ส่วนใบประกอบวิชาชีพ>')", true);
            }
        }

        protected void ButtonPlus12_Click(object sender, EventArgs e)
        {
            if (DropDownMonth12From.SelectedValue == "0" || DropDownYear12From.SelectedValue == "0" || DropDownMonth12To.SelectedValue == "0" || DropDownYear12To.SelectedValue == "0")
            {
                Util.Alert(this, "กรุณาเลือกเดือนและปีให้ถูกต้อง<ในส่วนประวัติการฝึกอบรม>");
                return;
            }
            if (txtCourse.Text != "" && txtBranchTrainning.Text != "")
            {
                ClassPersonTraining P = new ClassPersonTraining();
                P.CITIZEN_ID = txtCitizen.Text;
                P.COURSE = txtCourse.Text;
                P.MONTH_FROM = DropDownMonth12From.SelectedValue;
                P.YEAR_FROM = DropDownYear12From.SelectedValue;
                P.MONTH_TO = DropDownMonth12To.SelectedValue;
                P.YEAR_TO = DropDownYear12To.SelectedValue;
                P.BRANCH_TRAINING = txtBranchTrainning.Text;
                P.InsertPersonTraining();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('เพิ่มข้อมูลเในส่วน<ประวัติการฝึกอบรม>เรียบร้อย')", true);
                ClearDataGridViewNumber12();
                ClassPersonTraining p3 = new ClassPersonTraining();
                DataTable dt3 = p3.GetPersonTraining("", "", "", "", "", "", Session["login_id"].ToString());
                GridView3.DataSource = dt3;
                GridView3.DataBind();
                SetViewState(dt3);
            }
            else
            {
                Util.Alert(this, "กรุณากรอกข้อมูลให้ครบถ้วน<ในส่วนประวัติการฝึกอบรม>");
            }
        }

        protected void ButtonPlus13_Click(object sender, EventArgs e)
        {
            if (DropDownYear13.SelectedValue == "0")
            {
                Util.Alert(this, "กรุณาเลือก พ.ศ. ให้ถูกต้อง<ในส่วนการได้รับโทษทางวินัยและการนิรโทษกรรม>");
                return;
            }
            if (txtList13.Text != "" && txtRefDoc13.Text != "")
            {
                ClassPersonDISCIPLINARY P = new ClassPersonDISCIPLINARY();
                P.CITIZEN_ID = txtCitizen.Text;
                P.YEAR = DropDownYear13.SelectedValue;
                P.MENU = txtList13.Text;
                P.REF_DOC = txtRefDoc13.Text;
                P.InsertPersonDISCIPLINARY();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('เพิ่มข้อมูลเในส่วน<การได้รับโทษทางวินัยและการนิรโทษกรรม>เรียบร้อย')", true);
                ClearDataGridViewNumber13();
                ClassPersonDISCIPLINARY p4 = new ClassPersonDISCIPLINARY();
                DataTable dt4 = p4.GetPersonDISCIPLINARY("", "", "", Session["login_id"].ToString());
                GridView4.DataSource = dt4;
                GridView4.DataBind();
                SetViewState(dt4);
            }
            else
            {
                Util.Alert(this, "กรุณากรอกข้อมูลให้ครบถ้วน<ในส่วนการได้รับโทษทางวินัยและการนิรโทษกรรม>");
            }
        }

        protected void ButtonPlus14_Click(object sender, EventArgs e)
        {
            if (DropDownType_Position14.SelectedValue == "0" || DropDownDegree14.SelectedValue == "0")
            {
                Util.Alert(this, "กรุณาเลือก ตำแหน่งประเภทและระดับ ให้ถูกต้อง<ในส่วนตำแหน่งและเงินเดือน>");
                return;
            }
            if (txtDate14.Text != "" && txtPosition14.Text != "" && txtNo_Position14.Text != "" && txtSalary14.Text != "" && txtSalaryForPosition14.Text != "" && txtRefDoc14.Text != "")
            {
                ClassPersonPosiSalary P = new ClassPersonPosiSalary();
                P.DDATE = DateTime.Parse(txtDate14.Text);
                P.POSITION_NAME = txtPosition14.Text;
                P.PERSON_ID = txtNo_Position14.Text;
                P.ST_ID = DropDownType_Position14.SelectedValue;
                P.POSITION_ID = Convert.ToInt32(DropDownDegree14.SelectedValue);
                P.SALARY = Convert.ToInt32(txtSalary14.Text);
                P.POSITION_SALARY = Convert.ToInt32(txtSalaryForPosition14.Text);
                P.REFERENCE_DOCUMENT = txtRefDoc14.Text;
                P.CITIZEN_ID = txtCitizen.Text;
                P.InsertPersonPosiSalary();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('เพิ่มข้อมูลเในส่วน<ตำแหน่งและเงินเดือน>เรียบร้อย')", true);
                ClearDataGridViewNumber14();
                ClassPersonPosiSalary p5 = new ClassPersonPosiSalary();
                DataTable dt5 = p5.GetPersonPosiSalary("", "", "", "", 0, 0, 0, "", Session["login_id"].ToString());
                GridView5.DataSource = dt5;
                GridView5.DataBind();
                SetViewState(dt5);
            }
            else
            {
                Util.Alert(this, "กรุณากรอกข้อมูลให้ครบถ้วน<ในส่วนตำแหน่งและเงินเดือน>");
            }
        }

    }
}