using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApp2
{
    struct product
    {
        public int id;
        public string name;
        public double price;
        public int quantity;
    }

    internal class Program
    {
        static product[] myProducts = new product[100];
        static int counter = 0;
        static void Main(string[] args)
        {
         
            while (true) {

                Console.WriteLine("Please Select An Option ..");
                Console.WriteLine("1. Add New Product .");
                Console.WriteLine("2. View All Producs .");
                Console.WriteLine("3. Update Product . ");
                Console.WriteLine("4. Delete Product . ");
                Console.WriteLine("5. Search .....");
                Console.WriteLine("6. Exit . "); 

                int op = Convert.ToInt32(Console.ReadLine());
                
                switch (op)
                {
                    case 1:
                        addNewProduct(); 
                        break; 
                    case 2:
                        viewAllProducts(); 
                        break;
                    case 3:
                        updateProduct(); 
                        break; 
                    case 4:
                        deleteProduct(); 
                        break;
                    case 5:
                        searchForProduct();
                        break;
                    case 6:
                        Console.WriteLine("Goodbye!"); 
                        return;
                    default:
                        Console.WriteLine("Invalid Option !");
                        break;
                }
            
            
            
            }





        }

        private static void searchForProduct()
        {
            Console.Write("Enter Product Name : "); 
            string n = Console.ReadLine();
            bool found  = false;
            for (int i = 0; i< counter; i++)
            {
                var prod = myProducts[i];
                if(prod.name .Contains(n))
                {
                    found = true;
                    Console.WriteLine("Product Found "); 
                    Console.WriteLine($"ID : {prod.id} , NAME : {prod.name} , PRICE : {prod.price} , QUANTITY : {prod.quantity}");
                    break;
                }
            }
            if (found == false) Console.WriteLine("No Product Match !"); 
        }

        private static void deleteProduct()
        {
            Console.Write("Enter ID Of Product You Want To Delete : "); 
            int id = Convert.ToInt32(Console.ReadLine());

            int indx = -1; 

            for(int i =0; i< counter; i++)
            {
                if (myProducts[i].id == id )
                {
                    indx = i;
                    break; 
                }
            }
            if (indx == -1) Console.WriteLine("Product Not Found !"); 
            else
            {
                for(int i =0; i<counter -1;i++)
                {
                    myProducts[i] = myProducts[i+1];
                }

                counter--;

                Console.WriteLine("Product Deleted Successfully . "); 
                Console.WriteLine();
            }

        }

        private static void updateProduct()
        {
            throw new NotImplementedException();
        }

        private static void viewAllProducts()
        {
           if (counter ==0)
            {
                Console.WriteLine("No Products Found .");
                return; 
            }
           else 
                for(int i =0; i<counter; i++)
                {
                    var prod = myProducts[i]; 
                    Console.WriteLine($"ID : {prod.id} , NAME : {prod.name} , PRICE : {prod.price} , QUANTITY : {prod.quantity}");
                }
        }

        private static void addNewProduct()
        {
            //throw new NotImplementedException();

            if(counter >= myProducts.Length)
            {
                Console.WriteLine("Error. Maximum number of products reached .");
                return; 
            }

            Console.Write("Enter ID : "); 
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name : "); 
            string name = Console.ReadLine();
            Console.Write("Enter Price : "); 
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Quantity : "); 
            int quantity = Convert.ToInt32(Console.ReadLine());

            product pr = new product
            {
                id = id,
                name = name,
                price = price,
                quantity = quantity
            };

            myProducts[counter] = pr; 
            counter++;

            Console.WriteLine("Product Added Successfully . ");
            Console.WriteLine(); 

        }
    }
}
