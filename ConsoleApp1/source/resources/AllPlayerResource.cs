using System;
using System.Collections.Generic;
using System.Net.Http;
using ConsoleApp1.source.models;
using ConsoleApp1.source.utils;
using Newtonsoft.Json.Linq;

namespace ConsoleApp1.source.resources
{
    public class AllPlayerResource
    {
        private static HttpClient client = ProgramHttpClient.GetInstance.client;

        public static List<MatchResult> getMatchResults(String matchId)
        {
            try
            {
                var matchResultResponse = client.GetStringAsync(
                    $"https://www.callofduty.com/api/papi-client/crm/cod/v2/title/mw/platform/battle/fullMatch/wz/${matchId}/it"
                );
                var matchResultJson = JObject.Parse(matchResultResponse.Result);
                var allPlayers = matchResultJson["data"]["allPlayers"].ToObject<List<MatchResult>>();
                return allPlayers;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro na requisição de resultado da partida: " + e.Message);
                throw;
            }
        }
    }
}