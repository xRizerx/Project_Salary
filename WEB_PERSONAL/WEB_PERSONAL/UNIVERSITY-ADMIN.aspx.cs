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
    public partial class UNIV_ADMIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
                txtSearchUnivID.Attributes.Add("onkeypress", "return allowOnlyNumber(this)");
                txtInsertUnivID.Attributes.Add("onkeypress", "return allowOnlyNumber(this)");
                GridView1.AllowPaging = true;
                GridView1.AllowSorting = true;
            }
        }

        #region ViewState DataTable

        private DataTable GetViewState()
        {
            //Gets the ViewState
            return (DataTable)ViewState["UNIVERSITY"];
        }

        private void SetViewState(DataTable data)
        {
            //Sets the ViewState
            ViewState["UNIVERSITY"] = data;
        }

        #endregion

        void BindData()
        {
            ClassUniversity u = new ClassUniversity();
            DataTable dt = u.GetUniversity("","");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        void BindData1()
        {
            ClassUniversity u = new ClassUniversity();
            DataTable dt = u.GetUniversitySearch(txtSearchUnivID.Text, txtSearchUnivName.Text);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        private void ClearData()
        {
            txtSearchUnivID.Text = "";
            txtSearchUnivName.Text = "";
            txtInsertUnivID.Text = "";
            txtInsertUnivName.Text = "";
        }

        protected void btnSubmitUNIVERSITY_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInsertUnivID.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ รหัสมหาวิทยาลัย')", true);
                return;
            }
            
            if (string.IsNullOrEmpty(txtInsertUnivName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ ชื่อมหาวิทยาลัย')", true);
                return;
            }
            ClassUniversity u = new ClassUniversity();
            u.UNIV_ID = txtInsertUnivID.Text;
            u.UNIV_NAME = txtInsertUnivName.Text;

            if (u.CheckUseUniversityID())
            {
                u.InsertUniversity();
                BindData();
                ClearData();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('เพิ่มข้อมูลเรียบร้อย')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('มีรหัสมหาวิทยาลัยนี้ อยู่ในระบบแล้ว !')", true);
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
            ClassUniversity y = new ClassUniversity();
            y.UNIV_SEQ = id;
            y.DeleteUniversity();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ลบข้อมูลเรียบร้อย')", true);

            GridView1.EditIndex = -1;
            BindData1();
        }
        protected void modUpdateCommand(Object sender, GridViewUpdateEventArgs e)
        {
            Label lblUnivSEQ = (Label)GridView1.Rows[e.RowIndex].FindControl("lblUnivSEQ");
            TextBox txtUnivIDEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtUnivIDEdit");
            TextBox txtUnivNameEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtUnivNameEdit");

            ClassUniversity u = new ClassUniversity(Convert.ToInt32(lblUnivSEQ.Text)
                , txtUnivIDEdit.Text
                , txtUnivNameEdit.Text);

            u.UpdateUniversity();
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
                lb.Attributes.Add("onclick", "return confirm('คุณต้องการจะลบรหัสมหาวิทยาลัย " + DataBinder.Eval(e.Row.DataItem, "UNIV_ID") + " ใช่ไหม ?');");

                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    TextBox txt = (TextBox)e.Row.FindControl("txtUnivIDEdit");
                    txt.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                }
            }
        }
        protected void myGridViewUNIVERSITY_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }

        protected void btnCancelUNIVERSITY_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassUniversity y = new ClassUniversity();
            DataTable dt = y.GetUniversity("","");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        protected void btnSearchUniv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchUnivID.Text) && string.IsNullOrEmpty(txtSearchUnivName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก คำค้นหา')", true);
                return;
            }
            else
            {
                ClassUniversity y = new ClassUniversity();
                DataTable dt = y.GetUniversitySearch(txtSearchUnivID.Text, txtSearchUnivName.Text);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                SetViewState(dt);
            }
        }

        protected void btnSearchRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassUniversity y = new ClassUniversity();
            DataTable dt = y.GetUniversity("", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }
    }
}