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
    public partial class pre_title_name : System.Web.UI.Page
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
            return (DataTable)ViewState["Title"];
        }

        private void SetViewState(DataTable data)
        {
            //Sets the ViewState
            ViewState["Title"] = data;
        }

        #endregion

        void BindData()
        {
            TITLENAME ptn = new TITLENAME();
            DataTable dt = ptn.GetTITLENAME("", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        private void ClearData()
        {
            txtTitleNameEn.Text = "";
            txtTitleNameEnMin.Text = "";
            txtTitleNameTh.Text = "";
            txtTitleNameThMin.Text = "";
        }

        protected void btnSubmitPretitle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitleNameTh.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ชื่อภาษาไทย')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtTitleNameThMin.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ชื่อย่อภาษาไทย')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtTitleNameEn.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ชื่อภาษาอังกฤษ')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtTitleNameEnMin.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ชื่อย่อภาษาอังกฤษ')", true);
                return;
            }

            TITLENAME ptn = new TITLENAME();
            ptn.TITLE_NAME_TH = txtTitleNameTh.Text;
            ptn.TITLE_NAME_TH_MIN = txtTitleNameThMin.Text;
            ptn.TITLE_NAME_EN = txtTitleNameEn.Text;
            ptn.TITLE_NAME_EN_MIN = txtTitleNameEnMin.Text;


            if (ptn.CheckUseTitleNameTH())
            {
                ptn.InsertTITLENAME();
                BindData();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ชื่อภาษาไทยใช้แล้ว')", true);
            }
        }/*   if (ptn.CheckUseTitleNameTHmin())
            {
                ptn.InsertTITLENAME();
                BindData();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ชื่อย่อภาษาไทยใช้แล้ว')", true);
            }
            if (ptn.CheckUseTitleNameEN())
            {
                ptn.InsertTITLENAME();
                BindData();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ชื่อภาษาอังกฤษใช้แล้ว')", true);
            }
            if (ptn.CheckUseTitleNameENmin())
            {
                ptn.InsertTITLENAME();
                BindData();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ชื่อย่อภาษาอังกฤษใช้แล้ว')", true);
            }
        } */
        
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
            TITLENAME ptn = new TITLENAME();
            ptn.TITLE_ID = id;
            ptn.DeleteTITLENAME();

            GridView1.EditIndex = -1;
            BindData();
        }
        protected void modUpdateCommand(Object sender, GridViewUpdateEventArgs e)
        {
            Label lblTitleID = (Label)GridView1.Rows[e.RowIndex].FindControl("lblTitleID");

            TextBox txtTitleNameTh = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtTitleNameTh");

            TextBox txtTitleNameThMin = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtTitleNameThMin");

            TextBox txtTitleNameEn = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtTitleNameEn");

            TextBox txtTitleNameEnMin = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtTitleNameEnMin");

            TITLENAME ptn = new TITLENAME(Convert.ToInt32(lblTitleID.Text)
                , txtTitleNameTh.Text
                , txtTitleNameThMin.Text
                , txtTitleNameEn.Text
                , txtTitleNameEnMin.Text);

            ptn.UpdateTITLENAME();

            GridView1.EditIndex = -1;
            BindData();
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
        }
        protected void myGridViewPRETITLE_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }
    }
}