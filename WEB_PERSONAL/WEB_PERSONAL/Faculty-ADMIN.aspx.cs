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
    public partial class Faculty_ADMIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
                txtSearchCampusID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                txtInsertCampusID.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
            }
        }

        #region ViewState DataTable

        private DataTable GetViewState()
        {
            //Gets the ViewState
            return (DataTable)ViewState["FACULTY"];
        }

        private void SetViewState(DataTable data)
        {
            //Sets the ViewState
            ViewState["FACULTY"] = data;
        }

        #endregion

        void BindData()
        {
            ClassFaculty f = new ClassFaculty();
            DataTable dt = f.GetFaculty("", "", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        void BindData1()
        {
            ClassFaculty f = new ClassFaculty();
            DataTable dt = f.GetFacultySearch(txtSearchFacultyName.Text, txtSearchFacultyShort.Text, txtSearchCampusID.Text);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        private void ClearData()
        {
            txtSearchFacultyName.Text = "";
            txtSearchFacultyShort.Text = "";
            txtSearchCampusID.Text = "";
            txtInsertFacultyName.Text = "";
            txtInsertFacultyShort.Text = "";
            txtInsertCampusID.Text = "";
        }

        protected void btnSubmitFaculty_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInsertFacultyName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ ชื่อคณะ')", true);
                return;
            }

            if (string.IsNullOrEmpty(txtInsertFacultyShort.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ ชื่อย่อคณะ')", true);
                return;
            }

            if (string.IsNullOrEmpty(txtInsertCampusID.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาใส่ รหัสวิทยาเขต')", true);
                return;
            }
            ClassFaculty f = new ClassFaculty();
            f.FACULTY_NAME = txtInsertFacultyName.Text;
            f.FACULTY_SHORT = txtInsertFacultyShort.Text;
            f.CAMPUS_ID = Convert.ToInt32(txtInsertCampusID.Text);
 
            f.InsertFaculty();
            BindData();
            ClearData();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('เพิ่มข้อมูลเรียบร้อย')", true);
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
            ClassFaculty f = new ClassFaculty();
            f.FACULTY_ID = id;
            f.DeleteFaculty();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ลบข้อมูลเรียบร้อย')", true);

            GridView1.EditIndex = -1;
            BindData1();
        }
        protected void modUpdateCommand(Object sender, GridViewUpdateEventArgs e)
        {
            Label lblFacultyIDEdit = (Label)GridView1.Rows[e.RowIndex].FindControl("lblFacultyIDEdit");
            TextBox txtFacultyNameEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtFacultyNameEdit");
            TextBox txtFacultyShortEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtFacultyShortEdit");
            TextBox txtCampusIDEdit = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtCampusIDEdit");

            ClassFaculty f = new ClassFaculty(Convert.ToInt32(lblFacultyIDEdit.Text)
                , txtFacultyNameEdit.Text
                , txtFacultyShortEdit.Text
                , Convert.ToInt32(txtCampusIDEdit.Text));

            f.UpdateFaculty();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('อัพเดทข้อมูลเรียบร้อย')", true);
            GridView1.EditIndex = -1;
            BindData1();
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton lb = (LinkButton)e.Row.FindControl("DeleteButton1");
                lb.Attributes.Add("onclick", "return confirm('คุณต้องการจะลบ " + DataBinder.Eval(e.Row.DataItem, "FACULTY_NAME") + " ใช่ไหม ?');");

                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    TextBox txt = (TextBox)e.Row.FindControl("txtCampusIDEdit");
                    txt.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");
                }
            }
        }
        protected void myGridViewFaculty_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetViewState();
            GridView1.DataBind();
        }

        protected void btnCancelFaculty_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassFaculty f = new ClassFaculty();
            DataTable dt = f.GetFaculty("", "", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }

        protected void btnSearchFaculty_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtSearchFacultyName.Text) && string.IsNullOrEmpty(txtSearchFacultyShort.Text) && string.IsNullOrEmpty(txtSearchCampusID.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก คำค้นหา')", true);

                return;
            }
            else
            {
                ClassFaculty f = new ClassFaculty();
                DataTable dt = f.GetFacultySearch(txtSearchFacultyName.Text, txtSearchFacultyShort.Text, txtSearchCampusID.Text);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                SetViewState(dt);
            }
        }

        protected void btnSearchRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
            ClassFaculty f = new ClassFaculty();
            DataTable dt = f.GetFaculty("", "", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            SetViewState(dt);
        }
    }
}