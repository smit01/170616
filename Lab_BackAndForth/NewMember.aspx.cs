﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewMember : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        Session["userName"] = txtUserName.Text;
        Session["password"] = txtPassword.Text;
        Session["email"] = txtEmail.Text;
        Response.Redirect("Preview.aspx");
    }
}