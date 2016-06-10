using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Dapper;
using Microsoft.Data.Sqlite;
using Nancy;

namespace NancyVsVapor
{
    public class HomeModule : NancyModule
    {
        private static string connstring = string.Concat("Data Source=", Path.Combine(
            Path.GetDirectoryName(typeof(HomeModule).GetTypeInfo().Assembly.Location),
            "test.sqlite"));

        private static Random random = new Random();

        public HomeModule()
        {
            Get("/plaintext", _ => "Hello, World!");

            Get("/json", _ =>
            {
                return Response.AsJson(new JsonModel());
            });

            Get("sqlite-fetch", async (_, __) =>
            {
                using (var conn = new SqliteConnection(connstring))
                {
                    var users = await conn.QueryAsync<User>("select * from users where id = @id", new { id = random.Next(1, 3) });
                    return Response.AsJson(users.FirstOrDefault());
                }
            });
        }
    }
}
