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
    public partial class insignia_from_view : System.Web.UI.Page
    {

        public static string strConn = @"Data Source = ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm";
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
                    {
                        string Oracle = "SELECT STAFFTYPE_ID FROM TB_PERSON WHERE CITIZEN_ID = '" + citizen_id + "'";
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
                        //select 1
                        {
                            string Oracle = " Select AA_COMMAND.NAME_COMM, AA_REQUEST_INSIGNIA.YEAR, TB_GRADEINSIGNIA.NAME_GRADEINSIGNIA_THA, TB_RANK.RANK_NAME_TH, TB_TITLENAME.TITLE_NAME_TH,"
                                + " TB_PERSON.PERSON_NAME, TB_PERSON.PERSON_LASTNAME, TO_CHAR(TB_PERSON.BIRTHDATE,'dd MON yyyy','NLS_DATE_LANGUAGE = THAI'), TB_PERSON.CITIZEN_ID, TO_CHAR(TB_PERSON.INWORK_DATE,'dd MON yyyy','NLS_DATE_LANGUAGE = THAI')"
                                + " from TB_PERSON, AA_REQUEST_INSIGNIA, AA_COMMAND, TB_GRADEINSIGNIA, TB_RANK, TB_TITLENAME"
                                + " where tb_person.citizen_id = '" + citizen_id + "' AND AA_REQUEST_INSIGNIA.ID_COMM = AA_COMMAND.ID_COMM AND TB_GRADEINSIGNIA.ID_GRADEINSIGNIA = AA_REQUEST_INSIGNIA.ID_GRADEINSIGNIA AND TB_RANK.SEQ = AA_REQUEST_INSIGNIA.RANK_SEQ AND TB_PERSON.TITLE_ID = TB_PERSON.TITLE_ID";

                            using (OracleCommand command = new OracleCommand(Oracle, con))
                            {
                                using (OracleDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                       
                                        TextBox33.Text = reader.GetString(0); //AA_COMMAND.NAME_COMM
                                        TextBox34.Text = reader.GetInt32(1).ToString(); //AA_REQUEST_INSIGNIA.YEAR
                                        TextBox35.Text = reader.GetString(2); //TB_GRADEINSIGNIA.NAME_GRADEINSIGNIA_THA
                                        TextBox36.Text = reader.GetString(3); //TB_RANK.RANK_NAME_TH
                                        TextBox3.Text = reader.GetString(4); //TB_TITLENAME.TITLE_NAME_TH
                                        TextBox4.Text = reader.GetString(5); //TB_PERSON.PERSON_NAME
                                        TextBox5.Text = reader.GetString(6); //TB_PERSON.PERSON_LASTNAME
                                        TextBox7.Text = reader.GetString(7); //TO_CHAR(TB_PERSON.BIRTHDATE,'dd MON yyyy','NLS_DATE_LANGUAGE = THAI')
                                        TextBox8.Text = reader.GetString(8); //TB_PERSON.CITIZEN_ID
                                        TextBox9.Text = reader.GetString(9); //TO_CHAR(TB_PERSON.INWORK_DATE,'dd MON yyyy','NLS_DATE_LANGUAGE = THAI')



                                    }
                                }
                            }
                        }

                        //select 1.9 ชื่อตำแหน่งปัจจุบัน (เพราะตารางชนกันเลยต้องการอีก Select)
                        {
                            string Oracle = "select TB_POSITION_AND_SALARY.POSITION_NAME" +
                            " from TB_POSITION_AND_SALARY " +
                            " where TB_POSITION_AND_SALARY.citizen_id = '" + citizen_id + "'" +
                            " order by TB_POSITION_AND_SALARY.DDATE";

                            using (OracleCommand command = new OracleCommand(Oracle, con))
                            {
                                using (OracleDataReader reader = command.ExecuteReader())
                                {
                                    reader.Read();
                                    {
                                        TextBox10.Text = reader.GetString(0);
                                    }
                                }
                            }
                        }

                        //select 2 ชื่อตำแหน่งปัจจุบัน (เพราะตารางชนกันเลยต้องการอีก Select)
                        {
                            string Oracle = "select TB_POSITION_AND_SALARY.POSITION_NAME,TB_POSITION_AND_SALARY.SALARY,TB_POSITION_AND_SALARY.POSITION_SALARY " +
                            " from TB_POSITION_AND_SALARY " +
                            " where TB_POSITION_AND_SALARY.citizen_id = '" + citizen_id + "'" +
                            " order by TB_POSITION_AND_SALARY.DDATE desc";

                            using (OracleCommand command = new OracleCommand(Oracle, con))
                            {
                                using (OracleDataReader reader = command.ExecuteReader())
                                {

                                    reader.Read();
                                    {
                                        TextBox11.Text = reader.GetString(0);
                                        TextBox14.Text = reader.GetInt32(1).ToString();
                                        TextBox15.Text = reader.GetInt32(2).ToString();
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


                    {
                        if (staff_type_id == 1)
                        {
                            RadioButton1.Checked = true;
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("insignia_from_edit.aspx");
        }
    }
}


