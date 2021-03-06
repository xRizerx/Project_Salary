﻿using WEB_PERSONAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_PERSONAL
{
    public partial class Campus_ADMIN : System.Web.UI.Page
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
            return (DataTable)ViewState["CAMPUS"];
        }

        private void SetViewState(DataTable data)
        {
            //Sets the ViewState
            ViewState["CAMPUS"] = data;
        }

        #endregion

        void BindData()
        {
            ClassCampus c = new ClassCampus();
            DataTable dt = c.GetCampus("");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        void BindData1()
        {
            ClassCampus c = new ClassCampus();
            DataTable dt = c.GetCampusSearch(txtSearchName.Text);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        private void ClearData()
        {
            txtSearchName.Text = "";
            txtInsertName.Text = "";
        }

        protected void btnSubmitCampus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInsertName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ ชื่อวิทยาเขต')", true);
                return;
            }
            ClassCampus c = new ClassCampus();
            c.CAMPUS_NAME = txtInsertName.Text;

            c.InsertCampus();
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
            ClassCampus c = new ClassCampus();
            c.CAMPUS_ID = id;
            c.DeleteCampus();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ลบข้อมูลเรียบร้อย')", true);

            GridView1.EditIndex = -1;
            BindData1();
        }
        protected void modUpdateCommand(Object sender, GridViewUpdateEventArgs e)
        {
            Label lblCampusID = (Label)GridView1.Rows[e.RowIndex].FindControl("lblCampusID");
            TextBox txtCampusNameEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtCampusNameEdit");

            ClassCampus c = new ClassCampus(Convert.ToInt32(lblCampusID.Text),
                txtCampusNameEdit.Text);

            c.UpdateCampus();
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
                lb.Attributes.Add("onclick", "return confirm('คุณต้องการจะลบ " + DataBinder.Eval(e.Row.DataItem, "CAMPUS_NAME") + " ใช่ไหม ?');");
            }
        }
        protected void myGridViewCampus_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }

        protected void btnCancelCampus_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassCampus c = new ClassCampus();
            DataTable dt = c.GetCampus("");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        protected void btnSearchCampus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก คำค้นหา')", true);
                return;
            }
            else
            {
                ClassCampus c = new ClassCampus();
                DataTable dt = c.GetCampusSearch(txtSearchName.Text);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                SetViewState(dt);
            }
        }

        protected void btnSearchRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassCampus c = new ClassCampus();
            DataTable dt = c.GetCampus("");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }
    }
}