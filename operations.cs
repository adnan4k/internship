using System;
using System.Collections.Generic;
using System.Text;
using container;


namespace TodoApp
{
 class Operations
 {
    public List<Todo> task = new List<Todo>();
    
    //the following method add tasks
    public void showAll(Todo tasks)
    {
      Console.WriteLine($"Title: {tasks.Title}\n Description:{tasks.Description}\n Date: {tasks.dates}\n {tasks.status}");

        }
    
    public void addTask(Todo tasks)
    {
        task.Add(tasks);
    }
    //display all tasks and their corresponding information
    public void displayAll(List<Todo> task)
    {
        if(task.Count == 0 || task == null)
        {
            Console.WriteLine("sorry the list is empty, please add tasks by entering 1");
        }
        foreach(var tasks in task)
        {
            Console.WriteLine($"Title: {tasks.Title}\n Description:{tasks.Description}\n Date: {tasks.dates}\n Status:{tasks.status}");
        }
    }
    
    public void displayByTitle(String title)
    {
        var matchingTitle = task.FirstOrDefault(t =>t.Title == title);
        string match = matchingTitle.ToString();
        if(string.IsNullOrEmpty(match))
        {
            throw new ArgumentNullException("no task found");
        }
        Todo matchingTitles = matchingTitle;
        showAll(matchingTitles);
        
            
    }
        
            
    //mark tasks
    public void markTask(string title,string status)
    {
          var matchingTitle = task.FirstOrDefault(t =>t.Title == title);
          matchingTitle.status = status;
          Console.WriteLine($"you marked your task as {status}");
    }
      
    //remove by title
    public void removeByTitle(string givenTitle)
    {
       var removedItem = task.SingleOrDefault(r =>r.Title == givenTitle);
       if(removedItem == null)
       {
        Console.WriteLine($"no item to be removed");
       }
       task.Remove(removedItem);

       Console.WriteLine($"you successfully removed the task named: {givenTitle}");
    }
    public void displayAllTask()
    {
        displayAll(task);
    }

 }
}