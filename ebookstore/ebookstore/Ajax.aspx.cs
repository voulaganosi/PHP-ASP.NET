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

namespace ebookstore
{
    public partial class Ajax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ShowTime_InsideB_Click(object sender, EventArgs e)
        {//oti sumbainei mesa sto upadte panel dn bgainei pros ta eksw dn ksexilizei einai eswterikh ypothesh tou update panel
            //to update progress einai ena allo panel p oso diarkei to fwrtoma t server mporei na mas bgalei kapoio mynhma
            //tha parakolouthei to upadte panel1 oso to updatepanel fwrtonei kai den exei epiistrepsei h klhsh exw kanei dld request
            //sto server alla dn exei epistrepsei to response tote energopoihtai to update progress
            string time = DateTime.Now.ToLongTimeString();
            Time_InsideL.Text = "Klhsh apo mesa :" + time;
            System.Threading.Thread.Sleep(3000);
            //Time_OutsideL.Text = "klhsh apo eksw :" + time;
            //ama paw na enhmerwsw kai ta duo apo edw apo 'inside' den tha petyxei
        }

        protected void ShowTime_OutsideB_Click(object sender, EventArgs e)
        {//an paw na enhmerwsw kai ta dyyo apo dw tha petyxei
            string time = DateTime.Now.ToLongTimeString();
            Time_OutsideL.Text = "klhsh apo eksw :" + time;
            Time_InsideL.Text = "klhsh apo eksw :" + time;
        }
    }
}
