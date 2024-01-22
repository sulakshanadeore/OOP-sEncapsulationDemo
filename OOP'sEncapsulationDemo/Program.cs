using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncapsulationLibraryDemo;
namespace OOP_sEncapsulationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student.AcceptData();
            //Student.DisplayData();
            
            //Student s=new Student();//Calling the default constructor
            ////1
            //Student s1=new Student();
            ////2
            //Student s2=new Student();   
            ////3
            ///

            Products productCadbury=new Products();
            //Console.WriteLine("Enter product id");
            //productCadbury.ProductId = Convert.ToInt32(Console.ReadLine());//setter block
            

            Console.WriteLine("Enter ProductName");
            productCadbury.ProductName = Console.ReadLine();
            

            Console.WriteLine("Enter price");
            productCadbury.ProductPrice = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Now Printing.....");
            Console.WriteLine(productCadbury.ProductId);//getter block

            Console.WriteLine(productCadbury.ProductName);
            if (productCadbury.ProductPrice > 0)
            {
                Console.WriteLine(productCadbury.ProductPrice);
            }

            Products p1=new Products();
            Console.WriteLine("Enter ProductName");
            p1.ProductName = Console.ReadLine();


            Console.WriteLine("Enter price");
            p1.ProductPrice = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(p1.ProductId);
            Console.WriteLine(p1.ProductName);
            Console.WriteLine(p1.ProductPrice);


            Console.ReadLine();
        }
    }
}
