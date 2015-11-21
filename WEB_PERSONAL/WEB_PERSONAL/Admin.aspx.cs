using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_PERSONAL {
    public partial class Admin : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            BindGridView1();
        }
        private void BindGridView1() {
            GridView1.AllowPaging = true;
            GridView1.EnableSortingAndPagingCallbacks = true;
            GridView1.AutoGenerateColumns = false;
            GridView1.Controls.Clear();
            GridView1.Columns.Clear();
            {
                BoundField test = new BoundField();
                test.DataField = "ID";
                test.HeaderText = "รหัส";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "CITIZEN_ID";
                test.HeaderText = "รหัสพนักงาน";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "NAME";
                test.HeaderText = "ชื่อพนักงาน";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "COMMENT_DATE";
                test.HeaderText = "วันที่คอมเมนต์";
                GridView1.Columns.Add(test);
            }
            {
                BoundField test = new BoundField();
                test.DataField = "COMMENT_STRING";
                test.HeaderText = "คอมเมนต์";
                GridView1.Columns.Add(test);
            }

            SqlDataSource sds = new SqlDataSource("System.Data.OracleClient", "DATA SOURCE=ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm;", "SELECT TB_COMMENT.ID AS \"ID\", TB_COMMENT.CITIZEN_ID AS \"CITIZEN_ID\", TB_PERSON.PERSON_NAME || ' ' || TB_PERSON.PERSON_LASTNAME as \"NAME\", to_char(TB_COMMENT.COMMENT_DATE, 'dd mon yyyy', 'NLS_DATE_LANGUAGE = THAI') as \"COMMENT_DATE\", TB_COMMENT.COMMENT_STRING as \"COMMENT_STRING\" from TB_COMMENT, TB_PERSON WHERE TB_COMMENT.CITIZEN_ID = TB_PERSON.CITIZEN_ID");
            GridView1.DataSource = sds;
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e) {
            GridView1.PageIndex = e.NewPageIndex;
            BindGridView1();
        }
    }
}