using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace DoH.NET
{
    class Program
    {
        static string domain = "borntoberoot.net";
        static string type = "A";

        static void Main(string[] args)
        {
            WebRequest request = WebRequest.Create($"https://cloudflare-dns.com/dns-query?name={domain}&type={type}");
            request.ContentType = "application/dns-json";
            request.Method = "POST";

            WebResponse response = request.GetResponse();

            using Stream stream = response.GetResponseStream();
            using StreamReader reader = new StreamReader(stream);

            var responseData = reader.ReadToEnd();

            var dns = JsonConvert.DeserializeObject<Response>(responseData);

            foreach (var answer in dns.Answer)
            {
                Console.WriteLine(answer);
            }

            Console.WriteLine("Press any key to continue");
            var x = Console.ReadKey();
        }
    }
}
