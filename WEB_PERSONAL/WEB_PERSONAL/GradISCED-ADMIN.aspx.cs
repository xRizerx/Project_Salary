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
    public partial class GradISCED_ADMIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
                txtSearchGradISCEDID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                txtInsertGradISCEDID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
            }
        }

        #region ViewState DataTable

        private DataTable GetViewState()
        {
            //Gets the ViewState
            return (DataTable)ViewState["GRADISCED"];
        }

        private void SetViewState(DataTable data)
        {
            //Sets the ViewState
            ViewState["GRADISCED"] = data;
        }

        #endregion

        void BindData()
        {
            ClassGradISCED gi = new ClassGradISCED();
            DataTable dt = gi.GetGradISCED("", "", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        void BindData1()
        {
            ClassGradISCED gi = new ClassGradISCED();
            DataTable dt = gi.GetGradISCEDSearch(txtSearchGradISCEDID.Text, txtSearchGradISCEDNameTh.Text, txtSearchGradISCEDNameEng.Text);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        private void ClearData()
        {
            txtSearchGradISCEDID.Text = "";
            txtSearchGradISCEDNameTh.Text = "";
            txtSearchGradISCEDNameEng.Text = "";
            txtInsertGradISCEDID.Text = "";
            txtInsertGradISCEDNameTh.Text = "";
            txtInsertGradISCEDNameEng.Text = "";
        }

        protected void btnSubmitGradISCED_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInsertGradISCEDID.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ รหัสสาขาวิชาที่จบการศึกษาสูงสุด')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtInsertGradISCEDNameTh.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ ชื่อสาขาวิชาที่จบการศึกษาสูงสุด(TH)')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtInsertGradISCEDNameEng.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ ชื่อสาขาวิชาที่จบการศึกษาสูงสุด(ENG)')", true);
                return;
            }
            ClassGradISCED gi = new ClassGradISCED();
            gi.GRAD_ISCED_ID = txtInsertGradISCEDID.Text;
            gi.GRAD_ISCED_NAME_THAI = txtInsertGradISCEDNameTh.Text;
            gi.GRAD_ISCED_NAME_ENG = txtInsertGradISCEDNameEng.Text;

            if (gi.CheckUseGradISCEDID())
            {
                gi.InsertGradISCED();
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
            ClassGradISCED gi = new ClassGradISCED();
            gi.GRAD_ISCED_ID = id;
            gi.DeleteGradISCED();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ลบข้อมูลเรียบร้อย')", true);

            GridView1.EditIndex = -1;
            BindData1();
        }
        protected void modUpdateCommand(Object sender, GridViewUpdateEventArgs e)
        {
            TextBox txtGradISCEDIDEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtGradISCEDIDEdit");
            TextBox txtGradISCEDNameThEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtGradISCEDNameThEdit");
            TextBox txtGradISCEDNameEngEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtGradISCEDNameEngEdit");

            ClassGradISCED gi = new ClassGradISCED(txtGradISCEDIDEdit.Text
                , txtGradISCEDNameThEdit.Text
                , txtGradISCEDNameEngEdit.Text);

            gi.UpdateGradISCED();
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
                lb.Attributes.Add("onclick", "return confirm('คุณต้องการจะลบ " + DataBinder.Eval(e.Row.DataItem, "GRAD_ISCED_NAME_THAI") + " ใช่ไหม ?');");

                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    TextBox txt = (TextBox)e.Row.FindControl("txtGradISCEDIDEdit");
                    txt.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                }
            }
        }
        protected void myGridViewGradISCED_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }

        protected void btnCancelGradISCED_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassGradISCED gi = new ClassGradISCED();
            DataTable dt = gi.GetGradISCED("", "", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        protected void btnSearchGradISCED_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchGradISCEDID.Text) && string.IsNullOrEmpty(txtSearchGradISCEDNameTh.Text) && string.IsNullOrEmpty(txtSearchGradISCEDNameEng.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก คำค้นหา')", true);
                return;
            }
            else
            {
                ClassGradISCED gi = new ClassGradISCED();
                DataTable dt = gi.GetGradISCEDSearch(txtSearchGradISCEDID.Text, txtSearchGradISCEDNameTh.Text, txtSearchGradISCEDNameEng.Text);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                SetViewState(dt);
            }
        }

        protected void btnSearchRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassGradISCED gi = new ClassGradISCED();
            DataTable dt = gi.GetGradISCED("", "", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }
    }
}