using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;

namespace WEB_PERSONAL {
    public partial class UpdateHistory : System.Web.UI.Page {
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
                using (OracleCommand command = new OracleCommand("SELECT TB_WEB_UPDATE_HISTORY.ID, TO_CHAR(UPDATE_DATE, 'DD MON YYYY', 'NLS_DATE_LANGUAGE = THAI'), PERSON_NAME || ' ' || PERSON_LASTNAME FROM TB_WEB_UPDATE_HISTORY, TB_PERSON WHERE TB_WEB_UPDATE_HISTORY.CITIZEN_ID = TB_PERSON.CITIZEN_ID ORDER BY TB_WEB_UPDATE_HISTORY.ID DESC", con)) {
                    using (OracleDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            while (reader.Read()) {
                                using (OracleCommand command2 = new OracleCommand("SELECT DETAIL FROM TB_WEB_UPDATE_HISTORY, TB_WEB_UPDATE_HISTORY_DETAIL WHERE TB_WEB_UPDATE_HISTORY.ID = :1 AND TB_WEB_UPDATE_HISTORY.ID = TB_WEB_UPDATE_HISTORY_DETAIL.MAIN_ID", con)) {
                                    command2.Parameters.AddWithValue("1", reader.GetInt32(0));
                                    using (OracleDataReader reader2 = command2.ExecuteReader()) {
                                        div_update_history.InnerHtml += "<div class=\"div_update_history_item\">";
                                        div_update_history.InnerHtml += "<strong>" + reader.GetString(1) + " / " + reader.GetString(2) + " (#" + reader.GetInt32(0) + ")</strong><br>";
                                        while (reader2.Read()) {
                                            div_update_history.InnerHtml += "<span style=\"display: inline-block; width: 20px\"></span>- ";
                                            div_update_history.InnerHtml += reader2.GetString(0);
                                            div_update_history.InnerHtml += "<br>";
                                        }
                                        div_update_history.InnerHtml += "</div>";



                                    }
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}