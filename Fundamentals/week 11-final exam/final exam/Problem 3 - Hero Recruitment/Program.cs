using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Hero_Recruitment
{
    internal class Program
    {
        static void Main()
        {
            var heroes = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var command = input?.Split();
                var heroName = command?[1];

                switch (command?[0])
                {
                    case "Enroll":

                        if (!heroes.ContainsKey(heroName))
                        {
                            heroes.Add(heroName, new List<string>());
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} is already enrolled.");
                        }

                        break;
                    case "Learn":

                        var spellName = command[2];
                        if (heroes.ContainsKey(heroName))
                        {
                            if (!heroes[heroName].Contains(spellName))
                            {
                                heroes[heroName].Add(spellName);
                            }
                            else
                            {
                                Console.WriteLine($"{heroName} has already learnt {spellName}.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }

                        break;
                    case "Unlearn":

                        spellName = command[2];
                        if (heroes.ContainsKey(heroName))
                        {
                            if (heroes[heroName].Contains(spellName))
                            {
                                heroes[heroName].Remove(spellName);
                            }
                            else
                            {
                                Console.WriteLine($"{heroName} doesn't know {spellName}.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }

                        break;
                }
            }

            Console.WriteLine("Heroes:");
            foreach (var hero in heroes)
            {
                Console.WriteLine($"== {hero.Key}: {(hero.Value.Count > 0 ? string.Join(", ", hero.Value) : "")}");
            }
        }
    }
}
