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
    public partial class Department_ADMIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
                txtSearchDepartmentID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                txtInsertDepartmentID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
            }
        }

        #region ViewState DataTable

        private DataTable GetViewState()
        {
            //Gets the ViewState
            return (DataTable)ViewState["DEPARTMENT"];
        }

        private void SetViewState(DataTable data)
        {
            //Sets the ViewState
            ViewState["DEPARTMENT"] = data;
        }

        #endregion

        void BindData()
        {
            ClassDepartment d = new ClassDepartment();
            DataTable dt = d.GetDepartment("", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        void BindData1()
        {
            ClassDepartment d = new ClassDepartment();
            DataTable dt = d.GetDepartmentSearch(txtSearchDepartmentID.Text,txtSearchDepartmentName.Text);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        private void ClearData()
        {
            txtSearchDepartmentID.Text = "";
            txtSearchDepartmentName.Text = "";
            txtInsertDepartmentID.Text = "";
            txtInsertDepartmentName.Text = "";
        }

        protected void btnSubmitDepartment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInsertDepartmentID.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ รหัสคณะ/หน่วยงานที่สังกัด หรือเทียบเท่า')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtInsertDepartmentName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ ชื่อคณะ/หน่วยงานที่สังกัด หรือเทียบเท่า')", true);
                return;
            }
            ClassDepartment d = new ClassDepartment();
            d.DEPARTMENT_ID = txtInsertDepartmentID.Text;
            d.DEPARTMENT_NAME = txtInsertDepartmentName.Text;

            if (d.CheckUseDepartmentID())
            {
                d.InsertDepartment();
                BindData();
                ClearData();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('เพิ่มข้อมูลเรียบร้อย')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('มีรหัสคณะ/หน่วยงานที่สังกัด หรือเทียบเท่านี้ อยู่ในระบบแล้ว !')", true);
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
            string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            ClassDepartment d = new ClassDepartment();
            d.DEPARTMENT_ID = id;
            d.DeleteDepartment();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ลบข้อมูลเรียบร้อย')", true);

            GridView1.EditIndex = -1;
            BindData1();
        }
        protected void modUpdateCommand(Object sender, GridViewUpdateEventArgs e)
        {
            TextBox txtDepartmentIDEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtDepartmentIDEdit");
            TextBox txtDepartmentNameEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtDepartmentNameEdit");

            ClassDepartment d = new ClassDepartment(txtDepartmentIDEdit.Text, txtDepartmentNameEdit.Text);

            d.UpdateDepartment();
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
                lb.Attributes.Add("onclick", "return confirm('คุณต้องการจะลบรหัสคณะ/หน่วยงานที่สังกัด หรือเทียบเท่า " + DataBinder.Eval(e.Row.DataItem, "DEPARTMENT_ID") + " ใช่ไหม ?');");

                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    TextBox txt = (TextBox)e.Row.FindControl("txtDepartmentIDEdit");
                    txt.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                }
            }
        }
        protected void myGridViewDepartment_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }

        protected void btnCancelDepartment_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassDepartment d = new ClassDepartment();
            DataTable dt = d.GetDepartment("", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        protected void btnSearchDepartment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchDepartmentID.Text) && string.IsNullOrEmpty(txtSearchDepartmentName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก คำค้นหา')", true);
                return;
            }
            else
            {
                ClassDepartment d = new ClassDepartment();
                DataTable dt = d.GetDepartmentSearch(txtSearchDepartmentID.Text, txtSearchDepartmentName.Text);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                SetViewState(dt);
            }
        }

        protected void btnSearchRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassDepartment d = new ClassDepartment();
            DataTable dt = d.GetDepartment("", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }
    }
}