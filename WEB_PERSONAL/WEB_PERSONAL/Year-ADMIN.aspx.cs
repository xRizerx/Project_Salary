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
    public partial class Year_ADMIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
                txtYearName.Attributes.Add("onkeypress", "return allowOnlyNumber(this)");
                txtSearchTH.Attributes.Add("onkeypress", "return allowOnlyNumber(this)");
            }
        }

        #region ViewState DataTable

        private DataTable GetViewState()
        {
            //Gets the ViewState
            return (DataTable)ViewState["YEAR"];
        }

        private void SetViewState(DataTable data)
        {
            //Sets the ViewState
            ViewState["YEAR"] = data;
        }

        #endregion

        void BindData()
        {
            ClassYear y = new ClassYear();
            DataTable dt = y.GetYear("");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        private void ClearData()
        {
            txtSearchTH.Text ="";
            txtYearName.Text = "";
        }

        protected void btnSubmitYEAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtYearName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ ปีการศึกษา')", true);
                return;
            }
                ClassYear y = new ClassYear();
                y.Year_Name = txtYearName.Text;

            if (y.CheckUseYearName())
            {
                y.InsertYear();
                BindData();
                ClearData();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('เพิ่มข้อมูลเรียบร้อย')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('มีปีการศึกษานี้ อยู่ในระบบแล้ว !')", true);
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
            ClassYear y = new ClassYear();
            y.Year_ID = id;
            y.DeleteYear();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ลบข้อมูลเรียบร้อย')", true);

            GridView1.EditIndex = -1;
            BindData(); 
        }
        protected void modUpdateCommand(Object sender, GridViewUpdateEventArgs e)
        {
            Label lblYearID = (Label)GridView1.Rows[e.RowIndex].FindControl("lblYearID");

            TextBox txtYearNameEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtYearNameEdit");

            ClassYear y = new ClassYear(Convert.ToInt32(lblYearID.Text)
                , txtYearNameEdit.Text);

            y.UpdateYear();
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
                    TextBox txt = (TextBox)e.Row.FindControl("txtYearNameEdit");
                    txt.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                }
            }
        }
        protected void myGridViewYEAR_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }

        protected void btnCancelYEAR_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassYear y = new ClassYear();
            DataTable dt = y.GetYear("");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        protected void btnSearchYear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchTH.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก คำค้นหา')", true);
                return;
            }
            else
            {
                ClassYear y = new ClassYear();
                DataTable dt = y.GetYearSearch(txtSearchTH.Text);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                SetViewState(dt);
            }
        }
    }
}