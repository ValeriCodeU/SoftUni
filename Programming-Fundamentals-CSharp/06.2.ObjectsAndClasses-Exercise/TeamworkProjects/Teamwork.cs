using System;
using System.Collections.Generic;
using System.Text;

namespace TeamworkProjects
{
    class Teamwork
    {
        public Teamwork(string teamName, string creatorName)
        {
            TeamName = teamName;
            CreatorName = creatorName;
            Members = new List<string>();
        }
        public string TeamName { get; set; }

        public string CreatorName { get; set; }

        public List<string> Members { get; set; }

    }
}
