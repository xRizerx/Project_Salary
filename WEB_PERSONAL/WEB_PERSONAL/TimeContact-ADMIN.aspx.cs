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
    public partial class TimeContact_ADMIN : System.Web.UI.Page
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
            return (DataTable)ViewState["TIME_CONTACT_NAME"];
        }

        private void SetViewState(DataTable data)
        {
            //Sets the ViewState
            ViewState["TIME_CONTACT_NAME"] = data;
        }

        #endregion

        void BindData()
        {
            ClassTimeContact tc = new ClassTimeContact();
            DataTable dt = tc.GetTimeContact("");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        private void ClearData()
        {
            txtSearchTimeContactName.Text = "";
            txtInsertTimeContactName.Text = "";
        }

        protected void btnSubmitTimeContact_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInsertTimeContactName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ระยะเวลาการจ้างงาน')", true);
                return;
            }
            ClassTimeContact tc = new ClassTimeContact();
            tc.TIME_CONTACT_NAME = txtInsertTimeContactName.Text;

            tc.InsertTimeContact();
            BindData();
            ClearData();
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
            ClassTimeContact tc = new ClassTimeContact();
            tc.TIME_CONTACT_ID = id;
            tc.DeleteTimeContact();

            GridView1.EditIndex = -1;
            BindData();
        }
        protected void modUpdateCommand(Object sender, GridViewUpdateEventArgs e)
        {
            Label lblTimeContactID = (Label)GridView1.Rows[e.RowIndex].FindControl("lblTimeContactID");

            TextBox txtTimeContactNameEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtTimeContactNameEdit");

            ClassTimeContact tc = new ClassTimeContact(Convert.ToInt32(lblTimeContactID.Text)
                , txtTimeContactNameEdit.Text);

            tc.UpdateTimeContact();

            GridView1.EditIndex = -1;
            BindData();
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }
        protected void myGridViewTimeContact_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }

        protected void btnCancelTimeContact_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassTimeContact tc = new ClassTimeContact();
            DataTable dt = tc.GetTimeContact("");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        protected void btnSearchTimeContact_Click(object sender, EventArgs e)
        {
            ClassTimeContact tc = new ClassTimeContact();
            DataTable dt = tc.GetTimeContact(txtSearchTimeContactName.Text);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }
    }
}