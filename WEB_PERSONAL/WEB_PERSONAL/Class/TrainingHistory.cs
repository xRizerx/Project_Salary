using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OracleClient;

namespace WEB_PERSONAL.Class {
    public class TrainingHistory {

        private int id;
        private string citizen_id;
        private string course;
        private string month_from;
        private string year_from;
        private string month_to;
        private string year_to;
        private string branch_training;

        public TrainingHistory(int id) {
            this.id = id;
            using (OracleConnection con = Util.OC()) {
                using (OracleCommand command = new OracleCommand("SELECT CITIZEN_ID, COURSE, MONTH_FROM, YEAR_FROM, MONTH_TO, YEAR_TO, BRANCH_TRAINING FROM TB_TRAINING_HISTORY WHERE ID = :1", con)) {
                    command.Parameters.AddWithValue("1", id);
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            reader.Read();
                            citizen_id = reader.GetString(0);
                            course = reader.GetString(1);
                            month_from = reader.GetString(2);
                            year_from = reader.GetString(3);
                            month_to = reader.GetString(4);
                            year_to = reader.GetString(5);
                            branch_training = reader.GetString(6);
                        } else {
                            citizen_id = "-";
                            course = "-";
                            month_from = "-";
                            year_from = "-";
                            month_to = "-";
                            year_to = "-";
                            branch_training = "-";
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
        public string Course {
            get { return course; }
        }
        public string MonthFrom {
            get { return month_from; }
        }
        public string YearFrom {
            get { return year_from; }
        }
        public string FromDate {
            get { return month_from + " " + year_from; }
        }
        public string MonthTo {
            get { return month_to; }
        }
        public string YearTo {
            get { return year_to; }
        }
        public string ToDate {
            get { return month_to + " " + year_to; }
        }
        public string FromAndToDate {
            get { return FromDate + " - " + ToDate; }
        }
        public string BranchTraining {
            get { return branch_training; }
        }
    }
}