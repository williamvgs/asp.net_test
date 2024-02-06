using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class CryptoService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey = "7d4c3b15-9776-4cb5-8fe9-c574300048d6";

    public CryptoService()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("https://pro-api.coinmarketcap.com/v1/"); // API base URL
    }

    public async Task<CryptoCurrency> GetCryptoData(string symbol)
    {
        string endpoint = $"cryptocurrency/listings/latest?symbol={symbol}";

        // Include API key in request headers
        _httpClient.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", _apiKey);

        HttpResponseMessage response = await _httpClient.GetAsync(endpoint);

        if (response.IsSuccessStatusCode)
        {
            string responseData = await response.Content.ReadAsStringAsync();

            // Deserialize JSON response to your model
            CryptoCurrency cryptoData = JsonConvert.DeserializeObject<CryptoCurrency>(responseData);

            // Check for null after deserialization
            if (cryptoData != null)
            {
                return cryptoData;
            }
            else
            {
                // Handle the case when deserialization fails
                // You might log an error, throw an exception, or return a default value
                // For now, returning null, but consider a more appropriate action
                return null;
            }
        }
        else
        {
            // Handle error response
            // response.StatusCode, response.ReasonPhrase, etc.
            return null;
        }
    }

}
