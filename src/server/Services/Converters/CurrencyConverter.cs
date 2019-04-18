using System;
using Server.Infrastructure;
namespace Server.Services.Converters
{
    public class CurrencyConverter : ICurrencyConverter
    {
        public decimal GetConvertSum(decimal CurrencyFromSum, Currency CurrencyFrom, Currency CurrencyTo)
        {
            decimal CurrencyFromValue;
            decimal CurrencyToValue;
            decimal CurrencyToSum;
            
            if (CurrencyFromSum <= 0.00M)
                throw new Exception();

            if (!Constants.Currencies.TryGetValue(CurrencyFrom, out CurrencyFromValue))
                throw new Exception();

            if(!Constants.Currencies.TryGetValue(CurrencyTo, out CurrencyToValue))
                throw new Exception();

            CurrencyToSum = Math.Round(CurrencyFromSum * (CurrencyFromValue / CurrencyToValue),2);
            if (CurrencyToSum <= 0.00M)
                throw new Exception();

            return CurrencyToSum;
        }
    }
}

