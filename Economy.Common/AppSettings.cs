using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Common
{
    public class AppSettings
    {
        public static string Token { get => ConfigurationManager.AppSettings.Get("Token"); }
        public static string TokenNumber { get => ConfigurationManager.AppSettings.Get("TokenNumber"); }
        public static string ApiEmailUrl { get => ConfigurationManager.AppSettings.Get("ApiEmailUrl"); }
        public static string ApiNumberUrl { get => ConfigurationManager.AppSettings.Get("ApiNumberUrl"); }
        public static string ApiExchangeRatesDataUrl { get => ConfigurationManager.AppSettings.Get("ApiExchangeRatesDataUrl"); }
    }
}
