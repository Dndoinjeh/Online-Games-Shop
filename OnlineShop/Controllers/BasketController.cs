using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Models;
using QA.Resources;

namespace OnlineShop.Controllers
{
    public class BasketController : Controller
    {
        IOnlineShopRepository onlineShopRepository;
        IStateRepository stateRepository;
        ShoppingBasket basket;

        public BasketController()
            : this(new SQLOnlineShopRepository(), new SessionStateRepository())
        {
            basket = new ShoppingBasket();
        }

        public BasketController(IOnlineShopRepository onlineShopRepository, IStateRepository stateRepository)
        {
            this.onlineShopRepository = onlineShopRepository;
            this.stateRepository = stateRepository;
        }

        public ActionResult Index()
        {
            if (basket.BasketItems.Count == 0)
                {
                return View("noItem");
            }
            else
            {
                return View(basket.BasketItems);
            }
          
     
        }



        public ActionResult AdjustQuantity(int id, int quantity)
        {
            Game myGame = onlineShopRepository.GetGameByGameID(id);
            TempData["myGame"] = myGame;


            basket.AdjustItemQuantity(id, 1);

            return RedirectToAction("Index");

        }

        public ActionResult Remove(int ID)
        {
            basket.RemoveItem(ID);
           return RedirectToAction("Index");

        }
    }
}
