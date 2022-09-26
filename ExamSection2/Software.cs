using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSection2
{
    internal class Software : Product
    {
        public string version;
        public Software()
        {

        }
        public Software(string code, string description, decimal price, string version)
        {
            this.version = version;
            Code = code;
            Description = description;
            Price = price;
        }
        public string showVersion()
        {
            return "The software version is " + version;
        }
    }
}
