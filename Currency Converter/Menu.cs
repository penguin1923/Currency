using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Currency_Converter
{
    public class Menu
    {
        public void MenuStart() 
        {
            Console.WriteLine("Welcome to the currency converter program");
            Console.ReadLine();
            ListCurrency();
        }
        public void ListCurrency() 
        {
            //
            var client = new RestClient("https://free.currconv.com/api/v7/currencies?apiKey=f2196ac580f903faf2c4");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cookie", "__cfduid=d5ff7c2076506b64a724a9761178bb3e51601307747");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
