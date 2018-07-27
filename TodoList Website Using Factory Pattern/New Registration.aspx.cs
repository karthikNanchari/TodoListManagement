using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using TodoListBusinessObject;
//using TodoListBusinessLogicFactory;

public partial class New_Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            AgeCalendar.Visible = false;
            LoginButton.Visible = false;
            ErrorMessageLabel.Visible = false;
            SubmissionLabel.Visible = false;
        }
    }

    //Event to submit the user details
    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        try
        {
            TodoListBusinessObject obj_TodolistBO = new TodoListBusinessObject();

            obj_TodolistBO.name = NewUserTextBox.Text;
            obj_TodolistBO.EmailID = NewUserEmailTextBox.Text;

            TodoListBusinessLogicFactory obj_TodoBLF = new TodoListBusinessLogicFactory();
            bool isAvailable = obj_TodoBLF.CreateTodoListBLF().IsAvailableEmailBL(obj_TodolistBO);
            if (isAvailable == true)
            {
                ErrorMessageLabel.Visible = true;
                ErrorMessageLabel.Text = "EmailId Already Registered";
            }
            else
            {
                ErrorMessageLabel.Visible = false;
                if (Page.IsValid)
                {
                    obj_TodolistBO.name = NewUserTextBox.Text;
                    obj_TodolistBO.EmailID = NewUserEmailTextBox.Text;
                    obj_TodolistBO.Pwd = PwdTextBox.Text;
                    obj_TodolistBO.SecurityQuestion = SecurityQTextBox.Text;
                    obj_TodolistBO.SecurityAnswer = SecurityAnsTextBox.Text;
                    obj_TodolistBO.DateOfBirth = AgeCalendar.SelectedDate.Date.ToShortDateString();
                    obj_TodolistBO.Phone = PhoneTextBox.Text;
                    obj_TodolistBO.Country = CountryTextBox.Text;
                    obj_TodolistBO.ZipCode = Convert.ToInt32(ZipCodeTextBox.Text);
                    obj_TodolistBO.IsActive = true;

                    TodoListBusinessLogicFactory obj_TodoListBLF = new TodoListBusinessLogicFactory();
                    string status = obj_TodoListBLF.CreateTodoListBLF().InsertNewUserBL(obj_TodolistBO);

                    SubmissionLabel.Visible = true;
                    SubmissionLabel.Text = status;

                    LoginButton.Visible = true;
                }
            }
        }
        catch
        {
            if (ErrorMessageLabel.Text == null)
                ErrorMessageLabel.Text = "Input Error";
        }
    }

    //Event to fill the calendar textbox with  selected calendar dates 
    protected void AgeCalendar_SelectionChanged(object sender, EventArgs e)
    {
        AgeTextBox.Text = AgeCalendar.SelectedDate.ToShortDateString();
        AgeCalendar.Visible = false;
    }

    //Event to clear the user input
    protected void ClearInputButton_Click(object sender, EventArgs e)
    {
        NewUserTextBox.Text = "";
        NewUserEmailTextBox.Text = "";
        PwdTextBox.Text = "";
        ReEnterPwdTextBox.Text = "";
        SecurityQTextBox.Text = "";
        SecurityAnsTextBox.Text = "";
        AgeTextBox.Text = "";
        PhoneTextBox.Text = "";
        CountryTextBox.Text = "";
        ZipCodeTextBox.Text = "";
    }

    //Event to allow to pick date from calender 
    protected void CalendarImageButton_Click1(object sender, ImageClickEventArgs e)
    {
        AgeCalendar.Visible = true;

    }

    //Event to direct the user to land page
    protected void LoginButton_Click(object sender, EventArgs e)
    {
        string url = "~/WelcomePage.aspx";
        Response.Redirect(url);

    }

}