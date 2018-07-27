using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class LogedInUser_UserTodoListArchive : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["EmailID"] == string.Empty || Session["EmailID"] == null || Session["EmailID"] == "")
        {
            string url = "~/WelcomePage.aspx";
            Response.Redirect(url);
        }
        else
        {
            if (!IsPostBack)
            {
                FillGridView();
            }
            UserLabel.Text = (string)Session["EmailID"];
        }
    }

    //Method to Fill Completed lists into Grid View
    protected void FillGridView()
    {
        try
        {
            TodoListBusinessObject obj_TodoListBO = new TodoListBusinessObject();
            obj_TodoListBO.EmailID = (string)Session["EmailID"];

            TodoListBusinessLogicFactory obj_UserTodoListBLF = new TodoListBusinessLogicFactory();
            DataSet coll = obj_UserTodoListBLF.CreateTodoListBLF().GetUserArchiveBL(obj_TodoListBO);

            if (coll != null)
            {

                UserArchiveGridView.DataSource = coll.Tables["TodoList_UserLists"];
                UserArchiveGridView.DataBind();
            }
            else
            {
                DataTable dt = new DataTable();
                UserArchiveGridView.DataSource = dt;
                UserArchiveGridView.DataBind();
            }
        }
        catch
        {
            ErrorLabel.Text = "Error Filling GridView";
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

    //Event to delete selected List
    protected void DeleteButton_Click(object sender, EventArgs e)
    {
        try
        {


            foreach (GridViewRow gvslrow in UserArchiveGridView.Rows)
            {

                CheckBox chek = (CheckBox)gvslrow.FindControl("SelectCheckBox");
                if (chek != null && chek.Checked)
                {
                    ErrorLabel.Visible = false;

                    TodoListBusinessObject obj_DeleteListBO = new TodoListBusinessObject();
                    obj_DeleteListBO.EmailID = (String)Session["EmailID"];
                    obj_DeleteListBO.IsArchive = false;

                    foreach (GridViewRow gvslkrow in UserArchiveGridView.Rows)
                    {
                        CheckBox chk = (CheckBox)gvslkrow.FindControl("SelectCheckBox");
                        if (chk != null && chk.Checked)
                        {
                            obj_DeleteListBO.Title = gvslkrow.Cells[1].Text;
                            obj_DeleteListBO.Description = gvslkrow.Cells[2].Text;
                            ErrorLabel.Visible = false;

                            foreach (GridViewRow grid in UserArchiveGridView.Rows)
                            {

                                CheckBox uncheck = (CheckBox)grid.FindControl("SelectCheckBox");
                                uncheck.Enabled = false;

                            }
                        }
                        else
                        {
                            ErrorLabel.Text = "Please Select a Item to Delete";
                            ErrorLabel.Visible = true;
                        }
                    }

                    TodoListBusinessLogicFactory objDeleteBLLFactRow = new TodoListBusinessLogicFactory();
                    objDeleteBLLFactRow.CreateTodoListBLF().DeleteUserListBL(obj_DeleteListBO);

                    TodoListBusinessObject obj_TodoListBO = new TodoListBusinessObject();
                    obj_TodoListBO.EmailID = (string)Session["EmailID"];

                    TodoListBusinessLogicFactory obj_UserTodoListBLF = new TodoListBusinessLogicFactory();
                    DataSet coll = obj_UserTodoListBLF.CreateTodoListBLF().GetUserArchiveBL(obj_TodoListBO);

                    if (coll != null)
                    {
                        UserArchiveGridView.DataSource = coll.Tables["TodoList_UserLists"];
                        UserArchiveGridView.DataBind();
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        UserArchiveGridView.DataSource = dt;
                        UserArchiveGridView.DataBind();
                    }

                }
                else
                {

                    ErrorLabel.Text = "Please Select a Item to Delete";
                    ErrorLabel.Visible = true;

                }

            }
        }
        catch
        {
            ErrorLabel.Text = "Unable to load Delete Button";
        }

    }

    //Event to send back completed List Item to Todo Lists
    protected void SendBackButton_Click(object sender, EventArgs e)
    {
        try
        {
            foreach (GridViewRow gridrow in UserArchiveGridView.Rows)
            {
                CheckBox check = (CheckBox)gridrow.FindControl("SelectCheckBox");
                if (check != null && check.Checked)
                {
                    ErrorLabel.Visible = false;

                    TodoListBusinessObject obj_UnArchiveListBO = new TodoListBusinessObject();
                    obj_UnArchiveListBO.EmailID = (String)Session["EmailID"];
                    obj_UnArchiveListBO.IsArchive = false;

                    foreach (GridViewRow gvslkrow in UserArchiveGridView.Rows)
                    {
                        CheckBox chk = (CheckBox)gvslkrow.FindControl("SelectCheckBox");
                        if (chk != null && chk.Checked)
                        {
                            obj_UnArchiveListBO.Title = gvslkrow.Cells[1].Text;
                            obj_UnArchiveListBO.Description = gvslkrow.Cells[2].Text;
                            ErrorLabel.Visible = false;
                        }
                        else
                        {
                            ErrorLabel.Text = "Please Select a Item to send to TodoList";
                            ErrorLabel.Visible = true;
                        }
                    }

                    TodoListBusinessLogicFactory obj_UnArchiveBLF = new TodoListBusinessLogicFactory();
                    obj_UnArchiveBLF.CreateTodoListBLF().UnArchiveUserListBL(obj_UnArchiveListBO);


                    TodoListBusinessObject obj_TodoListBO = new TodoListBusinessObject();
                    obj_TodoListBO.EmailID = (string)Session["EmailID"];

                    TodoListBusinessLogicFactory obj_UserTodoListBLF = new TodoListBusinessLogicFactory();
                    DataSet coll = obj_UserTodoListBLF.CreateTodoListBLF().GetUserArchiveBL(obj_TodoListBO);

                    if (coll != null)
                    {
                        UserArchiveGridView.DataSource = coll.Tables["TodoList_UserLists"];
                        UserArchiveGridView.DataBind();
                        ErrorLabel.Visible = false;
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        UserArchiveGridView.DataSource = dt;
                        UserArchiveGridView.DataBind();
                    }
                }
                else
                {

                    ErrorLabel.Text = "Please Select a Item to send to TodoList";
                }

            }

        }
        catch
        {
            ErrorLabel.Text = "Error Sending Back Item";
        }
    }

    //Event to Logout Loggedin user
    protected void LogoutLinkButton_Click(object sender, EventArgs e)
    {
        Session["EmailID"] = "";

        string url = "~/WelcomePage.aspx";
        Response.Redirect(url);
    }
}
