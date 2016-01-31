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
    public partial class StatusWork_ADMIN : System.Web.UI.Page
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
            return (DataTable)ViewState["StatusWork"];
        }

        private void SetViewState(DataTable data)
        {
            //Sets the ViewState
            ViewState["StatusWork"] = data;
        }

        #endregion

        void BindData()
        {
            ClassStatusWork sw = new ClassStatusWork();
            DataTable dt = sw.GetStatusWork("");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        void BindData1()
        {
            ClassStatusWork sw = new ClassStatusWork();
            DataTable dt = sw.GetStatusWorkSearch(txtSearchName.Text);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        private void ClearData()
        {
            txtSearchName.Text = "";
            txtInsertName.Text = "";
        }

        protected void btnSubmitStatusWork_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInsertName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ ชื่อสถานะการทำงาน')", true);
                return;
            }
            ClassStatusWork sw = new ClassStatusWork();
            sw.STATUS_WORK = txtInsertName.Text;

            sw.InsertStatusWork();
            BindData();
            ClearData();

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
            ClassStatusWork sw = new ClassStatusWork();
            sw.STATUS_ID = id;
            sw.DeleteStatusWork();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ลบข้อมูลเรียบร้อย')", true);

            GridView1.EditIndex = -1;
            BindData1();
        }
        protected void modUpdateCommand(Object sender, GridViewUpdateEventArgs e)
        {
            Label lblStatusWorkID = (Label)GridView1.Rows[e.RowIndex].FindControl("lblStatusWorkID");
            TextBox txtStatusWorkNameEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtStatusWorkNameEdit");

            ClassStatusWork sw = new ClassStatusWork(Convert.ToInt32(lblStatusWorkID.Text),
                txtStatusWorkNameEdit.Text);

            sw.UpdateStatusWork();
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
                lb.Attributes.Add("onclick", "return confirm('คุณต้องการจะลบ " + DataBinder.Eval(e.Row.DataItem, "STATUS_WORK") + " ใช่ไหม ?');");
            }
        }
        protected void myGridViewStatusWork_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }

        protected void btnCancelStatusWork_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassStatusWork sw = new ClassStatusWork();
            DataTable dt = sw.GetStatusWork("");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        protected void btnSearchStatusWork_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก คำค้นหา')", true);
                return;
            }
            else
            {
                ClassStatusWork sw = new ClassStatusWork();
                DataTable dt = sw.GetStatusWorkSearch(txtSearchName.Text);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                SetViewState(dt);
            }
        }

        protected void btnSearchRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassStatusWork sw = new ClassStatusWork();
            DataTable dt = sw.GetStatusWork("");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }
    }
}