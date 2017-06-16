using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test0616_StateInfo {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {
            Application["appName"] = TextBox1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e) {
            TextBox1.Text = Application["appName"].ToString();
        }

        protected void Button3_Click(object sender, EventArgs e) {
            Session["uid"] = TextBox2.Text;
        }

        protected void Button4_Click(object sender, EventArgs e) {
            TextBox2.Text = Session["uid"].ToString();
        }

        protected void Button5_Click(object sender, EventArgs e) {
            Response.Cookies["userName"].Value = TextBox3.Text;
            Response.Cookies["userName"].Expires = DateTime.Now.AddMinutes(1);
        }

        // + 全域應用程式類別  Global.asax
        protected void Button6_Click(object sender, EventArgs e) {
            TextBox3.Text = Request.Cookies["userName"].Value;
        }
    }
}