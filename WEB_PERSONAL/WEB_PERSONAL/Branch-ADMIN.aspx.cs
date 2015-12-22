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
    public partial class Branch_ADMIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
                txtSearchBranchID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                txtInsertBranchID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
            }
        }

        #region ViewState DataTable

        private DataTable GetViewState()
        {
            //Gets the ViewState
            return (DataTable)ViewState["BRANCH"];
        }

        private void SetViewState(DataTable data)
        {
            //Sets the ViewState
            ViewState["BRANCH"] = data;
        }

        #endregion

        void BindData()
        {
            ClassBranch b = new ClassBranch();
            DataTable dt = b.GetBranch("", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        void BindData1()
        {
            ClassBranch b = new ClassBranch();
            DataTable dt = b.GetBranchSearch(txtSearchBranchID.Text, txtSearchBranchName.Text);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        private void ClearData()
        {
            txtSearchBranchID.Text = "";
            txtSearchBranchName.Text = "";
            txtInsertBranchID.Text = "";
            txtInsertBranchName.Text = "";
        }

        protected void btnSubmitBranch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInsertBranchID.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ รหัสหน่วยงานในมหาวิทยาลัย')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtInsertBranchName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ ชื่อหน่วยงานในมหาวิทยาลัย')", true);
                return;
            }
            ClassBranch b = new ClassBranch();
            b.BRANCH_ID = Convert.ToInt32(txtInsertBranchID.Text);
            b.BRANCH_NAME = txtInsertBranchName.Text;

            if (b.CheckUseBranchID())
            {
                b.InsertBranch();
                BindData();
                ClearData();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('เพิ่มข้อมูลเรียบร้อย')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('มีรหัสหน่วยงานในมหาวิทยาลัยนี้ อยู่ในระบบแล้ว !')", true);
            }
        }

        protected void modEditCommand(Object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindData1();
        }
        protected void modCancelCommand(Object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindData1();
        }
        protected void modDeleteCommand(Object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            ClassBranch b = new ClassBranch();
            b.BRANCH_ID = id;
            b.DeleteBranch();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ลบข้อมูลเรียบร้อย')", true);

            GridView1.EditIndex = -1;
            BindData1();
        }
        protected void modUpdateCommand(Object sender, GridViewUpdateEventArgs e)
        {
            TextBox txtBranchIDEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtBranchIDEdit");
            TextBox txtBranchNameEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtBranchNameEdit");

            ClassBranch b = new ClassBranch(Convert.ToInt32(txtBranchIDEdit.Text)
                , txtBranchNameEdit.Text);

            b.UpdateBranch();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('อัพเดทข้อมูลเรียบร้อย')", true);
            GridView1.EditIndex = -1;
            BindData1();
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            DataRowView drv = e.Row.DataItem as DataRowView;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton lb = (LinkButton)e.Row.FindControl("DeleteButton1");
                lb.Attributes.Add("onclick", "return confirm('คุณต้องการจะลบ " + DataBinder.Eval(e.Row.DataItem, "BRANCH_NAME") + " ใช่ไหม ?');");

                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    TextBox txt = (TextBox)e.Row.FindControl("txtBranchIDEdit");
                    txt.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                }
            }
        }
        protected void myGridViewBranch_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }

        protected void btnCancelBranch_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassBranch b = new ClassBranch();
            DataTable dt = b.GetBranch("", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        protected void btnSearchBranch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchBranchID.Text) && string.IsNullOrEmpty(txtSearchBranchName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก คำค้นหา')", true);
                return;
            }
            else
            {
                ClassBranch b = new ClassBranch();
                DataTable dt = b.GetBranchSearch(txtSearchBranchID.Text, txtSearchBranchName.Text);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                SetViewState(dt);
            }
        }

        protected void btnSearchRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassBranch b = new ClassBranch();
            DataTable dt = b.GetBranch("", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }
    }
}