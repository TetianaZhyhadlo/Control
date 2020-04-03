using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Company
{
    public abstract class People
    {
        public enum MF 
        {
            Male,
            Female
        }
        public int Age { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    
}

