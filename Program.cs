using System;

namespace NSSFolks
{
    class Program
    {
        static void Main(string[] args)
        {
            var Jason = new Student("Jason", "Collum", "Senior Student", 4.5);
            var Nate = new Student("Nate", "Fleming", "Senior Student", 4.5);

            var topic01 = new Topic("Test Topic 01");
            Nate.TopicList.Add(topic01);

            var Bryan = new Instructor("Bryan", "Nilsen", "Junior Instructor", 14, "Cohort 34");
            var Robby = new Instructor("Robby", "Hecht", "TA", 6, "Cohort 32");

            foreach (Topic topic in Nate.TopicList)
            {
                Console.WriteLine($"{topic.TopicName}");
            }

            Jason.SayYourInfo();

        }
    }
}

