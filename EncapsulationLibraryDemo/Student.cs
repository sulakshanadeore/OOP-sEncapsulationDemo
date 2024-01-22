using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationLibraryDemo
{
    public class Student
    {
           static int rno;
        //static fields remember the previous value with them, they have good memory.
        //static  string studname,city;

        //  public static void AcceptData()
        //  {
        //      Console.WriteLine("Enter Rollno");
        //      rno=Convert.ToInt32(Console.ReadLine());
        //      Console.WriteLine("Enter name");
        //      studname=Console.ReadLine();

        //  }

        //  public static void DisplayData()
        //  {
        //      Console.WriteLine(rno);
        //      Console.WriteLine(studname);
        //  }



        static Student()
        {
            //Static Constructor
            //1. Static constructor is called before any other constructor of the class is called.
            //2. It is only called once in the lifetime of the class
            //3. This constructor is used to initialize the data of the class
            Console.WriteLine("Static constructor called...");
               rno = 0;
            
            //static methods can use static fields/variables
            //Console.WriteLine("Rollno="  + rno);
        }

        public Student()
        {
           rno = rno + 1;
            Console.WriteLine(rno);
        }




    }
}
