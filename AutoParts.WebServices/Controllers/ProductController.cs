using AutoParts.Aplication.Dtos;
using AutoParts.Aplication.Services;
using AutoParts.Domain.Commons;
using AutoParts.Domain.Entities;
using AutoParts.Infrastructure.Commons;
using AutoParts.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoParts.WebServices.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductServices _productAppService;
        public ProductController()
        {
            DbContext dbContext = new ProyectContext();
            IRepository<Product> products = new Repository<Product>(dbContext);
            _productAppService = new ProductServices(products);
        }
        // GET: Product
        public ActionResult Index()
        {
            //_productAppService.CreateProduct(new ProductDto(1, "martillo", 0.5, 1.5));
            //_productAppService.AddProduct(1, 123);
            var products = _productAppService.GetProducts();
            return View(products.ToList());
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                _productAppService.CreateProduct(new ProductDto(123, "martillo", 0.5, 1.5));
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
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
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
    }
}
