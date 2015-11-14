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
    public partial class Ministry_GENERAL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
                txtInsertMinistryID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
            }
        }

        #region ViewState DataTable

        private DataTable GetViewState()
        {
            //Gets the ViewState
            return (DataTable)ViewState["Ministry"];
        }

        private void SetViewState(DataTable data)
        {
            //Sets the ViewState
            ViewState["Ministry"] = data;
        }

        #endregion

        void BindData()
        {
            ClassMinistry m = new ClassMinistry();
            DataTable dt = m.GetMinistry(0, "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        private void ClearData()
        {
            txtSearchMinistryID.Text = "";
            txtSearchMinistryName.Text = "";
            txtInsertMinistryID.Text = "";
            txtInsertMinistryName.Text = "";
        }

        protected void btnSubmitMinistry_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInsertMinistryID.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ รหัสกระทรวง')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtInsertMinistryName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ ชื่อกระทรวง')", true);
                return;
            }
            ClassMinistry m = new ClassMinistry();
            m.MINISTRY_ID = Convert.ToInt32(txtInsertMinistryID.Text);
            m.MINISTRY_NAME = txtInsertMinistryName.Text;

            if (m.CheckUseMINISTRYID())
            {
                m.InsertMINISTRY();
                BindData();
                ClearData();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('เพิ่มข้อมูลเรียบร้อย')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('มีรหัสกระทรวงนี้ อยู่ในระบบแล้ว !')", true);
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
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            ClassMinistry m = new ClassMinistry();
            m.MINISTRY_ID = id;
            m.DeleteMINISTRY();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ลบข้อมูลเรียบร้อย')", true);

            GridView1.EditIndex = -1;
            BindData();
        }
        protected void modUpdateCommand(Object sender, GridViewUpdateEventArgs e)
        {
            TextBox txtMinistryIDEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtMinistryIDEdit");
            TextBox txtMinistryNameEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtMinistryNameEdit");

            ClassMinistry m = new ClassMinistry(Convert.ToInt32(txtMinistryIDEdit.Text)
                , txtMinistryNameEdit.Text);

            m.UpdateMINISTRY();
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
                    TextBox txt = (TextBox)e.Row.FindControl("txtMinistryIDEdit");
                    txt.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                }
            }
        }
        protected void myGridViewMinistry_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }

        protected void btnCancelMinistry_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassMinistry m = new ClassMinistry();
            DataTable dt = m.GetMinistry(0, "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        protected void btnSearchMinistry_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchMinistryID.Text) && string.IsNullOrEmpty(txtSearchMinistryName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก คำค้นหา')", true);
                return;
            }
            else
            {
                ClassMinistry m = new ClassMinistry();
                DataTable dt = m.GetMinistrySearch(txtSearchMinistryID.Text,txtSearchMinistryName.Text);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                SetViewState(dt);
            }
        }

        protected void btnSearchRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassMinistry m = new ClassMinistry();
            DataTable dt = m.GetMinistry(0, "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }
    }
}