using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

namespace Lab6
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginB_Click(object sender, EventArgs e)
        {
            if (UserNameTB.Text == "nikos" && PasswordTB.Text == "123")
            {
                Session["user"] = UserNameTB.Text;
                Response.Redirect("Default.aspx");
            }
            else if (UserNameTB.Text == "admin" && PasswordTB.Text == "456")
            {
                Session["user"] = UserNameTB.Text;
                Response.Redirect("Default.aspx");
            }
            else
            {
                ErrorMSG.Text = "Λαθος κωδικος";
            }
        }

        protected void ForgotLink_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
        }

        protected void SignUpLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterUser.aspx");
        }
    }
}
