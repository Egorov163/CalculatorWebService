using System;
using System.Net.Http;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputData = new InputDataHelper();

            var inputNumbers = inputData.SetANumbers();

            var inputSign = inputData.SetASign();

            string res = GetString($"https://localhost:7150/api/calculator/{inputSign}/{inputNumbers}");
            Console.WriteLine($"Результат = {res}");
        }

        static public string GetString(string requestUrl)
        {
            string res = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    res = client.GetAsync(requestUrl).Result.Content.ReadAsStringAsync().Result;
                }
            }
            catch (System.Exception)
            {

                throw;
            }
            return res;
        }
    }
}
