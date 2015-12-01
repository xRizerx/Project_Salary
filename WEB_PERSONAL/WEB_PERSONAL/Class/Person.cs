using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OracleClient;
using System.Globalization;

namespace WEB_PERSONAL.Class {

    // universal person
    // created by tangkwa
    public class Person {

        //static -----------------------------------------------------------------
        public static bool IsExist(string citizen_id) {
            using (OracleConnection con = Util.OC()) {
                using (OracleCommand command = new OracleCommand("SELECT COUNT(*) FROM TB_PERSON WHERE CITIZEN_ID = :1", con)) {
                    command.Parameters.AddWithValue("1", citizen_id);
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            reader.Read();
                            if (reader.GetInt32(0) > 0) {
                                return true;
                            } else {
                                return false;
                            }
                        } else {
                            return false;
                        }
                    }
                }
            }
        }
        //instance ---------------------------------------------------------------------

        private bool error;
        private bool exist;
        private string citizen_id;
        private int title_id;
        private string title_name;
        private string name;
        private string lastname;
        private int gender_id;
        private string gender_name;
        private int system_status_id;
        private string system_status_name;
        private int staff_type_id;
        private string staff_type_name;
        private string position_id;
        private string position_name;
        private string position_name_description;
        private int ministry_id;
        private string ministry_name;
        private string department_name;
        private string birth_date;
        private string inwork_date;
        private string retire_date;
        private string father_name;
        private string father_lastname;
        private string mother_name;
        private string mother_lastname;
        private string mother_old_lastname;
        private string couple_name;
        private string couple_lastname;
        private string couple_old_lastname;
        private double salary;
        private double salary_year;
        private string admin_position_id;
        private string admin_position_name;
        private string position_work_id;
        private string position_work_name;
        private List<PositionAndSalary> position_and_salary_list = new List<PositionAndSalary>();
        private List<StudyHistory> study_history_list = new List<StudyHistory>();
        private List<JobLicense> job_license_list = new List<JobLicense>();
        private List<TrainingHistory> training_history_list = new List<TrainingHistory>();
        private List<DisciplinaryAndAmnesty> disciplinary_and_amnesty_list = new List<DisciplinaryAndAmnesty>();


        public Person(string citizen_id) {
            try {
                this.citizen_id = citizen_id;
                using (OracleConnection con = Util.OC()) {
                    using (OracleCommand command = new OracleCommand("SELECT COUNT(*) FROM TB_PERSON WHERE CITIZEN_ID = :1", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                if (reader.GetInt32(0) > 0) {
                                    exist = true;
                                } else {
                                    exist = false;
                                }
                            } else {
                                exist = false;
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(TITLE_ID, -1) FROM TB_PERSON WHERE CITIZEN_ID = :1", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                title_id = reader.GetInt32(0);
                            } else {
                                title_id = -1;
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(TB_TITLENAME.TITLE_NAME_TH, '-') FROM TB_PERSON, TB_TITLENAME WHERE CITIZEN_ID = :1 AND TB_PERSON.TITLE_ID = TB_TITLENAME.TITLE_ID", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                title_name = reader.GetString(0);
                            } else {
                                title_name = "-";
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(PERSON_NAME, '-'), NVL(PERSON_LASTNAME, '-') FROM TB_PERSON WHERE CITIZEN_ID = :1", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                name = reader.GetString(0);
                                lastname = reader.GetString(1);
                            } else {
                                name = "-";
                                lastname = "-";
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(GENDER_ID, -1) FROM TB_PERSON WHERE CITIZEN_ID = :1", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                gender_id = reader.GetInt32(0);
                            } else {
                                gender_id = -1;
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(GENDER_NAME, '-') FROM TB_PERSON, TB_GENDER WHERE CITIZEN_ID = :1 AND TB_PERSON.GENDER_ID = TB_GENDER.GENDER_ID", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                gender_name = reader.GetString(0);
                            } else {
                                gender_name = "-";
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(SYSTEM_STATUS_ID, -1) FROM TB_PERSON WHERE CITIZEN_ID = :1", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                system_status_id = reader.GetInt32(0);
                            } else {
                                system_status_id = -1;
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(TB_SYSTEM_STATUS.NAME, '-') FROM TB_PERSON, TB_SYSTEM_STATUS WHERE CITIZEN_ID = :1 AND TB_PERSON.SYSTEM_STATUS_ID = TB_SYSTEM_STATUS.ID", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                system_status_name = reader.GetString(0);
                            } else {
                                system_status_name = "-";
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(STAFFTYPE_ID, -1) FROM TB_PERSON WHERE CITIZEN_ID = :1", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                staff_type_id = reader.GetInt32(0);
                            } else {
                                staff_type_id = -1;
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(TB_STAFFTYPE.STAFFTYPE_NAME, '-') FROM TB_PERSON, TB_STAFFTYPE WHERE CITIZEN_ID = :1 AND TB_PERSON.STAFFTYPE_ID = TB_STAFFTYPE.STAFFTYPE_ID", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                staff_type_name = reader.GetString(0);
                            } else {
                                staff_type_name = "-";
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(POSITION_ID, '-') FROM TB_POSITION_AND_SALARY WHERE CITIZEN_ID = :1 ORDER BY ID DESC", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                position_id = reader.GetString(0);
                            } else {
                                position_id = "-";
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(TB_POSITION.NAME, '-') FROM TB_POSITION_AND_SALARY, TB_POSITION WHERE TB_POSITION_AND_SALARY.CITIZEN_ID = :1 AND TB_POSITION_AND_SALARY.POSITION_ID = TB_POSITION.ID ORDER BY TB_POSITION_AND_SALARY.ID", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                position_name = reader.GetString(0);
                            } else {
                                position_name = "-";
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(POSITION_NAME, '-') FROM TB_POSITION_AND_SALARY WHERE CITIZEN_ID = :1 ORDER BY ID DESC", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                position_name_description = reader.GetString(0);
                            } else {
                                position_name_description = "-";
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(MINISTRY_ID, -1) FROM TB_PERSON WHERE CITIZEN_ID = :1", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                ministry_id = reader.GetInt32(0);
                            } else {
                                ministry_id = -1;
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(TB_MINISTRY.MINISTRY_NAME, '-') FROM TB_PERSON, TB_MINISTRY WHERE CITIZEN_ID = :1 AND TB_PERSON.MINISTRY_ID = TB_MINISTRY.MINISTRY_ID", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                ministry_name = reader.GetString(0);
                            } else {
                                ministry_name = "-";
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(DEPARTMENT_NAME, '-') FROM TB_PERSON WHERE CITIZEN_ID = :1", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                department_name = reader.GetString(0);
                            } else {
                                department_name = "-";
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(TO_CHAR(BIRTHDATE, 'DD MON YYYY', 'NLS_DATE_LANGUAGE = THAI'), '-') FROM TB_PERSON WHERE CITIZEN_ID = :1", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                birth_date = reader.GetString(0);
                            } else {
                                birth_date = "-";
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(TO_CHAR(INWORK_DATE, 'DD MON YYYY', 'NLS_DATE_LANGUAGE = THAI'), '-') FROM TB_PERSON WHERE CITIZEN_ID = :1", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                inwork_date = reader.GetString(0);
                            } else {
                                inwork_date = "-";
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(TO_CHAR(RETIRE_DATE, 'DD MON YYYY', 'NLS_DATE_LANGUAGE = THAI'), '-') FROM TB_PERSON WHERE CITIZEN_ID = :1", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                retire_date = reader.GetString(0);
                            } else {
                                retire_date = "-";
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(FATHER_NAME, '-'), NVL(FATHER_LASTNAME, '-') FROM TB_PERSON WHERE CITIZEN_ID = :1", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                father_name = reader.GetString(0);
                                father_lastname = reader.GetString(1);
                            } else {
                                father_name = "-";
                                father_lastname = "-";
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(MOTHER_NAME, '-'), NVL(MOTHER_LASTNAME, '-'), NVL(MOTHER_OLD_LASTNAME, '-') FROM TB_PERSON WHERE CITIZEN_ID = :1", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                mother_name = reader.GetString(0);
                                mother_lastname = reader.GetString(1);
                                mother_old_lastname = reader.GetString(2);
                            } else {
                                mother_name = "";
                                mother_lastname = "";
                                mother_old_lastname = "";
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(COUPLE_NAME, '-'), NVL(COUPLE_LASTNAME, '-'), NVL(COUPLE_OLD_LASTNAME, '-') FROM TB_PERSON WHERE CITIZEN_ID = :1", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                couple_name = reader.GetString(0);
                                couple_lastname = reader.GetString(1);
                                couple_old_lastname = reader.GetString(2);
                            } else {
                                couple_name = "";
                                couple_lastname = "";
                                couple_old_lastname = "";
                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT ID FROM TB_POSITION_AND_SALARY WHERE CITIZEN_ID = :1", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                while (reader.Read()) {
                                    position_and_salary_list.Add(new PositionAndSalary(reader.GetInt32(0)));
                                }
                            } else {

                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT IDSEQ FROM TB_STUDY_HISTORY WHERE CITIZEN_ID = :1", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                while (reader.Read()) {
                                    study_history_list.Add(new StudyHistory(reader.GetInt32(0)));
                                }
                            } else {

                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT ID FROM TB_JOB_LICENSE WHERE CITIZEN_ID = :1", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                while (reader.Read()) {
                                    job_license_list.Add(new JobLicense(reader.GetInt32(0)));
                                }
                            } else {

                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT ID FROM TB_TRAINING_HISTORY WHERE CITIZEN_ID = :1", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                while (reader.Read()) {
                                    training_history_list.Add(new TrainingHistory(reader.GetInt32(0)));
                                }
                            } else {

                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT ID FROM TB_DISCIPLINARY_AND_AMNESTY WHERE CITIZEN_ID = :1", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                while (reader.Read()) {
                                    disciplinary_and_amnesty_list.Add(new DisciplinaryAndAmnesty(reader.GetInt32(0)));
                                }
                            } else {

                            }
                        }
                    }
                    using (OracleCommand command = new OracleCommand("SELECT NVL(TB_POSITION_AND_SALARY.SALARY, -1) FROM TB_PERSON, TB_POSITION_AND_SALARY WHERE TB_POSITION_AND_SALARY.CITIZEN_ID = :1 AND TB_POSITION_AND_SALARY.CITIZEN_ID = TB_PERSON.CITIZEN_ID ORDER BY TB_POSITION_AND_SALARY.ID", con)) {
                        command.Parameters.AddWithValue("1", citizen_id);
                        using (OracleDataReader reader = command.ExecuteReader()) {
                            if (reader.HasRows) {
                                reader.Read();
                                salary = reader.GetDouble(0);
                            } else {
                                salary = -1;
                            }
                        }
                    }
                    {
                        int m = 3;
                        int y = Util.ODTN().Year;
                        switch (DateTime.Now.Month) {
                            case 1:
                            case 2:
                            case 3:
                            case 10:
                            case 11:
                            case 12:
                                m = 9;
                                break;
                        }
                        switch (DateTime.Now.Month) {
                            case 1:
                            case 2:
                            case 3:
                                --y;
                                break;
                        }
                        using (OracleCommand command = new OracleCommand("select salary from tb_position_and_salary where CITIZEN_ID = :1 and extract(MONTH FROM DDATE) = :2 and extract(YEAR FROM DDATE) = :3", con)) {
                            command.Parameters.AddWithValue("1", citizen_id);
                            command.Parameters.AddWithValue("2", m);
                            command.Parameters.AddWithValue("3", y);
                            using (OracleDataReader reader = command.ExecuteReader()) {
                                if (reader.HasRows) {
                                    reader.Read();
                                    salary_year = reader.GetDouble(0);
                                } else {
                                    salary_year = -1;
                                }
                            }
                        }
                        using (OracleCommand command = new OracleCommand("select nvl(admin_position_id,'-') from tb_person where citizen_id = :1",con))
                        {
                            command.Parameters.AddWithValue("1", citizen_id);
                            using (OracleDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    reader.Read();
                                    admin_position_id = reader.GetString(0);
                                }
                                else
                                {
                                    admin_position_id = "-";
                                }
                            }
                        }
                        using (OracleCommand command = new OracleCommand("select nvl(tb_admin_position.admin_position_name,'-') from tb_person,tb_admin_position where citizen_id = :1 and tb_person.admin_position_id = tb_admin_position.admin_position_id", con))
                        {
                            command.Parameters.AddWithValue("1", citizen_id);
                            using (OracleDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    reader.Read();
                                    admin_position_name = reader.GetString(0);
                                }
                                else
                                {
                                    admin_position_name = "-";
                                }
                            }
                        }
                        using (OracleCommand command = new OracleCommand("select nvl(position_work_id,'-') from tb_person where citizen_id = :1", con))
                        {
                            command.Parameters.AddWithValue("1", citizen_id);
                            using (OracleDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    reader.Read();
                                    position_work_id = reader.GetString(0);
                                }
                                else
                                {
                                    position_work_id = "-";
                                }
                            }
                        }
                        using (OracleCommand command = new OracleCommand("select nvl(tb_position_work.position_work_name,'-') from tb_person,tb_position_work where citizen_id = :1 and tb_person.position_work_id = tb_position_work.position_work_id", con))
                        {
                            command.Parameters.AddWithValue("1", citizen_id);
                            using (OracleDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    reader.Read();
                                    position_work_name = reader.GetString(0);
                                }
                                else
                                {
                                    position_work_name = "-";
                                }
                            }
                        }
                    }

                }
            } catch {
                error = true;
            }
        }

        public bool Error {
            get { return error; }
        }
        public bool Exist {
            get { return exist; }
        }
        public string CitizenID {
            get { return citizen_id; }
        }
        public int TitleID {
            get { return title_id; }
        }
        public string TitleName {
            get { return title_name; }
        }
        public string Name {
            get { return name; }
        }
        public string Lastname {
            get { return lastname; }
        }
        public string NameAndLastname {
            get { return name + " " + lastname; }
        }
        public int GenderID {
            get { return gender_id; }
        }
        public string GenderName {
            get { return gender_name; }
        }
        public int SystemStatusID {
            get { return system_status_id; }
        }
        public string SystemStatusName {
            get { return system_status_name; }
        }
        public int StaffTypeID {
            get { return staff_type_id; }
        }
        public string StaffTypeName {
            get { return staff_type_name; }
        }
        public string PositionID {
            get { return position_id; }
        }
        public string PositionName {
            get { return position_name; }
        }
        public string PositionNameDescription {
            get { return position_name_description; }
        }
        public int MinistryID {
            get { return ministry_id; }
        }
        public string MinistryName {
            get { return ministry_name; }
        }
        public string DepartmentName {
            get { return department_name; }
        }
        public string Birthdate {
            get { return birth_date; }
        }
        public string InworkDate {
            get { return inwork_date; }
        }
        public string RetireDate {
            get { return retire_date; }
        }
        public string FatherName {
            get { return father_name; }
        }
        public string FatherLastname {
            get { return father_lastname; }
        }
        public string FatherNameAndLastname {
            get { return father_name + " " + father_lastname; }
        }
        public string MotherName {
            get { return mother_name; }
        }
        public string MotherLastname {
            get { return mother_lastname; }
        }
        public string MotherOldLastname {
            get { return mother_old_lastname; }
        }
        public string MotherNameAndLastname {
            get { return mother_name + " " + mother_lastname; }
        }
        public string CoupleName {
            get { return couple_name; }
        }
        public string CoupleLastname {
            get { return couple_lastname; }
        }
        public string CoupleOldLastname {
            get { return couple_old_lastname; }
        }
        public string CoupleNameAndLastname {
            get { return couple_name + " " + couple_lastname; }
        }
        public List<PositionAndSalary> PositionAndSalaryList {
            get { return position_and_salary_list; }
        }
        public List<StudyHistory> StudyHistoryList {
            get { return study_history_list; }
        }
        public List<JobLicense> JobLicenseList {
            get { return job_license_list; }
        }
        public List<TrainingHistory> TrainingHistoryList {
            get { return training_history_list; }
        }
        public List<DisciplinaryAndAmnesty> DisciplinaryAndAmnestyList {
            get { return disciplinary_and_amnesty_list; }
        }
        public double Salary {
            get { return salary; }
        }
        public double SalaryYear {
            get { return salary_year; }
        }
        public string AdminPositionName
        {
            get { return admin_position_name; }
        }
        public string AdminPositionID
        {
            get { return admin_position_id;  }
        }
        public string PositionWorkID
        {
            get { return position_work_id; }
        }
        public string PositionWorkName
        {
            get { return position_work_name; }
        }

    }

}