using github_user_activity.Entities;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static async Task Main(string[] args) {
            
            if (args.Length == 0) {
                Console.WriteLine("Please provide a command.");
                return;
            }
            Console.WriteLine("Username: ");
            string username = args[0];
            Console.WriteLine("Token: ");
            string token = args[0];
            Request.SendRequest(username, token);
        }
    }
}