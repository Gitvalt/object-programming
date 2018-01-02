using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace Peliverkkokauppa
{
    public class DatabaseController
    {
        private Uri baseServerAddress = new Uri("http://192.168.100.15:8080");

        //Constructor
        public DatabaseController()
        {
        }

        //test connection to database
        public async Task<Boolean> testConnection()
        {
            try { 
                HttpClient client = new HttpClient();    
                var msg = await client.GetAsync(baseServerAddress.AbsoluteUri + "/news");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Fetch list of all news from mongodb from server $baseServerAddress
        public async Task<List<News>> GetNews()
        {
            try
            {
                HttpClient client = new HttpClient();
                var msg = await client.GetAsync(baseServerAddress.AbsoluteUri + "news");
                
                if (msg.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string content = await msg.Content.ReadAsStringAsync();
                    try
                    {
                        List<News> newsList = JsonConvert.DeserializeObject<List<News>>(content);
                        return newsList;
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }

                else if (msg.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    //could not find the webpage
                    throw new Exception("Fetching data from API has failed. 404 not found.");
                }
                else
                {
                    //something failed;
                    throw new Exception(string.Format("Fetching data from API has failed"));
                }
            }
            catch(HttpRequestException)
            {
                return null;
            }
        }

        public async Task<Boolean> Authenticate(string user, string pass)
        {
            try { 
                HttpClient client = new HttpClient();

                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("user", user),
                    new KeyValuePair<string, string>("pwd", pass)
                });

                var response = await client.PostAsync(baseServerAddress.AbsoluteUri + "login", content);
                string response_as_string = await response.Content.ReadAsStringAsync();
                Boolean status = JsonConvert.DeserializeObject<Boolean>(response_as_string);
                return status;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
