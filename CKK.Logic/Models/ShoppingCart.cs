using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer? _customer;
        private List<ShoppingCartItem> items = new List<ShoppingCartItem>();

        public ShoppingCart(Customer cust)
        {
            _customer = cust;
        }
        public int GetCustomerId()
        {
            return _customer.GetId();
        }
        public ShoppingCartItem AddProduct(Product prod, int quantity) //Change, WIP
        {

            if (quantity <= 0)
            {
                return null;
            }
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].GetProduct().GetId() == prod.GetId())
                {
                    items[i].SetQuantity(items[i].GetQuantity() + quantity);
                    return items[i];
                }
            }
            var item = new ShoppingCartItem(prod, quantity);
            items.Add(item);
            return item;//End work in Progress
        }
        public ShoppingCartItem AddProduct(Product prod)//Change
        {
            return AddProduct(prod, 1);

        }
        public ShoppingCartItem RemoveProduct(int id, int quantity)//Change
        {
            
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].GetProduct().GetId() == id)
                {
                    items[i].SetQuantity(items[i].GetQuantity() - quantity);
                    if (items[i].GetQuantity() <= 0)
                    {
                        var item = new ShoppingCartItem(items[i].GetProduct(), 0);
                        items.RemoveAt(i);
                        return item;
                        
                    }
                    return items[i];
                }
                    
                
            }

            return null;
        }
        public ShoppingCartItem GetProductById(int id) //Change
        {
            var itemsLINQ = from item in items
                            orderby item.GetProduct().GetId()
                            where item.GetProduct().GetId() == id
                            select item;
            return itemsLINQ.FirstOrDefault();

        }
        public decimal GetTotal()
        {
            decimal total = 0;
            var itemsLINQ = from item in items
                        select item;
            foreach (var item in itemsLINQ)
            {
                total += item.GetTotal();
            }
            return total;
                


        }
        public List<ShoppingCartItem> GetProducts()
        {
            return items;


        }
















    }
}
