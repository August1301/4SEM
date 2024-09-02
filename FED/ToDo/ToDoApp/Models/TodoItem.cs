using System;
using System.Runtime.Intrinsics.X86;
using SQLite;

namespace ToDoApp.Models;

public class TodoItem
{
    [PrimaryKey,AutoIncrement]
    public int Id{get;set;}
    public string Title{get;set;}
    public DateTime Due{get;set;}
    public bool Done{get;set;} = false;
}
