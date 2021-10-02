using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());

            List<Teamwork> totalTeams = new List<Teamwork>();

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] input = Console.ReadLine().Split("-");
                string creator = input[0];
                string teamName = input[1];

                bool isTeamCreated = totalTeams.Select(x => x.TeamName).Contains(teamName);
                bool isMemberCreated = totalTeams.Any(u => u.CreatorName == creator);

                if (!isMemberCreated && !isTeamCreated)
                {
                    Teamwork currentTeam = new Teamwork(teamName, creator);
                    totalTeams.Add(currentTeam);

                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
                else if (isTeamCreated)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (isMemberCreated)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }                
            }
            string input2 = Console.ReadLine();

            while (input2 != "end of assignment")
            {
                string[] teamJoin = input2.Split("->");

                bool isTeamExist = totalTeams.Any(x => x.TeamName == teamJoin[1]);
                bool isCreatorCheating = totalTeams.Any(x => x.CreatorName == teamJoin[0]);
                bool isAleardyExist = totalTeams.Any(x => x.Members.Contains(teamJoin[0]));

                if (!isAleardyExist && !isCreatorCheating && isTeamExist)
                {
                    int indexOfTeam = totalTeams.FindIndex(x => x.TeamName == teamJoin[1]);

                    totalTeams[indexOfTeam].Members.Add(teamJoin[0]);
                }
                else if (!isTeamExist)
                {
                    Console.WriteLine($"Team {teamJoin[1]} does not exist!");
                }
                else if (isCreatorCheating || isAleardyExist)
                {
                    Console.WriteLine($"Member {teamJoin[0]} cannot join team {teamJoin[1]}!");
                }

                input2 = Console.ReadLine();
            }

            List<Teamwork> finalResultMembers = totalTeams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)
                .ToList();

            List<Teamwork> TeamFalse = totalTeams
           .Where(x => x.Members.Count == 0)
           .OrderBy(x => x.TeamName)
           .ToList();

            foreach (var team in finalResultMembers)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine("- " + team.CreatorName);
                team.Members.Sort();
                Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(x => "-- " + x)));
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in TeamFalse)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }
}
