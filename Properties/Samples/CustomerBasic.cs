using System;

namespace Properties.Samples
{
    public class CustomerBasic
    {
        private string _name;
        private int _id;
        private string _address;

        public CustomerBasic()
        {
        }

        public CustomerBasic(int id, string name, string address)
        {
            _id = id;
            _name = name;
            _address = address;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName(string name)
        {
            return _name;
        }

        public void SetAddress(string address)
        {
            _address = address;
        }

        public string GetAddress()
        {
            return _address;
        }

        public void DisplayData()
        {
            Console.WriteLine("*** Customer Data ***");
            Console.WriteLine($"Id: #{_id}");
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Address: {_address}");
        }
    }
}
