using LabProjectRAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabProjectRAiso.Repository
{
    public class CartRepository
    {
        static LocalDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<Cart> GetAllCart(int id)
        {
            return (from x in db.Carts
                    where x.UserID == id
                    select x).ToList();
        }

        public static void AddToCart(Cart cart)
        {
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public static Cart GetCart(int userID, int stationeryID)
        {
            return (from x in db.Carts
                    where x.UserID == userID
                    && x.StationeryID == stationeryID
                    select x).FirstOrDefault();
        }

        public static void UpdateCart(Cart cart, int quantity)
        {
            cart.Quantity = quantity;
            db.SaveChanges();
        }
    }
}