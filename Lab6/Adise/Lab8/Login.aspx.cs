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
using System.Data.OleDb;

namespace Lab6
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String conString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" +
                Server.MapPath(" ~/App_Data/ebookstoredb.mdb");
            using (OleDbConnection con = new OleDbConnection(conString))
            {
                con.Open();
                String query = "SELECT * FROM customer";
                using(OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    OleDbDataReader reader = cmd.ExecuteReader();
                    string Msg = "";
                    while (reader.Read())
                    {
                        Msg += reader["Fname"]
                            + ", " + reader["Lname"]
                            + ", " + reader["uname"]
                            + ", " + reader["passwd"]
                            + "<br/>";

                    }
                    reader.Close();
                    ErrorMSG.Text = Msg;
                }
            }
        }

        protected void LoginB_Click(object sender, EventArgs e)
        {
            /*if (UserNameTB.Text == "nikos" && PasswordTB.Text == "123")
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
            }*/

            String conString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" +
                Server.MapPath(" ~/App_Data/ebookstoredb.mdb");
            using (OleDbConnection con = new OleDbConnection(conString))
            {
                con.Open();
                string query = "SELECT count(*) FROM customer "
                    + "WHERE uname=@username AND passwd=@password";
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", UserNameTB.Text);
                    cmd.Parameters.AddWithValue("@password", PasswordTB.Text);

                    int result = (int)cmd.ExecuteScalar();
                    if (result == 1)
                    {
                        Session["user"] = UserNameTB.Text;
                        Response.Redirect("Default.aspx");
                    }
                    else
                    {
                        ErrorMSG.Text = "Δοκιμαστε ξανα!";
                    }
                }
                con.Close();
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
