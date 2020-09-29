using Currency_Converter.DAL;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;


namespace Currency_Converter
{
    public class Program
    {
        static void Main(string[] args)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();
            //string connectionString = configuration.GetConnectionString("");

            ICurrencyDAO currencyDAO = new CurrencyAPIDAO(connectionString);
            ICountryDAO countryDAO = new CountryAPIDAO(connectionString);
            IHistoryDAO historyDAO = new HistoryAPIDAO(connectionString);

            Menu menu = new Menu(ICurrencyDAO currencyDAO, ICountryDAO countryDAO, IHistoryDAO historyDAO);
            menu.MenuStart();
        }
    }
}
