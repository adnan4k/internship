using System;
using System.Collections.Generic;
using System.Text;
using container;
using TodoApp;


namespace Todos
{

class program
{
    public static void Main(String[] args)
    {
       
    Console.WriteLine("hello from the todo console application");
    Console.WriteLine("select from the menu");

    Console.WriteLine("1. add tasks");
    Console.WriteLine("2. display tasks by title");
    Console.WriteLine("3. mark taks");
    Console.WriteLine("4. view all tasks");
    Console.WriteLine("5. delete tasks by title ");
    Console.WriteLine("6. exit");

    var userInput = Console.ReadLine();
    var operation = new Operations();
    DateOnly validDate = new DateOnly(2022, 1, 1);

    while(true){

    switch(userInput)
    {
        case  "1":
        Console.WriteLine("enter the title of the task");
        var title = Console.ReadLine();
        Console.WriteLine("enter description");
        var description = Console.ReadLine();
        Console.WriteLine("enter date in mm/dd/yyyy format");
       
        try{
        var date = Console.ReadLine();
         validDate = DateOnly.Parse(date);
        }catch(Exception e){
            Console.WriteLine("enter valid format "+ e.Message);
        }
        
        

        var todo = new Todo(title,description,validDate);
        operation.addTask(todo);
        break;

         case  "2":
         Console.WriteLine("enter the title ");
         var titles = Console.ReadLine();
         operation.displayByTitle(titles);
        break;

         case  "3":
         Console.WriteLine("enter title to mark task");
         var markTitle = Console.ReadLine();
         Console.WriteLine("enter  completed or any text to mark as completed");
         var mark = Console.ReadLine();
         operation.markTask(markTitle,mark);
        
        break;

         case  "4":
         
         operation.displayAllTask();
        
        break;
         case  "5":
         Console.WriteLine("enter title of task to be removed");
         var removedTitle= Console.ReadLine();
         operation.removeByTitle(removedTitle);
        
        break;

        case "6":
        return;
        default:
        Console.WriteLine("wrong option");
        break;
    }
    Console.WriteLine("select operations");
    userInput = Console.ReadLine();
    }
    Console.WriteLine(validDate);

    }
    
}
}