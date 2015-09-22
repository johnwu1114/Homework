using System.Web.Mvc;

namespace PotterShoppingCart.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var bll = new ProductBLL();
            var models = bll.GetProductList();
            return View(models);
        }

        [HttpPost]
        public ActionResult Bills(Order model)
        {
            var bll = new OrderBLL();
            model.TotalPrice = bll.GetBills(model);
            return View(model);
        }
    }
}