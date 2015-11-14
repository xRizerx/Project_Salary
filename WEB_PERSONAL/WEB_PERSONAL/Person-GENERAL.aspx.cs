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

                Session["StudyHis"] = new DataTable();
                ((DataTable)(Session["StudyHis"])).Columns.Add("สถานศึกษา");
                ((DataTable)(Session["StudyHis"])).Columns.Add("ตั้งแต่ - ถึง (เดือน ปี)");
                ((DataTable)(Session["StudyHis"])).Columns.Add("วุฒิ(สาขาวิชาเอก)");
                GridView1.DataSource = ((DataTable)(Session["StudyHis"]));
                GridView1.DataBind();

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
                        DropDownMinistry.DataValueField = "MINISTRY_ID";
                        DropDownMinistry.DataTextField = "MINISTRY_NAME";
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

        protected void ClearDataGridViewNumber10()
        {
            txtGrad_Univ.Text = "";
            txtDate_From.Text = "";
            txtDate_To.Text = "";
            txtMajor.Text = "";
        }

        protected void btnCancelPerson_Click(object sender, EventArgs e)
        {
            ClearData();
            Session.Remove("StudyHis");
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

            for (int i = 0; i < GridView1.Rows.Count; ++i)
            {
                int id = 0;
                using (OracleConnection conn = Util.OC())
                {
                    using (OracleCommand command = new OracleCommand("INSERT INTO TB_STUDY_HISTORY VALUES (SEQ_STUDY_HISTORY_ID.NEXTVAL,:CITIZEN_ID,:GRAD_UNIV,:DATE_FROM,:DATE_TO,:MAJOR)", conn))
                    {
                        
                        try
                        {
                            if (conn.State != ConnectionState.Open)
                            {
                                conn.Open();
                            }
                            string[] ss = GridView1.Rows[i].Cells[1].Text.Split('-');
                            for(int j=0;j<ss.Length;++j)
                            {
                                ss[i] = ss[i].Trim();
                            }
                            DateTime dt_from = new DateTime(Convert.ToInt32(ss[2]), Convert.ToInt32(ss[1]), Convert.ToInt32(ss[0]));
                            DateTime dt_to = new DateTime(Convert.ToInt32(ss[5]), Convert.ToInt32(ss[4]), Convert.ToInt32(ss[3]));
                            command.Parameters.Add(new OracleParameter("CITIZEN_ID", txtCitizen.Text));
                            command.Parameters.Add(new OracleParameter("GRAD_UNIV", GridView1.Rows[i].Cells[0].Text));
                            command.Parameters.Add(new OracleParameter("DATE_FROM", dt_from));
                            command.Parameters.Add(new OracleParameter("DATE_TO", dt_to));
                            command.Parameters.Add(new OracleParameter("MAJOR", GridView1.Rows[i].Cells[2].Text));


                            id = command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                        finally
                        {
                            command.Dispose();
                            conn.Close();
                        }
                    }
                }


            }

            ClearData();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('เพิ่มข้อมูลเรียบร้อย')", true);
            Session.Remove("StudyHis");


        }


        protected void txtBirthDayNumber_TextChanged(object sender, EventArgs e)
        {

            txtBirthDayChar.Text = Util.ToThaiWord(txtBirthDayNumber.Text);

        }

        protected void txtAge60Number_TextChanged(object sender, EventArgs e)
        {
            txtAge60Char.Text = Util.ToThaiWord(txtAge60Number.Text);
        }

        protected void ButtonPlus_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtGrad_Univ.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก สถานศึกษา')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtDate_From.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ตั้งแต่ - ถึง (เดือน ปี) ให้ครบ')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtDate_To.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ตั้งแต่ - ถึง (เดือน ปี) ให้ครบ')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtMajor.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก วุฒิ(สาาขาาวิชาเอก)')", true);
                return;
            }

            DataRow dr = ((DataTable)(Session["StudyHis"])).NewRow();
            dr[0] = txtGrad_Univ.Text;
            dr[1] = txtDate_From.Text + " - " + txtDate_To.Text;
            dr[2] = txtMajor.Text;
            ((DataTable)(Session["StudyHis"])).Rows.Add(dr);
            GridView1.DataSource = ((DataTable)(Session["StudyHis"]));
            GridView1.DataBind();
            ClearDataGridViewNumber10();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('เพิ่มข้อมูลประวัติการศึกษาเรียบร้อย')", true);

        }
    }
}