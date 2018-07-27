using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;



public class TodoListBusinessLogic
{
    //method to register a new user
    public string InsertNewUserBL(TodoListBusinessObject todoListBO)
    {
        TodoListDataAccessFactory obj_TodoListDAF = new TodoListDataAccessFactory();
       return obj_TodoListDAF.CreateTodoListDAF().InsertNewUserDA(todoListBO);
    }

    //method to validate the login user details
    public bool ValidateUserBL(TodoListBusinessObject todoListBO)
    {
        TodoListDataAccessFactory objValidateDALFactory = new TodoListDataAccessFactory();
        return objValidateDALFactory.CreateTodoListDAF().ValidateUserDA(todoListBO);
    }

    public bool UserValidateInActiveBL(TodoListBusinessObject todoListBO)
    {
        TodoListDataAccessFactory objValidateDALFactory = new TodoListDataAccessFactory();
        return objValidateDALFactory.CreateTodoListDAF().UserValidateInActiveDA(todoListBO);
    }

    //To validate user who forgot password
        public bool ValidateUserForgotPwdBL(TodoListBusinessObject todoListBO)
    {
        TodoListDataAccessFactory objValidateDALFactory = new TodoListDataAccessFactory();
        return objValidateDALFactory.CreateTodoListDAF().ValidateUserForgotPwdDA(todoListBO);
    }

    //method to check if the emailid is already registered
    public bool IsAvailableEmailBL(TodoListBusinessObject todoListBO)
    {
        TodoListDataAccessFactory obj_IsAvalableEmailDAF  = new TodoListDataAccessFactory();
        return obj_IsAvalableEmailDAF.CreateTodoListDAF().IsAvailableEmailDA(todoListBO);
    }

    //method to insert into todolist
    public DataSet InsertUserListsBL(TodoListBusinessObject todoListBO)
    {
        TodoListDataAccessFactory obj_InsertUserListsDAF = new TodoListDataAccessFactory();
        return obj_InsertUserListsDAF.CreateTodoListDAF().InsertUserDetailsDA(todoListBO);

    }

    //method to get todolists for user
    public DataSet GetUserListsBL(TodoListBusinessObject todoListBO)
    {
        TodoListDataAccessFactory obj_GetUserListsDAF = new TodoListDataAccessFactory();
        return obj_GetUserListsDAF.CreateTodoListDAF().GetUserListsDA(todoListBO);

    }

    //Method to get selected user Details
    public DataSet GetUserDetailsBL(TodoListBusinessObject todoListBO) {
        TodoListDataAccessFactory obj_GetUserDetailsDAF = new TodoListDataAccessFactory();
        return  obj_GetUserDetailsDAF.CreateTodoListDAF().GetUserDetailsDA(todoListBO) ;
    }

    //method to get archive todolists of user
    public DataSet GetUserArchiveBL(TodoListBusinessObject todoListBO)
    {
        TodoListDataAccessFactory obj_GetUserArchiveDAF = new TodoListDataAccessFactory();
        return obj_GetUserArchiveDAF.CreateTodoListDAF().GetUserArchiveDA(todoListBO);

    }

    //method to update user todolists
    public string UpdateUserListBL(TodoListBusinessObject todoListBO)
    {
        TodoListDataAccessFactory obj_UpdateUserListDAF= new TodoListDataAccessFactory();
        return obj_UpdateUserListDAF.CreateTodoListDAF().UpdateUserListsDA(todoListBO);
    }

    //Method to delete UserList
    public DataSet DeleteUserListBL(TodoListBusinessObject todoListBO)
    {
        TodoListDataAccessFactory obj_DeleteUserListDAF = new TodoListDataAccessFactory();
        return obj_DeleteUserListDAF.CreateTodoListDAF().DeleteUserListDA(todoListBO);
    }

    //Method to delete Seleted User
    public DataSet DeleteUserBL(TodoListBusinessObject todoListBO)
    {
        TodoListDataAccessFactory obj_DeleteUserDAF = new TodoListDataAccessFactory();
        return obj_DeleteUserDAF.CreateTodoListDAF().DeleteUserDA(todoListBO);
    }

    //Method to delete Complete Lists of User
    public DataSet DeleteCompleteListsBL(TodoListBusinessObject todoListBO)
    {
        TodoListDataAccessFactory obj_DeleteCompleteListsDAF = new TodoListDataAccessFactory();
        return obj_DeleteCompleteListsDAF.CreateTodoListDAF().DeleteCompleteListsDA(todoListBO);
    }

    //Method to send Selected List to Completed 
    public DataSet SendToArchiveUserListBL(TodoListBusinessObject todoListBO)
    {
        TodoListDataAccessFactory obj_SendArchiveUserListDAF = new TodoListDataAccessFactory();
        return obj_SendArchiveUserListDAF.CreateTodoListDAF().SendToArchiveUserListDA(todoListBO);
    }

    //Method to send completed List to todoList
    public DataSet UnArchiveUserListBL(TodoListBusinessObject todoListBO)
    {
        TodoListDataAccessFactory obj_SendArchiveUserListDAF = new TodoListDataAccessFactory();
        return obj_SendArchiveUserListDAF.CreateTodoListDAF().UnArchiveUserListDA(todoListBO);
    }

    //method to fill the admin drop down list
    public DataSet GetUserEmailBL()
    {
        TodoListDataAccessFactory obj_GetUserEmailDAF = new TodoListDataAccessFactory();
        return obj_GetUserEmailDAF.CreateTodoListDAF().GetUserEmailsDA();
    }

    //Method to De Activate User
    public bool DeActivateUserBL(TodoListBusinessObject todoListBO)
    {
        TodoListDataAccessFactory obj_DeActivateDLF = new TodoListDataAccessFactory();
        return obj_DeActivateDLF.CreateTodoListDAF().DeActivateUserDA(todoListBO);
    }

    //Method to Activate User
    public bool ActivateUserBL(TodoListBusinessObject todoListBO)
    {
        TodoListDataAccessFactory obj_ActivateDAF = new TodoListDataAccessFactory();
        return obj_ActivateDAF.CreateTodoListDAF().ActivateUserDA(todoListBO);
    }

    //Method to Get security question of selected User
    public DataSet GetSecurityQnBL(TodoListBusinessObject todoListBO)
    {
        TodoListDataAccessFactory obj_GetSecurityQnDAF = new TodoListDataAccessFactory();
        return obj_GetSecurityQnDAF.CreateTodoListDAF().GetSecurityQnDA(todoListBO);

    }

    //Method to Get Security Answer of selected User
    public DataSet GetSecurityAnsBL(TodoListBusinessObject todoListBO)
    {
        TodoListDataAccessFactory obj_GetSecurityAnsDAF = new TodoListDataAccessFactory();
        return obj_GetSecurityAnsDAF.CreateTodoListDAF().GetSecurityAnsDA(todoListBO);

    }

}