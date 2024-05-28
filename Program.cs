using System;
using PlayGround;
namespace ElementaryUse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FunDay child = new FunDay();
            Console.WriteLine("Please enter the child\'s first name: ");
            child.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter the child\'s last name: ");
            child.LastName = Console.ReadLine();
            int tempAge;
            Console.WriteLine($"Please enter the child\'s age to the nearest year");
            while(!int.TryParse(Console.ReadLine(), out tempAge))
            {
                Console.WriteLine("Please enter a valid number without decimal places");
            }
            child.Age = tempAge;
            if(child.ElementaryPlayground)
                Console.WriteLine($"{child.FirstName} {child.LastName} " +
                    $" is old enough for the elementary playground.");
            else
                Console.WriteLine($"{child.FirstName} {child.LastName} " +
                    $" may use the preschool playground instead of the " +
                    $"elementary playground.");
        }
    }
}
