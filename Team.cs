using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_Company
{
    public delegate void ToAll(string announcement);
    public class Team : ICompanyBase, IStructure
    {
        public string Name { get; set; }
        public List<Employ> EmpList { get; set; }
        public Team(string name)
        {
            Name = name;
            EmpList = new List<Employ>();
        }

        public int EmployeCount(string name)
        {
            int count = 0;
            if (name == this.Name)
                count= this.EmpList.Count();
            return count;
        }

        public void ShowAll()
        {
            EmpList
                .ForEach(x => Console.WriteLine(x.FirstName, x.LastName, ConsoleColor.Cyan));
        }

        public void AddTo(string some, Employ first)
        {
            if (some == this.Name)
                EmpList.Add(first);
        }
    }
}
