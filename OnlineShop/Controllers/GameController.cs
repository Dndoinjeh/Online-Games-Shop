
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Models;
using QA.Resources;

namespace OnlineShop.Controllers
{
    public class GameController : Controller
    {
        IOnlineShopRepository onlineShopRepository;
        IStateRepository stateRepository;
        ShoppingBasket basket;

        public GameController()
            : this(new SQLOnlineShopRepository(), new SessionStateRepository())
        {
            basket = new ShoppingBasket();
        }

        public GameController(IOnlineShopRepository onlineShopRepository, IStateRepository stateRespository)
        {
            this.onlineShopRepository = onlineShopRepository;
            this.stateRepository = stateRespository;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "List of Games";
            if (TempData["MyGame"] != null)
            {
                Game myGame = (Game)TempData["MyGame"];
                ViewBag.GameName = myGame.Name + " has been added!";
            }
            IEnumerable<Game> games = onlineShopRepository.GetAllGames();
            return View(games);
        }

        //Adds Game to Basket
        public ActionResult AddToBasket(int id)
        {
            Game myGame = onlineShopRepository.GetGameByGameID(id);
            TempData["myGame"] = myGame;

            basket.AddItem(id, myGame.Name, myGame.UnitPrice, 1);

            return RedirectToAction("Index");
        }




    }
}
