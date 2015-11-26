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
                Session["default_dt1"] = new DataTable();
                ((DataTable)(Session["default_dt1"])).Columns.Add("c1");
                ((DataTable)(Session["default_dt1"])).Columns.Add("c2");
                ((DataTable)(Session["default_dt1"])).Columns.Add("c3");
                GridView1.DataSource = ((DataTable)(Session["default_dt1"]));
                GridView1.DataBind();

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

        protected void Button1_Click(object sender, EventArgs e) {
            /*TextBox tb = new TextBox();
            Panel1.Controls.Add(new LiteralControl("<br/>"));
            Panel1.Controls.Add(tb);
            Panel1.Controls.Add(new LiteralControl("<br/>"));*/
            //Util.Alert(this, Util.NormalizeThaiWord(Util.NumberToThaiWord("10095")));
            DataRow dr = ((DataTable)(Session["default_dt1"])).NewRow();
            dr[0] = "1";
            dr[1] = "2";
            dr[2] = "3";
            ((DataTable)(Session["default_dt1"])).Rows.Add(dr);
            GridView1.DataSource = ((DataTable)(Session["default_dt1"]));
            GridView1.DataBind();
        }


    }
}