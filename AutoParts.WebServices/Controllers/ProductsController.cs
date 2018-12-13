using System.Data.Entity;
using System.Linq;
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
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

          // POST: Products/Create
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Create([Bind(Include = "Id,Name,Cost,Price,Quantity")] ProductDto productDto)
            {
                if (ModelState.IsValid)
                {

                _productAppService.CreateProduct(productDto);
                return RedirectToAction("Index");
            }

                return View(productDto);
            }
        
    }
}
