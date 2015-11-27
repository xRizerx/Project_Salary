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
    public partial class Position_ADMIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
                txtSearchPositionID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                txtSearchSubStaffID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                txtInsertPositionID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                txtInsertSubStaffID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");

            }
        }

        #region ViewState DataTable

        private DataTable GetViewState()
        {
            //Gets the ViewState
            return (DataTable)ViewState["POSITION"];
        }

        private void SetViewState(DataTable data)
        {
            //Sets the ViewState
            ViewState["POSITION"] = data;
        }

        #endregion

        void BindData()
        {
            ClassPosition p = new ClassPosition();
            DataTable dt = p.GetPosition("", "", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        void BindData1()
        {
            ClassPosition p = new ClassPosition();
            DataTable dt = p.GetPositionSearch(txtSearchPositionID.Text, txtSearchPositionName.Text, txtSearchSubStaffID.Text);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        private void ClearData()
        {
            txtSearchPositionID.Text = "";
            txtSearchPositionName.Text = "";
            txtSearchSubStaffID.Text = "";
            txtInsertPositionID.Text = "";
            txtInsertPositionName.Text = "";
            txtInsertSubStaffID.Text = "";
        }

        protected void btnSubmitPosition_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtInsertPositionID.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ รหัสระดับ')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtInsertPositionName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ ชื่อระดับ')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtInsertSubStaffID.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ รหัสประเภทตำแหน่ง')", true);
                return;
            }
            ClassPosition p = new ClassPosition();
            p.ID = txtInsertPositionID.Text;
            p.NAME = txtInsertPositionName.Text;
            p.ST_ID = txtInsertSubStaffID.Text;

            if (p.CheckUsePositionID())
            {
                p.InsertPosition();
                BindData();
                ClearData();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('เพิ่มข้อมูลเรียบร้อย')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('มีรหัสตำแหน่งทางวิชาการ อยู่ในระบบแล้ว !')", true);
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
            ClassPosition p = new ClassPosition();
            p.ID = id;
            p.DeletePosition();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ลบข้อมูลเรียบร้อย')", true);

            GridView1.EditIndex = -1;
            BindData1();
        }
        protected void modUpdateCommand(Object sender, GridViewUpdateEventArgs e)
        {
            TextBox txtPositionIDEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtPositionIDEdit");
            TextBox txtPositionNameEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtPositionNameEdit");
            TextBox txtSubStaffIDEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtSubStaffIDEdit");

            ClassPosition p = new ClassPosition(txtPositionIDEdit.Text, txtPositionNameEdit.Text, txtSubStaffIDEdit.Text);

            p.UpdatePosition();
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
                lb.Attributes.Add("onclick", "return confirm('คุณต้องการจะลบรหัสระดับ " + DataBinder.Eval(e.Row.DataItem, "ID") + " ใช่ไหม ?');");

                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    TextBox txt = (TextBox)e.Row.FindControl("txtPositionIDEdit");
                    txt.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                    TextBox txt2 = (TextBox)e.Row.FindControl("txtSubStaffIDEdit");
                    txt2.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                }
            }
        }
        protected void myGridViewPosition_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }

        protected void btnCancelPosition_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassPosition p = new ClassPosition();
            DataTable dt = p.GetPosition("", "", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        protected void btnSearchPosition_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchPositionID.Text) && string.IsNullOrEmpty(txtSearchPositionName.Text) && string.IsNullOrEmpty(txtSearchSubStaffID.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก คำค้นหา')", true);
                return;
            }
            else
            {
                ClassPosition p = new ClassPosition();
                DataTable dt = p.GetPositionSearch(txtSearchPositionID.Text,txtSearchPositionName.Text, txtSearchSubStaffID.Text);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                SetViewState(dt);
            }
        }

        protected void btnSearchRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassPosition p = new ClassPosition();
            DataTable dt = p.GetPosition("", "", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }
    }
}