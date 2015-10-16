using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WEB_PERSONAL
{
    public partial class insignia1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["insignia_citizen_id"] == null)
            {
                Response.Redirect("insignia_citizen.aspx");
                return;

            }
            string citizen_id = Session["insignia_citizen_id"].ToString();
            int staff_type_id = 1;

            try
            {
                string connectionString = "Data Source=203.158.140.66;Initial Catalog=personal;Integrated Security=FALSE;User ID=rmutto;Password=Zxcvbnm!";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    {
                        string sql = "SELECT STAFFTYPE_ID FROM TB_PERSONAL WHERE CITIZEN_ID = " + citizen_id;
                        using (SqlCommand command = new SqlCommand(sql, con))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
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

                            string sql = "select tb_personal.stf_name, tb_personal.stf_lname, tb_gender.gender_name, tb_personal.birthday, tb_personal.citizen_id, tb_rank.rank_name_th, tb_titlename.title_name_th, tb_personal.datetime_inwork, tb_position_work.position_work_name, AA_GOVERNMENTOFFICER_TYPE.NAMETYPE_GO, tb_position.position_name from tb_personal, tb_gender , tb_rank, tb_department, tb_faculty, tb_titlename, tb_position_work, tb_position,AA_GOVERNMENTOFFICER_TYPE where tb_personal.citizen_id = " +  citizen_id + " AND tb_personal.gender_id = tb_gender.gender_id AND tb_personal.rank_id = tb_rank.seq AND tb_personal.department_id = tb_department.department_id AND tb_department.faculty_id = tb_faculty.faculty_id AND tb_personal.title_id = tb_titlename.title_id AND tb_personal.position_work = tb_position_work.position_work_id AND tb_personal.got_id = AA_GOVERNMENTOFFICER_TYPE.id_got AND tb_personal.position_id = tb_position.position_id; ";
		  /*tb_position_work.position_work_name*/;
                            using (SqlCommand command = new SqlCommand(sql, con))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        TextBox4.Text = reader.GetString(0);
                                        TextBox5.Text = reader.GetString(1);
                                        TextBox6.Text = reader.GetString(2);
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
            catch (Exception e2)
            {
                string script = "alert(\"เกิดข้อผิดพลาด! " + e2.Message + "\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
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
    }
}