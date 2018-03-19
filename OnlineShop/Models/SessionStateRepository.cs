using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QA.Resources;

namespace OnlineShop.Models
{
    public class SessionStateRepository:IStateRepository
    {
        ShoppingBasket IStateRepository.GetShoppingBasket()
        {
            throw new NotImplementedException();
        }
    }
}