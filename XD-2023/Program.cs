using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Ford", "white", 2021, 150);
            Car Opel = new Car("Mercedes", "blue", 2022, 180);
            Car Volvo = new Car("XC_90");
            //Ford.name="Ford";
            //Ford.year=2021;
            //Ford.color="white";
            //Ford.maxSpeed=150;
            Console.WriteLine(Ford.Name);
            Console.WriteLine(Ford.Color);
            Console.WriteLine(Ford.Year);
            Console.WriteLine(Ford.engine_type);
            Ford.fullThrottle();
            Ford.honk();

            Console.WriteLine(Opel.Name);
            Console.WriteLine(Opel.Color);
            Console.WriteLine(Opel.Year);
            Console.WriteLine(Opel.engine_type);
            Opel.fullThrottle();
            Opel.honk();

            Console.WriteLine("Enter Volvo's age: ");
            try
            {
                Volvo.Year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Volvo age is: " + Volvo.Year);
            } catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }

    }
}
