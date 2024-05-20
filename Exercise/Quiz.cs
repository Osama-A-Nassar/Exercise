using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Quiz
    {
        public string FirstName;
        public string LastName;
           
        public int Age;

        public string Fullname(string FName, string LName) 
        { 
        string Fullname = FName + " " + LName;
        return Fullname;
        } 

    }
}
