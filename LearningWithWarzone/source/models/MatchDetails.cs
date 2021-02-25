using System;
using System.Collections.Generic;

namespace LerningWithWarzone.source.models
{
    public class MatchDetails
    {
        public int utcStartSeconds { get; set; }
        public int utcEndSeconds { get; set; }
        public DateTime startDate { get; set; }
        public  DateTime endDate { get; set; }
        public List<team> teams { get; set; }
        public string map { get; set; }
        public string mode { get; set; }
        public string matchId { get; set; }
        public int duration { get; set; }
        public object playlistName { get; set; }
        public int version { get; set; }
        public string gameType { get; set; }
        public int playerCount { get; set; }
        public Playerstats playerStats { get; set; }
        public Player player { get; set; }
        public List<Player> players { get; set; }
        public int teamCount { get; set; }
        public object rankedTeams { get; set; }
        public bool draw { get; set; }
        public bool privateMatch { get; set; }
    }
}