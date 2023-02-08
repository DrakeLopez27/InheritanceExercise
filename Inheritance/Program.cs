using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird Hawk= new Bird();
            Hawk.age = 2;
            Hawk.isAlive= true;
            Hawk.wingColor = "Brown";
            Hawk.BeakLength = 1.75;




            Reptile Snake = new Reptile()
            {
                isAmphibious = true,
                hasLegs = false,
                NumberOfTeeth = 0,
                LegCount = 0,
            };

            var myAnimals = new Animal[] { Snake, Hawk };

            foreach (var a in myAnimals)
            {
                Console.WriteLine($"NUMBER OF LEGS: {a.LegCount}");
                Console.WriteLine($"LIFE STATUS: {a.isAlive}");
            }
            
            
            
            
            
            
            
            
            
            
            
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

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
