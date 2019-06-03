using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {       string monday = "Monday";
           string [] daysoftheWeek= {"Monday", "Tuesday", "Wednesday"

 };

     //       foreach (var item in daysoftheWeek)
	//{
   //             Console.WriteLine(item);
	//}
        Console.WriteLine("Write the value");
        int iDay = int.Parse(Console.ReadLine());
            string choosenDay = daysoftheWeek[iDay-1];
            Console.WriteLine($"That day is  {choosenDay}");

        }
        }
    }
