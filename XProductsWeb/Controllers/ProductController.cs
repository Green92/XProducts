using BusinessLayer;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XProductsWeb.Models;

namespace XProductsWeb.Controllers
{
    public class ProductController : Controller
    {
        private BusinessManager bm = BusinessManager.Instance;

        // GET: Product
        public ActionResult Index(ProductViewModel model)
        {
            model.Categories = bm.GetAllCategories();
            model.Products = bm.GetAllProducts();
            model.Search = "";

            return View(model);
        }

        public ActionResult GetProducts(string categoryId, string searchText)
        {
            ProductViewModel model = new ProductViewModel();
            int id = int.Parse(categoryId);

            bool category = id != 0;
            bool search = searchText != null;

            if (!category && !search)
            {
                model.Products = getAllProducts();
            }
            else
            {
                if (category && search)
                {
                    model.Products = bm.GetProductsByCategoryIdAndName(id, searchText);
                }
                else if (category)
                {
                    model.Products = bm.GetProductsByCategoryId(id);
                }
                else if (search)
                {
                    model.Products = bm.GetProductsByName(searchText);
                }
            }
            
            return PartialView("PartialProduct", model);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            ProductDetailsViewModel model = new ProductDetailsViewModel();
            model.Product = bm.GetProductById(id);
            model.Category = bm.GetCategoryById(model.Product.CategoryId);

            return View(model);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            ProductEditViewModel model = new ProductEditViewModel();
            model.Categories = bm.GetAllCategories();

            return View(model);
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductEditViewModel model)
        {
            try
            {
                model.Categories = bm.GetAllCategories();

                if (model == null || !ModelState.IsValid)
                {
                    return View(model);
                }

                model.Product.Category = bm.GetCategoryById(model.Product.CategoryId);
                bm.AddProduct(model.Product);

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View(model);
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            ProductEditViewModel model = new ProductEditViewModel();
            model.Product = bm.GetProductById(id);
            model.Categories = bm.GetAllCategories();

            return View(model);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ProductEditViewModel model)
        {
            try
            {
                model.Categories = bm.GetAllCategories();

                if (model == null || !ModelState.IsValid )
                {
                    return View(model);
                }

                model.Product.Category = bm.GetCategoryById(model.Product.CategoryId);
                bm.EditProduct(model.Product);

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View(model);
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            ProductDetailsViewModel model = new ProductDetailsViewModel();
            model.Product = bm.GetProductById(id);

            return View(model);
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ProductDetailsViewModel model)
        {
            try
            {
                bm.DeleteProduct(model.Product.Id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        private List<Product> getAllProducts()
        {
            return bm.GetAllProducts();
        }
    }
}
