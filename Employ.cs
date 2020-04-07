using System;
using System.Collections.Generic;
using System.Text;
using static Control_Company.Extension;

namespace Control_Company
{
    
    public enum MF
    {
        Male,
        Female
    }
    public class Employ: People
    {
        public event Action Announcement;
        public MF Type { get; set; }
        public string Position { get; set; }
        public Employ(string position,MF type)
        {
            Position = position;
            Type = type;
            Announcement += NewAnnouncement;
           
        }
        public void NewAnnouncement()
        {
            ToConsole("New announcement received",ConsoleColor.Green);
        }
        public void SendAnnouncement(string announcement)
        {
            Announcement?.Invoke();
            ToConsole(announcement, ConsoleColor.Red);

        }

    }

    
}
