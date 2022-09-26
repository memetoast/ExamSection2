using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSection2
{
    internal class Book : Product
    {
        public string author;

        public Book()
        {

        }

        public Book(string code, string description, decimal price, string author)
        {
            this.author = author;
            Code = code;
            Description = description;
            Price = price;
        }

        public string showAuthor()
        {
            return "The books Author is " + author;
        }
    }
}
