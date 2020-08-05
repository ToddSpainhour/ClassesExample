using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Animals
{
    class Chicken
    {

        //property - for data you want to expose (accessibility modifier -> type of thing it's storing, -> Name -> Read and Write permissions)
        public string Name { get; set; }




        // field keeping info close.just for you to use. Only this class cares about
        private bool _isHungry = true;




        // constructor 
        public Chicken(string name) // constructor paramenters - an argument here names something required
        {
            Name = name;
            Console.WriteLine("Chicken inside default constructor");
        }



        // method (signature = accessibility modifier -> return type -> Name -> Parameters)
        public void Peck(string typeOfFood)
        {
            if (_isHungry)
            {
                Console.WriteLine($"{Name} pecked hungrily at the {typeOfFood}");
                _isHungry = false;
            }
            else 
            {
                Console.WriteLine($"{Name} is not hungry.");
            }

        }

        // method overloading
        public void Peck()
        {
            Peck("Corn");
        }


    }
}



// every first letter in a class and method name needs to be capitalized (title case, no underscores _)
// default constructor has no return type, what's the minimum amout of info we need to get started
// public Chicken()
// {
// }

// default constructor


// properties store data in memory to use

// accessibility modifier - who can gain access (public), 
// return type - what does this method return (void means nothing),
// name (Peck)
// last part accepts arguments or could be empty parenthasis (string typeOfFood)
// and curly braces for your block of code
// all 4 of those things make this method uniniqe 