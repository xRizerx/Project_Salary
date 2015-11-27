using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OracleClient;
using System.IO;

namespace WEB_PERSONAL
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            /*if(Session["default_dt1"] == null) {
                Session["default_dt1"] = new DataTable();
                ((DataTable)(Session["default_dt1"])).Columns.Add("c1");
            }*/
            if(!IsPostBack) {

            }
            //if (Util.dt == null) {
              //  Util.dt = new DataTable();
                //Util.dt.Columns.Add("Column1");
            //}
                
            using(OracleConnection con = Util.OC()) {
                using(OracleCommand command = new OracleCommand("SELECT ANNOUNCE_STRING FROM TB_ANNOUNCE WHERE ANNOUNCE_ID = 1", con)) {
                    using(OracleDataReader reader = command.ExecuteReader()) {
                        if(reader.HasRows) {
                            reader.Read();
                            Label1.Text = reader.GetString(0);
                        }
                    }
                }
            }
            
            
        }

    }
}