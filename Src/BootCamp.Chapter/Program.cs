using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            string name;
            int age;
            int weight;
            double height;
            

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your weight: ");
            weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height: ");
            height = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine(name + " is " + age + " years old, his weight is " + weight +" kg and his height is " + height +"cm");

        }
    }
}
