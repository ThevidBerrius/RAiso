using LabProjectRAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabProjectRAiso.Factory
{
    public class CartFactory
    {
        public static Cart CreateCart(int UserID, int StationeryID, int Quantity)
        {
            Cart cart = new Cart()
            {
                UserID = UserID,
                StationeryID = StationeryID,
                Quantity = Quantity
            };
            return cart;
        }
    }
}