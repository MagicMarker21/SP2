using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Product
    {
        private int _id;
        private string? _name;
        private decimal _price;

        public int GetId()
        {
            return _id;
        }
        public void SetId(int Id)
        {
            _id = Id;
        }
        public string GetName()
        {

            return _name;
        }
        public void SetName(string Name)
        {
            _name = Name;
        }
        public decimal GetPrice()
        {
            return _price;
        }
        public void SetPrice(decimal Price)
        {
            _price = Price;
        }
    }
}

