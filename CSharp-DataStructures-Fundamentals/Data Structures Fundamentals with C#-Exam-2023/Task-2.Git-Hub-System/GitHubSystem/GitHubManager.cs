using System;
using System.Collections.Generic;
using System.Linq;

namespace GitHubSystem
{
    public class GitHubManager : IGitHubManager
    {
        private Dictionary<string, User> users = new Dictionary<string, User>();
        private Dictionary<string, Repository> repositories = new Dictionary<string, Repository>();      


        public void Create(User user)
        {
            if (!this.users.ContainsKey(user.Id))
            {
                users.Add(user.Id, user);
            }            
        }

        public void Create(Repository repository)
        {
            if (!this.repositories.ContainsKey(repository.Id))
            {
                repositories.Add(repository.Id, repository);
            }           
        }

        public bool Contains(User user)
        {
            return this.users.ContainsKey(user.Id);
        }

        public bool Contains(Repository repository)
        {
            return this.repositories.ContainsKey(repository.Id);
        }

        public void CommitChanges(Commit commit)
        {
            if (!this.repositories.ContainsKey(commit.RepositoryId) || !users.ContainsKey(commit.UserId))
            {
                throw new ArgumentException();
            }

            this.repositories[commit.RepositoryId].OwnerId = commit.UserId;
            this.repositories[commit.RepositoryId].Commits.Add(commit);

        }

        public Repository ForkRepository(string repositoryId, string userId)
        {
            if (!this.repositories.ContainsKey(repositoryId) || !users.ContainsKey(userId))
            {
                throw new ArgumentException();
            }            

            var repoForFork = repositories[repositoryId];

            var newRepo = new Repository()
            {
                Id = Guid.NewGuid().ToString(),
                Commits = repoForFork.Commits,
                OwnerId = userId,
                Name = repoForFork.Name
            };

            this.Create(newRepo);

            return this.repositories[newRepo.Id];

        }

        public IEnumerable<Commit> GetCommitsForRepository(string repositoryId)
        {
            var repo = this.repositories[repositoryId];

            return repo.Commits;
        }

        public IEnumerable<Repository> GetRepositoriesByOwner(string userId)
        {
            return this.repositories.Values.Where(r => r.OwnerId == userId);
        }

        public IEnumerable<Repository> GetMostForkedRepositories()
        {
            return this.repositories.Values.OrderByDescending(r => r.OwnerId);
        }

        public IEnumerable<Repository> GetRepositoriesOrderedByCommitsInDescending()
        {
            return this.repositories.Values.OrderByDescending(c => c.Commits.Count);
        }
    }
}