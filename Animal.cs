/******************************************************************************\
* Name: Jason D. F. D'Oyley
* Date: November 6, 2022
* Assignment CIS214 Performance Assessment - Inheritance & Overriding
* Description: Base class representing an Animal
\******************************************************************************/

namespace pa_inheritance_overriding
{
    public class Animal
    {
        // Class Attributes
        public string? Name { get; set; }
        public int Legs { get; set; }

        // Default Constructor
        public Animal()
        {
            Name = "";
            Legs = 0;
        }

        // Overloading Constructor
        public Animal(string name, int legs)
        {
            Name = name;
            Legs = legs;
        }

        // Class Methods
        public virtual void PrintAnimal()
        {
            // TODO: Display output for the animal
            Console.WriteLine(
                $"The Animal's name is {Name} and it has {Legs} legs."
            );
        }
    }
}