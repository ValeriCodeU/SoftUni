using System.Collections;
using System.Collections.Generic;

namespace NationalElectionSystem
{
    public class Candidate
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Party { get; set; }

        public IList<Voter> Voters { get; set; } = new List<Voter>();
    }
}