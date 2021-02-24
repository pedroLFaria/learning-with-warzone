﻿using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ConsoleApp1.source.person;
using ConsoleApp1.source.resources;
using ConsoleApp1.source.utils;

namespace ConsoleApp1
{
    class Program
    {
        private static HttpClient client = ProgramHttpClient.GetInstance.client;

        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(AllPlayerResource.getMatchResults("1326408137834580344")[0].playerStats.kdRatio);
        }

        static async Task<Person> getPerson()
        {
            return await client.GetFromJsonAsync<Person>("http://demo0592621.mockable.io/teste");
        }
    }
}