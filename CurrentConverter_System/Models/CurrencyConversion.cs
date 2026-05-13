using System.ComponentModel.DataAnnotations;
namespace CurrentConverter_System.Models
{
    public class CurrencyConversion
    {
        public int Id { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public string FromCurrency { get; set; } = "USD";
        [Required]
        public string ToCurrency { get; set; } = "SOS";
        [Required]
        public decimal Result { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
