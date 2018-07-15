using System;
using System.Collections.Generic;
using TemplatePattern.Comparable;

namespace TemplatePattern
{
    internal static class Program
    {
        static void Main()
        {
            var tea = new Tea();
            var coffee = new Coffee();
            tea.WantsCondiments = true;
            tea.AddSugar = 5;
            tea.Prepare();
            
            Console.WriteLine();
            coffee.WantsCondiments = true;
            coffee.Prepare();

            var people = new List<Person> { new Person("Ram", 25), new Person("Abishek", 12), new Person("Ram", 18), new Person("Abishek", 18) };
            foreach (var person in people)
            {
                Console.Write(person);
            }
            people.Sort();
            Console.WriteLine();
            foreach (var person in people)
            {
                Console.Write(person);
            }
        }
    }
}
