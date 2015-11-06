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
    public partial class Budget_ADMIN : System.Web.UI.Page
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
            return (DataTable)ViewState["BUDGET_NAME"];
        }

        private void SetViewState(DataTable data)
        {
            //Sets the ViewState
            ViewState["BUDGET_NAME"] = data;
        }

        #endregion

        void BindData()
        {
            ClassBudget b = new ClassBudget();
            DataTable dt = b.GetBudget("");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        private void ClearData()
        {
            txtSearchBudgetName.Text = "";
            txtInsertBudgetName.Text = "";
        }

        protected void btnSubmitBudget_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInsertBudgetName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ประเภทเงินจ้างงาน')", true);
                return;
            }
            ClassBudget b = new ClassBudget();
            b.BUDGET_NAME = txtInsertBudgetName.Text;

            b.InsertBudget();
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
            ClassBudget b = new ClassBudget();
            b.BUDGET_ID = id;
            b.DeleteBudget();

            GridView1.EditIndex = -1;
            BindData();
        }
        protected void modUpdateCommand(Object sender, GridViewUpdateEventArgs e)
        {
            Label lblBudgetID = (Label)GridView1.Rows[e.RowIndex].FindControl("lblBudgetID");

            TextBox txtBudgetNameEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtBudgetNameEdit");

            ClassBudget b = new ClassBudget(Convert.ToInt32(lblBudgetID.Text)
                , txtBudgetNameEdit.Text);

            b.UpdateBudget();

            GridView1.EditIndex = -1;
            BindData();
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }
        protected void myGridViewBudget_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }

        protected void btnCancelBudget_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassBudget b = new ClassBudget();
            DataTable dt = b.GetBudget("");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        protected void btnSearchBudgetName_Click(object sender, EventArgs e)
        {
            ClassBudget b = new ClassBudget();
            DataTable dt = b.GetBudget(txtSearchBudgetName.Text);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }
    }
}