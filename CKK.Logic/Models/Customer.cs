using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Customer
    {
        private int _id;
        private string? _name;
        private string? _address;

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
        public string GetAddress()
        {
            return _address;
        }
        public void SetAddress(string Address)
        {
            _address = Address;
        }


    }
}
