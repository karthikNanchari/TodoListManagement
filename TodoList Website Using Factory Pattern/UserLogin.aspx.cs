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
using System.Windows.Forms;
using System.Data;

public partial class UserLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            LoginMultiView.ActiveViewIndex = 0;
        }

        SecurityQnLabel.Visible = false;
        SecurityQuestionLabel.Visible = false;
        SecurityAnswerLabel.Visible = false;
        SecurityAnsLabel.Visible = false;
        SecurityAnsTextBox.Visible = false;
        SecurityAnsSubmitButton.Visible = false;


    }

    //Event to Disable Browser BackButton
    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
        string strDisAbleBackButton;
        strDisAbleBackButton = "<script language=\"javascript\">\n";
        strDisAbleBackButton += "window.history.forward(1);\n";
        strDisAbleBackButton += "\n</script>";
        ClientScript.RegisterClientScriptBlock(this.Page.GetType(), "clientScript", strDisAbleBackButton);
    }

    //Event to check credentials and login User
    protected void LoginButton_Click(object sender, EventArgs e)
    {
        try
        {
            if ((UserNameTextBox.Text != "" && PasswordTextBox.Text != "") && ((UserNameTextBox.Text != null && PasswordTextBox.Text != null)))
            {
                TodoListBusinessObject obj_UserLoginBO = new TodoListBusinessObject();
                obj_UserLoginBO.EmailID = UserNameTextBox.Text;
                obj_UserLoginBO.Pwd = PasswordTextBox.Text;

                TodoListBusinessLogicFactory obj_ValidateBLF = new TodoListBusinessLogicFactory();
                bool isValid = obj_ValidateBLF.CreateTodoListBLF().ValidateUserBL(obj_UserLoginBO);
                if (isValid == true)
                {
                    //redirect to land next page
                    Session["EmailID"] = UserNameTextBox.Text;

                    string url = "~/LogedInUser/UserTodoListLand.aspx?";
                    Response.Redirect(url);
                }
                else
                {
                    ErrorLabel.Text = "UserID or Password is Incorrect";
                }
            }
            else
            {
                if (UserNameTextBox.Text == null || UserNameTextBox.Text == string.Empty)
                {
                    ErrorLabel.Text = "Please Enter the EmailId";
                }
                else
                {

                    ErrorLabel.Text = "Please Enter Password";
                }
            }

        }
        catch
        {

            ErrorLabel.Text = "Error Occured";
        }

    }

    //Event to deactivate User
    protected void DeActiveButton_Click(object sender, EventArgs e)
    {

        try
        {
            string confirmValue = Request.Form["confirm_value"];
            if (confirmValue == "Yes")
            {

                TodoListBusinessObject obj_UserDeActivateBO = new TodoListBusinessObject();
                obj_UserDeActivateBO.EmailID = DeActivateMailTextbox.Text;
                obj_UserDeActivateBO.Pwd = DeActivatePwdTextbox.Text;

                TodoListBusinessLogicFactory obj_ValidateBLF = new TodoListBusinessLogicFactory();
                bool isValid = obj_ValidateBLF.CreateTodoListBLF().ValidateUserBL(obj_UserDeActivateBO);
                if (isValid == true)
                {
                    //TodoListBusinessObject obj_DeActivateUserBO = new TodoListBusinessObject();
                    obj_UserDeActivateBO.IsActive = false;

                    TodoListBusinessLogicFactory obj_DeActivateBLF = new TodoListBusinessLogicFactory();
                    bool deActivate = obj_DeActivateBLF.CreateTodoListBLF().DeActivateUserBL(obj_UserDeActivateBO);

                    if (deActivate == true)
                    {
                        DeActivateErrLabel.Text = " Account is Successfully DeActivated ";
                    }
                    else
                    {
                        DeActivateErrLabel.Text = "Unable to deactivate Account";
                    }

                }
                else
                {
                    DeActivateErrLabel.Text = "Invalid Account Details Or Account Is Deactive";
                }
            }

        }
        catch
        {

            ErrorLabel.Text = "Error Occured";
        }
    }

    //Event to direct user to deactivate view
    protected void DeActivateViewButton_Click(object sender, EventArgs e)
    {
        LoginMultiView.ActiveViewIndex = 1;
    }

    //Event to direct User Login view
    protected void LoginViewButton_Click(object sender, EventArgs e)
    {
        LoginMultiView.ActiveViewIndex = 0;
    }

    //Event to direct User to login view 
    protected void ViewLoginButton_Click(object sender, EventArgs e)
    {
        LoginMultiView.ActiveViewIndex = 0;

    }

    //Event to Activate User
    protected void ActivateButton_Click(object sender, EventArgs e)
    {
        try
        {
            string confirmValue = Request.Form["confirm_value"];
            if (confirmValue == "Yes")
            {
                TodoListBusinessObject obj_UserActivateBO = new TodoListBusinessObject();
                obj_UserActivateBO.EmailID = ActivateEmailTextbox.Text;
                obj_UserActivateBO.Pwd = ActivatePwdTextbox.Text;

                TodoListBusinessLogicFactory obj_ValidateBLF = new TodoListBusinessLogicFactory();
                bool isValid = obj_ValidateBLF.CreateTodoListBLF().UserValidateInActiveBL(obj_UserActivateBO);
                if (isValid == true)
                {
                    //TodoListBusinessObject obj_DeActivateUserBO = new TodoListBusinessObject();
                    obj_UserActivateBO.IsActive = true;

                    TodoListBusinessLogicFactory obj_ActivateBLF = new TodoListBusinessLogicFactory();
                    bool Activate = obj_ActivateBLF.CreateTodoListBLF().ActivateUserBL(obj_UserActivateBO);

                    if (Activate == true)
                    {
                        ActivateErrLabel.Text = " Account is Successfully Activated ";
                    }
                    else
                    {
                        ActivateErrLabel.Text = "Unable to deactivate Account";
                    }

                }
                else
                {
                    ActivateErrLabel.Text = "Invalid Account Details or Account already Active";
                }
            }
        }
        catch
        {
            ErrorLabel.Text = "Error Occured";
            //ErrorLabel.ForeColor;

        }

    }

    //Event to direct User Activate view 
    protected void ActivateViewButton_Click(object sender, EventArgs e)
    {
        LoginMultiView.ActiveViewIndex = 2;
    }

    //Event to open security Question and Answer textboxes and Labels 
    protected void ForgotPwdButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (UserNameTextBox.Text == string.Empty || UserNameTextBox.Text == null)
            {
                ErrorLabel.Text = "Please Enter User EmailId";
            }
            else
            {
                TodoListBusinessObject obj_UserBO = new TodoListBusinessObject();
                obj_UserBO.EmailID = UserNameTextBox.Text;
                

                TodoListBusinessLogicFactory obj_ValidateBLF = new TodoListBusinessLogicFactory();
                bool isValid = obj_ValidateBLF.CreateTodoListBLF().ValidateUserForgotPwdBL(obj_UserBO);
                if (isValid == true)
                {
                    ErrorLabel.Visible = false;

                    TodoListBusinessObject obj_TodoListBO = new TodoListBusinessObject();
                    obj_TodoListBO.EmailID = UserNameTextBox.Text;


                    TodoListBusinessLogicFactory obj_TodoListBL = new TodoListBusinessLogicFactory();
                    DataSet question = obj_TodoListBL.CreateTodoListBLF().GetSecurityQnBL(obj_TodoListBO);
                    SecurityQnLabel.Text = question.Tables[0].Rows[0]["SecurityQuestion"].ToString();

                    SecurityQnLabel.Visible = true;
                    SecurityQuestionLabel.Visible = true;
                    SecurityAnswerLabel.Visible = true;
                    SecurityAnsLabel.Visible = true;
                    SecurityAnsTextBox.Visible = true;
                    SecurityAnsSubmitButton.Visible = true;

                }
                else {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Invalid EmailId";
                }
                

            }
        }
        catch {
            ErrorLabel.Visible = true;
            ErrorLabel.Text = "Input Error";
        }
    }

    //Event to submit security Answer
    protected void SecurityAnsSubmitButton_Click(object sender, EventArgs e)
    {
        try
        {
            TodoListBusinessObject obj_TodoListBO = new TodoListBusinessObject();
            obj_TodoListBO.EmailID = UserNameTextBox.Text;

            TodoListBusinessLogicFactory obj_TodoListBL = new TodoListBusinessLogicFactory();
            DataSet answer = obj_TodoListBL.CreateTodoListBLF().GetSecurityAnsBL(obj_TodoListBO);

            string ans = answer.Tables[0].Rows[0]["SecurityAnswer"].ToString();

            if (SecurityAnsTextBox.Text.Equals(ans))
            {
                Session["EmailID"] = UserNameTextBox.Text;

                string url = "~/LogedInUser/UserTodoListLand.aspx?";
                Response.Redirect(url);
            }
            else
            {
                ErrorLabel.Text = "Incorrect Answer";
            }
        }
        catch {
            ErrorLabel.Text = "Unable to check Security Answer";
        }
    }
}


