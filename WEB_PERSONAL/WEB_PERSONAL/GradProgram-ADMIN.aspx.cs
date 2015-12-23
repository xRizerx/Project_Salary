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
    public partial class GradProgram_ADMIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
                txtSearchGradPROGID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                txtInsertGradPROGID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
            }
        }

        #region ViewState DataTable

        private DataTable GetViewState()
        {
            //Gets the ViewState
            return (DataTable)ViewState["GRADPROG"];
        }

        private void SetViewState(DataTable data)
        {
            //Sets the ViewState
            ViewState["GRADPROG"] = data;
        }

        #endregion

        void BindData()
        {
            ClassGradProgram gp = new ClassGradProgram();
            DataTable dt = gp.GetGradProgram("", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        void BindData1()
        {
            ClassGradProgram gp = new ClassGradProgram();
            DataTable dt = gp.GetGradProgramSearch(txtSearchGradPROGID.Text, txtSearchGradPROGName.Text);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        private void ClearData()
        {
            txtSearchGradPROGID.Text = "";
            txtSearchGradPROGName.Text = "";
            txtInsertGradPROGID.Text = "";
            txtInsertGradPROGName.Text = "";
        }

        protected void btnSubmitGradPROG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInsertGradPROGID.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ รหัสสาขาวิชาที่จบการศึกษาสูงสุด')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtInsertGradPROGName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ ชื่อสาขาวิชาที่จบการศึกษาสูงสุด')", true);
                return;
            }
            ClassGradProgram gp = new ClassGradProgram();
            gp.GRAD_PROG_ID = txtInsertGradPROGID.Text;
            gp.GRAD_PROG_NAME = txtInsertGradPROGName.Text;

            if (gp.CheckUseGradProgramID())
            {
                gp.InsertGradProgram();
                BindData();
                ClearData();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('เพิ่มข้อมูลเรียบร้อย')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('มีรหัสสาขาวิชาที่จบการศึกษาสูงสุดนี้ อยู่ในระบบแล้ว !')", true);
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
            ClassGradProgram gp = new ClassGradProgram();
            gp.GRAD_PROG_ID = id;
            gp.DeleteGradProgram();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ลบข้อมูลเรียบร้อย')", true);

            GridView1.EditIndex = -1;
            BindData1();
        }
        protected void modUpdateCommand(Object sender, GridViewUpdateEventArgs e)
        {
            TextBox txtGradPROGIDEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtGradPROGIDEdit");
            TextBox txtGradPROGNameEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtGradPROGNameEdit");

            ClassGradProgram gp = new ClassGradProgram(txtGradPROGIDEdit.Text
                , txtGradPROGNameEdit.Text);

            gp.UpdateGradProgram();
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
                lb.Attributes.Add("onclick", "return confirm('คุณต้องการจะลบ " + DataBinder.Eval(e.Row.DataItem, "GRAD_PROG_NAME") + " ใช่ไหม ?');");

                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    TextBox txt = (TextBox)e.Row.FindControl("txtGradPROGIDEdit");
                    txt.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                }
            }
        }
        protected void myGridViewGradPROG_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }

        protected void btnCancelGradPROG_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassGradProgram gp = new ClassGradProgram();
            DataTable dt = gp.GetGradProgram("", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        protected void btnSearchGradPROG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchGradPROGID.Text) && string.IsNullOrEmpty(txtSearchGradPROGName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก คำค้นหา')", true);
                return;
            }
            else
            {
                ClassGradProgram gp = new ClassGradProgram();
                DataTable dt = gp.GetGradProgramSearch(txtSearchGradPROGID.Text, txtSearchGradPROGName.Text);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                SetViewState(dt);
            }
        }

        protected void btnSearchRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassGradProgram gp = new ClassGradProgram();
            DataTable dt = gp.GetGradProgram("", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }
    }
}