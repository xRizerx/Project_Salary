using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OracleClient;

namespace WEB_PERSONAL.Class {
    public class DisciplinaryAndAmnesty {

        private int id;
        private string citizen_id;
        private string year;
        private string menu;
        private string ref_doc;

        public DisciplinaryAndAmnesty(int id) {
            this.id = id;
            using (OracleConnection con = Util.OC()) {
                using (OracleCommand command = new OracleCommand("SELECT CITIZEN_ID, YEAR, MENU, REF_DOC FROM TB_DISCIPLINARY_AND_AMNESTY WHERE ID = :1", con)) {
                    command.Parameters.AddWithValue("1", id);
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            reader.Read();
                            citizen_id = reader.GetString(0);
                            year = reader.GetString(1);
                            menu = reader.GetString(2);
                            ref_doc = reader.GetString(3);
                        } else {
                            citizen_id = "-";
                            year = "-";
                            menu = "-";
                            ref_doc = "-";
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
        public string Year {
            get { return year; }
        }
        public string Menu {
            get { return menu; }
        }
        public string ReferenceDocument {
            get { return ref_doc; }
        }
    }
}