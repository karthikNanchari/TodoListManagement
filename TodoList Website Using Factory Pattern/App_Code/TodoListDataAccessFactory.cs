using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class TodoListDataAccessFactory
{

    public TodoListDataAccess CreateTodoListDAF()
    {
        return (new TodoListDataAccess());
    }
	
}