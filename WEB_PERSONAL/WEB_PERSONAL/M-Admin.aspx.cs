using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;

namespace WEB_PERSONAL
{
    public partial class M_Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton13_Click(object sender, EventArgs e) {
            if(Session["login_id"] == null) {
                Util.Alert(this, "กรุณาเข้าสู่ระบบก่อน");
                return;
            }

            using(OracleConnection con = Util.OC()) {
                using(OracleCommand command = new OracleCommand("insert into TB_COMMENT values(SEQ_COMMENT_ID.NEXTVAL,:2,:3,:4)", con)) {
                    command.Parameters.AddWithValue("2",1);
                    command.Parameters.AddWithValue("3", Util.toOracleDateTime(DateTime.Now));
                    command.Parameters.AddWithValue("4", TextBox1.Text);
                    command.ExecuteNonQuery();
                    Util.Alert(this, "ส่งข้อเสนอแนะเรียบร้อนแบ้ว");
                }
            }

        }
    }
}