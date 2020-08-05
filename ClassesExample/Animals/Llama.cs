using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Animals
{
    class Llama
    {
        // auto-property
        public int Age { get; set; }
        // public string Color { get; }
        public string Color { get; private set; }

        public bool Spits { get; set; }


        // field
        public Llama(int age, string color)
        {
            Age = age;
            Color = color;
        }

        // constructor
        public void Dye(string color)
        {
            if (Age > 3)
            {
                Color = color;
            }
            else
            {
                DressUp("jeans", "baggy");
            }
        }

        private void DressUp(string clothing, string style)
        {
            Console.WriteLine($"The {Color} llama is wearing {style} {clothing}");
        }


    }
}



// every new class has an implicite access modifier called 'internal'
// the 'internal' access modifier is similar to public
// an 'internal' access modifier is accessible inside the same project it is defined in
// difference between internal and public is when you had multiple projects.
// get;set; make it readable and writable 
// 'ctor' then tab twice makes a constructor
// { get; } means read only - et only in constructor
// public property with private setter -- can be set whenever, but only by the class that owns the property