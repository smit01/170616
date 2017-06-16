using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace test0616_DataReaderOnWeb {
    public partial class Default : System.Web.UI.Page {

        public SqlDataReader dr;

        protected void Page_Load(object sender, EventArgs e) {
            SqlConnection cn = new SqlConnection("server=(local)\\SQLExpress; database=northwind; integrated security=true");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from products", cn);
            dr = cmd.ExecuteReader();
        }
    }
}