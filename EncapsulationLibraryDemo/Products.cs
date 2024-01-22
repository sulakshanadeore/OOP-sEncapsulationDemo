using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationLibraryDemo
{

    public class Products
    {
        //property-->smart method----1) accepting & displaying---2) can do validations 3) abstraction implemented(access specfier)

      private static int _prodid;//best coding practices--variable

        public int ProductId {

            get {
                _prodid = _prodid + 1;
                return _prodid; }
        }

        //public int ProductId //property
        //{
        //writing/assinging value to the variable
        //    set {
        //        if(value < 0) 
        //            Console.WriteLine("Product id cannot be zero");
        //        else
        //        _prodid = value;
            
        //    }//accepting-validation can be performed while accepting the data 
        //    get { return _prodid; } //display/return---validation can be performed while displaying/returning the data
        //}


        private string _prodname;
        public string ProductName 
        {
            get { return _prodname; }//get has a return of the variable
            set {
                if(value.Length>0 && value.Length<10)
                    _prodname = value;
                else
                   Console.WriteLine("Name can be max 9 chars long");
                
            
            }//set has a value assigned to the varaible
        
        }

        private decimal _price;
        public decimal ProductPrice
        {
            set { 
                if(value > 0)
                _price = value;
                else
                    Console.WriteLine("Invalid price");
            }
            get { return _price; }
        }


    }
}
