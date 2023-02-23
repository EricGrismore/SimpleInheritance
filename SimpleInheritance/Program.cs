using System;
using System.Drawing;
using System.Xml.Linq;

namespace Inheritance
{


    class Animal
    {
        public string name;


        public Animal()
        {
            name = "";


        }

        public Animal(string name)
        {
            this.name = name;

        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");

        }

    }
    class personal : Animal 
    {
        public string info;
        public string height;
        public string weight;

        public personal()
            :base()
        {
            info = "";
            height = "";
            weight = "";

        }
        public personal(string name, string weight, string height, string info)
            :base(name)
        {
            this.info = info;
            this.height = height;
            this.weight = weight;
        }
        public void showcase()
        {
            Console.WriteLine($"My name is {name}");
        }
        public void getinfo()
        {
            Console.WriteLine($"Owner: {info}");
        }
        public void getheight()
        {
            Console.WriteLine($"Height: {height}");
        }
        public void getweight()
        {
            Console.WriteLine($"Weight: {weight}");
        }
    }

    class paradise : Animal
    {
        public string color;
        public string age;
        public string diet;

        public paradise()
            : base()
        {
            color = "";
            age = "";
            diet = "";

        }
        public paradise(string name, string color, string age, string diet)
            : base(name)
        {
            this.color = color;
            this.age = age;
            this.diet = diet;
        }
        public void showbiz()
        {
            Console.WriteLine($"My name is {name}");
        }
        public void getcolor()
        {
            Console.WriteLine($"Owner: {color}");
        }
        public void getage()
        {
            Console.WriteLine($"Height: {age}");
        }
        public void getdiet()
        {
            Console.WriteLine($"Weight: {diet}");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            personal myPet = new personal();
            myPet.name = "Sparky";
            myPet.display();

            myPet.info = "William Fredrick";
            myPet.height = "6";
            myPet.weight = "120";
            myPet.getweight();
            myPet.getinfo();
            myPet.getheight();


            personal Sam = new personal("William Fredrick", "135lb", "6ft", "Fast Runner");
            Sam.display();
            Sam.getheight();
            Sam.getinfo();
            Sam.getweight();

            paradise Jon = new paradise();
            Jon.name = "Louise the Llama";
            Jon.display();

            Jon.color = "Black";
            Jon.age = "7";
            Jon.diet = "Carrots";
            Jon.getcolor();
            Jon.getage();   
            Jon.getdiet();

            paradise dex = new paradise("Dexter the eel", "Black", "7", "Carrots");
            dex.display();
            Jon.getcolor();
            Jon.getage();
            Jon.getdiet();

            Console.ReadLine();

        }

    }
}
