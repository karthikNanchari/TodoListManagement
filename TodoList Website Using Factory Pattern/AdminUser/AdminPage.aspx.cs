using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class AdminUser_AdminPage : System.Web.UI.Page
{
    //Page Load Event
    protected void Page_Load(object sender, EventArgs e)
    {
        // Condition to allow only LoggedIn Admin 
        if ((string)Session["EmailID"] == string.Empty || Session["EmailID"] == null || Session["EmailID"] == "")
        {
            string url = "~/WelcomePage.aspx";
            Response.Redirect(url);
        }
        else {

            if (!IsPostBack)
            {
                MultiView.ActiveViewIndex = 0;
                FillDropDownList();
            }

            UserLabel.Text = (string)Session["EmailID"];
        }
        
        
    }

    //Method to Fill DropDownList
    public void FillDropDownList()
    {
        try
        {
            TodoListBusinessObject obj_TodoListBO = new TodoListBusinessObject();
            obj_TodoListBO.EmailID = (string)Session["EmailID"];

            TodoListBusinessLogicFactory obj_UserTodoListBLF = new TodoListBusinessLogicFactory();
            DataSet coll = obj_UserTodoListBLF.CreateTodoListBLF().GetUserEmailBL();
            if (coll != null)
            {

                MailIDDropDownList.DataSource = coll;
                MailIDDropDownList.DataValueField = "EmailID";
                MailIDDropDownList.DataTextField = "EmailID";
                MailIDDropDownList.SelectedIndex = -1;
                MailIDDropDownList.DataBind();

            }
            else
            {
                DataTable dt = new DataTable();
                MailIDDropDownList.DataSource = dt;
                MailIDDropDownList.DataBind();
            }

            if (MultiView.ActiveViewIndex == 1 && coll != null)
            {
                UserMailIDDropDownList.DataSource = coll;
                UserMailIDDropDownList.DataValueField = "EmailID";
                UserMailIDDropDownList.DataTextField = "EmailID";
                UserMailIDDropDownList.SelectedIndex = -1;
                UserMailIDDropDownList.DataBind();
            }
            else
            {
                DataTable dt = new DataTable();
                UserMailIDDropDownList.DataSource = dt;
                UserMailIDDropDownList.DataBind();
            }
        }
        catch {

            GridViewErrorLabel.Text = "Unable to get details ";
        }

    }

    //Event to disable browser BackButton
    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
        string strDisAbleBackButton;
        strDisAbleBackButton = "<script language=\"javascript\">\n";
        strDisAbleBackButton += "window.history.forward(1);\n";
        strDisAbleBackButton += "\n</script>";
        ClientScript.RegisterClientScriptBlock(this.Page.GetType(), "clientScript", strDisAbleBackButton);
    }

    //Method to display Specific ID Lists
    protected void MailIDDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            TodoListBusinessObject obj_TodoGetListsBO = new TodoListBusinessObject();
            obj_TodoGetListsBO.EmailID = MailIDDropDownList.SelectedItem.Text;

            TodoListBusinessLogicFactory obj_TodoListsBLF = new TodoListBusinessLogicFactory();
            DataSet lists = obj_TodoListsBLF.CreateTodoListBLF().GetUserListsBL(obj_TodoGetListsBO);


            if (lists != null)
            {
                UserListsGridView.DataSource = lists.Tables["TodoList_UserLists"];
               
                UserListsGridView.DataBind();
                
            }
            else
            {
                DataTable dt = new DataTable();
                UserListsGridView.DataSource = dt;
                UserListsGridView.DataBind();
            }
        }
        catch {
            GridViewErrorLabel.Text = "Unable to get EmailId's";
        }

    }

    //Method to display Details of Specific ID
    protected void UserMailIDDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            TodoListBusinessObject obj_TodoGetUserDetailsBO = new TodoListBusinessObject();
            string EmailID = UserMailIDDropDownList.SelectedItem.Text;
            obj_TodoGetUserDetailsBO.EmailID = UserMailIDDropDownList.SelectedItem.Text;

            TodoListBusinessLogicFactory obj_TodoListsBLF = new TodoListBusinessLogicFactory();
            DataSet lists = obj_TodoListsBLF.CreateTodoListBLF().GetUserDetailsBL(obj_TodoGetUserDetailsBO);

            DeleteButton.Visible = true;

            if (lists != null)
            {
                UserDetailsGridView.DataSource = lists.Tables["TodoList_UserDetails"];
                UserDetailsGridView.DataBind();
            }
            else
            {
                DataTable dt = new DataTable();
                UserDetailsGridView.DataSource = dt;
                UserDetailsGridView.DataBind();
            }
        }
        catch {
            ErrorLabel.Text = "Details Loading Error";
        }

    }

    //View Change Button Click event
    protected void UserDetailsButton_Click(object sender, EventArgs e)
    {
        MultiView.ActiveViewIndex = 1;
        FillDropDownList();
        DeleteButton.Visible = false;

    }

    //View Change Button Click event
    protected void UserListsButton_Click(object sender, EventArgs e)
    {
        MultiView.ActiveViewIndex = 0;
    }

    //Event to delete selected User details
    protected void DeleteButton_Click(object sender, EventArgs e)
    {
        try
        {

            string confirmValue = Request.Form["confirmDelete_value"];
            if (confirmValue == "Yes") {
                if (UserMailIDDropDownList.SelectedItem.Text != (string)Session["EmailID"])
                {
                    TodoListBusinessObject obj_TodoDeleteUserDetailsBO = new TodoListBusinessObject();
                    if (UserMailIDDropDownList.SelectedItem.Text != null || UserMailIDDropDownList.SelectedItem.Text != "")
                    {
                        obj_TodoDeleteUserDetailsBO.EmailID = UserMailIDDropDownList.SelectedItem.Text;
                        ErrorLabel.Visible = false;
                    }
                    else
                    {
                        ErrorLabel.Text = "Please Select User";
                    }

                    TodoListBusinessLogicFactory obj_TodoListsBLF = new TodoListBusinessLogicFactory();
                    obj_TodoListsBLF.CreateTodoListBLF().DeleteCompleteListsBL(obj_TodoDeleteUserDetailsBO);

                    DataSet user = obj_TodoListsBLF.CreateTodoListBLF().DeleteUserBL(obj_TodoDeleteUserDetailsBO);
                    if (user == null)
                    {
                        DataTable dt = new DataTable();
                        UserDetailsGridView.DataSource = dt;
                        UserDetailsGridView.DataBind();
                    }
                    UserDetailsGridView.DataBind();
                    FillDropDownList();
                    UserMailIDDropDownList.ClearSelection();
                }
                else
                {
                    ErrorLabel.Text = "You can't Delete the Logged in Admin";
                }
            
            }
            
        }
        catch {
            ErrorLabel.Text = "Unable to Delete User";
        }
    }

    //Event to Logout Logged in Admin
    protected void LogoutLinkButton_Click(object sender, EventArgs e)
    {
        Session["EmailID"] = "";

        string url = "~/WelcomePage.aspx";
        Response.Redirect(url);
    }

}