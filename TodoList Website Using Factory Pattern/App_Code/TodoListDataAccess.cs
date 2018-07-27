using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using TodoListBusinessObject;
using System.Data.SqlClient;
using System.Data;
using System.Data.Linq;

public class TodoListDataAccess
{

  

    public string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\TodoList.mdf;Integrated Security=True";

    //Method to insert new user
    public string InsertNewUserDA(TodoListBusinessObject todoListBO)
    {
        using (var context = new TodolistDataContext(connectionString))
        {
            try
            {
                if (context.Connection.State == System.Data.ConnectionState.Closed)
                    context.Connection.Open();
                //context.InsertOnSubmit(todoListBO);
                context.InsertNewUser(todoListBO.name, todoListBO.EmailID, todoListBO.Pwd, todoListBO.SecurityQuestion, todoListBO.SecurityAnswer, todoListBO.Phone, todoListBO.ZipCode, todoListBO.Country, todoListBO.DateOfBirth, todoListBO.IsActive);
               
                context.SubmitChanges();

                return "The User Registered Successfully";
            }
            catch
            {
                return "The User Did Not Register";
            }
            finally
            {
                context.Connection.Close();
            }

        }
    }

    //Method to Update User Details
    public void UpdateUserDetailsDA(TodoListBusinessObject todoListBO)
    {
        using (var context = new TodolistDataContext(connectionString))
        {
            if (context.Connection.State == System.Data.ConnectionState.Closed)
                context.Connection.Open();

            context.InsertNewUser(todoListBO.name, todoListBO.EmailID, todoListBO.Pwd, todoListBO.SecurityQuestion, todoListBO.SecurityAnswer, todoListBO.Phone, todoListBO.ZipCode, todoListBO.Country, todoListBO.DateOfBirth, todoListBO.IsActive);
            
            context.SubmitChanges();
        }
    }

    //Method to Validate User
    public bool ValidateUserDA(TodoListBusinessObject todoListBO)
    {
        try
        {
            using (var context = new TodolistDataContext(connectionString))
            {
                if (context.Connection.State == System.Data.ConnectionState.Closed)
                    context.Connection.Open();

                bool isValid = context.UserValidate(todoListBO.EmailID, todoListBO.Pwd).Any();
                return isValid;
            }
        }
        catch
        {

            return false;
        }
    }

    //Method to Validate User who forgot password
    public bool ValidateUserForgotPwdDA(TodoListBusinessObject todoListBO)
    {
        try
        {
            using (var context = new TodolistDataContext(connectionString))
            {
                if (context.Connection.State == System.Data.ConnectionState.Closed)
                    context.Connection.Open();

                bool isValid = context.UserValidForgotPwd(todoListBO.EmailID).Any();
                return isValid;
            }
        }
        catch
        {

            return false;
        }
    }
    //MEthod to validate users who are inactive
    public bool UserValidateInActiveDA(TodoListBusinessObject todoListBO)
    {
        try
        {
            using (var context = new TodolistDataContext(connectionString))
            {
                if (context.Connection.State == System.Data.ConnectionState.Closed)
                    context.Connection.Open();

                bool isValid = context.UserValidateInActive(todoListBO.EmailID, todoListBO.Pwd).Any();
                return isValid;
            }
        }
        catch
        {

            return false;
        }
    }

    //Method to check if the Email is already registered
    public bool IsAvailableEmailDA(TodoListBusinessObject todoListBO)
    {
        try
        {
            using (var context = new TodolistDataContext(connectionString))
            {
                if (context.Connection.State == System.Data.ConnectionState.Closed)
                    context.Connection.Open();

                bool isAvailable = context.IsAvailable(todoListBO.EmailID).Any();
                return isAvailable;
            }
        }
        catch
        {
            return false;
        }
    }

    //Method to insert the user details
    public DataSet InsertUserDetailsDA(TodoListBusinessObject todoListBO) 
    {



        using (  TodolistDataContext td = new TodolistDataContext())   //TodoListDataContext db = new DataContext())
        {
           // Child c = new Child();
            //c.ForeignKeyID = SomeID;

            
            //td.InsertOnSubmit(c);
           // td.SubmitChanges();
        }




        
        using (var context = new TodolistDataContext(connectionString))
        {
            if (context.Connection.State == System.Data.ConnectionState.Closed)
                context.Connection.Open();
            context.InsertUserLists(todoListBO.EmailID, todoListBO.CreatedDate, todoListBO.Title, todoListBO.Description, todoListBO.IsActive, todoListBO.IsArchive);



          





            SqlDataAdapter da = new SqlDataAdapter("GetUserLists", connectionString);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(new SqlParameter("@EmailID", SqlDbType.Text));
            da.SelectCommand.Parameters["@EmailID"].Value = todoListBO.EmailID;
            DataSet ds = new DataSet();
            da.Fill(ds, "TodoList_UserLists");
            return ds;
        }
    }

    //Method to get selected user Details
    public DataSet GetUserDetailsDA(TodoListBusinessObject todoListBO)
    {

        using (var context = new TodolistDataContext(connectionString))
        {
            if (context.Connection.State == System.Data.ConnectionState.Closed)
                context.Connection.Open();

            SqlDataAdapter da = new SqlDataAdapter("GetUserDetails", connectionString);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(new SqlParameter("@EmailID", SqlDbType.Text));
            da.SelectCommand.Parameters["@EmailID"].Value = todoListBO.EmailID;
            DataSet ds = new DataSet();
            da.Fill(ds, "TodoList_UserDetails");
            return ds;
        }
    }

    //public List<GetUserListsResult> GetUserListsDA(TodoListBusinessObject todoListBO)
    //Method to get seleted user lists
    public DataSet GetUserListsDA(TodoListBusinessObject todoListBO)
    {

        using (var context = new TodolistDataContext(connectionString))
        {
            if (context.Connection.State == System.Data.ConnectionState.Closed)
                context.Connection.Open();

            //List<GetUserListsResult> x = context.GetUserLists("karthik@gmail.com").ToList();

            SqlDataAdapter da = new SqlDataAdapter("GetUserLists", connectionString);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(new SqlParameter("@EmailID", SqlDbType.Text));
            da.SelectCommand.Parameters["@EmailID"].Value = todoListBO.EmailID;
            DataSet ds = new DataSet();
            da.Fill(ds, "TodoList_UserLists");
            return ds;

            //return ds;
            //return List<GetUserListsResult>;
        }
    }

    //Method to get user completed Lists
    public DataSet GetUserArchiveDA(TodoListBusinessObject todoListBO)
    {

        using (var context = new TodolistDataContext(connectionString))
        {
            if (context.Connection.State == System.Data.ConnectionState.Closed)
                context.Connection.Open();

            SqlDataAdapter da = new SqlDataAdapter("GetArchive", connectionString);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(new SqlParameter("@EmailID", SqlDbType.Text));
            da.SelectCommand.Parameters["@EmailID"].Value = todoListBO.EmailID;
            DataSet ds = new DataSet();
            da.Fill(ds, "TodoList_UserLists");
            return ds;
        }
    }

    //Method to update user list
    public string UpdateUserListsDA(TodoListBusinessObject todoListBO)
    {
        using (var context = new TodolistDataContext(connectionString))
            try
            {
                {
                    if (context.Connection.State == System.Data.ConnectionState.Closed)
                        context.Connection.Open();
                    context.UpdateList(todoListBO.EmailID, todoListBO.TitleOld, todoListBO.TitleNew, todoListBO.Description, todoListBO.CreatedDate);
                    return "User List Updated Successfully";
                }
            }
            catch
            {
                return "User List Not Updated";
            }
            finally
            {
                context.Connection.Close();
            }
    }

    //Method to delete selected user Lists
    public DataSet DeleteUserListDA(TodoListBusinessObject todoListBO)
    {

        using (var context = new TodolistDataContext(connectionString))
        {
            try
            {
                if (context.Connection.State == System.Data.ConnectionState.Closed)
                    context.Connection.Open();
                context.DeleteUserList(todoListBO.EmailID, todoListBO.Title, todoListBO.Description);

                SqlDataAdapter da = new SqlDataAdapter("GetUserLists", connectionString);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add(new SqlParameter("@EmailID", SqlDbType.Text));
                da.SelectCommand.Parameters["@EmailID"].Value = todoListBO.EmailID;
                DataSet ds = new DataSet();
                da.Fill(ds, "TodoLists_UserLists");
                return ds;
            }
            catch
            {
                DataSet ds = new DataSet();
                return ds;

            }
            finally
            {
                context.Connection.Close();
            }
        }
    }

    //Method to delete all User Lists
    public DataSet DeleteCompleteListsDA(TodoListBusinessObject todoListBO)
    {
        using (var context = new TodolistDataContext(connectionString))
        {
            try
            {
                if (context.Connection.State == System.Data.ConnectionState.Closed)
                    context.Connection.Open();
                context.DeleteCompleteLists(todoListBO.EmailID);

                SqlDataAdapter da = new SqlDataAdapter("DeleteCompleteLists", connectionString);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add(new SqlParameter("@EmailID", SqlDbType.Text));
                da.SelectCommand.Parameters["@EmailID"].Value = todoListBO.EmailID;
                DataSet ds = new DataSet();
                da.Fill(ds, "TodoLists_UserLists");
                return ds;
            }
            catch
            {
                DataSet ds = new DataSet();
                return ds;
            }
            finally
            {
                context.Connection.Close();
            }
        }
    }

    //Method to delete User
    public DataSet DeleteUserDA(TodoListBusinessObject todoListBO)
    {
        using (var context = new TodolistDataContext(connectionString))
        {
            try
            {
                if (context.Connection.State == System.Data.ConnectionState.Closed)
                    context.Connection.Open();
                context.DeleteUser(todoListBO.EmailID);

                SqlDataAdapter da = new SqlDataAdapter("DeleteUser", connectionString);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add(new SqlParameter("@EmailID", SqlDbType.Text));
                da.SelectCommand.Parameters["@EmailID"].Value = todoListBO.EmailID;
                DataSet ds = new DataSet();
                da.Fill(ds, "TodoLists_UserDetails");
                return ds;
            }
            catch
            {
                DataSet ds = new DataSet();
                return ds;
            }
            finally
            {
                context.Connection.Close();
            }
        }
    }

    //Method to get user EmailID's
    public DataSet GetUserEmailsDA()
    {
        using (var context = new TodolistDataContext(connectionString))
        {
            try
            {
                if (context.Connection.State == System.Data.ConnectionState.Closed)
                    context.Connection.Open();

                context.GetUserMailIds(true);
                SqlDataAdapter da = new SqlDataAdapter("GetUserMailIds", connectionString);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add(new SqlParameter("@IsActive", SqlDbType.Bit));
                da.SelectCommand.Parameters["@IsActive"].Value = true;
                DataSet ds = new DataSet();
                da.Fill(ds, "TodoList_UserDetails");
                return ds;
            }
            catch
            {
                DataSet ds = new DataSet();
                return ds;
            }
            finally
            {
                context.Connection.Close();
            }

        }
    }

    //method to send User lists to completed List
    public DataSet SendToArchiveUserListDA(TodoListBusinessObject todoListBO)
    {

        using (var context = new TodolistDataContext(connectionString))
        {

            try
            {
                if (context.Connection.State == System.Data.ConnectionState.Closed)
                    context.Connection.Open();
                context.SendToArchiveUserList(todoListBO.EmailID, todoListBO.Title, todoListBO.Description, todoListBO.IsArchive);

                SqlDataAdapter da = new SqlDataAdapter("GetUserLists", connectionString);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add(new SqlParameter("@EmailID", SqlDbType.Text));
                da.SelectCommand.Parameters["@EmailID"].Value = todoListBO.EmailID;
                DataSet ds = new DataSet();
                da.Fill(ds, "UserLIsts");
                return ds;
            }
            catch
            {
                DataSet ds = new DataSet();
                return ds;
            }
            finally
            {
                context.Connection.Close();
            }
        }
    }

    //Method to change completed Lists to TodoLists
    public DataSet UnArchiveUserListDA(TodoListBusinessObject todoListBO)
    {
        using (var context = new TodolistDataContext(connectionString))
        {
            try
            {
                if (context.Connection.State == System.Data.ConnectionState.Closed)
                    context.Connection.Open();
                context.UnArchive(todoListBO.EmailID, todoListBO.Title, todoListBO.Description, todoListBO.IsArchive);

                SqlDataAdapter da = new SqlDataAdapter("GetUserLists", connectionString);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add(new SqlParameter("@EmailID", SqlDbType.Text));
                da.SelectCommand.Parameters["@EmailID"].Value = todoListBO.EmailID;
                DataSet ds = new DataSet();
                da.Fill(ds, "UserLIsts");
                return ds;
            }
            catch
            {
                DataSet ds = new DataSet();
                return ds;
            }
            finally
            {
                context.Connection.Close();
            }
        }
    }

    //Method to DeActivae User
    public bool DeActivateUserDA(TodoListBusinessObject todoListBO)
    {
        using (var context = new TodolistDataContext(connectionString))
            try
            {
                {
                    if (context.Connection.State == System.Data.ConnectionState.Closed)
                        context.Connection.Open();

                    context.DeActivate(todoListBO.EmailID, todoListBO.IsActive);
                    return true;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                context.Connection.Close();
            }
    }

    //Method to Activate User
    public bool ActivateUserDA(TodoListBusinessObject todoListBO)
    {
        using (var context = new TodolistDataContext(connectionString))
            try
            {
                {
                    if (context.Connection.State == System.Data.ConnectionState.Closed)
                        context.Connection.Open();

                    context.ReActivate(todoListBO.EmailID);
                    return true;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                context.Connection.Close();
            }
    }

    // public List<GetSecurityQnResult> GetSecurityQnDA(TodoListBusinessObject todoListBO)
    //Method to Get security Question
    public DataSet GetSecurityQnDA(TodoListBusinessObject todoListBO)
    {
        using (var context = new TodolistDataContext(connectionString))
        try
        {
            {
                if (context.Connection.State == System.Data.ConnectionState.Closed)
                    context.Connection.Open();

                //List<GetSecurityQnResult> x = context.GetSecurityQn(todoListBO.EmailID).ToList();
                // context.GetSecurityQn(todoListBO.EmailID);

                SqlDataAdapter da = new SqlDataAdapter("GetSecurityQn", connectionString);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add(new SqlParameter("@EmailID", SqlDbType.VarChar));
                da.SelectCommand.Parameters["@EmailID"].Value = todoListBO.EmailID;
                DataSet ds = new DataSet();
                da.Fill(ds, "TodoList_UserDetails");
                return ds;
            }
        }
        catch
        {
            DataSet ds = new DataSet();
            return ds;
        }
        finally {
            context.Connection.Close();
        }
    }

    //Method to get security Answer
    public DataSet GetSecurityAnsDA(TodoListBusinessObject todoListBO)
    {
        using (var context = new TodolistDataContext(connectionString))
            try
            {
                {
                    if (context.Connection.State == System.Data.ConnectionState.Closed)
                        context.Connection.Open();

                    //var question = context.GetSecurityAns(todoListBO.EmailID);
                    SqlDataAdapter da = new SqlDataAdapter("GetSecurityAns", connectionString);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@EmailID", SqlDbType.VarChar));
                    da.SelectCommand.Parameters["@EmailID"].Value = todoListBO.EmailID;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "TodoList_UserDetails");
                    return ds;
                }
            }
            catch
            {
                DataSet ds = new DataSet();
                return ds;
            }
            finally {
                context.Connection.Close();
            }
    }

}
