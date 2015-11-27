using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;
using System.IO;
using WEB_PERSONAL.Class;

namespace WEB_PERSONAL {
    public partial class Profile : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if(Session["login_id"] == null) {
                return;
            }
            //sec2.InnerHtml = "";
            
            string path = Server.MapPath("~/AppData/Image/UserImage/" + Session["login_id"].ToString());
            if(Directory.Exists(path)) {
                string[] ss = Directory.GetFiles(path);

                //List<string> files = new List<string>();
                
                for (int j=0; j<ss.Length;++j) {
                    if (Path.GetExtension(ss[j]) == ".png" ||
                        Path.GetExtension(ss[j]) == ".jpg" ||
                        Path.GetExtension(ss[j]) == ".gif") {
                        //files.Add(ss[j]);
                        //sec2.InnerHtml += "<img src=\"" + ResolveUrl("~/AppData/Image/UserImage/" + Session["login_id"].ToString() + "/" + Path.GetFileName(files[j])) + "\"></img>";
                        string temp = ss[j];

                        Panel imagePanel = new Panel();
                        imagePanel.CssClass = "imagePanel";

                        Image img = new Image();
                        img.ImageUrl = ResolveUrl("~/AppData/Image/UserImage/" + Session["login_id"].ToString() + "/" + Path.GetFileName(ss[j]));
                        imagePanel.Controls.Add(img);

                        LinkButton lbSelect = new LinkButton();
                        lbSelect.CssClass = "linkButton";
                        lbSelect.Text = "เลือก";
                        lbSelect.Click += (e2, e3) => {
                            selectImageFile(Path.GetFileName(temp));
                        };
                        imagePanel.Controls.Add(lbSelect);

                        LinkButton lb = new LinkButton();
                        lb.CssClass = "linkButton";
                        lb.Text = "ลบ";
                        lb.Click += (e2, e3) => {

                            deleteImageFile(Path.GetFileName(temp));

                        };
                        imagePanel.Controls.Add(lb);

                        Label lbImageExtension = new Label();
                        lbImageExtension.Text = Path.GetExtension(ss[j]).Replace(".","").ToUpper();
                        lbImageExtension.CssClass = "extension";
                        imagePanel.Controls.Add(lbImageExtension);

                        Panel1.Controls.Add(imagePanel);
                        //sec2.InnerHtml += "<asp:LinkButton runat=\"server\" OnClientClick=\"deleteFile()\">LinkButton</asp:LinkButton>";
                    }
                    
                }
                
                //files.Sort((x, y) => y.CompareTo(x));
                //if (files.Count > 0) {
                    //profile_pic.Attributes["src"] = ResolveUrl("~/AppData/Image/UserImage/" + Session["login_id"].ToString() + "/" + Path.GetFileName(files[0]));
                //}

                using (OracleConnection con = Util.OC()) {
                    using (OracleCommand command = new OracleCommand("SELECT URL FROM TB_PERSON_IMAGE WHERE CITIZEN_ID = :1 AND PRESENT = :2", con)) {
                        command.Parameters.AddWithValue("1", Session["login_id"].ToString());
                        command.Parameters.AddWithValue("2", "1");
                        using(OracleDataReader reader = command.ExecuteReader()) {
                            if(reader.HasRows) {
                                reader.Read();
                                profile_pic.Attributes["src"] = ResolveUrl("~/AppData/Image/UserImage/" + Session["login_id"].ToString() + "/" + reader.GetString(0));
                            } else {

                            }
                        }
                        
                    }
                }





            } else {
                
            }


            Person person = new Person(Session["login_id"].ToString());
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
                position_and_salary_div.InnerHtml += "<td>" + i.PersonID + "</td>";
                position_and_salary_div.InnerHtml += "<td>" + i.STID + "</td>";
                position_and_salary_div.InnerHtml += "<td>" + i.PositionID + "</td>";
                position_and_salary_div.InnerHtml += "<td>" + i.Salary + "</td>";
                position_and_salary_div.InnerHtml += "<td>" + i.PositionSalary + "</td>";
                position_and_salary_div.InnerHtml += "<td>" + i.ReferenceDocument + "</td>";
                position_and_salary_div.InnerHtml += "</tr>";
            }
            position_and_salary_div.InnerHtml += "</table>";

            //-----
        }
        public void selectImageFile(string target) {
            using (OracleConnection con = Util.OC()) {
                using (OracleCommand command = new OracleCommand("UPDATE TB_PERSON_IMAGE SET PRESENT = :1 WHERE CITIZEN_ID = :2", con)) {
                    command.Parameters.AddWithValue("1", "0");
                    command.Parameters.AddWithValue("2", Session["login_id"].ToString());
                    command.ExecuteNonQuery();
                }
                using (OracleCommand command = new OracleCommand("UPDATE TB_PERSON_IMAGE SET PRESENT = :1 WHERE CITIZEN_ID = :2 AND URL = :3", con)) {
                    command.Parameters.AddWithValue("1", "1");
                    command.Parameters.AddWithValue("2", Session["login_id"].ToString());
                    command.Parameters.AddWithValue("3", target);
                    command.ExecuteNonQuery();
                }
            }
            Response.Redirect(Request.Url.ToString());
        }
        public void deleteImageFile(string target) {

            using (OracleConnection con = Util.OC()) {
                using (OracleCommand command = new OracleCommand("DELETE FROM TB_PERSON_IMAGE WHERE CITIZEN_ID = :1 AND URL = :2", con)) {
                    command.Parameters.AddWithValue("1", Session["login_id"].ToString());
                    command.Parameters.AddWithValue("2", target);
                    command.ExecuteNonQuery();
                }
                using (OracleCommand command = new OracleCommand("UPDATE TB_PERSON_IMAGE SET PRESENT = :1 WHERE CITIZEN_ID = :2", con)) {
                    command.Parameters.AddWithValue("1", "0");
                    command.Parameters.AddWithValue("2", Session["login_id"].ToString());
                    command.ExecuteNonQuery();
                }
            }

            string path = Server.MapPath("~/AppData/Image/UserImage/" + Session["login_id"].ToString() + "/" + target);
            File.Delete(path);
            Response.Redirect(Request.Url.ToString());
        }

        protected void LinkButton12_Click(object sender, EventArgs e) {
            string password = "";
            using(OracleConnection conn = Util.OC()) {
                using(OracleCommand command = new OracleCommand("SELECT PASSWORD FROM TB_PERSON WHERE CITIZEN_ID = '" + Session["login_id"].ToString() + "'" ,conn)) {
                    using(OracleDataReader reader = command.ExecuteReader()) {
                        if(reader.HasRows) {
                            reader.Read();
                            password = reader.GetString(0);
                        }
                    }
                }
            }
            if(TextBox1.Text != password) {
                Util.Alert(this, "รหัสผ่านเก่าไม่ถูกต้อง");
                return;
            }
            if (TextBox2.Text == null || TextBox3.Text == null || TextBox2.Text == "" || TextBox3.Text == "") {
                Util.Alert(this, "กรุณากรอกรหัสผ่านใหม่ให้ครบถ้วน");
                return;
            }
            if (TextBox2.Text != TextBox3.Text) {
                Util.Alert(this, "รหัสผ่านใหม่ไม่ตรงกัน");
                return;
            }
            
            if (TextBox2.Text == password) {
                Util.Alert(this, "รหัสผ่านใหม่ต้องไม่ซ้ำกับรหัสผ่านเก่า");
                return;
            }

            using (OracleConnection conn = Util.OC()) {
                using (OracleCommand command = new OracleCommand("UPDATE TB_PERSON SET PASSWORD = :1 WHERE CITIZEN_ID = :2", conn)) {
                    command.Parameters.AddWithValue("1", TextBox2.Text);
                    command.Parameters.AddWithValue("2", Session["login_id"].ToString());
                    command.ExecuteNonQuery();
                    Util.Alert(this, "แก้ไขข้อมูลสำเร็จ");
                }
            }

        }

        protected void LinkButton11_Click(object sender, EventArgs e) {
            Response.Redirect("Person-ADMIN.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e) {
            if (FileUpload1.HasFile) {
                if (Path.GetExtension(FileUpload1.FileName) == ".png" ||
                    Path.GetExtension(FileUpload1.FileName) == ".jpg" ||
                    Path.GetExtension(FileUpload1.FileName) == ".gif") {

                    string nameToSave = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + Path.GetExtension(FileUpload1.FileName);

                    using (OracleConnection con = Util.OC()) {
                        using (OracleCommand command = new OracleCommand("UPDATE TB_PERSON_IMAGE SET PRESENT = :1 WHERE CITIZEN_ID = :2", con)) {
                            command.Parameters.AddWithValue("1", "0");
                            command.Parameters.AddWithValue("2", Session["login_id"].ToString());
                            command.ExecuteNonQuery();
                        }
                        using (OracleCommand command = new OracleCommand("INSERT INTO TB_PERSON_IMAGE VALUES(SEQ_PERSON_IMAGE_ID.NEXTVAL, :2, :3, :4, :5, :6)", con)) {
                            command.Parameters.AddWithValue("2", Session["login_id"].ToString());
                            command.Parameters.AddWithValue("3", nameToSave);
                            command.Parameters.AddWithValue("4", Util.ODTN());
                            command.Parameters.AddWithValue("5", Util.ODTN());
                            command.Parameters.AddWithValue("6", "1");
                            command.ExecuteNonQuery();
                        }
                    }

                    string path = Server.MapPath("~/AppData/Image/UserImage/" + Session["login_id"].ToString());
                    if (!Directory.Exists(path)) {
                        Directory.CreateDirectory(path);
                    }
                    
                    FileUpload1.SaveAs(path + "/" + nameToSave);
                    Response.Redirect(Request.Url.ToString());
                    //FileUpload1.SaveAs(path + "/" + FileUpload1.FileName);

                    


                } else {
                    Util.Alert(this, "ไฟล์ไม่ถูกต้อง");
                    return;
                }
                
            } else {
                Util.Alert(this, "กรุณาเลือกไฟล์");
            }
        }

  
    }
}