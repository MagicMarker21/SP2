using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id;
        private string? _name;

        private List<StoreItem> items = new List<StoreItem>();
        public int GetId()
        {
            return _id;
        }
        public void SetId(int id)
        {
            _id = id;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            if (quantity > 0)
            {

            
                for (int i = 0; i < items.Count; i++)
                {

                    if (items[i].GetProduct().GetId() == prod.GetId())
                    {
                        items[i].SetQuantity(items[i].GetQuantity() + quantity);
                        return items[i];
                    }

                }
                var item = new StoreItem(prod, quantity);
                items.Add(item);
                return item;
            }
            return null;



        }

        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            for (int i = 0; i< items.Count; i++)
            {
                if (items[i].GetProduct().GetId() == id)
                {
                    items[i].SetQuantity(items[i].GetQuantity() - quantity);
                    if (items[i].GetQuantity() < 0)
                    {
                        items[i].SetQuantity(0);
                    }
                return items[i];
                }
            }

            
            return null;


            //End WIP */
        }
        public List<StoreItem> GetStoreItems()
        {
            return items;
        }
        public StoreItem FindStoreItemById(int id)
        {

           var itemsLINQ = from item in items
                           where id == item.GetProduct().GetId()
                           select item;
            return itemsLINQ.FirstOrDefault();









        }


    }
}
