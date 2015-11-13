using WEB_PERSONAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;
using System.Data;
using System.Configuration;

namespace WEB_PERSONAL
{
    public partial class Person_GENERAL : System.Web.UI.Page
    {
        public static string strConn = @"Data Source = ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DDLMisnistry();
                DDLDepart();
                DDLTitle();
                DDLStaffType();
                txtCitizen.Attributes.Add("onkeypress", "return allowOnlyNumber(this);");

            }

        }

        private void DDLMisnistry()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_MINISTRY";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownMinistry.DataSource = dt;
                        DropDownMinistry.DataValueField = "ID";
                        DropDownMinistry.DataTextField = "NAME";
                        DropDownMinistry.DataBind();
                        sqlConn.Close();

                        DropDownMinistry.Items.Insert(0, new ListItem("--กรุณาเลือก กระทรวง--", "0"));

                    }
                }
            }
            catch { }
        }


        private void DDLDepart()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_DEPARTMENT_RENEW";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownDepart.DataSource = dt;
                        DropDownDepart.DataValueField = "ID";
                        DropDownDepart.DataTextField = "DEPARTMENT_NAME";
                        DropDownDepart.DataBind();
                        sqlConn.Close();

                       // DropDownDepart.Items.Insert(0, new ListItem("--กรุณาเลือก กรม--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLTitle()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_TITLENAME";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownTitle.DataSource = dt;
                        DropDownTitle.DataValueField = "TITLE_ID";
                        DropDownTitle.DataTextField = "TITLE_NAME_TH";
                        DropDownTitle.DataBind();
                        sqlConn.Close();

                        DropDownTitle.Items.Insert(0, new ListItem("--กรุณาเลือก คำนำหน้านาม--", "0"));

                    }
                }
            }
            catch { }
        }

        private void DDLStaffType()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_STAFFTYPE";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownStaffType.DataSource = dt;
                        DropDownStaffType.DataValueField = "STAFFTYPE_ID";
                        DropDownStaffType.DataTextField = "STAFFTYPE_NAME";
                        DropDownStaffType.DataBind();
                        sqlConn.Close();

                        DropDownStaffType.Items.Insert(0, new ListItem("--กรุณาเลือก ประเภทข้าราชการ--", "0"));

                    }
                }
            }
            catch { }
        }

        protected void ClearData()
        {
            DropDownMinistry.SelectedIndex = 0;
            txtDepart.Text = "มหาวิทยาลัยเทคโนโลยีราชมงคลตะวันออก";
            //DropDownDepart.SelectedIndex = 0;
            DropDownTitle.SelectedIndex = 0;
            txtCitizen.Text = "";
            txtName.Text = "";
            txtLastName.Text = "";
            txtFatherName.Text = "";
            txtFatherLastName.Text = "";
            txtMotherName.Text = "";
            txtMotherLastName.Text = "";
            txtMotherLastNameOld.Text = "";
            txtMarriedName.Text = "";
            txtMarriedLastName.Text = "";
            txtMarriedLastNameOld.Text = "";
            txtBirthDayNumber.Text = "";
            txtBirthDayChar.Text = "";
            txtDateInWork.Text = "";
            DropDownStaffType.SelectedIndex = 0;
            txtAge60Number.Text = "";
            txtAge60Char.Text = "";
        }


        protected void btnCancelPerson_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        protected void btnSubmitPerson_Click(object sender, EventArgs e)
        {
         /*   if (DropDownMinistry.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก กระทรวง')", true);
                return;
            }
            //  if (DropDownDepart.SelectedIndex == 0)
            //  {
            //      ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก กรม')", true);
            //      return;
            //  }
            if (DropDownTitle.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก คำนำหน้านาม')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtCitizen.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก รหัสบัตรประชาชน')", true);
                return;
            }
            if (txtCitizen.Text.Length < 13)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก รหัสบัตรประชาชนให้ครบ 13 หลัก')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ชื่อ')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก นามสกุล')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtFatherName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ชื่อบิดา')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtFatherLastName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก นามสกุลบิดา')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtMotherName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ชื่อมารดา')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtMotherLastName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก นามสกุลมารดา')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtMotherLastNameOld.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก นามสกุลมารดาเดิม')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtMarriedName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ชื่อคู่สมรส')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtMarriedLastName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก นามสกุลคู่สมรส')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtMarriedLastNameOld.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก นามสกุลเดิมคู่สมรสเดิม')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtBirthDayNumber.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก วัน เดือน ปีเกิด (dd-mm-yyyy)')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtBirthDayChar.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก วัน เดือน ปีเกิด (ตัวบรรจง เต็มบรรทัด)')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtDateInWork.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก วันที่บรรจุ (dd-mm-yyyy)')", true);
                return;
            }
            if (DropDownStaffType.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณาเลือก ประเภทข้าราชการ')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtAge60Number.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก วันครบเกษียณอายุ (dd-mm-yyyy)')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtAge60Char.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก วันครบเกษียณอายุ (ตัวบรรจง เต็มบรรทัด)')", true);
                return;
            }*/


            ClassPerson P = new ClassPerson();
            P.CITIZEN_ID = txtCitizen.Text;
            P.BIRTHDATE = DateTime.Parse(txtBirthDayNumber.Text);
            P.INWORK_DATE = DateTime.Parse(txtDateInWork.Text);
            P.RETIRE_DATE = DateTime.Parse(txtAge60Number.Text);
            P.DEPARTMENT_NAME = txtDepart.Text;
            P.MINISTRY_ID = Convert.ToInt32(DropDownMinistry.SelectedValue);
            P.TITLE_ID = DropDownTitle.SelectedValue;
            P.BIRTHDATE_LONG = txtBirthDayChar.Text;
            P.RETIRE_DATE_LONG = txtAge60Char.Text;
            P.STAFFTYPE_ID = Convert.ToInt32(DropDownStaffType.SelectedValue);
            P.FATHER_NAME = txtFatherName.Text;
            P.FATHER_LASTNAME = txtFatherLastName.Text;
            P.MOTHER_NAME = txtMotherName.Text;
            P.MOTHER_LASTNAME = txtMotherLastName.Text;
            P.MOTHER_OLD_LASTNAME = txtMotherLastNameOld.Text;
            P.COUPLE_NAME = txtMarriedName.Text;
            P.COUPLE_LASTNAME = txtMarriedLastName.Text;
            P.COUPLE_OLD_LASTNAME = txtMarriedLastNameOld.Text;
            P.PERSON_LASTNAME = txtLastName.Text;
            P.PERSON_NAME = txtName.Text;

            string[] splitDate1 = txtBirthDayNumber.Text.Split('-');
            string[] splitDate2 = txtDateInWork.Text.Split('-');
            string[] splitDate3 = txtAge60Number.Text.Split('-');
            P.BIRTHDATE = new DateTime(Convert.ToInt32(splitDate1[2]), Convert.ToInt32(splitDate1[1]), Convert.ToInt32(splitDate1[0]));
            P.INWORK_DATE = new DateTime(Convert.ToInt32(splitDate2[2]), Convert.ToInt32(splitDate2[1]), Convert.ToInt32(splitDate2[0]));
            P.RETIRE_DATE = new DateTime(Convert.ToInt32(splitDate3[2]), Convert.ToInt32(splitDate3[1]), Convert.ToInt32(splitDate3[0]));

            
                P.InsertPerson();
                ClearData();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('เพิ่มข้อมูลเรียบร้อย')", true);
          
        }

        
        protected void txtBirthDayNumber_TextChanged(object sender, EventArgs e)
        {
            txtBirthDayChar.Text = Util.ToThaiWord(txtBirthDayNumber.Text);
        }

        protected void txtAge60Number_TextChanged(object sender, EventArgs e)
        {
            txtAge60Char.Text = Util.ToThaiWord(txtAge60Number.Text);
        }
    }
}