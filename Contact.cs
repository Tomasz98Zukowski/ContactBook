using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    public class Contact
    {      
        

        public string Number {  get; set; }
        
        public string Name { get; set; }
        public Contact(string name,string number)
        {
            Name = name;
            Number = number;
        }
    }
}
