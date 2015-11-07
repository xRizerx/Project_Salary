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
                txtSearchSubStaffName.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                txtInsertPositionID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                txtInsertSubStaffName.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");

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
            DataTable dt = p.GetPosition("","", 0);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        private void ClearData()
        {
            txtSearchPositionID.Text = "";
            txtSearchPositionName.Text = "";
            txtSearchSubStaffName.Text = "";
            txtInsertPositionID.Text = "";
            txtInsertPositionName.Text = "";
            txtInsertSubStaffName.Text = "";
        }

        protected void btnSubmitPosition_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtInsertPositionID.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ รหัสตำแหน่งทางวิชาการ')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtInsertPositionName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ ชื่อตำแหน่งทางวิชาการ')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtInsertSubStaffName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ รหัสประเภทบุคลากรย่อย')", true);
                return;
            }
            ClassPosition p = new ClassPosition();
            p.POSITION_ID = txtInsertPositionID.Text;
            p.POSITION_NAME = txtInsertPositionName.Text;
            p.SUBSTAFFTYPE_ID = Convert.ToInt32(txtInsertSubStaffName.Text);

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
            BindData();
        }
        protected void modCancelCommand(Object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindData();
        }
        protected void modDeleteCommand(Object sender, GridViewDeleteEventArgs e)
        {
            string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            ClassPosition p = new ClassPosition();
            p.POSITION_ID = id;
            p.DeletePosition();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ลบข้อมูลเรียบร้อย')", true);

            GridView1.EditIndex = -1;
            BindData();
        }
        protected void modUpdateCommand(Object sender, GridViewUpdateEventArgs e)
        {
            TextBox txtPositionIDEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtPositionIDEdit");
            TextBox txtPositionNameEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtPositionNameEdit");
            TextBox txtSubStaffNameEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtSubStaffNameEdit");

            ClassPosition p = new ClassPosition(txtPositionIDEdit.Text, txtPositionNameEdit.Text, Convert.ToInt32(txtSubStaffNameEdit.Text));

            p.UpdatePosition();
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
                    TextBox txt = (TextBox)e.Row.FindControl("txtPositionIDEdit");
                    txt.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                    TextBox txt2 = (TextBox)e.Row.FindControl("txtSubStaffNameEdit");
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
            DataTable dt = p.GetPosition("", "",0);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        protected void btnSearchPosition_Click(object sender, EventArgs e)
        {
            ClassPosition p = new ClassPosition();
            DataTable dt = p.GetPositionSearch(txtSearchPositionID.Text, txtSearchPositionName.Text, Convert.ToInt32(txtSearchSubStaffName.Text));
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }
    }
}