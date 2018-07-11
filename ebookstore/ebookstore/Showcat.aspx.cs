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
    public partial class Showcat : System.Web.UI.Page
    {
        string globalCategory=" ";
        int posothta = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            string cat = Request.QueryString["Category"];
            globalCategory = Request.QueryString["Category"];


            CategoryL.Text = "h kathgoria pou epileksate einai : " + cat;
            if (cat.Equals("Programming Languages"))
            {

                string conString = "Provider=MIcrosoft.ACE.OLEDB.12.0; Data Source=" +
               Server.MapPath(" ~/bookstoreDataBase.mdb");
                using (OleDbConnection con = new OleDbConnection(conString))
                {//tha dokimasei na anoiksei ena neo OleDbConnection
                    //an ola pane kala mpainw mesa sto using an oxi dn mpainw mesa sto using
                    con.Open();
                    string query = "select * from product p where p.Category=1 ";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        OleDbDataReader myreader = cmd.ExecuteReader();
                        string output = "";
                        string idProductTostring = "";
                        while (myreader.Read())
                        {

                            int ca = (int)myreader["Category"];
                            if (ca == 1)
                            {
                                TableRow row = new TableRow();
                                int countpedia = 0;

                                while (countpedia != 5)
                                {
                                    if (countpedia == 0)
                                    {
                                        int idProduct;
                                        idProduct = (int)myreader["ID"];

                                        idProductTostring = Convert.ToString(idProduct);

                                        TableCell cell = new TableCell();
                                        cell.Text = idProductTostring;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 1)
                                    {
                                        output = (string)myreader["Title"];
                                        TableCell cell = new TableCell();
                                        cell.Text = output;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 2)
                                    {
                                        output = (string)myreader["Description"];
                                        TableCell cell = new TableCell();
                                        cell.Text = output;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 3)
                                    {
                                        float priceProduct;
                                        priceProduct = (float)myreader["Price"];
                                        string stringpriceProduct = Convert.ToString(priceProduct);
                                        TableCell cell = new TableCell();
                                        cell.Text = stringpriceProduct;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 4)
                                    {
                                        Button Buttonprosthiki = new Button();
                                        Buttonprosthiki.Text = "prothiki sto kalathi";
                                        Buttonprosthiki.ID = idProductTostring;
                                        Buttonprosthiki.Click += new EventHandler(Add);
                                        TableCell cell = new TableCell();
                                        cell.Controls.Add(Buttonprosthiki);
                                        row.Cells.Add(cell);

                                    }
                                 
                                    countpedia++;
                                }
                                ProductTable.Rows.Add(row);
                            }
                        }

                    }
                }
            }
            if (cat.Equals("Operating Systems"))
            {
                string conString = "Provider=MIcrosoft.ACE.OLEDB.12.0; Data Source=" +
               Server.MapPath(" ~/bookstoreDataBase.mdb");
                using (OleDbConnection con = new OleDbConnection(conString))
                {//tha dokimasei na anoiksei ena neo OleDbConnection
                    //an ola pane kala mpainw mesa sto using an oxi dn mpainw mesa sto using
                    con.Open();
                    string query = "select * from product p where p.Category=2 ";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        OleDbDataReader myreader = cmd.ExecuteReader();
                        string output = "";
                        string idProductTostring = "";
                        while (myreader.Read())
                        {

                            int ca = (int)myreader["Category"];
                           // CategoryL.Text = "mphka";
                            if (ca == 2)
                            {
                                TableRow row = new TableRow();
                                int countpedia = 0;

                                while (countpedia != 6)
                                {
                                    if (countpedia == 0)
                                    {
                                        int idProduct;
                                        idProduct = (int)myreader["ID"];
                                        idProductTostring = Convert.ToString(idProduct);
                                        TableCell cell = new TableCell();
                                        cell.Text = idProductTostring;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 1)
                                    {
                                        output = (string)myreader["Title"];
                                        TableCell cell = new TableCell();
                                        cell.Text = output;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 2)
                                    {
                                        output = (string)myreader["Description"];
                                        TableCell cell = new TableCell();
                                        cell.Text = output;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 3)
                                    {
                                        float priceProduct;
                                        priceProduct = (float)myreader["Price"];
                                        string stringpriceProduct = Convert.ToString(priceProduct);
                                        TableCell cell = new TableCell();
                                        cell.Text = stringpriceProduct;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 4)
                                    {
                                        Button Buttonprosthiki = new Button();
                                        Buttonprosthiki.Text = "prothiki sto kalathi";
                                        Buttonprosthiki.ID = idProductTostring;
                                        Buttonprosthiki.Click += new EventHandler(Add);
                                        TableCell cell = new TableCell();
                                        cell.Controls.Add(Buttonprosthiki);
                                        row.Cells.Add(cell);

                                    }
                                
                                    countpedia++;
                                }
                                ProductTable.Rows.Add(row);
                            }//kleini if(ca==2)
                        }//kleini while(myread.read())

                    }
                }
            }

            if (cat.Equals("Databases"))
            {
                string conString = "Provider=MIcrosoft.ACE.OLEDB.12.0; Data Source=" +
              Server.MapPath(" ~/bookstoreDataBase.mdb");
                using (OleDbConnection con = new OleDbConnection(conString))
                {//tha dokimasei na anoiksei ena neo OleDbConnection
                    //an ola pane kala mpainw mesa sto using an oxi dn mpainw mesa sto using
                    con.Open();
                    string query = "select * from product p where p.Category=3 ";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        OleDbDataReader myreader = cmd.ExecuteReader();
                        string output = "";
                        string idProductTostring = "";
                        while (myreader.Read())
                        {

                            int ca = (int)myreader["Category"];
                            CategoryL.Text = "mphka";
                            if (ca == 3)
                            {
                                TableRow row = new TableRow();
                                int countpedia = 0;

                                while (countpedia != 5)
                                {
                                    if (countpedia == 0)
                                    {
                                        int idProduct;
                                        idProduct = (int)myreader["ID"];

                                        idProductTostring = Convert.ToString(idProduct);

                                        TableCell cell = new TableCell();
                                        cell.Text = idProductTostring;
                                        row.Cells.Add(cell);



                                    }
                                    if (countpedia == 1)
                                    {
                                        output = (string)myreader["Title"];
                                        TableCell cell = new TableCell();
                                        cell.Text = output;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 2)
                                    {
                                        output = (string)myreader["Description"];
                                        TableCell cell = new TableCell();
                                        cell.Text = output;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 3)
                                    {
                                        float priceProduct;
                                        priceProduct = (float)myreader["Price"];
                                        string stringpriceProduct = Convert.ToString(priceProduct);
                                        TableCell cell = new TableCell();
                                        cell.Text = stringpriceProduct;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 4)
                                    {
                                        Button Buttonprosthiki = new Button();
                                        Buttonprosthiki.Text = "prothiki sto kalathi";
                                        Buttonprosthiki.ID = idProductTostring;
                                        Buttonprosthiki.Click += new EventHandler(Add);
                                        TableCell cell = new TableCell();
                                        cell.Controls.Add(Buttonprosthiki);
                                        row.Cells.Add(cell);

                                    }
                                  
                                    countpedia++;
                                }
                                ProductTable.Rows.Add(row);
                            }//kleini if(ca==2)
                        }//kleini while(myread.read())

                    }
                }

            }

            if (cat.Equals("Networks"))
            {
                string conString = "Provider=MIcrosoft.ACE.OLEDB.12.0; Data Source=" +
              Server.MapPath(" ~/bookstoreDataBase.mdb");
                using (OleDbConnection con = new OleDbConnection(conString))
                {//tha dokimasei na anoiksei ena neo OleDbConnection
                    //an ola pane kala mpainw mesa sto using an oxi dn mpainw mesa sto using
                    con.Open();
                    string query = "select * from product p where p.Category=4 ";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        OleDbDataReader myreader = cmd.ExecuteReader();
                        string output = "";
                        string idProductTostring = "";
                        while (myreader.Read())
                        {

                            int ca = (int)myreader["Category"];
                            CategoryL.Text = "mphka";
                            if (ca == 4)
                            {
                                TableRow row = new TableRow();
                                int countpedia = 0;

                                while (countpedia != 5)
                                {
                                    if (countpedia == 0)
                                    {
                                        int idProduct;
                                        idProduct = (int)myreader["ID"];

                                        idProductTostring = Convert.ToString(idProduct);

                                        TableCell cell = new TableCell();
                                        cell.Text = idProductTostring;
                                        row.Cells.Add(cell);



                                    }
                                    if (countpedia == 1)
                                    {
                                        output = (string)myreader["Title"];
                                        TableCell cell = new TableCell();
                                        cell.Text = output;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 2)
                                    {
                                        output = (string)myreader["Description"];
                                        TableCell cell = new TableCell();
                                        cell.Text = output;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 3)
                                    {
                                        float priceProduct;
                                        priceProduct = (float)myreader["Price"];
                                        string stringpriceProduct = Convert.ToString(priceProduct);
                                        TableCell cell = new TableCell();
                                        cell.Text = stringpriceProduct;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 4)
                                    {
                                        Button Buttonprosthiki = new Button();
                                        Buttonprosthiki.Text = "prothiki sto kalathi";
                                        Buttonprosthiki.ID = idProductTostring;
                                        Buttonprosthiki.Click += new EventHandler(Add);
                                        TableCell cell = new TableCell();
                                        cell.Controls.Add(Buttonprosthiki);
                                        row.Cells.Add(cell);

                                    }
                                    
                                    countpedia++;
                                }
                                ProductTable.Rows.Add(row);
                            }//kleini if(ca==2)
                        }//kleini while(myread.read())

                    }
                }

            }
            if (cat.Equals("Web"))
            {
                string conString = "Provider=MIcrosoft.ACE.OLEDB.12.0; Data Source=" +
              Server.MapPath(" ~/bookstoreDataBase.mdb");
                using (OleDbConnection con = new OleDbConnection(conString))
                {//tha dokimasei na anoiksei ena neo OleDbConnection
                    //an ola pane kala mpainw mesa sto using an oxi dn mpainw mesa sto using
                    con.Open();
                    string query = "select * from product p where p.Category=5 ";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        OleDbDataReader myreader = cmd.ExecuteReader();
                        string output = "";
                        string idProductTostring = "";
                        while (myreader.Read())
                        {

                            int ca = (int)myreader["Category"];
                            CategoryL.Text = "mphka";

                            if (ca == 5)
                            {
                                TableRow row = new TableRow();
                                int countpedia = 0;

                                while (countpedia != 5)
                                {
                                    if (countpedia == 0)
                                    {
                                        int idProduct;
                                        idProduct = (int)myreader["ID"];

                                        idProductTostring = Convert.ToString(idProduct);

                                        TableCell cell = new TableCell();
                                        cell.Text = idProductTostring;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 1)
                                    {
                                        output = (string)myreader["Title"];
                                        TableCell cell = new TableCell();
                                        cell.Text = output;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 2)
                                    {
                                        output = (string)myreader["Description"];
                                        TableCell cell = new TableCell();
                                        cell.Text = output;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 3)
                                    {
                                        float priceProduct;
                                        priceProduct = (float)myreader["Price"];
                                        string stringpriceProduct = Convert.ToString(priceProduct);
                                        TableCell cell = new TableCell();
                                        cell.Text = stringpriceProduct;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 4)
                                    {
                                        Button Buttonprosthiki = new Button();
                                        Buttonprosthiki.Text = "prothiki sto kalathi";
                                        // Buttonprosthiki.ID = Convert.ToString(prId);
                                        Buttonprosthiki.ID = idProductTostring;
                                        Buttonprosthiki.Click += new EventHandler(Add);
                                        TableCell cell = new TableCell();
                                        cell.Controls.Add(Buttonprosthiki);
                                        row.Cells.Add(cell);


                                    }
                                 
                                    countpedia++;
                                }
                                ProductTable.Rows.Add(row);
                            }//kleini if(ca==2)
                        }//kleini while(myread.read())

                    }
                }

            }
        }//kleini page load

        protected void Add(object sender, EventArgs e)
        {

            MultiView1.ActiveViewIndex = 1;
            Button clicked = (Button)sender;
            string clickedId = clicked.ID;
            string idProductTostring = "";
            //Label1.Text = clickedId;

            string conString = "Provider=MIcrosoft.ACE.OLEDB.12.0; Data Source=" +
             Server.MapPath(" ~/bookstoreDataBase.mdb");
            using (OleDbConnection con = new OleDbConnection(conString))
            {//tha dokimasei na anoiksei ena neo OleDbConnection
                //an ola pane kala mpainw mesa sto using an oxi dn mpainw mesa sto using
                con.Open();
                string query = "select * from product p where p.ID= " + clickedId;
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    OleDbDataReader myreader = cmd.ExecuteReader();
                    string output = "";
                    int countpedia = 0;
                    TableRow row = new TableRow();
                    while(myreader.Read()){
                    while (countpedia != 6)
                    {
                        if (countpedia == 0)
                        {
                            int idProduct;
                            idProduct = (int)myreader["ID"];

                            idProductTostring = Convert.ToString(idProduct);

                            TableCell cell = new TableCell();
                            cell.Text = idProductTostring;
                            row.Cells.Add(cell);
                        }
                        if (countpedia == 1)
                        {
                            output = (string)myreader["Title"];
                            TableCell cell = new TableCell();
                            cell.Text = output;
                            row.Cells.Add(cell);
                        }
                        if (countpedia == 2)
                        {
                            output = (string)myreader["Description"];
                            TableCell cell = new TableCell();
                            cell.Text = output;
                            row.Cells.Add(cell);
                        }
                        if (countpedia == 3)
                        {
                            float priceProduct;
                            priceProduct = (float)myreader["Price"];
                            string stringpriceProduct = Convert.ToString(priceProduct);
                            TableCell cell = new TableCell();
                            cell.Text = stringpriceProduct;
                            row.Cells.Add(cell);
                        }
                        if (countpedia == 4)
                        {
                            Button synB = new Button();
                            synB.Text = "+";
                            synB.ID = "synB";
                            synB.Click += new EventHandler(Prosthese);
                            TableCell cell1 = new TableCell();
                            cell1.Controls.Add(synB);
                            row.Cells.Add(cell1);

                            Button meionB = new Button();
                            meionB.Text = "-";
                            meionB.ID = "meionB";
                            meionB.Click += new EventHandler(Afairese);
                            TableCell cell2 = new TableCell();
                            cell2.Controls.Add(meionB);
                            row.Cells.Add(cell2);

                        }
                        if (countpedia == 5)
                        {
                            Button ButtonprosthikiA = new Button();
                            ButtonprosthikiA.Text = "agora";
                            ButtonprosthikiA.ID = idProductTostring;
                            ButtonprosthikiA.Click += new EventHandler(agora);
                            TableCell cell1 = new TableCell();
                            cell1.Controls.Add(ButtonprosthikiA);
                            row.Cells.Add(cell1);

                            Button ButtonprosthikiP = new Button();
                            ButtonprosthikiP.Text = "pisw";
                            ButtonprosthikiP.ID = "BackB";
                            ButtonprosthikiP.Click += new EventHandler(Pisw);
                            TableCell cell2 = new TableCell();
                            cell2.Controls.Add(ButtonprosthikiP);
                            row.Cells.Add(cell2);
                        }
                      
                         
                        countpedia++;
                    }
                    CartTable.Rows.Add(row);
                }
                }//kleini emfoleumeno using
                con.Close();
            }//kleini arixko using
            
        }//kleini h add

        protected void agora(object sender, EventArgs e)
        {
            
        }



        protected void Pisw(object sender, EventArgs e)
        {//thelei douleia
          
           // Response.Redirect("Showcat.aspx?Category=globalCategory");
            MultiView1.ActiveViewIndex = 0;
            string cat = globalCategory;
            CategoryL.Text = "h kathgoria pou epileksate einai : " + cat;
            if (cat.Equals("Programming Languages"))
            {

                string conString = "Provider=MIcrosoft.ACE.OLEDB.12.0; Data Source=" +
               Server.MapPath(" ~/bookstoreDataBase.mdb");
                using (OleDbConnection con = new OleDbConnection(conString))
                {//tha dokimasei na anoiksei ena neo OleDbConnection
                    //an ola pane kala mpainw mesa sto using an oxi dn mpainw mesa sto using
                    con.Open();
                    string query = "select * from product p where p.Category=1 ";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        OleDbDataReader myreader = cmd.ExecuteReader();
                        string output = "";
                        string idProductTostring = "";
                        while (myreader.Read())
                        {

                            int ca = (int)myreader["Category"];
                            if (ca == 1)
                            {
                                TableRow row = new TableRow();
                                int countpedia = 0;

                                while (countpedia != 5)
                                {
                                    if (countpedia == 0)
                                    {
                                        int idProduct;
                                        idProduct = (int)myreader["ID"];

                                        idProductTostring = Convert.ToString(idProduct);

                                        TableCell cell = new TableCell();
                                        cell.Text = idProductTostring;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 1)
                                    {
                                        output = (string)myreader["Title"];
                                        TableCell cell = new TableCell();
                                        cell.Text = output;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 2)
                                    {
                                        output = (string)myreader["Description"];
                                        TableCell cell = new TableCell();
                                        cell.Text = output;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 3)
                                    {
                                        float priceProduct;
                                        priceProduct = (float)myreader["Price"];
                                        string stringpriceProduct = Convert.ToString(priceProduct);
                                        TableCell cell = new TableCell();
                                        cell.Text = stringpriceProduct;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 4)
                                    {
                                        Button Buttonprosthiki = new Button();
                                        Buttonprosthiki.Text = "prothiki sto kalathi";
                                        Buttonprosthiki.ID = idProductTostring;
                                        Buttonprosthiki.Click += new EventHandler(Add);
                                        TableCell cell = new TableCell();
                                        cell.Controls.Add(Buttonprosthiki);
                                        row.Cells.Add(cell);

                                    }

                                    countpedia++;
                                }
                                ProductTable.Rows.Add(row);
                            }
                        }

                    }
                }
            }
            if (cat.Equals("Operating Systems"))
            {
                string conString = "Provider=MIcrosoft.ACE.OLEDB.12.0; Data Source=" +
               Server.MapPath(" ~/bookstoreDataBase.mdb");
                using (OleDbConnection con = new OleDbConnection(conString))
                {//tha dokimasei na anoiksei ena neo OleDbConnection
                    //an ola pane kala mpainw mesa sto using an oxi dn mpainw mesa sto using
                    con.Open();
                    string query = "select * from product p where p.Category=2 ";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        OleDbDataReader myreader = cmd.ExecuteReader();
                        string output = "";
                        string idProductTostring = "";
                        while (myreader.Read())
                        {

                            int ca = (int)myreader["Category"];
                            // CategoryL.Text = "mphka";
                            if (ca == 2)
                            {
                                TableRow row = new TableRow();
                                int countpedia = 0;

                                while (countpedia != 6)
                                {
                                    if (countpedia == 0)
                                    {
                                        int idProduct;
                                        idProduct = (int)myreader["ID"];
                                        idProductTostring = Convert.ToString(idProduct);
                                        TableCell cell = new TableCell();
                                        cell.Text = idProductTostring;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 1)
                                    {
                                        output = (string)myreader["Title"];
                                        TableCell cell = new TableCell();
                                        cell.Text = output;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 2)
                                    {
                                        output = (string)myreader["Description"];
                                        TableCell cell = new TableCell();
                                        cell.Text = output;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 3)
                                    {
                                        float priceProduct;
                                        priceProduct = (float)myreader["Price"];
                                        string stringpriceProduct = Convert.ToString(priceProduct);
                                        TableCell cell = new TableCell();
                                        cell.Text = stringpriceProduct;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 4)
                                    {
                                        Button Buttonprosthiki = new Button();
                                        Buttonprosthiki.Text = "prothiki sto kalathi";
                                        Buttonprosthiki.ID = idProductTostring;
                                        Buttonprosthiki.Click += new EventHandler(Add);
                                        TableCell cell = new TableCell();
                                        cell.Controls.Add(Buttonprosthiki);
                                        row.Cells.Add(cell);

                                    }

                                    countpedia++;
                                }
                                ProductTable.Rows.Add(row);
                            }//kleini if(ca==2)
                        }//kleini while(myread.read())

                    }
                }
            }

            if (cat.Equals("Databases"))
            {
                string conString = "Provider=MIcrosoft.ACE.OLEDB.12.0; Data Source=" +
              Server.MapPath(" ~/bookstoreDataBase.mdb");
                using (OleDbConnection con = new OleDbConnection(conString))
                {//tha dokimasei na anoiksei ena neo OleDbConnection
                    //an ola pane kala mpainw mesa sto using an oxi dn mpainw mesa sto using
                    con.Open();
                    string query = "select * from product p where p.Category=3 ";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        OleDbDataReader myreader = cmd.ExecuteReader();
                        string output = "";
                        string idProductTostring = "";
                        while (myreader.Read())
                        {

                            int ca = (int)myreader["Category"];
                            CategoryL.Text = "mphka";
                            if (ca == 3)
                            {
                                TableRow row = new TableRow();
                                int countpedia = 0;

                                while (countpedia != 5)
                                {
                                    if (countpedia == 0)
                                    {
                                        int idProduct;
                                        idProduct = (int)myreader["ID"];

                                        idProductTostring = Convert.ToString(idProduct);

                                        TableCell cell = new TableCell();
                                        cell.Text = idProductTostring;
                                        row.Cells.Add(cell);



                                    }
                                    if (countpedia == 1)
                                    {
                                        output = (string)myreader["Title"];
                                        TableCell cell = new TableCell();
                                        cell.Text = output;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 2)
                                    {
                                        output = (string)myreader["Description"];
                                        TableCell cell = new TableCell();
                                        cell.Text = output;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 3)
                                    {
                                        float priceProduct;
                                        priceProduct = (float)myreader["Price"];
                                        string stringpriceProduct = Convert.ToString(priceProduct);
                                        TableCell cell = new TableCell();
                                        cell.Text = stringpriceProduct;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 4)
                                    {
                                        Button Buttonprosthiki = new Button();
                                        Buttonprosthiki.Text = "prothiki sto kalathi";
                                        Buttonprosthiki.ID = idProductTostring;
                                        Buttonprosthiki.Click += new EventHandler(Add);
                                        TableCell cell = new TableCell();
                                        cell.Controls.Add(Buttonprosthiki);
                                        row.Cells.Add(cell);

                                    }

                                    countpedia++;
                                }
                                ProductTable.Rows.Add(row);
                            }//kleini if(ca==2)
                        }//kleini while(myread.read())

                    }
                }

            }

            if (cat.Equals("Networks"))
            {
                string conString = "Provider=MIcrosoft.ACE.OLEDB.12.0; Data Source=" +
              Server.MapPath(" ~/bookstoreDataBase.mdb");
                using (OleDbConnection con = new OleDbConnection(conString))
                {//tha dokimasei na anoiksei ena neo OleDbConnection
                    //an ola pane kala mpainw mesa sto using an oxi dn mpainw mesa sto using
                    con.Open();
                    string query = "select * from product p where p.Category=4 ";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        OleDbDataReader myreader = cmd.ExecuteReader();
                        string output = "";
                        string idProductTostring = "";
                        while (myreader.Read())
                        {

                            int ca = (int)myreader["Category"];
                            CategoryL.Text = "mphka";
                            if (ca == 4)
                            {
                                TableRow row = new TableRow();
                                int countpedia = 0;

                                while (countpedia != 5)
                                {
                                    if (countpedia == 0)
                                    {
                                        int idProduct;
                                        idProduct = (int)myreader["ID"];

                                        idProductTostring = Convert.ToString(idProduct);

                                        TableCell cell = new TableCell();
                                        cell.Text = idProductTostring;
                                        row.Cells.Add(cell);



                                    }
                                    if (countpedia == 1)
                                    {
                                        output = (string)myreader["Title"];
                                        TableCell cell = new TableCell();
                                        cell.Text = output;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 2)
                                    {
                                        output = (string)myreader["Description"];
                                        TableCell cell = new TableCell();
                                        cell.Text = output;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 3)
                                    {
                                        float priceProduct;
                                        priceProduct = (float)myreader["Price"];
                                        string stringpriceProduct = Convert.ToString(priceProduct);
                                        TableCell cell = new TableCell();
                                        cell.Text = stringpriceProduct;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 4)
                                    {
                                        Button Buttonprosthiki = new Button();
                                        Buttonprosthiki.Text = "prothiki sto kalathi";
                                        Buttonprosthiki.ID = idProductTostring;
                                        Buttonprosthiki.Click += new EventHandler(Add);
                                        TableCell cell = new TableCell();
                                        cell.Controls.Add(Buttonprosthiki);
                                        row.Cells.Add(cell);

                                    }

                                    countpedia++;
                                }
                                ProductTable.Rows.Add(row);
                            }//kleini if(ca==2)
                        }//kleini while(myread.read())

                    }
                }

            }
            if (cat.Equals("Web"))
            {
                string conString = "Provider=MIcrosoft.ACE.OLEDB.12.0; Data Source=" +
              Server.MapPath(" ~/bookstoreDataBase.mdb");
                using (OleDbConnection con = new OleDbConnection(conString))
                {//tha dokimasei na anoiksei ena neo OleDbConnection
                    //an ola pane kala mpainw mesa sto using an oxi dn mpainw mesa sto using
                    con.Open();
                    string query = "select * from product p where p.Category=5 ";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        OleDbDataReader myreader = cmd.ExecuteReader();
                        string output = "";
                        string idProductTostring = "";
                        while (myreader.Read())
                        {

                            int ca = (int)myreader["Category"];
                            CategoryL.Text = "mphka";

                            if (ca == 5)
                            {
                                TableRow row = new TableRow();
                                int countpedia = 0;

                                while (countpedia != 5)
                                {
                                    if (countpedia == 0)
                                    {
                                        int idProduct;
                                        idProduct = (int)myreader["ID"];

                                        idProductTostring = Convert.ToString(idProduct);

                                        TableCell cell = new TableCell();
                                        cell.Text = idProductTostring;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 1)
                                    {
                                        output = (string)myreader["Title"];
                                        TableCell cell = new TableCell();
                                        cell.Text = output;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 2)
                                    {
                                        output = (string)myreader["Description"];
                                        TableCell cell = new TableCell();
                                        cell.Text = output;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 3)
                                    {
                                        float priceProduct;
                                        priceProduct = (float)myreader["Price"];
                                        string stringpriceProduct = Convert.ToString(priceProduct);
                                        TableCell cell = new TableCell();
                                        cell.Text = stringpriceProduct;
                                        row.Cells.Add(cell);
                                    }
                                    if (countpedia == 4)
                                    {
                                        Button Buttonprosthiki = new Button();
                                        Buttonprosthiki.Text = "prothiki sto kalathi";
                                        // Buttonprosthiki.ID = Convert.ToString(prId);
                                        Buttonprosthiki.ID = idProductTostring;
                                        Buttonprosthiki.Click += new EventHandler(Add);
                                        TableCell cell = new TableCell();
                                        cell.Controls.Add(Buttonprosthiki);
                                        row.Cells.Add(cell);


                                    }

                                    countpedia++;
                                }
                                ProductTable.Rows.Add(row);
                            }//kleini if(ca==2)
                        }//kleini while(myread.read())

                    }
                }

            }
        }//kleini Pisw()


        protected void Prosthese(object sender, EventArgs e)
        {//thelei douleia
            posothta++;
            PosotL.Text = "posothta :" + Convert.ToString(posothta);
            Session["posot"] = posothta;
           
        }
        protected void Afairese(object sender, EventArgs e)
        {//thelei douleia
            posothta--;
            PosotL.Text = "posothta :" + Convert.ToString(posothta);
            Session["posot"] = posothta;
        }

    }//kleini klash 



}//kleini using namespace



