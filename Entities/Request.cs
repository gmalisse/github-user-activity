using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace github_user_activity.Entities {
    internal class Request {
        public Request() { }
        public async Task SendRequest(string username, string token) {
            using (var client = new HttpClient()) {
                User user = new User(username, token);
                var endpoint = new Uri($"https://api.github.com/users/{username}/events");
                client.DefaultRequestHeaders.Add("User-Agent", $"token {token}");

                var result = await client.GetAsync(endpoint);
                var json = await result.Content.ReadAsStringAsync();
                Console.WriteLine(json);
            }           
        }
    }
}
