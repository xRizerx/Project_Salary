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
    public partial class SEMINAR_ADMIN : System.Web.UI.Page
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
            Seminar ptn = new Seminar();
            DataTable dt = ptn.GetSEMINAR("");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
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
            Seminar S = new Seminar();
            S.SEMINAR_ID = id;
            S.DeleteSEMINAR();

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
        protected void myGridViewSEMINARADMIN_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }

        protected void btnSearchNameSeminar_Click(object sender, EventArgs e)
        {
            Seminar S = new Seminar();
            DataTable dt = S.GetSEMINAR(txtSearchNameSeminar.Text);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }
    }
}