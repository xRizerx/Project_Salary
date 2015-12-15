using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;

namespace WEB_PERSONAL {
    public partial class Admin : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if(Session["login_system_status_id"] != null && Session["login_system_status_id"].ToString() != "1") {
                Response.Redirect("default.aspx");
                return;
            }
            if(IsPostBack) {
                Util.RunScript(this, "$(function () { foggle('1'); });");
            }
        }
        private void BindAllGridView() {
            GridView1.DataBind();
            GridView2.DataBind();
            GridView3.DataBind();
        }

        protected void LinkButton11_Click(object sender, EventArgs e) {
            Util.RunScript(this, "$(function () { foggle('3'); });");
            int id;
            using(OracleConnection con = Util.OC()) {
                using (OracleCommand command = new OracleCommand("SELECT SEQ_WUH_ID.NEXTVAL FROM DUAL", con)) {
                    using(OracleDataReader reader = command.ExecuteReader()) {
                        reader.Read();
                        id = reader.GetInt32(0);
                    }
                }
                
                using(OracleCommand command = new OracleCommand("INSERT INTO TB_WEB_UPDATE_HISTORY VALUES(:1, :2, :3)", con)) {
                    command.Parameters.AddWithValue("1", id);
                    command.Parameters.AddWithValue("2", Session["login_id"].ToString());
                    command.Parameters.AddWithValue("3", Util.ODTT());
                    command.ExecuteNonQuery();
                }
                string[] lines = TextBox2.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                Array.Reverse(lines);
                for(int i=0; i<lines.Length; ++i) {
                    if (lines[i] == null || lines[i] == "")
                        continue;
                    using (OracleCommand command = new OracleCommand("INSERT INTO TB_WEB_UPDATE_HISTORY_DETAIL VALUES(SEQ_WUHD_ID.NEXTVAL, :2, :3)", con)) {
                        command.Parameters.AddWithValue("2", id);
                        command.Parameters.AddWithValue("3", lines[i]);
                        command.ExecuteNonQuery();
                    }
                }
                
            }
            BindAllGridView();
        }

        protected void LinkButton12_Click(object sender, EventArgs e) {
            Util.RunScript(this, "$(function () { foggle('3'); });");
            using (OracleConnection con = Util.OC()) {
                using (OracleCommand command = new OracleCommand("DELETE FROM TB_WEB_UPDATE_HISTORY WHERE ID = :1", con)) {
                    command.Parameters.AddWithValue("1", TextBox3.Text);
                    command.ExecuteNonQuery();
                }
                using (OracleCommand command = new OracleCommand("DELETE FROM TB_WEB_UPDATE_HISTORY_DETAIL WHERE MAIN_ID = :1", con)) {
                    command.Parameters.AddWithValue("1", TextBox3.Text);
                    command.ExecuteNonQuery();
                }
            }
            BindAllGridView();
        }

        protected void LinkButton13_Click(object sender, EventArgs e) {
            Util.RunScript(this, "$(function () { foggle('1'); });");
            using (OracleConnection con = Util.OC()) {
                using (OracleCommand command = new OracleCommand("DELETE FROM TB_COMMENT WHERE ID = :1", con)) {
                    command.Parameters.AddWithValue("1", TextBox4.Text);
                    command.ExecuteNonQuery();
                }
            }
            BindAllGridView();
        }

        protected void LinkButton14_Click(object sender, EventArgs e) {
            Util.RunScript(this, "$(function () { foggle('2'); });");
            using (OracleConnection con = Util.OC()) {
                using (OracleCommand command = new OracleCommand("INSERT INTO TB_ANNOUNCE VALUES(SEQ_ANNOUNCE_ID.NEXTVAL, :2, :3, :4)", con)) {
                    command.Parameters.AddWithValue("2", Session["login_id"].ToString());
                    command.Parameters.AddWithValue("3", Util.ODTN());
                    command.Parameters.AddWithValue("4", TextBox5.Text);
                    command.ExecuteNonQuery();
                }
            }
            BindAllGridView();
        }

        protected void LinkButton15_Click(object sender, EventArgs e) {
            Util.RunScript(this, "$(function () { foggle('2'); });");
            using (OracleConnection con = Util.OC()) {
                using (OracleCommand command = new OracleCommand("DELETE FROM TB_ANNOUNCE WHERE ANNOUNCE_ID = :1", con)) {
                    command.Parameters.AddWithValue("1", TextBox6.Text);
                    command.ExecuteNonQuery();
                }
            }
            BindAllGridView();
        }
    }
}