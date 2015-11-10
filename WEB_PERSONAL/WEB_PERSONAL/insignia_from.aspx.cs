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
    public partial class insignia_form : System.Web.UI.Page
    {

        public static string strConn = @"Data Source = ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["insignia_citizen_id"] == null)
            {
                Response.Redirect("insignia_citizen.aspx");
                return;

            }
            string citizen_id = Session["insignia_citizen_id"].ToString();
            int staff_type_id = 1;

            if (!IsPostBack)
            {
                BindDropDown1();
                BindDropDown2();
                BindDropDown3();
                BindDropDown4();
                BindDropDown5();
                BindDropDown6();
            }

            // try
            {
                string connectionString = "Data Source=ORCL_RMUTTO;User ID=rmutto;Password=Zxcvbnm";
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    {
                        string Oracle = "SELECT STAFFTYPE_ID FROM TB_PERSONAL WHERE CITIZEN_ID = " + citizen_id;
                        using (OracleCommand command = new OracleCommand(Oracle, con))
                        {
                            using (OracleDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    staff_type_id = reader.GetInt32(0);
                                }
                            }
                        }
                    }

                    {
                        if (staff_type_id == 1)
                        {
                            RadioButton1.Checked = true;
                            //select 1
                            {
                                string Oracle = "select tb_personal.stf_name, tb_personal.stf_lname, tb_gender.gender_name, tb_personal.birthday, tb_personal.citizen_id, tb_rank.rank_name_th, tb_titlename.title_name_th, tb_personal.datetime_inwork, tb_position_work.position_work_name, AA_GOVERNMENTOFFICER_TYPE.NAMETYPE_GO, tb_position.position_name, tb_salary.salary, tb_faculty.faculty_name " +
                                " from tb_personal, tb_gender, tb_rank, tb_department, tb_titlename, tb_position_work, tb_position,AA_GOVERNMENTOFFICER_TYPE, tb_salary, tb_faculty " +
                                " where tb_personal.citizen_id = '" + citizen_id + "' AND tb_personal.gender_id = tb_gender.gender_id AND tb_personal.rank_id = tb_rank.seq AND tb_personal.department_id = tb_department.department_id AND tb_personal.title_id = tb_titlename.title_id AND tb_personal.position_work_id = tb_position_work.position_work_id AND tb_personal.got_id = AA_GOVERNMENTOFFICER_TYPE.id_got AND tb_personal.position_id = tb_position.position_id AND tb_personal.citizen_id = tb_salary.citizen_id AND tb_personal.faculty_id = tb_faculty.faculty_id ";

                                using (OracleCommand command = new OracleCommand(Oracle, con))
                                {
                                    using (OracleDataReader reader = command.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            TextBox4.Text = reader.GetString(0); /*tb_personal.stf_name*/
                                            TextBox5.Text = reader.GetString(1); /* tb_personal.stf_lname*/
                                            TextBox6.Text = reader.GetString(2); /*tb_gender.gender_name*/
                                            TextBox7.Text = reader.GetDateTime(3).ToString("dd/MM/yyyy"); /*tb_personal.birthday*/
                                            TextBox8.Text = reader.GetString(4); /*tb_personal.citizen_id*/
                                            TextBox2.Text = reader.GetString(5); /*tb_rank.rank_name_th*/
                                            TextBox3.Text = reader.GetString(6); /*tb_titlename.title_name_th*/
                                            TextBox9.Text = reader.GetDateTime(7).ToString("dd/MM/yyyy"); /*tb_personal.datetime_inwork*/
                                            TextBox11.Text = reader.GetString(8); /*tb_position_work.position_work_name*/
                                            TextBox12.Text = reader.GetString(9); /*AA_GOVERNMENTOFFICER_TYPE.NAMETYPE_GO*/
                                            TextBox13.Text = reader.GetString(10); /*tb_position.position_name*/
                                            TextBox14.Text = reader.GetInt32(11).ToString(); /*tb_salary.salary*/
                                            TextBox1.Text = reader.GetString(12); /*tb_faculty.faculty_name*/

                                        }
                                    }
                                }
                            }

                            //select 2
                            {
                                string Oracle = "select TB_POSITION_WORK.POSITION_WORK_NAME " +
                                " from TB_POSITION_WORK, tb_personal " +
                                " where TB_PERSONAL.START_POSITION_WORK_ID = TB_POSITION_WORK.POSITION_WORK_ID ";

                                using (OracleCommand command = new OracleCommand(Oracle, con))
                                {
                                    using (OracleDataReader reader = command.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            TextBox10.Text = reader.GetString(0);

                                        }
                                    }
                                }
                            }

                            //select 3
                            {
                                string Oracle = "select count(*) " +
                                " from AA_REQUEST_INSIGNIA " +
                                " where citizen_id = '" + citizen_id + "'";

                                using (OracleCommand command = new OracleCommand(Oracle, con))
                                {
                                    using (OracleDataReader reader = command.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            if (reader.GetInt32(0) == 0)
                                            {
                                                TextBox21.Text = TextBox9.Text;
                                            }

                                        }
                                    }
                                }
                            }



                        }
                        else if (staff_type_id == 2)
                        {
                            RadioButton2.Checked = true;
                        }
                        else if (staff_type_id == 5)
                        {
                            RadioButton3.Checked = true;
                        }
                        else if (staff_type_id == 3)
                        {
                            RadioButton4.Checked = true;
                        }
                    }

                }
            }
            // catch (Exception e2)
            // {
            //    string script = "alert(\"เกิดข้อผิดพลาด! " + e2.Message + "\");";
            //    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            //S }
          
        }

        private void BindDropDown1()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from AA_COMMAND";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownList1.DataSource = dt;
                        DropDownList1.DataValueField = "ID_COMM";
                        DropDownList1.DataTextField = "NAME_COMM";
                        DropDownList1.DataBind();
                        sqlConn.Close();

                        DropDownList1.Items.Insert(0, new ListItem("-- กรุณาเลือก --", "0"));

                    }
                }
            }
            catch { }
        }

        private void BindDropDown2()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from AA_BUDDHISTERA";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownList2.DataSource = dt;
                        DropDownList2.DataValueField = "ID_BBE";
                        DropDownList2.DataTextField = "ID_BBE";
                        DropDownList2.DataBind();
                        sqlConn.Close();

                        DropDownList2.Items.Insert(0, new ListItem("-- กรุณาเลือก --", "0"));

                    }
                }
            }
            catch { }
        }

        private void BindDropDown3()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_GRADEINSIGNIA";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownList3.DataSource = dt;
                        DropDownList3.DataValueField = "ID_GRADEINSIGNIA";
                        DropDownList3.DataTextField = "NAME_GRADEINSIGNIA_THA";
                        DropDownList3.DataBind();
                        sqlConn.Close();

                        DropDownList3.Items.Insert(0, new ListItem("-- กรุณาเลือก --", "0"));

                    }
                }
            }
            catch { }
        }

        private void BindDropDown4()
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
                        DropDownList4.DataSource = dt;
                        DropDownList4.DataValueField = "TITLE_ID";
                        DropDownList4.DataTextField = "TITLE_NAME_TH";
                        DropDownList4.DataBind();
                        sqlConn.Close();

                        DropDownList4.Items.Insert(0, new ListItem("-- กรุณาเลือก --", "0"));

                    }
                }
            }
            catch { }
        }

        private void BindDropDown5()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_POSITION";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownList5.DataSource = dt;
                        DropDownList5.DataValueField = "POSITION_ID";
                        DropDownList5.DataTextField = "POSITION_NAME";
                        DropDownList5.DataBind();

                        DropDownList6.DataSource = dt;
                        DropDownList6.DataValueField = "POSITION_ID";
                        DropDownList6.DataTextField = "POSITION_NAME";
                        DropDownList6.DataBind();

                        sqlConn.Close();

                        DropDownList5.Items.Insert(0, new ListItem("-- กรุณาเลือก --", "0"));
                        DropDownList6.Items.Insert(0, new ListItem("-- กรุณาเลือก --", "0"));

                    }
                }
            }
            catch { }
        }

        private void BindDropDown6()
        {
            try
            {
                using (OracleConnection sqlConn = new OracleConnection(strConn))
                {
                    using (OracleCommand sqlCmd = new OracleCommand())
                    {
                        sqlCmd.CommandText = "select * from TB_POSITION_WORK";
                        sqlCmd.Connection = sqlConn;
                        sqlConn.Open();
                        OracleDataAdapter da = new OracleDataAdapter(sqlCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownList7.DataSource = dt;
                        DropDownList7.DataValueField = "POSITION_WORK_ID";
                        DropDownList7.DataTextField = "POSITION_WORK_NAME";
                        DropDownList7.DataBind();

                        DropDownList8.DataSource = dt;
                        DropDownList8.DataValueField = "POSITION_WORK_ID";
                        DropDownList8.DataTextField = "POSITION_WORK_NAME";
                        DropDownList8.DataBind();

                        sqlConn.Close();

                        DropDownList7.Items.Insert(0, new ListItem("-- กรุณาเลือก --", "0"));
                        DropDownList8.Items.Insert(0, new ListItem("-- กรุณาเลือก --", "0"));

                    }
                }
            }
            catch { }
        }



        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("insignia_from");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("insignia_from");
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("insignia_from_edit.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("insignia_user.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // try
            {
                string connectionString = "Data Source=ORCL_RMUTTO;User ID=rmutto;Password=Zxcvbnm";
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    //Select 1
                    {
                        string Oracle = "insert into AA_REQUEST_INSIGNIA values (SEQ_REQUEST_INSIGNIA_id.nextval,:2,:3,:4,:5,:6,:7,:8,:9,:10,:11,:12,:13,:14,:15,:16,:17,:18,:19)";

                        using (OracleCommand command = new OracleCommand(Oracle, con))
                        {
                            command.Parameters.AddWithValue("2", Session["insignia_citizen_id"].ToString());
                            command.Parameters.AddWithValue("3", DropDownList1.SelectedValue); /*ID_COMM*/
                            command.Parameters.AddWithValue("4", DropDownList2.SelectedValue); /*YEAR*/
                            command.Parameters.AddWithValue("5", DropDownList3.SelectedValue); /*ID_GRADEINSIGNIA*/
                            command.Parameters.AddWithValue("6", RadioButton5.Checked ? "1":"0"); /*REPEAT_REQUEST*/
                            command.Parameters.AddWithValue("7", TextBox17.Text); /*SALARY_BACK5Y*/
                            command.Parameters.AddWithValue("8", DropDownList4.SelectedValue); /*OLD_TITLE_ID*/
                            command.Parameters.AddWithValue("9", TextBox19.Text); /*OLD_NAME*/
                            command.Parameters.AddWithValue("10", TextBox20.Text); /*OLD_LASTNAME*/
                            command.Parameters.AddWithValue("11", DropDownList5.SelectedValue); /*H1_POSITION_ID_1*/
                            command.Parameters.AddWithValue("12", Util.toOracleDateTime(TextBox25.Text)); /*H1_DATE_1*/
                            command.Parameters.AddWithValue("13", DropDownList6.SelectedValue); /*H1_POSITION_ID_2*/
                            command.Parameters.AddWithValue("14", Util.toOracleDateTime(TextBox26.Text)); /*H1_DATE_2*/
                            command.Parameters.AddWithValue("15", DropDownList7.SelectedValue); /*H2_OLD_POSITION_WORK_ID*/
                            command.Parameters.AddWithValue("16", DropDownList8.SelectedValue); /*H2_NEW_POSITION_WORK_ID*/

                            int g2id = 1;
                            if (CheckBox2.Checked)
                            {
                                g2id = 2;
                            }

                            int g2id2 = 3;
                            if (CheckBox4.Checked)
                            {
                                g2id2 = 4;
                            }
                            else
                            {
                                g2id2 = 5;
                            }

                            command.Parameters.AddWithValue("17", g2id);
                            command.Parameters.AddWithValue("18", g2id2);
                            command.Parameters.AddWithValue("19", TextBox16.Text); /*YEAR_BACK5Y*/
                            command.ExecuteNonQuery();
                            Util.Alert(this, "บันทีกเรียบร้อย");
                        }
                    }
                   
                    
                }
            }
        }

        
    }
}