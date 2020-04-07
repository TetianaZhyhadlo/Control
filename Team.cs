using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_Company
{
    
    public class Team : ICompanyBase, IStructure
    {
        public string Name { get; set; }
        public List<Employ> EmpList { get; set; }
        public Team(string name)
        {
            Name = name;
            EmpList = new List<Employ>();
        }

        public int EmployeCount()
        {
            int count= this.EmpList.Count();
            return count;
        }

        public void ShowAll()
        {
            EmpList
                .ForEach(x => Console.WriteLine(x.FirstName, x.LastName, ConsoleColor.Cyan));
        }

        public void AddToTeam(Employ first)
        {
                EmpList.Add(first);
        }
    }
}
