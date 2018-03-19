using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Models;
using QA.Resources;


namespace OnlineShop.Controllers
{
    public class CheckoutController : Controller
    {
        IOnlineShopRepository onlineShopRepository;
        IStateRepository stateRepository;

        public CheckoutController()
            : this(new SQLOnlineShopRepository(), new SessionStateRepository())
        {
        }

        public CheckoutController(IOnlineShopRepository onlineShopRepository, IStateRepository stateRepository)
        {
            this.onlineShopRepository = onlineShopRepository;
            this.stateRepository = stateRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
