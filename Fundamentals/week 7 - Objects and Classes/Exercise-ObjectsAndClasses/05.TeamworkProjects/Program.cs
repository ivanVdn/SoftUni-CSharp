using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.TeamworkProjects
{
    public class Teams
    {
        public string TeamName { get; set; }
        public string TeamCreator { get; set; }
        public List<string> TeamMember { get; set; } = new List<string>();
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{TeamName}");
            sb.AppendLine($"- {TeamCreator}");
            foreach (var member in TeamMember.OrderBy(member => member))
            {
                sb.AppendLine($"-- {member}");
            }
            return sb.ToString().TrimEnd();
        }
    }

    internal class Program
    {
        static void Main()
        {
            List<Teams> teams = new List<Teams>();
            var team = new Teams();

            var numberOfTeams = int.Parse(Console.ReadLine() ?? string.Empty);

            for (var i = 0; i < numberOfTeams; i++)
            {
                var teamsWithCreator = Console.ReadLine()
                    .Split("-")
                    .Select(s => s.Trim())
                    .ToList();

                var teamCreator = teamsWithCreator[0];
                var teamName = teamsWithCreator[1];

                var isExist = teams.Any(t => t.TeamName == teamName);
                if (isExist)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                isExist = teams.Any(t => t.TeamCreator == teamCreator);
                if (isExist)
                {
                    Console.WriteLine($"{teamCreator} cannot create another team!");
                    continue;
                }

                var newTeam = new Teams() { TeamCreator = teamCreator, TeamName = teamName };
                teams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
            }

            string line;
            while ((line = Console.ReadLine()) != "end of assignment")
            {
                var userToAdd = line?
                    .Split("->")
                    .Select(s => s.Trim())
                    .ToList();
                var teamToAdd = userToAdd[1];
                var user = userToAdd[0];

                team = teams.FirstOrDefault(t => t.TeamName == teamToAdd);
                if (team == null)
                {
                    Console.WriteLine($"Team {teamToAdd} does not exist!");
                    continue;
                }

                if (team.TeamMember.Contains(user) || team.TeamCreator == user || teams.Any(t => t.TeamMember.Contains(user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamToAdd}!");
                    continue;
                }

                team.TeamMember.Add(user);
            }

            var teamToPrint = teams.Where(t => t.TeamMember.Count > 0).OrderByDescending(t => t.TeamMember.Count).ThenBy(t => t.TeamName);
            foreach (var t in teamToPrint)
            {
                Console.WriteLine(t);
            }

            Console.WriteLine("Teams to disband:");
            var teamToDisband = teams.Where(t => t.TeamMember.Count == 0).OrderBy(t => t.TeamName);
            foreach (var t in teamToDisband)
            {
                Console.WriteLine(t.TeamName);
            }
        }
    }
}
