using WEB_PERSONAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_PERSONAL
{
    public partial class SEMINAR_GENERAL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ClearData()
        {
            txtName.Text = "";
            txtLastName.Text = "";
            txtPosition.Text = "";
            txtDegree.Text = "";
            txtCampus.Text = "";
            txtNameOfProject.Text = "";
            txtPlace.Text = "";
            txtDateFrom.Text = "";
            txtDateTO.Text = "";
            txtYear.Text = "";
            txtMonth.Text = "";
            txtDay.Text = "";
            txtBudget.Text = "";
            txtSupportBudget.Text = "";
            txtCertificate.Text = "";
            txtAbstract.Text = "";
            txtResult.Text = "";
            txtShow1.Text = "";
            txtShow2.Text = "";
            txtShow3.Text = "";
            txtShow4.Text = "";
            txtProblem.Text = "";
            txtComment.Text = "";
        }
    
        protected void btnSubmitCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ชื่อ')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก นามสกุล')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtPosition.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ตำแหน่ง')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtDegree.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ระดับ')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtCampus.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก สังกัด')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtNameOfProject.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ชื่อโครงการฝึกอบรม/สัมมนา/ดูงาน')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtPlace.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก สถานที่ฝึกอบรม/สัมมนา/ดูงาน')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtDateFrom.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก วันที่เริ่ม')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtDateTO.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก วันที่สิ้นสุด')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtBudget.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ค่าใช้จ่ายตลอดโครงการ')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtSupportBudget.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก แหล่งงบประมาณที่ได้รับการสนับสนุน')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtCertificate.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ประกาศนียบัตรที่ได้รับ')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtAbstract.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก สรุปผลการฝึกอบรม/สัมมนา/ดูงาน')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtResult.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ผลที่ได้รับจากการฝึกอบรม/สัมมนา/ดูงาน')", true);
                return;
            }
         /*  if (string.IsNullOrEmpty(txtShow1.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก การนำผลงานที่ได้รับจากการฝึกอบรม/สัมมนา/ดูงาน : ด้านการเรียนการสอน')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtShow2.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก การนำผลงานที่ได้รับจากการฝึกอบรม/สัมมนา/ดูงาน : ด้านการวิจัย')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtShow3.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก การนำผลงานที่ได้รับจากการฝึกอบรม/สัมมนา/ดูงาน : ด้านการบริการวิชาการ')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtShow4.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก การนำผลงานที่ได้รับจากการฝึกอบรม/สัมมนา/ดูงาน : ด้านอื่นๆ')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtProblem.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ปัญหาอุปสรรคในการฝึกอบรม/สัมมนา/ดูงาน')", true);
                return;
            }
            if (string.IsNullOrEmpty(txtComment.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('กรุณากรอก ความคิดเห็น/ข้อเสนอแนะอื่นๆ')", true);
                return;
            }
            */

           
        }

        protected void btnCancelCustomer_Click(object sender, EventArgs e)
        {
            //ClearData;
        }

        protected void chkBox_CheckedChanged(object sender, EventArgs e)
        {
             
        }
    }
}