using LabProjectRAiso.Factory;
using LabProjectRAiso.Model;
using LabProjectRAiso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabProjectRAiso.Handler
{
    public class CartHandler
    {
        public static List<Cart> GetCarts(int id)
        {
            return CartRepository.GetAllCart(id);
        }

        public static void AddToCartHandler(int userID, int stationeryID, int quantity)
        {
            Cart cart = CartFactory.CreateCart(userID, stationeryID, quantity);
            CartRepository.AddToCart(cart);
        }

        public static Cart GetCart(int userID, int stationeryID)
        {
            return CartRepository.GetCart(userID, stationeryID);
        }

        public static void UpdateHandler(Cart cart, int quantity)
        {
            CartRepository.UpdateCart(cart, quantity);
        }
    }
}