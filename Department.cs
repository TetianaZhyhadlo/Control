using System;
using System.Collections.Generic;
using System.Text;
using static Control_Company.Extension;

namespace Control_Company
{
        
    public class Department<T> where T: Team, IStructure
    {
        public List<Team> TeamList { get; set; }
        public string Name { get; set; }

        public Department(string name)
        {
            Name = name;
            TeamList = new List<Team>();
        }
                
        public int EmployeCount()
        {
            int count = 0;
            this.TeamList.ForEach(x => count = count+x.EmpList.Count);
            return count;
        }
        public void AddToDepartment(Team first)
        {
            TeamList.Add(first);
        }
        public static void ShowStructure<X>(Department<Team> first, Department<Team> second)
        {
            try
            {
                ToConsole($"Number of company employees:{first.EmployeCount() + second.EmployeCount()}", ConsoleColor.DarkBlue);
                ShowDepartment(first);
                ShowDepartment(second);

            }
            catch (Exception exeption)
            {
                ToConsole(exeption.Message, ConsoleColor.Red);
            }

        }

        public static void ShowDepartment(Department<Team> name)
        {
            ToConsole($"Department {name.Name} consists of teams: ", ConsoleColor.Yellow);
            name.TeamList
                .ForEach(x => ToConsole(x.Name + " - " + x.EmployeCount() + " people", ConsoleColor.Yellow));
        }
    }
}
