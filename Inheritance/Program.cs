using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird hawk = new Bird();
            hawk.Name = "Hawk";
            hawk.Legs = 2;
            hawk.Habitat = "Tree";
            hawk.LaysEggs = true;
            
            hawk.WingSpan = 53;
            hawk.BeakShape = "Hooked";
            hawk.ChirpSound = "CAW";
            hawk.EatsOtherBirds = true;

            Console.WriteLine($"Name: {hawk.Name}");
            Console.WriteLine($"Number of Legs: {hawk.Legs}");
            Console.WriteLine($"Habitat: {hawk.Habitat}");
            Console.WriteLine($"Does it Lay Eggs?: {hawk.LaysEggs}");
            Console.WriteLine($"Wingspan: {hawk.WingSpan}\"");
            Console.WriteLine($"Beak Shape: {hawk.BeakShape}");
            Console.WriteLine($"Sound: {hawk.ChirpSound}");
            Console.WriteLine($"Does it Eat Other Birds?: {hawk.EatsOtherBirds}");
            Console.WriteLine("------------------------------------");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile snake = new Reptile();
            snake.Name = "Snake";
            snake.Legs = 0;
            snake.Habitat = "Hole in the ground";
            snake.LaysEggs = true;

            snake.LivesInWater = false;
            snake.IsColdBlooded = true;
            snake.HasScales = true;
            snake.HasForkedTounge = true;

            Console.WriteLine($"Name: {snake.Name}");
            Console.WriteLine($"Number of Legs: {snake.Legs}");
            Console.WriteLine($"Habitat: {snake.Habitat}");
            Console.WriteLine($"Does it Lay Eggs?: {snake.LaysEggs}");
            Console.WriteLine($"Does it Live in the Water?: {snake.LivesInWater}");
            Console.WriteLine($"Is it Cold Blooded?: {snake.IsColdBlooded}");
            Console.WriteLine($"Does it Have Scales?: {snake.HasScales}");
            Console.WriteLine($"Does it Have a Forked Tounge?: {snake.HasForkedTounge}");
            Console.WriteLine("------------------------------------");
        }
    }
}
