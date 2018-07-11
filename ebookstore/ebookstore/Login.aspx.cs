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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginSubmitB_Click(object sender, EventArgs e)
        {
            string conString = "Provider=MIcrosoft.ACE.OLEDB.12.0; Data Source=" +
                Server.MapPath(" ~/bookstoreDataBase.mdb");
            using (OleDbConnection con = new OleDbConnection(conString))
            {//tha dokimasei na anoiksei ena neo OleDbConnection
                    //an ola pane kala mpainw mesa sto using an oxi dn mpainw mesa sto using
                con.Open();
                string query = "select count(*) from customer "
                    + "where uname=@username and passwd=@password";//thelw n dw an ontws o xrhsths uparxei sth database
                //krataw ena plceholder p legetai username kai enan p legete password
                
                using(OleDbCommand cmd=new OleDbCommand(query,con))
                {//xrhsimopoiw thn entolh using giaati kati mporei na paei straba me to query
                    //an ola pane kala mpainw mesa sto using an oxi dn mpainw mesa sto using
                    cmd.Parameters.AddWithValue("@username", UserNameTB.Text);//dinw parametro-timh sto placeholder mou
                    cmd.Parameters.AddWithValue("@password", PasswordTB.Text);

                    int result = (int)cmd.ExecuteScalar();//h entolh auth tha parei ena kai mono record sygkekrimena to prwto epeidh
                    //tha epistrafoun polla records apo t query..kai pio sugkekrimena to prwto collumn-th prwth sthlh-pedio tou record

                    //mas endiaferei n doume an uparxei estw ena record m auto to username kai password
                    if (result == 1)
                    {
                        Session["user"] = UserNameTB.Text;
                        Response.Redirect("Default.aspx");
                    }
                    else 
                    {
                        ErrMsg.Text = "parakalw dokimaste ksana";
                    }
                }
                con.Close();
            }
        }

        protected void ForgetPswd_Lb_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void RegLink_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }

        protected void RegB_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 3;
        }

        protected void BackB_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }
        
    }
}
