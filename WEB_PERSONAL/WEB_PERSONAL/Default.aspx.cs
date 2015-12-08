using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OracleClient;
using System.IO;

namespace WEB_PERSONAL {
    public partial class Default : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            /*if(Session["default_dt1"] == null) {
                Session["default_dt1"] = new DataTable();
                ((DataTable)(Session["default_dt1"])).Columns.Add("c1");
            }*/
            if (!IsPostBack) {

            }
            //if (Util.dt == null) {
            //  Util.dt = new DataTable();
            //Util.dt.Columns.Add("Column1");
            //}

            using (OracleConnection con = Util.OC()) {
                using (OracleCommand command = new OracleCommand("SELECT ANNOUNCE_STRING, TO_CHAR(ANNOUNCE_DATE, 'DD MON YYYY', 'NLS_DATE_LANGUAGE = THAI') FROM TB_ANNOUNCE ORDER BY ANNOUNCE_DATE DESC, ANNOUNCE_ID DESC", con)) {
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            while (reader.Read()) {
                                div_announce.InnerHtml += "<span style=\"display: inline-block; width: 20px\"></span>";
                                div_announce.InnerHtml += "(" + reader.GetString(1) + ") " + reader.GetString(0);
                                div_announce.InnerHtml += "<br>";
                            }
                        }
                    }
                }

            }


        }

    }
}