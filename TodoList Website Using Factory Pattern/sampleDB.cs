using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
/// <summary>
/// Summary description for sampleDB
/// </summary>
public class sampleDB
{
	
		//
		// TODO: Add constructor logic here
		//
        public string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\TodoList.mdf;Integrated Security=True";
       // public string InsertNewUserDA(TodoListBusinessObject todoListBO)
    {
       // using (var context = new TodolistDataContext(connectionString))
        {
            try
            {
               // if (context.Connection.State == System.Data.ConnectionState.Closed)
                  //  context.Connection.Open();
                TodoList_UserList obj = new TodoList_UserList()
                {
                   // Id = todoListBO.EmailID;

                }
               // context.TodoList_UsersDetails.InsertOnSubmit(todoListBO.name, todoListBO.EmailID, todoListBO.Pwd, todoListBO.SecurityQuestion, todoListBO.SecurityAnswer, todoListBO.Phone, todoListBO.ZipCode, todoListBO.Country, todoListBO.DateOfBirth, todoListBO.IsActive);

               // context.SubmitChanges();
            }
        
        }
	}
}