using System;
using System.Collections.Generic;
using System.Linq;

namespace NationalElectionSystem
{
    public class ElectionManager : IElectionManager
    {
        private Dictionary<string, Candidate> candidatesByName = new Dictionary<string, Candidate>();
        private Dictionary<string, Voter> votersByName = new Dictionary<string, Voter>();

        public void AddCandidate(Candidate candidate)
        {
            if (!this.candidatesByName.ContainsKey(candidate.Id))
            {
                this.candidatesByName.Add(candidate.Id, candidate);
            }

        }

        public void AddVoter(Voter voter)
        {
            if (!this.votersByName.ContainsKey(voter.Id))
            {
                this.votersByName.Add(voter.Id, voter);
            }
        }

        public bool Contains(Candidate candidate)
        {
            return this.candidatesByName.ContainsKey(candidate.Id);
        }

        public bool Contains(Voter voter)
        {
            return this.votersByName.ContainsKey(voter.Id);
        }

        public IEnumerable<Candidate> GetCandidates()
        {
            return this.candidatesByName.Values;
        }

        public IEnumerable<Voter> GetVoters()
        {
            return this.votersByName.Values;
        }

        public void Vote(string voterId, string candidateId)
        {
            if (!this.votersByName.ContainsKey(voterId)
                || !this.candidatesByName.ContainsKey(candidateId)
                || this.votersByName[voterId].Age < 18
                || this.candidatesByName[candidateId].Voters.Contains(votersByName[voterId]))
            {
                throw new ArgumentException();
            }

            this.candidatesByName[candidateId].Voters.Add(votersByName[voterId]);
        }

        public int GetVotesForCandidate(string candidateId)
        {
            return candidatesByName[candidateId].Voters.Count;
        }

        public IEnumerable<Candidate> GetWinner()
        {
            var maxVoteCount = this.candidatesByName.Values.Max(c => c.Voters.Count);

            if (maxVoteCount == 0)
            {
                return null;
            }

            var candidatesWithMostVotes = this.candidatesByName.Values.Where(c => c.Voters.Count == maxVoteCount);
            return candidatesWithMostVotes;
        }

        public IEnumerable<Candidate> GetCandidatesByParty(string party)
        {
            return this.candidatesByName.Values.Where(c => c.Party == party).OrderByDescending(c => c.Voters.Count);
        }
    }
}