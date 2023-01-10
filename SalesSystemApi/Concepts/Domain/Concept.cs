using System;
using Newtonsoft.Json;
using SalesSystemApi.Products.Domain;
using SalesSystemApi.Sales.Domain;

namespace SalesSystemApi.Concepts.Domain
{
    public class Concept
    {
        public Concept(int saleId, int quantity, float unitPrice, float import, int productId)
        {
            this.saleId = saleId;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
            this.import = import;
            this.productId = productId;
        }

        [JsonProperty("saleId")]
        private int saleId;
        public int SaleId
        {
            get { return saleId; }
            set { saleId = value; }
        }

        [JsonProperty("quantity")]
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        [JsonProperty("unitPrice")]
        private float unitPrice;
        public float UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        [JsonProperty("import")]
        private float import;
        public float Import
        {
            get { return import; }
            set { import = value; }
        }

        [JsonProperty("productId")]
        private int productId;
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        [JsonProperty("id")]
        private int id;
        public int Id
        {
            get { return id; }
        }

        [JsonProperty("products")]
        private ICollection<Product> products;
        public virtual ICollection<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        [JsonProperty("sales")]
        private ICollection<Sale> sales;
        public virtual ICollection<Sale> Sales
        {
            get { return sales; }
            set { sales = value; }
        }


    }
}