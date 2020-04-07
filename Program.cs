using System;
using static Control_Company.Extension;

namespace Control_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Employment
            Employ a1 = new Employ("marketolog", MF.Female);
            a1.Age = 21;
            a1.FirstName = "Elen";
            a1.LastName = "Makarova";
            Employ a2 = new Employ("designer", MF.Female);
            a2.Age = 28;
            a2.FirstName = "Maria";
            a2.LastName = "Polinska";
            Employ a3 = new Employ("manager", MF.Male);
            a3.Age = 35;
            a3.FirstName = "Den";
            a3.LastName = "Super";
            Employ a4 = new Employ("General manager", MF.Male);
            a4.Age = 20;
            a4.FirstName = "Antony";
            a4.LastName = "SuperPuper";
            #endregion
            #region Company
            Department<Team> d1 = new Department<Team>("TopManagement");
            Department<Team> d2 = new Department<Team>("Subordinates");
            Team team1 = new Team("Best");
            Team team2 = new Team("BestOfTheBest");
            Team team3 = new Team("GM");
            team1.AddToTeam(a1);
            team1.AddToTeam(a2);
            team2.AddToTeam(a3);
            team3.AddToTeam(a4);
            d1.AddToDepartment(team3);
            d2.AddToDepartment(team1);
            d2.AddToDepartment(team2);
            #endregion
            Department<Team>.ShowStructure<Department<Team>>(d1, d2);
            a4.SendAnnouncement("Quarantine!");
                      

        }
    }
}
