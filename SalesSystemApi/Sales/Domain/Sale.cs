using System;
using Newtonsoft.Json;
using SalesSystemApi.Clients.Domain;

namespace SalesSystemApi.Sales.Domain
{
    public class Sale
    {
        public Sale(DateTime date, float total, int clientId)
        {
            this.date = date;
            this.total = total;
            this.clientId = clientId;
        }

        [JsonProperty("date")]
        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        [JsonProperty("total")]
        private float total;
        public float Total
        {
            get { return total; }
            set { total = value; }
        }
        [JsonProperty("clientId")]
        private int clientId;
        public int ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }

        [JsonProperty("id")]
        private int id;
        public int Id
        {
            get { return id; }
        }

        [JsonProperty("client")]
        private ICollection<Client> client;
        public virtual ICollection<Client> Client
        {
            get { return client; }
            set { client = value; }
        }

    }
}