using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEB_PERSONAL.Class;
using System.Data.OracleClient;

namespace WEB_PERSONAL {
    public partial class Person_Detail : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            if (Session["login_person"] == null)
                return;
            

            SqlDataSource sds = new SqlDataSource("System.Data.OracleClient", "DATA SOURCE=ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm;", "SELECT TB_PERSON.ID, TB_PERSON.CITIZEN_ID, PERSON_NAME, PERSON_LASTNAME, TB_STAFFTYPE.STAFFTYPE_NAME, TB_POSITION.NAME, TB_MINISTRY.MINISTRY_NAME, TB_PERSON.DEPARTMENT_NAME FROM TB_PERSON, TB_POSITION, TB_POSITION_AND_SALARY, TB_STAFFTYPE, TB_MINISTRY WHERE TB_PERSON.CITIZEN_ID = TB_POSITION_AND_SALARY.CITIZEN_ID AND TB_POSITION_AND_SALARY.POSITION_ID = TB_POSITION.ID AND TB_PERSON.STAFFTYPE_ID = TB_STAFFTYPE.STAFFTYPE_ID AND TB_PERSON.MINISTRY_ID = TB_MINISTRY.MINISTRY_ID AND ROWNUM = 1 ORDER BY TB_POSITION_AND_SALARY.ID DESC");
            GridView1.DataSource = sds;
            GridView1.DataBind();
        }

        protected void LinkButton11_Click(object sender, EventArgs e) {
            SqlDataSource sds = new SqlDataSource("System.Data.OracleClient", "DATA SOURCE=ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm;", "SELECT TB_PERSON.ID, TB_PERSON.CITIZEN_ID, PERSON_NAME, PERSON_LASTNAME, TB_STAFFTYPE.STAFFTYPE_NAME, TB_POSITION.NAME, TB_MINISTRY.MINISTRY_NAME, TB_PERSON.DEPARTMENT_NAME FROM TB_PERSON, TB_POSITION, TB_POSITION_AND_SALARY, TB_STAFFTYPE, TB_MINISTRY WHERE TB_PERSON.CITIZEN_ID = TB_POSITION_AND_SALARY.CITIZEN_ID AND TB_POSITION_AND_SALARY.POSITION_ID = TB_POSITION.ID AND TB_PERSON.STAFFTYPE_ID = TB_STAFFTYPE.STAFFTYPE_ID AND TB_PERSON.MINISTRY_ID = TB_MINISTRY.MINISTRY_ID AND ROWNUM = 1 AND TB_PERSON.CITIZEN_ID = '" + TextBox1.Text + "' ORDER BY TB_POSITION_AND_SALARY.ID DESC");
            GridView1.DataSource = sds;
            GridView1.DataBind();
        }

        protected void LinkButton12_Click(object sender, EventArgs e) {
            SqlDataSource sds = new SqlDataSource("System.Data.OracleClient", "DATA SOURCE=ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm;", "SELECT TB_PERSON.ID, TB_PERSON.CITIZEN_ID, PERSON_NAME, PERSON_LASTNAME, TB_STAFFTYPE.STAFFTYPE_NAME, TB_POSITION.NAME, TB_MINISTRY.MINISTRY_NAME, TB_PERSON.DEPARTMENT_NAME FROM TB_PERSON, TB_POSITION, TB_POSITION_AND_SALARY, TB_STAFFTYPE, TB_MINISTRY WHERE TB_PERSON.CITIZEN_ID = TB_POSITION_AND_SALARY.CITIZEN_ID AND TB_POSITION_AND_SALARY.POSITION_ID = TB_POSITION.ID AND TB_PERSON.STAFFTYPE_ID = TB_STAFFTYPE.STAFFTYPE_ID AND TB_PERSON.MINISTRY_ID = TB_MINISTRY.MINISTRY_ID AND ROWNUM = 1 ORDER BY TB_POSITION_AND_SALARY.ID DESC");
            GridView1.DataSource = sds;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) {
            GridViewRow row = GridView1.SelectedRow;

            using (OracleConnection con = Util.OC()) {
                using (OracleCommand command = new OracleCommand("SELECT URL FROM TB_PERSON_IMAGE WHERE CITIZEN_ID = :1 AND PRESENT = :2", con)) {
                    command.Parameters.AddWithValue("1", Session["login_id"].ToString());
                    command.Parameters.AddWithValue("2", "1");
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            reader.Read();
                            profile_pic.Attributes["src"] = ResolveUrl("~/AppData/Image/UserImage/" + row.Cells[1].Text + "/" + reader.GetString(0));
                        } else {

                        }
                    }

                }
            }

            Person person = new Person(row.Cells[1].Text);
            Label14.Text = person.CitizenID;
            Label32.Text = person.TitleName;
            Label15.Text = person.Name;
            Label17.Text = person.Lastname;
            Label46.Text = person.GenderName;
            Label22.Text = person.SystemStatusName;
            Label30.Text = person.StaffTypeName;
            Label24.Text = person.PositionName;
            Label42.Text = person.MinistryName;
            Label44.Text = person.DepartmentName;
            Label26.Text = person.Birthdate;
            Label28.Text = person.InworkDate;
            Label34.Text = person.RetireDate;
            Label38.Text = person.FatherNameAndLastname;
            Label39.Text = person.MotherNameAndLastname;
            Label40.Text = person.CoupleNameAndLastname;
            Label48.Text = person.NationNameTH;
            Label52.Text = person.HomeAdd;
            Label53.Text = person.Moo;
            Label54.Text = person.Street;
            Label59.Text = person.DistrictName;
            Label60.Text = person.AmphurName;
            Label61.Text = person.ProvinceName;
            Label62.Text = person.Zipcode.ToString();
            Label64.Text = person.Telephone;
            Label67.Text = person.TimeContactName;
            Label68.Text = person.BudgetName;
            Label70.Text = person.SubStaffTypeName;
            Label73.Text = person.SpecialName;
            Label74.Text = person.TeachISCED_Name;
            Label76.Text = person.GraduationLevelName;
            Label78.Text = person.GraduationCurr;
            Label80.Text = person.GraduationISCED_Name;
            Label82.Text = person.GraduationProgramName;
            Label84.Text = person.GraduationUniversity;
            Label86.Text = person.GraduationCountryName;
            Label89.Text = person.BranchName;
            Label90.Text = person.RankName;
            Label93.Text = person.FacultyName;
            Label94.Text = person.StartPositionWorkName;

            //Study History
            study_history_div.InnerHtml += "<table>";
            study_history_div.InnerHtml += "<tr>";
            study_history_div.InnerHtml += "<td class=\"table_column_header\"><span>สถานศึกษา</span></td>";
            study_history_div.InnerHtml += "<td class=\"table_column_header\"><span>ตั้งแต่ - ถึง (เดือน ปี)</span></td>";
            study_history_div.InnerHtml += "<td class=\"table_column_header\"><span>วุฒิ (สาขาวิชาเอก)</span></td>";
            study_history_div.InnerHtml += "</tr>";

            foreach (StudyHistory i in person.StudyHistoryList) {
                study_history_div.InnerHtml += "<tr>";
                study_history_div.InnerHtml += "<td>" + i.GraduationUniversity + "</td>";
                study_history_div.InnerHtml += "<td>" + i.FromAndToDate + "</td>";
                study_history_div.InnerHtml += "<td>" + i.Major + "</td>";
                study_history_div.InnerHtml += "</tr>";
            }
            study_history_div.InnerHtml += "</table>";

            //-----

            //Job license
            job_license_div.InnerHtml += "<table>";
            job_license_div.InnerHtml += "<tr>";
            job_license_div.InnerHtml += "<td class=\"table_column_header\"><span>ชื่อใบอนุญาติ</span></td>";
            job_license_div.InnerHtml += "<td class=\"table_column_header\"><span>หน่วยงาน</span></td>";
            job_license_div.InnerHtml += "<td class=\"table_column_header\"><span>เลขที่ใบอนุญาต</span></td>";
            job_license_div.InnerHtml += "<td class=\"table_column_header\"><span>วันที่มีผลบังคับใช้ (วัน เดือน ปี)</span></td>";
            job_license_div.InnerHtml += "</tr>";

            foreach (JobLicense i in person.JobLicenseList) {
                job_license_div.InnerHtml += "<tr>";
                job_license_div.InnerHtml += "<td>" + i.LicenseName + "</td>";
                job_license_div.InnerHtml += "<td>" + i.Branch + "</td>";
                job_license_div.InnerHtml += "<td>" + i.LicenseNo + "</td>";
                job_license_div.InnerHtml += "<td>" + i.Date + "</td>";
                job_license_div.InnerHtml += "</tr>";
            }
            job_license_div.InnerHtml += "</table>";

            //-----

            //Training History
            training_history_div.InnerHtml += "<table>";
            training_history_div.InnerHtml += "<tr>";
            training_history_div.InnerHtml += "<td class=\"table_column_header\"><span>หลักสูตรฝึกอบรม</span></td>";
            training_history_div.InnerHtml += "<td class=\"table_column_header\"><span>ตั้งแต่ - ถึง (วัน เดือน ปี)</span></td>";
            training_history_div.InnerHtml += "<td class=\"table_column_header\"><span>หน่วยงานที่จัดฝึกอบรม</span></td>";
            training_history_div.InnerHtml += "</tr>";

            foreach (TrainingHistory i in person.TrainingHistoryList) {
                training_history_div.InnerHtml += "<tr>";
                training_history_div.InnerHtml += "<td>" + i.Course + "</td>";
                training_history_div.InnerHtml += "<td>" + i.FromAndToDate + "</td>";
                training_history_div.InnerHtml += "<td>" + i.BranchTraining + "</td>";
                training_history_div.InnerHtml += "</tr>";
            }
            training_history_div.InnerHtml += "</table>";

            //-----

            //Disciplinary and Amnesty
            disciplinary_and_amnesty.InnerHtml += "<table>";
            disciplinary_and_amnesty.InnerHtml += "<tr>";
            disciplinary_and_amnesty.InnerHtml += "<td class=\"table_column_header\"><span>พ.ศ.</span></td>";
            disciplinary_and_amnesty.InnerHtml += "<td class=\"table_column_header\"><span>รายการ</span></td>";
            disciplinary_and_amnesty.InnerHtml += "<td class=\"table_column_header\"><span>เอกสารอ้างอิง</span></td>";
            disciplinary_and_amnesty.InnerHtml += "</tr>";

            foreach (DisciplinaryAndAmnesty i in person.DisciplinaryAndAmnestyList) {
                disciplinary_and_amnesty.InnerHtml += "<tr>";
                disciplinary_and_amnesty.InnerHtml += "<td>" + i.Year + "</td>";
                disciplinary_and_amnesty.InnerHtml += "<td>" + i.Menu + "</td>";
                disciplinary_and_amnesty.InnerHtml += "<td>" + i.ReferenceDocument + "</td>";
                disciplinary_and_amnesty.InnerHtml += "</tr>";
            }
            disciplinary_and_amnesty.InnerHtml += "</table>";

            //-----

            //Position And Salary
            position_and_salary_div.InnerHtml += "<table>";
            position_and_salary_div.InnerHtml += "<tr>";
            position_and_salary_div.InnerHtml += "<td class=\"table_column_header\"><span>วันที่</span></td>";
            position_and_salary_div.InnerHtml += "<td class=\"table_column_header\"><span>ตำแหน่ง</span></td>";
            position_and_salary_div.InnerHtml += "<td class=\"table_column_header\"><span>เลขที่ตำแหน่ง</span></td>";
            position_and_salary_div.InnerHtml += "<td class=\"table_column_header\"><span>ระดับ</span></td>";
            position_and_salary_div.InnerHtml += "<td class=\"table_column_header\"><span>ตำแหน่งประเภท</span></td>";
            position_and_salary_div.InnerHtml += "<td class=\"table_column_header\"><span>เงินเดือน</span></td>";
            position_and_salary_div.InnerHtml += "<td class=\"table_column_header\"><span>เงินเดือนประจำตำแหน่ง</span></td>";
            position_and_salary_div.InnerHtml += "<td class=\"table_column_header\"><span>เอกสารอ้างอิง</span></td>";
            position_and_salary_div.InnerHtml += "</tr>";

            foreach (PositionAndSalary i in person.PositionAndSalaryList) {
                position_and_salary_div.InnerHtml += "<tr>";
                position_and_salary_div.InnerHtml += "<td>" + i.Date + "</td>";
                position_and_salary_div.InnerHtml += "<td>" + i.PositionDescription + "</td>";
                position_and_salary_div.InnerHtml += "<td class=\"t_center\">" + i.PersonID + "</td>";
                position_and_salary_div.InnerHtml += "<td class=\"t_center\">" + i.STID + "</td>";
                position_and_salary_div.InnerHtml += "<td class=\"t_center\">" + i.PositionID + "</td>";
                position_and_salary_div.InnerHtml += "<td class=\"t_center\">" + i.Salary + "</td>";
                position_and_salary_div.InnerHtml += "<td class=\"t_center\">" + i.PositionSalary + "</td>";
                position_and_salary_div.InnerHtml += "<td>" + i.ReferenceDocument + "</td>";
                position_and_salary_div.InnerHtml += "</tr>";
            }
            position_and_salary_div.InnerHtml += "</table>";

            //-----
        }
    }
}