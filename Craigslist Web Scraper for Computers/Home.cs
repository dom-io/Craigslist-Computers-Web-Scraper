using Microsoft.AspNetCore.Html;
using System.Net;
using System.Xml.Linq;
using System.IO;
using System.Text;

namespace Craigslist_Web_Scraper_for_Computers
{
    public class Home
    {
        static async Task Main(string[] args)
        {
            // We'll use the HttpClient class to 
            // send a request to the server
            using (var client = new HttpClient())
            {
                // We'll use the GetAsync method to send 
                // a GET request to the specified URL
                var response = await client.GetAsync("https://orangecounty.craigslist.org/search/sya#search=1~gallery~0~0");

                // If the response is successful, we'll
                // interpret the response as XML
                if (response.IsSuccessStatusCode)
                {
                    var xml = await response.Content.ReadAsStringAsync();

                    // We can then use the LINQ to XML API to query the XML
                    var doc = XDocument.Parse(xml);

                    // Let's query the XML to get all of the <title> elements
                    var titles = html.

                    // And finally, we'll print out the titles
                    foreach (var title in titles)
                    {
                        Console.WriteLine(title);
                    }
                }
            }
        }

        //// HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
        //static readonly HttpClient client = new HttpClient();

        //static async Task Main()
        //{
        //    // Call asynchronous network methods in a try/catch block to handle exceptions.
        //    try
        //    {
        //        using HttpResponseMessage response = await client.GetAsync("https://orangecounty.craigslist.org/search/sya#search=1~gallery~0~0");
        //        response.EnsureSuccessStatusCode();
        //        string responseBody = await response.Content.ReadAsStringAsync();
        //        // Above three lines can be replaced with new helper method below
        //        //string responseBody = await client.GetStringAsync("https://orangecounty.craigslist.org/search/sya#search=1~gallery~0~0");

        //        Console.WriteLine(responseBody);
        //        Console.WriteLine("yo");
        //    }
        //    catch (HttpRequestException e)
        //    {
        //        Console.WriteLine("\nException Caught!");
        //        Console.WriteLine("Message :{0} ", e.Message);
        //    }
        //}

    }
}
