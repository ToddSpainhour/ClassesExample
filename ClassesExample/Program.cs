using ClassesExample.Animals;
using System;


namespace ClassesExample

{
    class Program
        
    {
        
        static void Main(string[] args)
        {

            var chicken = new Chicken("Liza");
            var bob = new Chicken("Bob");

            chicken.Name = "Liza";
            // bob.Name = "Bob";

            chicken.Peck("corn");
            bob.Peck("Watermelon");

            Console.WriteLine($"{chicken.Name} and {bob.Name} are proud chickens.");



            Console.Read();

        }

        

    }

}



//' using System' lives inside the eco system Microsoft built. Any code that's inside this namespace is avaviable. it's to hold related code
// a namespace is a large high-level bundle of code
// A class is a like a blueprint for functionality. classes in C# and JS are similar. there is nothing special about the word program above 
// once class per file and name the .cs file the same as that class
// below is a method, a function inside a class, a behavior
// "new it up." is creating a new instance
// hitting tab to auto complete adds the 'using' up top
// new Chicken () - the parenthesis says give me a copy of this. called a constructor
// without making it a variable it is constructed to memory and instantly goes away