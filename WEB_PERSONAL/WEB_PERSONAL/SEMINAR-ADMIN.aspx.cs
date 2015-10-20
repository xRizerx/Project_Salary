using WEB_PERSONAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_PERSONAL
{
    public partial class SEMINAR_ADMIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }

        #region ViewState DataTable

        private DataTable GetViewState()
        {
            //Gets the ViewState
            return (DataTable)ViewState["seminar"];
        }

        private void SetViewState(DataTable data)
        {
            //Sets the ViewState
            ViewState["seminar"] = data;
        }

        #endregion

        void BindData()
        {
            Seminar ptn = new Seminar();
            DataTable dt = ptn.GetSEMINAR("");
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
            Seminar S = new Seminar();
            S.SEMINAR_ID = id;
            S.DeleteSEMINAR();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ลบข้อมูลเรียบร้อย')", true);

            GridView1.EditIndex = -1;
            BindData();
        }
        protected void modUpdateCommand(Object sender, GridViewUpdateEventArgs e)
        {
            Label lblSEMINAR_ID = (Label)GridView1.Rows[e.RowIndex].FindControl("lblSEMINAR_ID");
            TextBox txtName = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtName");
            TextBox txtLastName = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtLastName");
            TextBox txtPosition = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtPosition");
            TextBox txtDegree = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtDegree");
            TextBox txtCampus = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtCampus");
            TextBox txtNameOfProject = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtNameOfProject");
            TextBox txtPlace = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtPlace");
            TextBox lblSEMINAR_DATETIME_FROM = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtDateFrom");
            TextBox lblSEMINAR_DATETIME_TO = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtDateTO");
            TextBox txtDay = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtDay");
            TextBox txtMonth = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtMonth");
            TextBox txtYear = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtYear");
            TextBox txtBudget = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtBudget");
            TextBox txtSupportBudget = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtSupportBudget");
            TextBox txtCertificate = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtCertificate");
            TextBox txtAbstract = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtAbstract");
            TextBox txtResult = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtResult");
            TextBox txtShow1 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtShow1");
            TextBox txtShow2 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtShow2");
            TextBox txtShow3 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtShow3");
            TextBox txtShow4 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtShow4");
            TextBox txtProblem = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtProblem");
            TextBox txtComment = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtComment");
            DateTime SEMINAR_DATETIME_FROM = DateTime.Parse(lblSEMINAR_DATETIME_FROM.Text);
            DateTime SEMINAR_DATETIME_TO = DateTime.Parse(lblSEMINAR_DATETIME_TO.Text);
            DateTime SEMINAR_SIGNED_DATETIME = DateTime.Now;

            
            Seminar S = new Seminar(Convert.ToInt32(lblSEMINAR_ID.Text)
                , txtName.Text
                , txtLastName.Text
                , txtPosition.Text
                , txtDegree.Text
                , txtCampus.Text
                , txtNameOfProject.Text
                , txtPlace.Text
                , SEMINAR_DATETIME_FROM
                , SEMINAR_DATETIME_TO
                , Convert.ToInt32(txtDay.Text)
                , Convert.ToInt32(txtMonth.Text)
                , Convert.ToInt32(txtYear.Text)
                , Convert.ToInt32(txtBudget.Text)
                , txtSupportBudget.Text
                , txtCertificate.Text
                , txtAbstract.Text
                , txtResult.Text
                , txtShow1.Text
                , txtShow2.Text
                , txtShow3.Text
                , txtShow4.Text
                , txtProblem.Text
                , txtComment.Text
                , SEMINAR_SIGNED_DATETIME);

          

            S.UpdateSEMINAR();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('อัพเดทข้อมูลเรียบร้อย')", true);

            GridView1.EditIndex = -1;
            BindData();
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            DataRowView drv = e.Row.DataItem as DataRowView;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    TextBox txt = (TextBox)e.Row.FindControl("txtBudget");
                    txt.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                }
            }
        }
        protected void myGridViewSEMINARADMIN_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }

        protected void btnSearchNameSeminar_Click(object sender, EventArgs e)
        {
            Seminar S = new Seminar();
            DataTable dt = S.GetSEMINAR(txtSearchNameSeminar.Text);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }
    }
}