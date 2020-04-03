using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Company
{
    
    
    public class Department<T> where T: Team, IStructure
    {
        List<Team> TeamList { get; set; }
        public string Name { get; set; }

        public Department(string name)
        {
            Name = name;
            TeamList = new List<Team>();
        }

        
        public int EmployeCount(string name)
        {
            int count = 0;
            if (name == this.Name)
                this.TeamList.ForEach(x => count = count+x.EmpList.Count);
            return count;
        }
    }
}
