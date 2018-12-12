using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoParts.Aplication.Dtos;
using AutoParts.Aplication.Services;
using AutoParts.Domain.Commons;
using AutoParts.Domain.Entities;
using AutoParts.Infrastructure.Commons;
using AutoParts.Infrastructure.Contexts;

namespace AutoParts.WebServices.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductServices _productAppService;
        public ProductsController()
        {
            DbContext dbContext = new ProyectContext();
            IRepository<Product> products = new Repository<Product>(dbContext);
            _productAppService = new ProductServices(products);
        }

        // GET: Products
        public ActionResult Index()
        {
            return View(_productAppService.GetProducts().ToList());
            //return View();
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            return View(_productAppService.GetProducts().ToList());
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //ProductDto productDto = db.products.Find(id);
            //if (productDto == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(productDto);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        //    // POST: Products/Create
        //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Create([Bind(Include = "Id,Name,Cost,Price,Quantity")] ProductDto productDto)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            ProyectContext.products.Add(productDto);
        //            db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }

        //        return View(productDto);
        //    }

        //    // GET: Products/Edit/5
        //    public ActionResult Edit(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //        }
        //        ProductDto productDto = db.products.Find(id);
        //        if (productDto == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        return View(productDto);
        //    }

        //    // POST: Products/Edit/5
        //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Edit([Bind(Include = "Id,Name,Cost,Price,Quantity")] ProductDto productDto)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            bContext.Entry(productDto).State = EntityState.Modified;
        //            db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }
        //        return View(productDto);
        //    }

        //    // GET: Products/Delete/5
        //    public ActionResult Delete(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //        }
        //        ProductDto productDto = db.products.Find(id);
        //        if (productDto == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        return View(productDto);
        //    }

        //    // POST: Products/Delete/5
        //    [HttpPost, ActionName("Delete")]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult DeleteConfirmed(int id)
        //    {
        //        ProductDto productDto = db.products.Find(id);
        //        db.products.Remove(productDto);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    protected override void Dispose(bool disposing)
        //    {
        //        if (disposing)
        //        {
        //            db.Dispose();
        //        }
        //        base.Dispose(disposing);
        //    }
        //}
    }
}
