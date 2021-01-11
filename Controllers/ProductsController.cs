using ADLVShop.Data;
using ADLVShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADLVShop.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            //generate some fake data and send it to a view
            List<ProductModel> products = new List<ProductModel>();
            ProductDAO productDAO = new ProductDAO();

            products = productDAO.FetchAll();

            return View("Index", products);
        }

        public ActionResult Details(int id)
        {
            ProductDAO productDAO = new ProductDAO();
            ProductModel product = productDAO.FetchOne(id);

            return View("Details", product);
        }

        public ActionResult Create()
        {
            return View("ProductForm");

        }

        public ActionResult Edit(int id)
        {
            ProductDAO productDAO = new ProductDAO();
            ProductModel product = productDAO.FetchOne(id);
            return View("ProductForm", product);

        }
        
        [HttpPost]
        public ActionResult ProcessCreate(ProductModel productModel) 
        {
            //save to the .db
            ProductDAO productDAO = new ProductDAO();

            productDAO.CreateOrUpdate(productModel);

            return View("Details", productModel);
        }
    }
}