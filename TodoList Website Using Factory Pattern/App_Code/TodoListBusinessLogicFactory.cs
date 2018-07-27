using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class TodoListBusinessLogicFactory
{
    public TodoListBusinessLogic CreateTodoListBLF()
    {
        return (new TodoListBusinessLogic());
    }
}