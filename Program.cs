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
            else {
                Request request = new Request();
                string username = args[0];
                string token = args[1];
                await request.SendRequest(username, token);
            }
        }
            
    }
}