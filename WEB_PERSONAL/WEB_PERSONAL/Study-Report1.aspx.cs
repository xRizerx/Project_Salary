using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;
using System.Data;

namespace WEB_PERSONAL {
    public partial class Study_Report1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Session["login_id"] == null) {
                Session["redirect_to"] = Request.Url.ToString();
                Response.Redirect("Access.aspx");
                return;
            }
            BindGridView1();
        }

        private void BindGridView1() {



            DataTable dt = new DataTable();


            dt.Columns.Add("ลำดับที่");
            dt.Columns.Add("ชื่อ - นามสกุล");
            dt.Columns.Add("ประเภท");
            dt.Columns.Add("ตำแหน่ง");
            dt.Columns.Add("ปีที่ศึกษา");
            dt.Columns.Add("ระดับ");
            dt.Columns.Add("สาขาที่ศึกษา");
            dt.Columns.Add("สถานที่ศึกษา");
            dt.Columns.Add("หลักสูตร");
            dt.Columns.Add("ระยะเวลาที่ศึกษา (ปี)");
            dt.Columns.Add("ตั้งแต่วันที่");
            dt.Columns.Add("ระยะเวลาที่ศึกษาตามหลักสูตร");
            dt.Columns.Add("หมายเหตุ");

            int i = 1;
            using (OracleConnection con = Util.OC()) {
                using (OracleCommand command = new OracleCommand("SELECT TB_PERSON.CITIZEN_ID, TB_PERSON.PERSON_NAME || ' ' || TB_PERSON.PERSON_LASTNAME, TB_STAFFTYPE.STAFFTYPE_NAME, STUDY_YEAR, TB_STUDY_DEGREE.STUDY_DEGREE_SHORT_NAME, STUDY_BRANCH_NAME, STUDY_LOCATION, TB_STUDY_COURSE.STUDY_COURSE_NAME, STUDY_TIME || ' (' || STUDY_TIME_YEAR || ')', TO_CHAR(STUDY_FROM_DATE, 'DD MON RRRR', 'NLS_DATE_LANGUAGE = THAI') || ' - ' || TO_CHAR(STUDY_TO_DATE, 'DD MON RRRR', 'NLS_DATE_LANGUAGE = THAI'), STUDY_TIME_COURSE, \"COMMENT\" FROM TB_PERSON, TB_STUDY, TB_STAFFTYPE, TB_STUDY_DEGREE, TB_STUDY_COURSE WHERE TB_STUDY.CITIZEN_ID = TB_PERSON.CITIZEN_ID AND TB_PERSON.STAFFTYPE_ID = TB_STAFFTYPE.STAFFTYPE_ID AND TB_STUDY.STUDY_DEGREE_ID = TB_STUDY_DEGREE.STUDY_DEGREE_ID AND TB_STUDY.STUDY_COURSE_ID = TB_STUDY_COURSE.STUDY_COURSE_ID", con)) {
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            while (reader.Read()) {

                                DataRow dr = dt.NewRow();
                                dr[0] = i++;
                                dr[1] = reader.GetString(1);
                                dr[2] = reader.GetString(2);
                                dr[4] = reader.GetInt32(3).ToString();
                                dr[5] = reader.GetString(4);
                                dr[6] = reader.GetString(5);
                                dr[7] = reader.GetString(6);
                                dr[8] = reader.GetString(7);
                                dr[9] = reader.GetString(8);
                                dr[10] = reader.GetString(9);
                                dr[11] = reader.GetInt32(10).ToString();
                                dr[12] = reader.IsDBNull(11) ? "-":reader.GetString(11);

                                if (!reader.IsDBNull(0)) {
             
                                    //tam-nang
                                    using (OracleCommand command2 = new OracleCommand("SELECT POSITION_NAME FROM TB_POSITION_AND_SALARY WHERE CITIZEN_ID = :1 ORDER BY ID DESC", con)) {
                                        command2.Parameters.AddWithValue("1", reader.GetString(0));
                                        using (OracleDataReader reader2 = command2.ExecuteReader()) {
                                            if (reader2.HasRows) {
                                                reader2.Read();
                                                dr[3] = reader2.GetString(0);
                                            } else {
                                                dr[3] = "-";
                                            }
                                        }
                                    }
                                    
                                    
                                }





                                dt.Rows.Add(dr);
                            }
                        } else {
                            Util.Alert(this, "no data");
                            return;
                        }
                    }
                }
            }

            GridView1.DataSource = dt;
            GridView1.DataBind();

            if(GridView1.Rows.Count > 0) {
                Label4.Text = "";
            } else {
                Label4.Text = "ไม่มีข้อมูล";
            }
        }
    }
}