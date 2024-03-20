using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    public class student
    {
        private int id;
        private string name; 
        private int age;

        //Default Constructor
        public student() {
            this.id = 0;
            this.name = string.Empty;
            this.age = 0; 
        }
        //Parameterized Constructor
        public student(int id , string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public void setName(string name)
        {
            this.name=name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public int getId()
        {
            return this.id;
        }
        public string getName() { 
           return this.name;
        }
        public int getAge()
        {
            return this.age;
        }  
    }
    public class CrudApp
    {
        private List<student> stds; 
        public CrudApp()
        {
            stds = new List<student>();
        }

        public void addStudent() {
            Console.WriteLine("Please Insert Student Details ?");

            Console.Write("ID : "); 
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name : ");
            string name = Console.ReadLine();

            Console.Write("Age : "); 
            int age = int.Parse(Console.ReadLine());


            student s = new student(id , name , age);
            /*s.setId(id);
            s.setName(name);
            s.setAge(age);*/
            stds.Add(s);
            Console.WriteLine("Student Added Successfully!"); 
        }
        public void displayAllstudents()
        {
            if(stds.Count ==0)
            {
                Console.WriteLine("No Students Yet !"); 
            }
            else
            {
                for (int i = 0; i < stds.Count; i++)
                {
                    Console.WriteLine($"Student {i + 1} Info [ ID : {stds[i].getId()} , Name : {stds[i].getName()} , Age : {stds[i].getAge()} ]");
                }
            }
        
        }

        public void UpdateStudentInfo()
        {
            Console.Write("Enter ID OF Student You Want To Update It's Info : ");
            int id = int.Parse(Console.ReadLine());

            int index = -1;
            bool found = false; 
            for(int i =0; i < stds.Count;i++)
            {
                var s = stds[i];
                if(s.getId() == id)
                {
                    found = true;
                    index = i; 
                    break;
                }
            }

            if(found == false)
            {
                Console.WriteLine("Invalid ID .");
                return;
            }
            Console.Write("Enter New ID : "); 
            int nwId = int.Parse(Console.ReadLine());

            Console.Write("Enter New Name : "); 
            string Nwname = Console.ReadLine() ;

            Console.Write("Enter New Age : "); 
            int NwAge = int.Parse(Console.ReadLine());

            stds[index].setId(nwId);
            stds[index].setName(Nwname);
            stds[index].setAge(NwAge);


            Console.WriteLine("Student info Updated Successfully !"); 

        }

        public void deleteStudent()
        {
            Console.Write("Enter ID OF Student You Want To Delete It's Info : ");
            int id = int.Parse(Console.ReadLine());

            int index = -1;
            bool found = false;
            for (int i = 0; i < stds.Count; i++)
            {
                var s = stds[i];
                if (s.getId() == id)
                {
                    found = true;
                    index = i;
                    break;
                }
            }

            if (found == false)
            {
                Console.WriteLine("Invalid ID .");
                return;
            }
            
            var deletedStudent = stds[index];
            stds.Remove(deletedStudent);

            Console.WriteLine("Student info Deleted Successfully !");
        }

        public void Search()
        {
            Console.Write("Student ID : ");
            int id = int.Parse(Console.ReadLine()) ;

            if(stds.Count!=0)
            {
                for (int i = 0; i < stds.Count(); i++)
                {
                    var std = stds[i];

                    if (std.getId().Equals(id))
                    {
                        Console.WriteLine($"{id}. [ Name : {std.getName()} , Age : {std.getAge()} ]");
                    }

                }
            }
            Console.WriteLine("No Students At The List !");

        }

       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CrudApp crudApp = new CrudApp();
            while (true)
            {
                Console.WriteLine("1.Create New Student \n");
                Console.WriteLine("2.Updated Student Information \n");
                Console.WriteLine("3.Display All Student \n");
                Console.WriteLine("4.Deleted Student \n");
                Console.WriteLine("5.Search ... \n");
                Console.WriteLine("6.Exit . \n"); 
                int choice = int.Parse(Console.ReadLine()) ;
                switch (choice)
                {
                    case 1:
                        //Done.
                        crudApp.addStudent();
                        break;
                    case 2:
                        crudApp.UpdateStudentInfo(); 
                        break;
                    case 3:
                        //Done.
                        crudApp.displayAllstudents();
                        break;
                    case 4:
                        crudApp.deleteStudent(); 
                        break;
                    case 5:
                        //Done.
                        crudApp.Search(); 
                        break;
                    
                    case 6:
                        return; 
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break; 
                }
                Console.WriteLine(); 
            }
        }
    }
}
