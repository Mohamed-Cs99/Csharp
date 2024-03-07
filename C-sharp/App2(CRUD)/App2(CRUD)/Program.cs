using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2_CRUD_
{
    internal class Program
    {

        static string[] itemsArray = new string[100];
        static int itemsCounter = 0; 
        static void Main(string[] args)
        {
           
            while(true)
            {
                Console.WriteLine("Please select an option ...");
                Console.WriteLine("1. Add new item ...");
                Console.WriteLine("2. View all items ...");
                Console.WriteLine("3. Search for an item ...");
                Console.WriteLine("4. Update an item ...");
                Console.WriteLine("5. Delete an item ...");
                Console.WriteLine("6. Exit . ");
                Console.WriteLine();
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        addNewItem();
                        break;
                    case 2:
                        viewAllItems();
                        break;
                    case 3:
                        searchForItem();
                        break;
                    case 4:
                        updateAnItem();
                        break;
                    case 5:
                        deleteAnItem();
                        break;
                    case 6:
                        return;

                    default:
                        Console.WriteLine("Invalid Option ...");
                        break;

                }
            }
          

        }

        private static void addNewItem()
        {
            Console.Write("Please enter item name : ");
            string itm = Console.ReadLine();
            if(itemsCounter < itemsArray.Length)
            {
                itemsArray[itemsCounter] = itm;
                itemsCounter++;
                Console.WriteLine("Item added successfully ........");
                Console.WriteLine();
            }
           
        }
        private static void viewAllItems()
        {
            if(itemsCounter == 0)
            {
                Console.WriteLine("No Items Found !"); 

            }
            else
            {
                Console.WriteLine("All items .........");
                Console.WriteLine();

                for (int i = 0; i < itemsCounter; i++)
                {
                    Console.WriteLine($"item {i + 1}. {itemsArray[i]}");
                    Console.WriteLine();
                }
            }
          
        }
        private static void searchForItem()
        {
            Console.WriteLine("item you want to find ? "); 
            string term = Console.ReadLine();
            bool found = false;
            for(int i =0; i<itemsCounter;i ++)
            {
                if (itemsArray[i].Contains(term))
                {
                    found = true;
                    Console.WriteLine($"Item Found At Index {i}"); 
                }
            }
            if(found ==false )
            {
                Console.WriteLine("Item not found "); 
            }
        }
        private static void deleteAnItem()
        {
            Console.WriteLine("Please enter item index ? "); 
            int indx = Convert.ToInt32(Console.ReadLine());
            if(indx<0 ||indx>=itemsCounter)
            {
                Console.WriteLine("Invalid index");
                return; 
            }
            for(int i = indx; i<itemsCounter-1;i++)
            {
                itemsArray[i] = itemsArray[i+1];
            }
            itemsCounter--;
            Console.WriteLine("Item deleted successfully ! ...");
            Console.WriteLine(); 
           // viewAllItems();
        }

        private static void updateAnItem()
        {
            Console.WriteLine("Please enter item index ? ");
            int indx = Convert.ToInt32(Console.ReadLine());
            if (indx < 0 || indx >= itemsCounter)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            Console.Write("Enter new value for the item  : "); 
            string val = Console.ReadLine();
            itemsArray[indx] = val; 
            
            Console.WriteLine("Items updated successfully ! ...");


        }


    }
}
