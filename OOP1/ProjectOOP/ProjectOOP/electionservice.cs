
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ProjectOOP
{
    public static class ElectionService
    {
        public static int TotalVoters()
        {
            return Database.GetCount(
                "SELECT COUNT(*) FROM dbo.Voters");
        }

        public static int VotesCast()
        {
            return Database.GetCount(
                "SELECT COUNT(*) FROM dbo.Votes");
        }

        public static int RemainingVoters()
        {
            return TotalVoters() - VotesCast();
        }

        public static DataTable GetCandidates()
        {
            return Database.GetData(
                @"SELECT CandidateID,
                         CandidateName,
                         Position,
                         Platform
                  FROM dbo.Candidates
                  ORDER BY CandidateID");
        }

        public static DataTable GetVoters()
        {
            return Database.GetData(
                @"SELECT VoterID,
                         VoterName,
                         CASE
                             WHEN HasVoted = 1
                             THEN 'Voted'
                             ELSE 'Not Voted'
                         END AS Status
                  FROM dbo.Voters
                  ORDER BY VoterID");
        }

        public static DataTable GetResults()
        {
            return Database.GetData(
                @"SELECT *
                  FROM dbo.ElectionResults
                  ORDER BY TotalVotes DESC");
        }
    }
}
