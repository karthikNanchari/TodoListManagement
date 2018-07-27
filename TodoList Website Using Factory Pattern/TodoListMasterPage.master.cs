using System;
using System.Timers ;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class TodoListMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //to display time into time label
       TimerLabel.Text = DateTime.Now.ToString("T");

    }
}
