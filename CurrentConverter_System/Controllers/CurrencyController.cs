using CurrentConverter_System.Data;
using CurrentConverter_System.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CurrentConverter_System.Controllers
{
    public class CurrencyController : Controller
    {
        private readonly CurrencyDbContext _context;
        public CurrencyController(CurrencyDbContext context)
        {
            _context = context;
        }

        // BOGGA 1: Form-ka lagu qoro lacagta (GET)
        [HttpGet]
        public IActionResult Index()
        {
            // Hubi in faylkaaga uu magaciisu yahay Index.cshtml ama Convert.cshtml
            return View();
        }

        // SHAQADA SARRIFKA (POST)
        [HttpPost]
        public async Task<IActionResult> Index(decimal amount, string fromCurrency, string toCurrency)
        {
            try
            {
                decimal rate = await GetExchangeRateFromApi(fromCurrency, toCurrency);
                decimal finalResult = amount * rate;

                var conversion = new CurrencyConversion
                {
                    Amount = amount,
                    FromCurrency = fromCurrency,
                    ToCurrency = toCurrency,
                    Result = finalResult,
                    CreatedAt = DateTime.Now
                };

                _context.Conversions.Add(conversion);
                await _context.SaveChangesAsync();

                ViewBag.Result = $"{amount} {fromCurrency} = {finalResult:N2} {toCurrency}";
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Cilad ayaa dhacday: " + ex.Message;
            }

            return View();
        }

        // BOGGA 2: Table-ka History-ga (GET)
        public IActionResult History()
        {
            var history = _context.Conversions
                .OrderByDescending(x => x.CreatedAt)
                .ToList();
            return View(history);
        }

        private async Task<decimal> GetExchangeRateFromApi(string from, string to)
        {
            string url = $"https://open.er-api.com/v6/latest/{from}";
            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync(url);
                // dynamic waxay u baahan tahay Newtonsoft.Json
                dynamic data = JsonConvert.DeserializeObject(response);
                return (decimal)data.rates[to];
            }
        }
    }
}