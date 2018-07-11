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

namespace ebookstore
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            if (Session["user"] != null && (string)Session["user"]!="admin")
            {
                MultiView1.ActiveViewIndex = 0;
                UserGreeting.Text = "kalwshrthes " + (string)Session["user"];
                string conString = "Provider=MIcrosoft.ACE.OLEDB.12.0; Data Source=" +
               Server.MapPath(" ~/bookstoreDataBase.mdb");
                using (OleDbConnection con = new OleDbConnection(conString))
                {//tha dokimasei na anoiksei ena neo OleDbConnection
                    //an ola pane kala mpainw mesa sto using an oxi dn mpainw mesa sto using
                    con.Open();
                    string query = "select Name from category ";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        OleDbDataReader myreader = cmd.ExecuteReader();
                        string category = "";
                        int i = 0;
                        while (myreader.Read())//oso exei dedomena na diabasei
                        {
                            category = (string)myreader["Name"];
                            if (i == 0)
                            {
                                Cat1.Text = category;
                            }
                            if (i == 1)
                            {
                                Cat2.Text = category;
                            }
                            if (i == 2)
                            {
                                Cat3.Text = category;
                            }
                            if (i == 3)
                            {
                                Cat4.Text = category;
                            }
                            if (i == 4)
                            {
                                Cat5.Text = category;
                            }
                            i++;
                        }
                        myreader.Close();
                    }
                    con.Close();
                }

            }
            else if((string)Session["user"]=="admin")
            {
                MultiView1.ActiveViewIndex = 1;
            }
            else 
            {
                Cat1.Visible = false;
                Cat2.Visible = false;
                Cat3.Visible = false;
                Cat4.Visible = false;
                Cat5.Visible = false;
            }
            
            
                
                
            
        }
    }
}
