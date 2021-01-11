using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ADLVShop.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [Required]
        [DisplayName ("Product Name")]
        public string ProductName { get; set; }
        [Required]
        [DisplayName("Description")]
        public string ProductDescription { get; set; }
        [Required]
        [DisplayName("Product Price")]
        public double ProductPrice { get; set; }
        [Required]
        [DisplayName("Available items")]
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