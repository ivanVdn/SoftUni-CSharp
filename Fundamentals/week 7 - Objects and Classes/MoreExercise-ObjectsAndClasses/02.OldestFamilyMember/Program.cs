using System;
using System.Xml.Linq;

namespace _02.OldestFamilyMember
{
    internal class Program
    {
        internal static void Main()
        {
            var family = new Family();
            var n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                var name = input[0];
                var age = int.Parse(input[1]);

                var person = new Person (name, age );
                family.AddMember(person);
            }

            var oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }

    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    internal class Family
    {
        private List<Person> _people;

        public Family()
        {
            _people = new List<Person>();
        }

        public void AddMember(Person member)
        {
            _people.Add(member);
        }

        public Person GetOldestMember()
        {
            var oldestMember = _people[0];
            for (var i = 1; i < _people.Count; i++)
            {
                if (_people[i].Age > oldestMember.Age)
                {
                    oldestMember = _people[i];
                }
            }
            return oldestMember;
        }
    }
}
