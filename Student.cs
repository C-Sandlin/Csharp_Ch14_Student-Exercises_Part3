using System;
using System.Collections.Generic;

namespace NSSFolks
{
    public class Student : Person
    {
        public List<Topic> TopicList = new List<Topic>();

        public Student(string firstname, string lastname, string title, double monthsatnss)
        {
            FirstName = firstname;
            LastName = lastname;
            Title = title;
            MonthsAtNSS = monthsatnss;
            TopicList = new List<Topic>();
        }
    }
}
