using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;

namespace WEB_PERSONAL
{
    public partial class insignia2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["insignia_citizen_id"] == null)
            {
                Response.Redirect("insignia_citizen.aspx");
                return;

            }
            string citizen_id = Session["insignia_citizen_id"].ToString();
            int staff_type_id = 1;

            // try
            {
                string connectionString = "Data Source=ORCL_RMUTTO;User ID=rmutto;Password=Zxcvbnm";
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    //Select 1
                    {
                        string Oracle = "SELECT STAFFTYPE_ID,RANK_ID,title_id,GENDER_ID,POSITION_WORK_ID,GOT_ID,POSITION_ID "
                            + "FROM TB_PERSONAL "
                            + "WHERE CITIZEN_ID = '" + citizen_id+"'";
                        using (OracleCommand command = new OracleCommand(Oracle, con))
                        {
                            using (OracleDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    staff_type_id = reader.GetInt32(0);
                                    DropDownList4.SelectedValue = "" + reader.GetInt32(1); /*RANK_ID*/
                                    DropDownList5.SelectedValue = "" + reader.GetInt32(2); /*title_id*/
                                    DropDownList6.SelectedValue = "" + reader.GetInt32(3); /*GENDER_ID*/
                                    DropDownList8.SelectedValue = "" + reader.GetString(4); /*POSITION_WORK_ID*/
                                    DropDownList9.SelectedValue = "" + reader.GetInt32(5);  /*GOT_ID*/
                                    DropDownList10.SelectedValue = "" + reader.GetString(6); /*POSITION_ID*/
                                   
                                }
                            }
                        }
                    }
                    //Select 2
                    {
                        string Oracle = "SELECT START_POSITION_WORK_ID "
                            + "FROM TB_PERSONAL "
                            + "WHERE CITIZEN_ID = '" + citizen_id + "'";
                        using (OracleCommand command = new OracleCommand(Oracle, con))
                        {
                            using (OracleDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    DropDownList7.SelectedValue = "" + reader.GetString(0);
                                }
                            }
                        }
                    }

                    {
                        if (staff_type_id == 1)
                        {
                            RadioButton1.Checked = true;

                            string Oracle = "select tb_personal.stf_name, tb_personal.stf_lname, tb_gender.gender_name, tb_personal.birthday, tb_personal.citizen_id, tb_rank.rank_name_th, tb_titlename.title_name_th, tb_personal.datetime_inwork, tb_position_work.position_work_name, AA_GOVERNMENTOFFICER_TYPE.NAMETYPE_GO, tb_position.position_name, tb_salary.salary " +
                                "from tb_personal, tb_gender , tb_rank, tb_department, tb_faculty, tb_titlename, tb_position_work, tb_position,AA_GOVERNMENTOFFICER_TYPE, tb_salary " +
                                "where tb_personal.citizen_id = '" + citizen_id + "' AND tb_personal.gender_id = tb_gender.gender_id AND tb_personal.rank_id = tb_rank.seq AND tb_personal.department_id = tb_department.department_id AND tb_personal.faculty_id = tb_faculty.faculty_id AND tb_personal.title_id = tb_titlename.title_id AND tb_personal.position_work_id = tb_position_work.position_work_id AND tb_personal.got_id = AA_GOVERNMENTOFFICER_TYPE.id_got AND tb_personal.position_id = tb_position.position_id AND tb_salary.citizen_id = tb_personal.citizen_id  ";

                            using (OracleCommand command = new OracleCommand(Oracle, con))
                            {
                                using (OracleDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        TextBox4.Text = reader.GetString(0); /*tb_personal.stf_name*/
                                        TextBox5.Text = reader.GetString(1); /* tb_personal.stf_lname*/
                                        TextBox7.Text = reader.GetDateTime(3).ToString("dd/MM/yyyy"); /*tb_personal.birthday*/
                                        TextBox8.Text = reader.GetString(4); /*tb_personal.citizen_id*/
                                        TextBox9.Text = reader.GetDateTime(7).ToString("dd/MM/yyyy"); /*tb_personal.datetime_inwork*/



                                        /*TextBox14.Text = reader.GetInt32(11).ToString(); /*tb_salary.salary*/
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
            if (!IsPostBack)
            {
                DropDownList11.Items.Add("--ยังไม่สมบูรณ์--");
            }
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
            Response.Redirect("insignia_from_edit");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("insignia_user.aspx");

        }


    }
}