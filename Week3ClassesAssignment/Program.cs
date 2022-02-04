using System;

namespace Week3ClassesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objects
            Car c1 = new Car();
            Car c2 = new Car();
            Car c3 = new Car();

            //Variables
            int speedLimit;

            Console.WriteLine("Please enter the speed limit: ");
            speedLimit = Convert.ToInt32(Console.ReadLine());

            //Car 1
            Console.WriteLine("\nEnter the make of the first car: ");
            c1.make = Console.ReadLine();

            Console.WriteLine("Enter the model of the first car: ");
            c1.model = Console.ReadLine();

            Console.WriteLine("Enter the speed/mph of the first car: ");
            c1.speedMph = Convert.ToInt32(Console.ReadLine());
            
            //Car 2
            Console.WriteLine("\nEnter the make of the second car: ");
            c2.make = Console.ReadLine();

            Console.WriteLine("Enter the model of the second car: ");
            c2.model = Console.ReadLine();

            Console.WriteLine("Enter the speed/mph of the second car: ");
            c2.speedMph = Convert.ToInt32(Console.ReadLine());
            
            //Car 3
            Console.WriteLine("\nEnter the make of the third car: ");
            c3.make = Console.ReadLine();

            Console.WriteLine("Enter the model of the third car: ");
            c3.model = Console.ReadLine();

            Console.WriteLine("Enter the speed/mph of the third car: ");
            c3.speedMph = Convert.ToInt32(Console.ReadLine());

            //Output
            Console.WriteLine("\n\nSpeed Limit: " + speedLimit + "mph");

            if (c1.speedMph <= speedLimit)
            {
                Console.WriteLine("\n" + c1.make + " " + c1.model + " " + c1.speedMph + "mph: OK");
            }
            else
            {
                int demeritPts = (c1.speedMph - speedLimit) / 5;
                if (demeritPts < 10)
                {
                    Console.WriteLine("\n" + c1.make + " " + c1.model + " " + c1.speedMph + "mph: " + demeritPts + " demerits");
                }
                else
                {
                    Console.WriteLine("\n" + c1.make + " " + c1.model + " " + c1.speedMph + "mph: " + demeritPts + " demerits <LICENSE SUSPENDED>");
                }
            }
            if (c2.speedMph <= speedLimit)
            {
                Console.WriteLine(c2.make + " " + c2.model + " " + c2.speedMph + "mph: OK");
            }
            else
            {
                int demeritPts = (c2.speedMph - speedLimit) / 5;
                if (demeritPts < 10)
                {
                    Console.WriteLine(c2.make + " " + c2.model + " " + c2.speedMph + "mph: " + demeritPts + " demerits");
                }
                else
                {
                    Console.WriteLine(c2.make + " " + c2.model + " " + c2.speedMph + "mph: " + demeritPts + " demerits <LICENSE SUSPENDED>");
                }
            }
            if (c3.speedMph <= speedLimit)
            {
                Console.WriteLine(c3.make + " " + c3.model + " " + c3.speedMph + "mph: OK");
            }
            else
            {
                int demeritPts = (c3.speedMph - speedLimit) / 5;
                if (demeritPts < 10)
                {
                    Console.WriteLine(c3.make + " " + c3.model + " " + c3.speedMph + "mph: " + demeritPts + " demerits");
                }
                else
                {
                    Console.WriteLine(c3.make + " " + c3.model + " " + c3.speedMph + "mph: " + demeritPts + " demerits <LICENSE SUSPENDED>");
                }
            }
        }
    }

    public class Car
    {
        public string make;
        public string model;
        public int speedMph;
    }
}