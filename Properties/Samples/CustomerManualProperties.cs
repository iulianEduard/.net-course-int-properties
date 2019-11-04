using System;

namespace Properties.Samples
{
    public class CustomerManualProperties
    {
        private int _id;
        private string _name;
        private string _address;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Address { get => _address; set => _address = value; }

        public CustomerManualProperties()
        {
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
