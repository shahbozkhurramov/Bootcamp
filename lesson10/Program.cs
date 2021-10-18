using System;
using System.Text.Json;
using System.Threading.Tasks;
using lesson10.Dto.PrayerTime;
using lesson10.Dto.User;
using lesson10.Services;

namespace lesson10
{
    class Program
    {
        private static string usersApi = "https://randomuser.me/api/";
        private static string prayerTimeApi= $"http://api.aladhan.com/v1/timingsByCity?city=&country=&method=8";
        public static void Modify(string city,string country)
        {
            prayerTimeApi= $"http://api.aladhan.com/v1/timingsByCity?city={city}&country={country}&method=8";
        }
        static async Task Main(string[] args)
        {
            Console.Write("Enter city: ");
            var city = Console.ReadLine();
            Console.Write("Enter country: ");
            var country = Console.ReadLine();
            Modify(city,country);
            var httpService = new HttpClientService();
            var result = await httpService.GetObjectAsync<PrayerTime>(prayerTimeApi);

            if(result.IsSuccess)
            {
                var settings = new JsonSerializerOptions()
                {
                    WriteIndented = true
                };

                var json = JsonSerializer.Serialize(result.Data, settings);
                json=json.Replace("\"", "");
                json=json.Replace("      ", "");
                json=json.Substring(27,128);
                Console.WriteLine(json);
            }
            else
            {
                Console.WriteLine($"{result.ErrorMessage}");
            }
            
        }
        static async Task Main_user(string[] args)
        {
            var httpService = new HttpClientService();
            var result = await httpService.GetObjectAsync<User>(usersApi);

            if(result.IsSuccess)
            {
                Console.WriteLine($"{result.Data.Results[0].Name.First}");
            }
            else
            {
                Console.WriteLine($"{result.ErrorMessage}");
            }
            
        }
    }
}
