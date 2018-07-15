using System;

namespace TemplatePattern.Comparable
{
    class Person : IComparable
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(object obj)
        {
            var other = (Person)obj;
            if (String.Compare(Name, other.Name, StringComparison.Ordinal) == 0)
            {
                return Age.CompareTo(other.Age);
            }
            return String.Compare(Name, other.Name, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return $"{Name} : {Age} < ";
        }

    }
}