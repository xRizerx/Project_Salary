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
    public partial class Year_ADMIN : System.Web.UI.Page
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
            return (DataTable)ViewState["YEAR_NAME"];
        }

        private void SetViewState(DataTable data)
        {
            //Sets the ViewState
            ViewState["YEAR_NAME"] = data;
        }

        #endregion

        void BindData()
        {
            ClassYear y = new ClassYear();
            DataTable dt = y.GetYear("");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        private void ClearData()
        {
            txtSearchTH.Text ="";
            txtYear.Text = "";
        }

        protected void btnSubmitYEAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtYear.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ปีการศึกษา')", true);
                return;
            }
                ClassYear y = new ClassYear();
                y.Year_Name = txtYear.Text;

                y.InsertYear();
                BindData();
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
            ClassYear y = new ClassYear();
            y.Year_ID = id;
            y.DeleteYear();

            GridView1.EditIndex = -1;
            BindData(); 
        }
        protected void modUpdateCommand(Object sender, GridViewUpdateEventArgs e)
        {
            Label lblYear_ID = (Label)GridView1.Rows[e.RowIndex].FindControl("lblYear_ID");

            TextBox txtYear = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtYear");

            ClassYear y = new ClassYear(Convert.ToInt32(lblYear_ID.Text)
                , txtYear.Text);

            y.UpdateYear();

            GridView1.EditIndex = -1;
            BindData();
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
        }
        protected void myGridViewYEAR_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }

        protected void btnCancelYEAR_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        protected void btnSearchYear_Click(object sender, EventArgs e)
        {
            ClassYear y = new ClassYear();
            DataTable dt = y.GetYear(txtSearchTH.Text);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }
    }
}