using System;
using System.Collections.Generic;
using WiredBrainCoffee.DataAccess.Model;

namespace WireBrainCoffee.ShopInfoTool
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShop()
        {
            yield return new CoffeeShop { location = "Frankfurt", BeansInStocking = 107 };
            yield return new CoffeeShop { location = "Freiburg", BeansInStocking = 23 };
            yield return new CoffeeShop { location = "Munich", BeansInStocking = 56 };
        }
    }
}
