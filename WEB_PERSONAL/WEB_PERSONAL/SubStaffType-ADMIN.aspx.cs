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
    public partial class SubStaffType_ADMIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
                txtSearchSubStaffTypeID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                txtInsertSubStaffTypeID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
            }
        }

        #region ViewState DataTable

        private DataTable GetViewState()
        {
            //Gets the ViewState
            return (DataTable)ViewState["SUBSTAFFTYPE"];
        }

        private void SetViewState(DataTable data)
        {
            //Sets the ViewState
            ViewState["SUBSTAFFTYPE"] = data;
        }

        #endregion

        void BindData()
        {
            ClassSubStaffType sst = new ClassSubStaffType();
            DataTable dt = sst.GetSubStaffType("", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        void BindData1()
        {
            ClassSubStaffType sst = new ClassSubStaffType();
            DataTable dt = sst.GetSubStaffType(txtSearchSubStaffTypeID.Text, txtSearchSubStaffTypeName.Text);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        private void ClearData()
        {
            txtSearchSubStaffTypeID.Text = "";
            txtSearchSubStaffTypeName.Text = "";
            txtInsertSubStaffTypeID.Text = "";
            txtInsertSubStaffTypeName.Text = "";
        }

        protected void btnSubmitSubStaffType_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInsertSubStaffTypeID.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ รหัสประเภทบุคลากรย่อย')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtInsertSubStaffTypeName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ ชื่อประเภทบุคลากรย่อย')", true);
                return;
            }
            ClassSubStaffType sst = new ClassSubStaffType();
            sst.SUBSTAFFTYPE_ID = Convert.ToInt32(txtInsertSubStaffTypeID.Text);
            sst.SUBSTAFFTYPE_NAME = txtInsertSubStaffTypeName.Text;

            if (sst.CheckUseSubStaffTypeID())
            {
                sst.InsertSubStaffType();
                BindData();
                ClearData();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('เพิ่มข้อมูลเรียบร้อย')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('มีรหัสประเภทบุคลากรย่อยนี้ อยู่ในระบบแล้ว !')", true);
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
            ClassSubStaffType sst = new ClassSubStaffType();
            sst.SUBSTAFFTYPE_ID = id;
            sst.DeleteSubStaffType();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ลบข้อมูลเรียบร้อย')", true);

            GridView1.EditIndex = -1;
            BindData1();
        }
        protected void modUpdateCommand(Object sender, GridViewUpdateEventArgs e)
        {

            TextBox txtSubStaffTypeIDEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtSubStaffTypeIDEdit");
            TextBox txtSubStaffTypeNameEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtSubStaffTypeNameEdit");

            ClassSubStaffType sst = new ClassSubStaffType(Convert.ToInt32(txtSubStaffTypeIDEdit.Text), txtSubStaffTypeNameEdit.Text);

            sst.UpdateSubStaffType();
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
                lb.Attributes.Add("onclick", "return confirm('คุณต้องการจะลบ " + DataBinder.Eval(e.Row.DataItem, "SUBSTAFFTYPE_NAME") + " ใช่ไหม ?');");

                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    TextBox txt = (TextBox)e.Row.FindControl("txtSubStaffTypeIDEdit");
                    txt.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                }
            }
        }
        protected void myGridViewSubStaffType_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }

        protected void btnCancelSubStaffType_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassSubStaffType sst = new ClassSubStaffType();
            DataTable dt = sst.GetSubStaffType("", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        protected void SearchSubStaffType_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchSubStaffTypeID.Text) && string.IsNullOrEmpty(txtSearchSubStaffTypeName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก คำค้นหา')", true);
                return;
            }
            else
            {
                ClassSubStaffType sst = new ClassSubStaffType();
                DataTable dt = sst.GetSubStaffTypeSearch(txtSearchSubStaffTypeID.Text, txtSearchSubStaffTypeName.Text);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                SetViewState(dt);
            }
        }

        protected void btnSearchRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassSubStaffType sst = new ClassSubStaffType();
            DataTable dt = sst.GetSubStaffType("", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }
    }
}