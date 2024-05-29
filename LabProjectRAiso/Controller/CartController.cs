using LabProjectRAiso.Handler;
using LabProjectRAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabProjectRAiso.Controller
{
    public class CartController
    {
        public static List<Cart> GetCarts(int id)
        {
            return CartHandler.GetCarts(id);
        }

        public static void AddToCart(int userID, int stationeryID, int quantity)
        {
            CartHandler.AddToCartHandler(userID, stationeryID, quantity);
        }

        public static Cart GetCart(int userID, int stationeryID)
        {
            return CartHandler.GetCart(userID, stationeryID);
        }

        public static void UpdateCart(Cart cart, int quantity)
        {
            CartHandler.UpdateHandler(cart, quantity);
        }
    }
}