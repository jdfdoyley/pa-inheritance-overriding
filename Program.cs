/******************************************************************************\
* Name: Jason D. F. D'Oyley
* Date: November 6, 2022
* Assignment CIS214 Performance Assessment - Inheritance & Overriding
* Description: The main application class
*
* Must meet the following requirements:
*   Print a line that states "Your Name - Week 5 PA Inheritance and Overriding"
*   Creates an instance of each class using parameters of your choosing
*   Print each object's properties to the console using the PrintAnimal function
*   Update the properties of each instance to reflect values that are different
*   from their original values
*   Print each object's properties to the console using the PrintAnimal function
\******************************************************************************/

namespace pa_inheritance_overriding
{
    public class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Jason D'Oyley - Week 5 - Inheritance & Overriding\n"
            );

            // Creates an instance of each class using parameters of your choosing
            Animal animal = new Animal("Roo", 2);
            Cat cat = new Cat();

            cat.Name = "Fluffy";
            cat.Legs = 4;

            // Print each object's properties to the console using the
            // PrintAnimal function
            animal.printAnimal();
            cat.printAnimal();
        }
    }
}