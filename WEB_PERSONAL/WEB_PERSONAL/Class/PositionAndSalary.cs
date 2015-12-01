using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OracleClient;

namespace WEB_PERSONAL.Class {
    public class PositionAndSalary {

        private int id;
        private string date;
        private string position_description;
        private string person_id;
        private string st_id;
        private string position_id;
        private string position_name;
        private int salary;
        private int position_salary;
        private string reference_document;
        private string citizen_id;

        public PositionAndSalary(int id) {
            this.id = id;
            using (OracleConnection con = Util.OC()) {
                using (OracleCommand command = new OracleCommand("SELECT NVL(TO_CHAR(DDATE, 'DD MON YYYY', 'NLS_DATE_LANGUAGE = THAI'), '-') FROM TB_POSITION_AND_SALARY WHERE ID = :1", con)) {
                    command.Parameters.AddWithValue("1", id);
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            reader.Read();
                            date = reader.GetString(0);
                        } else {
                            date = "-";
                        }
                    }
                }
                using (OracleCommand command = new OracleCommand("SELECT NVL(POSITION_NAME, '-') FROM TB_POSITION_AND_SALARY WHERE ID = :1", con)) {
                    command.Parameters.AddWithValue("1", id);
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            reader.Read();
                            position_description = reader.GetString(0);
                        } else {
                            position_description = "-";
                        }
                    }
                }
                using (OracleCommand command = new OracleCommand("SELECT NVL(PERSON_ID, '-') FROM TB_POSITION_AND_SALARY WHERE ID = :1", con)) {
                    command.Parameters.AddWithValue("1", id);
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            reader.Read();
                            person_id = reader.GetString(0);
                        } else {
                            person_id = "-";
                        }
                    }
                }
                using (OracleCommand command = new OracleCommand("SELECT NVL(ST_ID, '-') FROM TB_POSITION_AND_SALARY WHERE ID = :1", con)) {
                    command.Parameters.AddWithValue("1", id);
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            reader.Read();
                            st_id = reader.GetString(0);
                        } else {
                            st_id = "-";
                        }
                    }
                }
                using (OracleCommand command = new OracleCommand("SELECT NVL(POSITION_ID, '-') FROM TB_POSITION_AND_SALARY WHERE ID = :1", con)) {
                    command.Parameters.AddWithValue("1", id);
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            reader.Read();
                            position_id = reader.GetString(0);
                        } else {
                            position_id = "-";
                        }
                    }
                }
                using (OracleCommand command = new OracleCommand("SELECT NVL(TB_POSITION.NAME, '-') FROM TB_POSITION_AND_SALARY, TB_POSITION WHERE TB_POSITION_AND_SALARY.ID = :1 AND TB_POSITION_AND_SALARY.POSITION_ID = TB_POSITION.ID", con)) {
                    command.Parameters.AddWithValue("1", id);
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            reader.Read();
                            position_name = reader.GetString(0);
                        } else {
                            position_name = "-";
                        }
                    }
                }
                using (OracleCommand command = new OracleCommand("SELECT NVL(SALARY, -1) FROM TB_POSITION_AND_SALARY WHERE ID = :1", con)) {
                    command.Parameters.AddWithValue("1", id);
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            reader.Read();
                            salary = reader.GetInt32(0);
                        } else {
                            salary = -1;
                        }
                    }
                }
                using (OracleCommand command = new OracleCommand("SELECT NVL(POSITION_SALARY, -1) FROM TB_POSITION_AND_SALARY WHERE ID = :1", con)) {
                    command.Parameters.AddWithValue("1", id);
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            reader.Read();
                            position_salary = reader.GetInt32(0);
                        } else {
                            position_salary = -1;
                        }
                    }
                }
                using (OracleCommand command = new OracleCommand("SELECT NVL(REFERENCE_DOCUMENT, '-') FROM TB_POSITION_AND_SALARY WHERE ID = :1", con)) {
                    command.Parameters.AddWithValue("1", id);
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            reader.Read();
                            reference_document = reader.GetString(0);
                        } else {
                            reference_document = "-";
                        }
                    }
                }
                using (OracleCommand command = new OracleCommand("SELECT NVL(CITIZEN_ID, '-') FROM TB_POSITION_AND_SALARY WHERE ID = :1", con)) {
                    command.Parameters.AddWithValue("1", id);
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            reader.Read();
                            citizen_id = reader.GetString(0);
                        } else {
                            citizen_id = "-";
                        }
                    }
                }

            }
        }

        public int ID {
            get { return id; }
        }
        public string Date {
            get { return date; }
        }
        public string PositionDescription {
            get { return position_description; }
        }
        public string PersonID {
            get { return person_id; }
        }
        public string STID {
            get { return st_id; }
        }
        public string PositionID {
            get { return position_id; }
        }
        public string PositionName {
            get { return position_name; }
        }
        public int Salary {
            get { return salary; }
        }
        public int PositionSalary {
            get { return position_salary; }
        }
        public string ReferenceDocument {
            get { return reference_document; }
        }
        public string CitizenID {
            get { return citizen_id; }
        }
        public Person Citizen {
           get { return new Person(citizen_id); }
        }

    }
}