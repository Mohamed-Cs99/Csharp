using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Program
    {

        struct task
        {
           public string title;
           public string description;
           public DateTime dueDate;
           public bool isCompleted; 

        }

        static task[] myTasks = new task[100];
        static int counter = 0;

        static void CreateTask()
        {
            Console.Write("Please insert task title : ");
            string title = Console.ReadLine();
            Console.Write("Please insert task description : "); 
            string description = Console.ReadLine();
            Console.Write("Please insert task dueDate : "); 
            DateTime dueDate =Convert.ToDateTime(Console.ReadLine());

            task t = new task
            {
                title = title,
                description = description,
                dueDate = dueDate,
                isCompleted = false
            };
            myTasks[counter] = t;
            counter++;

            Console.WriteLine("Task Created Successfully . "); 

        }

        static void ViewTask()
        {
            
            if(counter==0)
            {
                Console.WriteLine("No Tasks Found ");
                return; 
            }
            else
            {
                Console.WriteLine("All Tasks ...."); 
                for(int i = 0; i < counter; i++ )
                {

                    Console.WriteLine("Title : "+ myTasks[i].title);
                    Console.WriteLine("Description : " + myTasks[i].description); 
                    Console.WriteLine("Date : "+ myTasks[i].dueDate.ToString("yyyy-MM-dd"));
                    Console.WriteLine("Status : " + (myTasks[i].isCompleted ? "Completed" : "Pending"));


                    Console.WriteLine(); 

                }
               
            }
           
        }

        static void MarkAsCompleted()
        {
            Console.WriteLine("Please Enter Task title to mark as completed !"); 
            string tit = Console.ReadLine();
            bool found = false; 
            for(int i = 0;i < counter; i++ )
            {
                task xt = myTasks[i];
                if (tit.Equals(xt.title))
                {
                    xt.isCompleted = true;
                    myTasks[i] = xt; 
                    Console.WriteLine("Task Marked As Completed ."); 
                    found = true;
                    break; 
                }
            }
            if(!found)
            {
                Console.WriteLine("Task not found ..."); 
            }
        }
     
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Task Manager !"); 

            while (true)
            {
                Console.WriteLine("Please Select An Option ?");
                Console.WriteLine("1. Create a new task ");
                Console.WriteLine("2. View all tasks ");
                Console.WriteLine("3. Mark task as completed ");
                Console.WriteLine("4. Exit"); 
                int option  =Convert.ToInt32(Console.ReadLine());
                switch (option)
                {

                    case 1:
                        CreateTask(); 
                        break;
                    case 2:ViewTask(); 
                        break;
                    case 3:
                        MarkAsCompleted();
                        break; 
                    case 4:
                        Console.WriteLine("Thank You For Using Task Manager"); 
                        return;
                    default:
                        Console.WriteLine("Error. Invalid Option ");
                        break;
                }
            }
             
        }

      

      

    
    }
}
