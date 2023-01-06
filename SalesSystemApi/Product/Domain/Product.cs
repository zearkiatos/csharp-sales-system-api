using System;
using Newtonsoft.Json;

namespace SalesSystemApi.Product.Domain
{
    public class Product
    {
        public Product(string name, float unitPrice, float cost)
        {
            this.name = name;
            this.unitPrice = unitPrice;
            this.cost = cost;
        }

        [JsonProperty("name")]
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [JsonProperty("unitPrice")]
        private float unitPrice;
        public float UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }
        [JsonProperty("cost")]
        private float cost;
        public float Cost
        {
            get { return cost; }
            set { cost = value; }
        }



        private int id;
        public int Id
        {
            get { return id; }
        }


    }
}