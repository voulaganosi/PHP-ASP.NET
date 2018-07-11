using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Lab6
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                UserMsg.Text = "Welcome " + (String)Session["user"];
                if ((String)Session["user"] != "admin")
                {
                    Panel1.Visible = true;
                    Panel2.Visible = false;
                //    MyOrdersLink.Visible = true;
                //    MyOrdersLink.Height = 20;
                  //  MyDetailsLink.Visible = true;
                   // MyDetailsLink.Height = 20;
                }
                else if ((String)Session["user"] == "admin")
                {
                    Panel1.Visible = false;
                    Panel2.Visible = true;
                 //   CustomersLink.Visible = true;
                //    CustomersLink.Height = 20;
                //    OrdersLink.Visible = true;
                 //   OrdersLink.Height = 20;
                }
                LogoutLink.Visible = true;
                LogoutLink.Height = 20;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Products.aspx");
        }

        protected void MyOrdersLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyOrders.aspx");
        }

        protected void MyDetailsLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyDetails.aspx");
        }

        protected void LogoutLink_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("Default.aspx");
        }

        protected void CustomersLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customers.aspx");
        }

        protected void OrdersLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Orders.aspx");
        }
    }
}
