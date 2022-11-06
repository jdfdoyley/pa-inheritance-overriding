/******************************************************************************\
* Name: Jason D. F. D'Oyley
* Date: November 6, 2022
* Assignment CIS214 Performance Assessment - Inheritance & Overriding
* Description: Derived class representing a Cat
\******************************************************************************/

namespace pa_inheritance_overriding
{
    public class Cat : Animal
    {
        // Class Attributes
        public string? Sound { get; set; }

        // Default Constructor
        public Cat()
        {
            base.Name = "";
            base.Legs = 0;
            Sound = "";
        }

        // Overloaded Constructor
        public Cat(string name, int legs, string sound) : base(name, legs)
        {
            base.Name = name;
            base.Legs = legs;
            Sound = sound;
        }

        // Class Methods
        public override void printAnimal()
        {
            Console.WriteLine(
                $"The Cat's name is {base.Name}, and it has {base.Legs} and " +
                $"is making a meow sound."
            );
        }
    }
}