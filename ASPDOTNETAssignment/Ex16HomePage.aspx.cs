using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebFormsApp
{
    public partial class Ex16HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ex14LoginPage.aspx");
        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ex13ValidationControls.aspx");
        }
    }
}