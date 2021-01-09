using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADLVShop.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public int AvailableItems { get; set; }


        public ProductModel()
        {
            Id = -1;
            ProductName = "Nothing";
            ProductDescription = "Nothing yet";
            ProductPrice = -1.0;
            AvailableItems = -1;
        }

        public ProductModel(int id, string productName, string productDescription, double productPrice, int availableItems)
        {
            Id = id;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductPrice = productPrice;
            AvailableItems = availableItems;
        }
    }
}