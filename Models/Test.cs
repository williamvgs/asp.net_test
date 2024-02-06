using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

class ApiTest
{
    public static async Task<UserResult?> Main()
    {
        // Replace the API endpoint with the actual endpoint you want to call
        string apiEndpoint = "https://randomuser.me/api/?nat=us&randomapi";

        using (HttpClient client = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(apiEndpoint);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    UserResult? userResult = JsonSerializer.Deserialize<UserResult>(result);
                    Console.WriteLine(userResult);
                    return userResult;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
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
