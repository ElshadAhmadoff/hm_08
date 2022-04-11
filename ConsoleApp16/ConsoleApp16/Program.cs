using ConsoleApp16.Models.hm_08_04;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;

namespace hm_08_04
{
    class Program
    {
        static void Main(string[] args)
        {

            HttpClient client = new HttpClient();
            string str = client.GetStringAsync("https://jsonplaceholder.typicode.com/posts").Result;
            List<User> user = JsonConvert.DeserializeObject<List<User>>(str);
            foreach (User item in user)
            {
                Console.WriteLine(item.title);
            }

        }
    }
}