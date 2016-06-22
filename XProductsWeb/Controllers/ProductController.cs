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
        public ActionResult Index(Models.ProductViewModel model)
        {
            model.Categories = bm.GetAllCategories();
            model.Products = bm.GetAllProducts();
            model.Search = "";

            return View(model);
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
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Models.ProductViewModel model)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
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
            catch
            {
                return View(model);
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Search(ProductViewModel model)
        {
            model.Categories = bm.GetAllCategories();

            bool category = model.SelectedCategory != 0;
            bool search = model.Search != null;

            if (!category && !search)
            {
                model.Products = getAllProducts();
            }
            else
            {
                if (category && search)
                {
                    model.Products = bm.GetProductsByCategoryIdAndName(model.SelectedCategory, model.Search);                    
                }
                else if (category)
                {
                    model.Products = bm.GetProductsByCategoryId(model.SelectedCategory);
                }
                else if (search)
                {
                    model.Products = bm.GetProductsByName(model.Search);
                }
            } 

            return View("Index", model);
        }

        private List<Product> getAllProducts()
        {
            return bm.GetAllProducts();
        }
    }
}
