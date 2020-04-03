using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Company
{
    public class Employ: People
    {
        public string Position { get; set; }
        public Employ(string position)
        {
            Position = position;
        }

    }
}
