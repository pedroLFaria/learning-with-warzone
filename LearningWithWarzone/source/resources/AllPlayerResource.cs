using System;
using System.Collections.Generic;
using System.Net.Http;
using LerningWithWarzone.source.models;
using LerningWithWarzone.source.utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConsoleApp1.source.resources {
	public class AllPlayerResource {
		private static HttpClient client = ProgramHttpClient.GetInstance.client;

		public static List<MatchDetails> getMatchResults(String matchId) {
			try {
				var matchResultResponse = client.GetStringAsync(
					$"https://www.callofduty.com/api/papi-client/crm/cod/v2/title/mw/platform/battle/fullMatch/wz/{matchId}/it"
				);
				var teste = JsonConvert.DeserializeObject(matchResultResponse.Result);
				var matchResultJson = JObject.Parse(matchResultResponse.Result);
				var allPlayers = matchResultJson["data"]["allPlayers"].ToObject<List<MatchDetails>>();
				var matchDetailsJson = desirealizeActivisionMatchResul(matchResultJson);
				return allPlayers;
			}
			catch (Exception e) {
				Console.WriteLine("Erro na requisição de resultado da partida: " + e.Message);
				throw;
			}
		}

		private static MatchDetails desirealizeActivisionMatchResul(JObject matchResultJson) {
			MatchDetails matchDetails = new MatchDetails();
			deserializeMatchDetails(matchResultJson, matchDetails);
			deserializePlayers(matchResultJson, matchDetails);
			return matchDetails;
		}

		private static void deserializeMatchDetails(JObject matchResultJson, MatchDetails matchDetails) {
			var matchDetailsJson = matchResultJson["data"]["allPlayers"][0];
			matchDetails.map = matchDetailsJson?["map"]?.ToString();
			matchDetails.teamCount = (int) matchDetailsJson?["teamCount"];
			matchDetails.playerCount = (int) matchDetailsJson?["playerCount"];
			matchDetails.startDate = DateTimeOffset.FromUnixTimeSeconds((int) matchDetailsJson?["utcStartSeconds"])
				.UtcDateTime;
			matchDetails.endDate =
				DateTimeOffset.FromUnixTimeSeconds((int) matchDetailsJson?["utcEndSeconds"]).UtcDateTime;
			matchDetails.matchId = matchDetailsJson?["matchID"]?.ToString();
		}

		private static void deserializePlayers(JObject matchResultJson, MatchDetails matchDetails) {
			foreach (var playerJson in matchResultJson?["data"]?["allPlayers"]) {
				Player player = new Player();
				player.uno = playerJson?["player"]?["uno"]?.ToString();
				player.username = playerJson?["player"]?["username"]?.ToString();
				player.clantag = playerJson?["player"]?["clantag"]?.ToString();
				player.kills = (int) playerJson?["playerStats"]?["kills"];
				player.death = (int) playerJson?["playerStats"]?["deaths"];
				player.damageDone = (int) playerJson?["playerStats"]?["damageDone"];
				player.damageTaken = (int) playerJson?["playerStats"]?["damageTaken"];
				matchDetails.players.Add(player);
			}
		}
	}
}