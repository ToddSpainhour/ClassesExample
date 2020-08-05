using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Animals
{
    class Cat
    {
        
        public CatColor Color { get; set; }

        public bool IsFeral { get; set; }

        public Chicken BestFriend { get; set; }

        public void Dye(CatColor color)
        {
            Color = color;
        }

        public void HaveASnack()
        {
            Console.WriteLine($"The {Color} cat just met {BestFriend.Name}.");
        }

    }





    enum CatColor
    {
        Orange, 
        Grey,
        Black,
        White
    }





}



// access modifier - if you don't see it doesn't mean it's not there; defaults to private
// a list of options are called an 'enum' it's a set of values and just like a class it gets a name
// without a constructor a behond the scenes 'default constructor' is always there
// enums are store as a integer; hover over and you'll see; it defaults to the first option if anothe isn't picked