using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class CryptoController : Controller
{
    private readonly CryptoService _cryptoService;

    public CryptoController(CryptoService cryptoService)
    {
        _cryptoService = cryptoService;
    }

    public async Task<IActionResult> Index()
    {
        // Example: Retrieve Bitcoin data
        CryptoCurrency bitcoinData = await _cryptoService.GetCryptoData("BTC");

        // Use the data in your view or perform additional actions

        return View(bitcoinData);
    }
}
