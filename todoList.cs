using System;
using System.Collections.Generic;
using System.Text;

namespace container
{
    public class Todo
    {   public DateOnly dates = new DateOnly();
        public Todo(string title,string description,DateOnly date)
        {

             Title = title;
             Description = description;
             
             this.dates = date;
             status = "not completed yet";
        }
         
        public string Title { get; set; }
        public string Description { get; set; }
        public string date { get; set; }
        public string status { get;set;}

    }
}