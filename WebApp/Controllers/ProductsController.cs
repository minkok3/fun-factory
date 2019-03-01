using System.Linq;
using System.Web.Mvc;
using WebApp.Data;
using WebApp.Extensions;

namespace WebApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly FunFactoryDbContext _dbContext = new FunFactoryDbContext();

        public ActionResult Index()
        {
            ViewBag.Title = "Products";
            var products = _dbContext.Products.ToList();
            return View(products);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var product = _dbContext.Products.Find(id);

            return View(product);
        }

        [HttpPost]
        public ActionResult Details(int id, int qty)
        {
            var product = _dbContext.Products.Find(id);
            product.AdjustStockQuantities(qty);
            _dbContext.SaveChanges();

            ViewBag.Message = "Purchase successful";
            return View(product);
        }
    }
}
