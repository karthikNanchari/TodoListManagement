//ServerSide Course Project Work
//WebSite: TodoList Manager
//Programmer: Karthik Nanchari
//kxn27570@gmail.com
//700662757


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WelcomePage : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["EmailID"] = ""; 

    }
    
}