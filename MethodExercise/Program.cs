using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi User!");
            Console.WriteLine("Could you please tell me your name?"); // output
            var name = Console.ReadLine(); // input

            Console.WriteLine($"Whats your favorite color {name}?");
            var color = Console.ReadLine();

            Console.WriteLine($"Which is your favorite animal {name}?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Whats your is favorite soccer team name {name}?");
            var soccerTeamName = Console.ReadLine();


            Console.WriteLine($"The users name is {name}, he/she like's {color} color." +
                $" Her/His favorite animal is {animal} and favorite soccer team is {soccerTeamName}");


        }
    }
}

