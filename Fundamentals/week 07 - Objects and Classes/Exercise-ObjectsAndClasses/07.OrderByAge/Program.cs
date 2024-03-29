using static _07.OrderByAge.Program;

namespace _07.OrderByAge
{
    public class Person
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public uint Age { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            var persons = new List<Person>();
            string? input;
            while ((input = Console.ReadLine()) != "End")
            {
                string?[]? personInfo = input?
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var person = new Person();

                person.Name = personInfo?[0];
                person.Id = personInfo?[1];
                person.Age = uint.Parse(personInfo?[2] ?? string.Empty);

                persons.Add(person);

                var findPerson = persons.FirstOrDefault(p => p.Id == person.Id);

                if (findPerson != null)
                {
                    person.Age = person.Age;
                    person.Name = person.Name;
                }
                else
                {
                    persons.Add(person);
                }
            }

            foreach (var person in persons.OrderBy(p => p.Age).ToList())
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}
