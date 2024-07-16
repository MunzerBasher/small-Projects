using System;
using ToDoBusinessLayer;
namespace ToDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(clsTask.AddTask("1","1",1,1,1,"1",1))
            {
                Console.WriteLine("Add Successful !");
            }
        }
    }
}
