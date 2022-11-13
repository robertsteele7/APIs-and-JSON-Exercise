using APIsAndJSON;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
namespace KanyeAndRon 
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new QuoteGenerator();


            for (int i = 0; i < 7; i++)
            {

                Console.WriteLine($"Kanye: {quote.KanyeQuote()}");
                
                Console.WriteLine($"Ron Swanson:{quote.RonQuote()}");

                Console.WriteLine($"-----------------------------------------------------------");
            }
        }
    }
}
