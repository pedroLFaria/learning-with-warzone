using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ConsoleApp1.source.resources;
using LerningWithWarzone.source.person;
using LerningWithWarzone.source.utils;

namespace LerningWithWarzone
{
    class Program
    {
        private static HttpClient client = ProgramHttpClient.GetInstance.client;

        static async Task Main(string[] args)
        {
            var matchResult = AllPlayerResource.getMatchResults("10521100311752649465");
            var player = matchResult.Find(result => result.player.username.Contains("Jonymiguxo"));
            Console.WriteLine($"Username: {player.player.username}; kills: {player.playerStats.kills}; Deaths: {player.playerStats.deaths}");
        }

        static async Task<Person> getPerson()
        {
            return await client.GetFromJsonAsync<Person>("http://demo0592621.mockable.io/teste");
        }
    }
}