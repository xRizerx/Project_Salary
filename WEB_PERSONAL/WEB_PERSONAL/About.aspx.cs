using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;

namespace WEB_PERSONAL {
    public partial class About : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            using(OracleConnection con = Util.OC()) {
                using (OracleCommand command = new OracleCommand("SELECT COUNTER FROM TB_WEB WHERE ID = 1", con)) {
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            reader.Read();
                            LabelCounter.Text = "จำนวนผู้เข้าชมทั้งหมด : " + reader.GetInt32(0).ToString("#,###") + " ครั้ง";
                        }
                    }
                }
            }
        }
    }
}