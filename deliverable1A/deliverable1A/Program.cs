using System;

namespace deliverable1A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of vacation would you like to take? Musical, Tropical, or Adventurous");
            string vacationType = (Console.ReadLine());
            Console.WriteLine("What is your group size?");
            int groupSize = int.Parse(Console.ReadLine());

            string destination= null;
            if (String.Compare(vacationType, "Musical", true/*ignoreCase*/) == 0)
            {
                destination = "New Orleans";
            }
            else if (String.Compare(vacationType, "Tropical", true/*ignoreCase*/) == 0)
            {
                destination = "A beach vacation in Mexico";
            }
            else if (String.Compare(vacationType, "Adventurous", true/*ignoreCase*/) == 0)
            {
                destination = "Whitewater raft the Grand Canyon";
            }
            string travel= null;
            if (groupSize <=2)
            {
                travel = "Fly First Class";
            }
            else if (groupSize <= 5)
            {
                travel = "Take a Helicopter";
            }
            else if (groupSize >= 6)
            {
                travel = "Charter a flight";
            }
            string result;
            result = "Because you have a group of "+groupSize+" going on a "+vacationType+" vacation, you should "+travel+" to "+destination+".";
            Console.WriteLine(result);
        }
    }
}
