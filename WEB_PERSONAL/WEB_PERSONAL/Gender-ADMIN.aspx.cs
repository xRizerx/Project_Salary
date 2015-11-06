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
    public partial class Gender_ADMIN : System.Web.UI.Page
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
            return (DataTable)ViewState["GENDER_NAME"];
        }

        private void SetViewState(DataTable data)
        {
            //Sets the ViewState
            ViewState["GENDER_NAME"] = data;
        }

        #endregion

        void BindData()
        {
            ClassGender g = new ClassGender();
            DataTable dt = g.GetGender("");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        private void ClearData()
        {
            txtSearchGenderName.Text = "";
            txtGenderName.Text = "";
        }

        protected void btnSubmitGender_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGenderName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่เพศ')", true);
                return;
            }
            ClassGender g = new ClassGender();
            g.Gender_Name = txtGenderName.Text;

            g.InsertGender();
            BindData();
            ClearData();
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
            ClassGender y = new ClassGender();
            y.Gender_ID = id;
            y.DeleteGender();

            GridView1.EditIndex = -1;
            BindData();
        }
        protected void modUpdateCommand(Object sender, GridViewUpdateEventArgs e)
        {
            Label lblGenderID = (Label)GridView1.Rows[e.RowIndex].FindControl("lblGenderID");

            TextBox txtGenderNameEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtGenderNameEdit");

            ClassGender g = new ClassGender(Convert.ToInt32(lblGenderID.Text)
                , txtGenderNameEdit.Text);

            g.UpdateGender();

            GridView1.EditIndex = -1;
            BindData();
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
           
        }
        protected void myGridViewGENDER_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }

        protected void btnCancelGender_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassGender g = new ClassGender();
            DataTable dt = g.GetGender("");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        protected void btnSearchGender_Click(object sender, EventArgs e)
        {
            ClassGender g = new ClassGender();
            DataTable dt = g.GetGender(txtSearchGenderName.Text);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }
    }
}