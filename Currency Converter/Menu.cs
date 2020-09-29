using Currency_Converter.DAL;
using System;
using System.Collections.Generic;
//using System.Text;
using Currency_Converter.Models;
//using System.ComponentModel;

namespace Currency_Converter
{
    public class Menu
    {
        const string Command_List_Currencies = "1";
        const string Command_List_Countries = "2";
        const string Command_Historical_Data = "3";
        //const string Command_ = "4";
        //const string Command_ = "5";
        //const string Command_ = "6";
        const string Command_Quit = "Q";

        private ICurrencyDAO currencyDAO;
        private ICountryDAO countryDAO;
        private IHistoryDAO historyDAO;

        public Menu(ICurrencyDAO currencyDAO,ICountryDAO countryDAO, IHistoryDAO historyDAO) 
        {
            this.currencyDAO = currencyDAO;
            this.countryDAO = countryDAO;
            this.historyDAO = historyDAO;
        }

        public void MenuStart()
        {
            Console.WriteLine("Welcome to the currency converter program");
            Console.WriteLine();

        }
    }
}
