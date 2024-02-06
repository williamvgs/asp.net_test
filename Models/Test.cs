using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

class ApiTest
{
    public static async Task<UserResult?> Main()
    {
        // Replace the API endpoint with the actual endpoint you want to call
        string apiEndpoint = "https://randomuser.me/api/?nat=us&randomapi";

        using (HttpClient client = new HttpClient())
        {
            //testing
            var testing = new UserResult();
            testing.Results = new List<Result>();
            testing.Results.Add(new Result()
            {
                Name = new Name()
                {
                    First = "Per",
                    Last = "Hansen",
                    Title = "Sjef"
                }
            });




            try
            {
                HttpResponseMessage response = await client.GetAsync(apiEndpoint);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    UserResult userResult = JsonConvert.DeserializeObject<UserResult>(result);
                    //var userResult = testing;
                    Console.WriteLine(userResult);
                    //string json = JsonConvert.SerializeObject(userResult);

                    return userResult;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            return null;
        }
    }
}
