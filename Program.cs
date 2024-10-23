using System;
using System.Net.Http;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            using (var client = new HttpClient()) {
                var endpoint = new Uri("https://api.github.com/users/gmalisse/events");

               
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
            }
        }
    }
}