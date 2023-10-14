using System.Collections;
using System.Collections.Generic;

namespace GitHubSystem
{
    public class Repository
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Stars { get; set; }

        public string OwnerId { get; set; }

        public IList<Commit> Commits { get; set; } = new List<Commit>();
    }
}