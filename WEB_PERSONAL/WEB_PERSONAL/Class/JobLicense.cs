using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OracleClient;

namespace WEB_PERSONAL.Class {
    public class JobLicense {

        private int id;
        private string citizen_id;
        private string license_name;
        private string branch;
        private string license_no;
        private string date;

        public JobLicense(int id) {
            this.id = id;
            using (OracleConnection con = Util.OC()) {
                using (OracleCommand command = new OracleCommand("SELECT NVL(CITIZEN_ID, '-'), NVL(LICENCE_NAME, '-'), NVL(BRANCH, '-'), NVL(LICENCE_NO, '-'), NVL(TO_CHAR(DDATE, 'DD MON YYYY', 'NLS_DATE_LANGUAGE = THAI'), '-') FROM TB_JOB_LICENSE WHERE ID = :1", con)) {
                    command.Parameters.AddWithValue("1", id);
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            reader.Read();
                            citizen_id = reader.GetString(0);
                            license_name = reader.GetString(1);
                            branch = reader.GetString(2);
                            license_no = reader.GetString(3);
                            date = reader.GetString(4);
                        } else {
                            citizen_id = "-";
                            license_name = "-";
                            branch = "-";
                            license_no = "-";
                            date = "-";
                        }
                    }
                }
            }
        }

        public int ID {
            get { return id; }
        }
        public string CitizenID {
            get { return citizen_id; }
        }
        public string LicenseName {
            get { return license_name; }
        }
        public string Branch {
            get { return branch; }
        }
        public string LicenseNo {
            get { return license_no; }
        }
        public string Date {
            get { return date; }
        }

    }
}