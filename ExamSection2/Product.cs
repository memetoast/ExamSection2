using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSection2
{
    class Product
    {
        private string code;
        private string description;
        private decimal price;

        //An empty constructor
        public Product()
        {

        }

        //An overload constructor with the fields as parameters (Object initializer)
        public Product(string code, string description, decimal price)
        {
            this.code = code;
            this.description = description;
            this.price = price;

        }

        //A public function that returns a string such as 
        //“The Product Number “+ code + “is a “+ description.
        public string showDescription()
        {
            return "The Product Number " + code + " is a " + description;
        }

        //A public function that return a string such as
        //“The Price for Product Number “+ code + “is $“+ price.
        public string showPrice()
        {
            return "The Product Number " + code + " is $" + price;
        }

        //Getters and setters
        public string Code
        {
            get 
            { 
                return code; 
            }
            set 
            { 
                code = value; 
            }
        }
        public string Description
        {
            get 
            { 
                return description; 
            }
            set 
            { 
                description = value; 
            }
        }
        public decimal Price
        {
            get 
            { 
                return price; 
            }
            set
            {
                price = value;
            }
        }


    }
}
