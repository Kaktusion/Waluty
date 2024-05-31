using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace Logic
{

    public class ExchangeRatesTable
    {

        public string Table { get; set; }
        public string No { get; set; }
        public DateOnly EffectiveDate { get; set; }
        public List<ExchangeRate> Rates { get; set; }

        
        
    }
    public class ExchangeRate
    {
        public string Currency { get; set; }
        public string Code { get; set; }
        public decimal Mid { get; set; }
    }
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string CurrencyCodeFrom { get; set; }
        public string CurrencyCodeTo { get; set; }
        public decimal MoneyIn { get; set; }
        public decimal MoneyOut { get;set; }

        public Transaction(DateTime date, string currencyCodeFrom, string currencyCodeTo, decimal moneyIn, decimal moneyOut)
        {
            Date = date;
            CurrencyCodeFrom = currencyCodeFrom;
            CurrencyCodeTo = currencyCodeTo;
            MoneyIn = moneyIn;
            MoneyOut = moneyOut;
        }

    }
}

    



