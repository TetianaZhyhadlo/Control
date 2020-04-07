using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Company
{
    public interface IStructure
    {
        public string Name { get; set; }
        public int EmployeCount(); 
    }

}
