using System;
using Newtonsoft.Json;

namespace SalesSystemApi.Clients.Domain
{
    public class Client
    {
        public Client(string name)
        {
            this.name = name;
        }

        [JsonProperty("name")]
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [JsonProperty("id")]
        private int id;
        public int Id
        {
            get { return id; }
        }


    }
}