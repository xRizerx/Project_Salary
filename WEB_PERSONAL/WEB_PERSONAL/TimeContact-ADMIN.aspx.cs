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
    public partial class TimeContact_ADMIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
                txtSearchTimeContactID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                txtInsertTimeContactID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
            }
        }

        #region ViewState DataTable

        private DataTable GetViewState()
        {
            //Gets the ViewState
            return (DataTable)ViewState["TIME_CONTACT"];
        }

        private void SetViewState(DataTable data)
        {
            //Sets the ViewState
            ViewState["TIME_CONTACT"] = data;
        }

        #endregion

        void BindData()
        {
            ClassTimeContact tc = new ClassTimeContact();
            DataTable dt = tc.GetTimeContact("", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        void BindData1()
        {
            ClassTimeContact tc = new ClassTimeContact();
            DataTable dt = tc.GetTimeContact(txtSearchTimeContactID.Text, txtSearchTimeContactName.Text);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        private void ClearData()
        {
            txtSearchTimeContactID.Text = "";
            txtSearchTimeContactName.Text = "";
            txtInsertTimeContactID.Text = "";
            txtInsertTimeContactName.Text = "";
        }

        protected void btnSubmitTimeContact_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInsertTimeContactID.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ รหัสระยะเวลาจ้าง')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtInsertTimeContactName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ ชื่อระยะเวลาจ้าง')", true);
                return;
            }
            ClassTimeContact tc = new ClassTimeContact();
            tc.TIME_CONTACT_ID = Convert.ToInt32(txtInsertTimeContactID.Text);
            tc.TIME_CONTACT_NAME = txtInsertTimeContactName.Text;

            if (tc.CheckUseTimeContactID())
            {
                tc.InsertTimeContact();
                BindData();
                ClearData();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('เพิ่มข้อมูลเรียบร้อย')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('มีรหัสระยะเวลาจ้าง อยู่ในระบบแล้ว !')", true);
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
            ClassTimeContact tc = new ClassTimeContact();
            tc.TIME_CONTACT_ID = id;
            tc.DeleteTimeContact();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ลบข้อมูลเรียบร้อย')", true);

            GridView1.EditIndex = -1;
            BindData1();
        }
        protected void modUpdateCommand(Object sender, GridViewUpdateEventArgs e)
        {
            TextBox txtTimeContactIDEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtTimeContactIDEdit");
            TextBox txtTimeContactNameEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtTimeContactNameEdit");

            ClassTimeContact tc = new ClassTimeContact(Convert.ToInt32(txtTimeContactIDEdit.Text)
                , txtTimeContactNameEdit.Text);

            tc.UpdateTimeContact();
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
                lb.Attributes.Add("onclick", "return confirm('คุณต้องการจะลบ " + DataBinder.Eval(e.Row.DataItem, "TIME_CONTACT_NAME") + " ใช่ไหม ?');");

                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    TextBox txt = (TextBox)e.Row.FindControl("txtTimeContactIDEdit");
                    txt.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                }
            }
        }
        protected void myGridViewTimeContact_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }

        protected void btnCancelTimeContact_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassTimeContact tc = new ClassTimeContact();
            DataTable dt = tc.GetTimeContact("", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        protected void btnSearchTimeContact_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchTimeContactID.Text) && string.IsNullOrEmpty(txtSearchTimeContactName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก คำค้นหา')", true);
                return;
            }
            else
            {
                ClassTimeContact tc = new ClassTimeContact();
                DataTable dt = tc.GetTimeContactSearch(txtSearchTimeContactID.Text, txtSearchTimeContactName.Text);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                SetViewState(dt);
            }
        }

        protected void btnSearchRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassTimeContact tc = new ClassTimeContact();
            DataTable dt = tc.GetTimeContact("", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }
    }
}