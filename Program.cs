using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            dog.ShowInfo();
            cat.ShowInfo();
            Console.ReadKey();
        }
    }

    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name="Животное")
        {
            Name = name;
        }



        public abstract string Say();

        public virtual void ShowInfo()
        {
            Console.WriteLine(" Это {0}. Она говорит {1}", Name, Say());
        }



    }

    class Dog : Animal
    {
        public override string Name { get; set; }
        public Dog(string name="Собака")
        {
            Name = name;
        }


        public override string Say()
        {
            return "Гав";
        }

        public new void ShowInfo()
        {

            Console.WriteLine(" Это {0}. Она говорит {1}", Name, Say());

        }

    }
    class Cat : Animal
    {
        public override string Name { get; set; }
        public Cat(string name = "Кошка")
        {
            Name = name;
        }


        public override string Say()
        {
            return "Мя";
        }

        public new void ShowInfo()
        {

            Console.WriteLine(" Это {0}. Она говорит {1}", Name, Say());

        }

    }











}
