using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Net.Mail;
using System.IO;

public partial class UserLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //if ((string)Session["EmailID"] == (string.Empty) || Session["EmailID"] == null || Session["EmailID"] == "")
            if((string.IsNullOrEmpty((string)Session["EmailID"])))
        {
            string url = "~/WelcomePage.aspx";
            Response.Redirect(url);
        }
        else
        {

            if (!IsPostBack)
            {
                UserMultiView.ActiveViewIndex = 0;
                FillGridView();
            }

            EditTable.Visible = false;
            AddTable.Visible = false;
            EmailTextBox.Visible = false;
            EmailLabel.Visible = false;
            SendEmailButton.Visible = false;

            UserLabel.Text = (String)Session["EmailID"];

        }


    }

    //Method to fill todoList Details into GridVieew
    protected void FillGridView()
    {
        try
        {
            TodoListBusinessObject obj_TodoListBO = new TodoListBusinessObject();
            obj_TodoListBO.EmailID = (string)Session["EmailID"];

            TodoListBusinessLogicFactory obj_UserTodoListBLF = new TodoListBusinessLogicFactory();
            DataSet coll = obj_UserTodoListBLF.CreateTodoListBLF().GetUserListsBL(obj_TodoListBO);

            if (coll != null)
            {
                UserListsGridView.DataSource = coll.Tables["TodoList_UserLists"];


                UserListsGridView.DataBind();
            }
            else
            {
                DataTable dt = new DataTable();
                UserListsGridView.DataSource = dt;
                UserListsGridView.DataBind();
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

    //Event to Add/Edit Lists
    protected void AddEditButton_Click(object sender, EventArgs e)
    {
        try
        {
            UserMultiView.ActiveViewIndex = 1;

            TodoListBusinessObject obj_TodoListBO = new TodoListBusinessObject();
            obj_TodoListBO.EmailID = (string)Session["EmailID"];

            TodoListBusinessLogicFactory obj_UserTodoListBLF = new TodoListBusinessLogicFactory();
            DataSet coll = obj_UserTodoListBLF.CreateTodoListBLF().GetUserListsBL(obj_TodoListBO);

            if (coll != null)
            {
                EditGridView.DataSource = coll.Tables["TodoList_UserLists"];
                EditGridView.DataBind();
            }
            else
            {
                DataTable dt = new DataTable();
                EditGridView.DataSource = dt;
                EditGridView.DataBind();
            }
            EditTable.Visible = false;
            AddTable.Visible = false;
        }
        catch
        {
            ErrorLabel.Text = "Unable to Load button";
        }
    }

    //Event to Edit selected TodoList
    protected void EditButton_Click(object sender, EventArgs e)
    {
        try
        {
            int count = 0;
            foreach (GridViewRow gridvrow in EditGridView.Rows)
            {
                CheckBox editdetailscheck = (CheckBox)gridvrow.FindControl("SelectCheckBox");
                if (editdetailscheck != null && editdetailscheck.Checked)
                {
                    count++;
                    ErrorSelectionLabel.Visible = false;
                    EditTable.Visible = true;
                    foreach (GridViewRow gvslkrow in EditGridView.Rows)
                    {
                        CheckBox editcheck = (CheckBox)gvslkrow.FindControl("SelectCheckBox");
                        if (editcheck != null && editcheck.Checked)
                        {
                            EditTitleTextBox.Text = gvslkrow.Cells[1].Text;
                            EditDescriptionTextBox.Text = gvslkrow.Cells[2].Text;

                            TodoListBusinessObject obj_TodoListBO = new TodoListBusinessObject();
                            obj_TodoListBO.TitleOld = gvslkrow.Cells[1].Text;

                            foreach(GridViewRow grid in EditGridView.Rows )
                            {

                                CheckBox uncheck = (CheckBox)grid.FindControl("SelectCheckBox");
                                uncheck.Enabled = false;

                            }
                        }
                    }
                }
                else
                {
                    if (count == 0)
                    {
                        ErrorSelectionLabel.Visible = true;
                        ErrorSelectionLabel.Text = "Please select a row and then click Edit";
                    }
                }
            }
        }
        catch
        {
            ErrorSelectionLabel.Visible = true;
            ErrorSelectionLabel.Text = "Unable to load Button";
        }
    }

    //Event to Delete Selected TodoList
    protected void DeleteButton_Click(object sender, EventArgs e)
    {
        try
        {
            int count = 0;
            foreach (GridViewRow gridvrow in EditGridView.Rows)
            {
                CheckBox editdetailscheck = (CheckBox)gridvrow.FindControl("SelectCheckBox");
                if (editdetailscheck != null && editdetailscheck.Checked)
                {
                    count++;

                    TodoListBusinessObject obj_DeleteListBO = new TodoListBusinessObject();
                    obj_DeleteListBO.EmailID = (String)Session["EmailID"];
                    obj_DeleteListBO.IsArchive = true;

                    foreach (GridViewRow gvslkrow in EditGridView.Rows)
                    {
                        CheckBox chk = (CheckBox)gvslkrow.FindControl("SelectCheckBox");
                        if (chk != null && chk.Checked)
                        {
                            obj_DeleteListBO.Title = gvslkrow.Cells[1].Text;
                            obj_DeleteListBO.Description = gvslkrow.Cells[2].Text;


                            foreach (GridViewRow grid in EditGridView.Rows)
                            {

                                CheckBox uncheck = (CheckBox)grid.FindControl("SelectCheckBox");
                                uncheck.Enabled = false;

                            }

                        }
                    }

                    TodoListBusinessLogicFactory objDeleteBLLFactRow = new TodoListBusinessLogicFactory();
                    objDeleteBLLFactRow.CreateTodoListBLF().DeleteUserListBL(obj_DeleteListBO);


                    TodoListBusinessObject obj_TodoListBO = new TodoListBusinessObject();
                    obj_TodoListBO.EmailID = (string)Session["EmailID"];

                    TodoListBusinessLogicFactory obj_UserTodoListBLF = new TodoListBusinessLogicFactory();
                    DataSet coll = obj_UserTodoListBLF.CreateTodoListBLF().GetUserListsBL(obj_TodoListBO);

                    ErrorSelectionLabel.Visible = false;
                    if (coll != null)
                    {
                        EditGridView.DataSource = coll.Tables["TodoList_UserLists"];
                        EditGridView.DataBind();
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        EditGridView.DataSource = dt;
                        EditGridView.DataBind();
                    }
                }
                else
                {
                    if (count == 0)
                    {
                        ErrorSelectionLabel.Visible = true;
                        ErrorSelectionLabel.Text = "Please select a row and then click Delete";
                    }

                }
            }

        }

        catch
        {
            ErrorSelectionLabel.Visible = true;
            ErrorSelectionLabel.Text = "Unable to load button";
        }
    }

    //Event to add List to TodoLists
    protected void AddButton_Click(object sender, EventArgs e)
    {
        ErrorSelectionLabel.Visible = false;
        AddTable.Visible = true;
        {
            AddDescriptionTextBox.Text = "";
            AddTitleTextBox.Text = "";
        }
    }

    //Event to submit Edited List
    protected void EditSubmitButton_Click(object sender, EventArgs e)
    {
        if (EditTitleTextBox.Text != null && EditDescriptionTextBox.Text != null)
        {
            TodoListBusinessObject obj_TodolistBO = new TodoListBusinessObject();
            obj_TodolistBO.TitleNew = EditTitleTextBox.Text;
            obj_TodolistBO.EmailID = (string)Session["EmailID"];
            obj_TodolistBO.Description = EditDescriptionTextBox.Text;

            foreach (GridViewRow gvslkrow in EditGridView.Rows)
            {
                CheckBox chk = (CheckBox)gvslkrow.FindControl("SelectCheckBox");
                if (chk != null && chk.Checked)
                {
                    obj_TodolistBO.TitleOld = gvslkrow.Cells[1].Text;
                }
            }

            obj_TodolistBO.CreatedDate = (System.DateTime.Now.Date.ToShortDateString());
            TodoListBusinessLogicFactory obj_UserDetailsBLF = new TodoListBusinessLogicFactory();
            ErrorSelectionLabel.Text = obj_UserDetailsBLF.CreateTodoListBLF().UpdateUserListBL(obj_TodolistBO);


            TodoListBusinessObject obj_TodoListBO = new TodoListBusinessObject();
            obj_TodoListBO.EmailID = (string)Session["EmailID"];

            TodoListBusinessLogicFactory obj_UserTodoListBLF = new TodoListBusinessLogicFactory();
            DataSet coll = obj_UserTodoListBLF.CreateTodoListBLF().GetUserListsBL(obj_TodoListBO);

            if (coll != null)
            {
                EditGridView.DataSource = coll.Tables["TodoList_UserLists"];
                EditGridView.DataBind();
                EditTitleTextBox.Text = "";
                AddTitleTextBox.Text = "";
            }
            else
            {
                DataTable dt = new DataTable();
                EditGridView.DataSource = dt;
                EditGridView.DataBind();
            }
        }
        else
        {
            if (EditTitleTextBox.Text == null || EditTitleTextBox.Text == "")
            {
                TitleErrorLabel.Text = "Please Enter Title";
            }
            else if (EditDescriptionTextBox.Text == null || EditDescriptionTextBox.Text == "")
            {
                DescriptionErrorLabel.Text = "Please Enter Description";
            }
        }
    }

    //Event to submit and add list
    protected void AddSubmitButton_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(AddTitleTextBox.Text) && (!string.IsNullOrEmpty(AddDescriptionTextBox.Text)))
        {
            TodoListBusinessObject obj_InsertListBO = new TodoListBusinessObject();
            obj_InsertListBO.EmailID = (string)Session["EmailID"];
            obj_InsertListBO.CreatedDate = (DateTime.Today.Date.ToShortDateString());
            obj_InsertListBO.Title = AddTitleTextBox.Text;
            obj_InsertListBO.Description = AddDescriptionTextBox.Text;
            obj_InsertListBO.IsActive = true;
            obj_InsertListBO.IsArchive = false;
            TodoListBusinessLogicFactory obj_InsertListBLF = new TodoListBusinessLogicFactory();
            DataSet coll = obj_InsertListBLF.CreateTodoListBLF().InsertUserListsBL(obj_InsertListBO);

            TodoListBusinessObject obj_TodoListBO = new TodoListBusinessObject();
            obj_TodoListBO.EmailID = (string)Session["EmailID"];

            TodoListBusinessLogicFactory obj_UserTodoListBLF = new TodoListBusinessLogicFactory();
            obj_UserTodoListBLF.CreateTodoListBLF().GetUserArchiveBL(obj_TodoListBO);

            if (coll != null)
            {
                EditGridView.DataSource = coll.Tables["TodoList_UserLists"];
                EditGridView.DataBind();
                EditTitleTextBox.Text = "";
                AddTitleTextBox.Text = "";

            }
            else
            {
                DataTable dt = new DataTable();
                EditGridView.DataSource = dt;
                EditGridView.DataBind();
            }
        }
        else
        {
            if (AddTitleTextBox.Text == null)
            {
                TitleErrorLabel.Text = "Please Enter Title";
            }
            else
                DescriptionErrorLabel.Text = "Please Enter Description";
        }
    }

    //Event to get seleted list to edit 
    protected void EditGridView_SelectedIndexChanged(object sender, EventArgs e)
    {
        EditTitleTextBox.Text = EditGridView.SelectedRow.Cells[1].Text;
        AddTitleTextBox.Text = EditGridView.SelectedRow.Cells[2].Text;
    }

    //Event to send selected list to completed List
    protected void ArchiveButton_Click(object sender, EventArgs e)
    {


        TodoListBusinessObject obj_SendArchiveListBO = new TodoListBusinessObject();
        obj_SendArchiveListBO.EmailID = (String)Session["EmailID"];
        obj_SendArchiveListBO.IsArchive = false;

        foreach (GridViewRow gvslkrow in EditGridView.Rows)
        {
            CheckBox chk = (CheckBox)gvslkrow.FindControl("SelectCheckBox");
            if (chk != null && chk.Checked)
            {
                obj_SendArchiveListBO.Title = gvslkrow.Cells[1].Text;
                obj_SendArchiveListBO.Description = gvslkrow.Cells[2].Text;
                ErrorSelectionLabel.Visible = false;

            }
            else
            {
                ErrorSelectionLabel.Text = "Please Select a List";
            }
        }

        if (ErrorSelectionLabel.Text == null || ErrorSelectionLabel.Text == "")
        {
            ErrorSelectionLabel.Visible = false;
        }

        TodoListBusinessLogicFactory obj_SendArchiveBLF = new TodoListBusinessLogicFactory();
        obj_SendArchiveBLF.CreateTodoListBLF().SendToArchiveUserListBL(obj_SendArchiveListBO);


        TodoListBusinessObject obj_TodoListBO = new TodoListBusinessObject();
        obj_TodoListBO.EmailID = (string)Session["EmailID"];

        TodoListBusinessLogicFactory obj_UserTodoListBLF = new TodoListBusinessLogicFactory();
        DataSet coll = obj_UserTodoListBLF.CreateTodoListBLF().GetUserListsBL(obj_TodoListBO);

        if (coll != null)
        {
            EditGridView.DataSource = coll.Tables["TodoList_UserLists"];
            EditGridView.DataBind();
        }
        else
        {
            DataTable dt = new DataTable();
            EditGridView.DataSource = dt;
            EditGridView.DataBind();
        }

    }

    //Event to  open Email sending option for sending TodoLists to a MailId
    protected void EmailButton_Click(object sender, EventArgs e)
    {
        EmailTextBox.Visible = true;
        EmailLabel.Visible = true;
        SendEmailButton.Visible = true;

    }

    //Event to send email to entered EmailId
    protected void SendEmailButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (EmailTextBox.Text != null)
            {
                using (StringWriter stringWriter = new StringWriter())
                {

                    using (HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter))
                    {
                        UserListsGridView.RenderControl(htmlTextWriter);
                        StringReader stringReader = new StringReader(stringWriter.ToString());
                        MailMessage mailMessage = new MailMessage("karthikaspdotnet@gmail.com", EmailTextBox.Text);
                        mailMessage.Subject = "TodoList";
                        mailMessage.Body = "TodoList:<hr/>" + stringWriter.ToString();
                        mailMessage.IsBodyHtml = true;
                        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                        smtpClient.Credentials = new System.Net.NetworkCredential()
                        {
                            UserName = "karthikaspdotnet@gmail.com",
                            Password = "karthik*123"
                        };
                        smtpClient.EnableSsl = true;
                        smtpClient.Send(mailMessage);

                        ErrorLabel.Text = "Email Sent Successfully";
                    }
                }

            }
            else
            {
                ErrorLabel.Text = "Please Enter EmailID to send";
            }
        }
        catch (Exception E)
        {
            ErrorLabel.Text = "Please Try Again Later";
        }
    }

    //Event to Logout logged in user
    protected void LogOutLinkButton_Click(object sender, EventArgs e)
    {
        Session["EmailID"] = "";

        string url = "~/WelcomePage.aspx";
        Response.Redirect(url);
    }
}