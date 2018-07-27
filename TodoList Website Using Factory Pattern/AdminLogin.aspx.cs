using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SecurityQnLabel.Visible = false;
        SecurityQuestionLabel.Visible = false;
        SecurityAnswerLabel.Visible = false;
        SecurityAnsLabel.Visible = false;
        SecurityAnsTextBox.Visible = false;
        SecuritySubmitButton.Visible = false;
        SecurityAnswerRequiredFieldValidator.Visible = false;
    }

    //Event to evaluate login credentials and direct to land page
    protected void AdminSignInButton_Click(object sender, EventArgs e)
    {
        try
        {
            TodoListBusinessObject obj_AdminLoginBO = new TodoListBusinessObject();
            obj_AdminLoginBO.EmailID = AdminNameTextBox.Text;
            obj_AdminLoginBO.Pwd = AdminPwdTextBox.Text;

            TodoListBusinessLogicFactory obj_AdminLoginBLF = new TodoListBusinessLogicFactory();
            bool isValid = obj_AdminLoginBLF.CreateTodoListBLF().ValidateUserBL(obj_AdminLoginBO);

            if (isValid == true)
            {

                //redirect to next page
                Session["EmailID"] = AdminNameTextBox.Text;

                string url = "~/AdminUser/AdminPage.aspx?";
                Response.Redirect(url);
            }
            else
            {
                ErrorLabel.Text = "UserID or Password is Incorrect";
            }
        }
        catch
        {
            ErrorLabel.Text = "Error Occured";
        }
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

    //Event to submit security answer and redirect to page 
    protected void SecuritySubmitButton_Click(object sender, EventArgs e)
    {
        TodoListBusinessObject obj_TodoListBO = new TodoListBusinessObject();
        obj_TodoListBO.EmailID = AdminNameTextBox.Text;

        TodoListBusinessLogicFactory obj_TodoListBL = new TodoListBusinessLogicFactory();
          DataSet answer = obj_TodoListBL.CreateTodoListBLF().GetSecurityAnsBL(obj_TodoListBO);

          string ans = answer.Tables[0].Rows[0]["SecurityAnswer"].ToString();

        if (SecurityAnsTextBox.Text.Equals(ans))
        {
            Session["EmailID"] = AdminNameTextBox.Text;

            string url = "~/AdminUser/AdminPage.aspx?";
            Response.Redirect(url);
        }
        else {
            ErrorLabel.Text = "Incorrect Answer";
        }
    }

    //Event to open forgot password textboxes to provide inputs
    protected void ForgotPasswordButton_Click(object sender, EventArgs e)
    {
        if (AdminNameTextBox.Text == string.Empty || AdminNameTextBox.Text == null)
        {
            ErrorLabel.Text = "Please Enter User EmailId";
        }
        else
        {

           TodoListBusinessObject obj_TodoListBO = new TodoListBusinessObject();
            obj_TodoListBO.EmailID = AdminNameTextBox.Text;
                

                TodoListBusinessLogicFactory obj_ValidateBLF = new TodoListBusinessLogicFactory();
                bool isValid = obj_ValidateBLF.CreateTodoListBLF().ValidateUserForgotPwdBL(obj_TodoListBO);
                if (isValid == true)
                {

                    TodoListBusinessLogicFactory obj_TodoListBL = new TodoListBusinessLogicFactory();
                    DataSet question = obj_TodoListBL.CreateTodoListBLF().GetSecurityQnBL(obj_TodoListBO);
                    SecurityQuestionLabel.Text = question.Tables[0].Rows[0]["SecurityQuestion"].ToString();

                    SecurityQnLabel.Visible = true;
                    SecurityQuestionLabel.Visible = true;
                    SecurityAnswerLabel.Visible = true;
                    SecurityAnsLabel.Visible = true;
                    SecurityAnsTextBox.Visible = true;
                    SecuritySubmitButton.Visible = true;

                }
                else {

                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Invalid EmailId";
                }
        }
    }

    protected void Unnamed1_SelectedNodeChanged(object sender, EventArgs e)
    {

    }
}