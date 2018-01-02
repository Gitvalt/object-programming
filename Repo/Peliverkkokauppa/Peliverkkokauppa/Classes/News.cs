using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Peliverkkokauppa
{
    public class News
    {
        [JsonProperty("ID")]
        public string ID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("tag")]
        private string tag { get; set; }
        public string Tag
        {
            get
            {
                return tag;
            }
        }

        public string StringDate
        {
            get
            {
                return Date.ToString("MMMM dd, yyyy");
            }
        }

        public string FinerDate
        {
            get
            {
                return Date.ToString("dd-MM-yyyy hh:mm:ss");
            }
        }

        public News(string title, string content, DateTimeOffset date)
        {
            Title = title;
            Content = content;
            Date = date;
        }


    }
}
