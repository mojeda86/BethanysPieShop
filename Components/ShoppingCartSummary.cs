﻿using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.ViewModels;

namespace BethanysPieShop.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            this.shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = shoppingCart.GetShoppingCartItems();
            shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = shoppingCart,
                ShoppingCartTotal = shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel); 
        }
    }
}
