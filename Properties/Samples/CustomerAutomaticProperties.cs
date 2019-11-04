using System;

namespace Properties.Samples
{
    public class CustomerAutomaticProperties
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public CustomerAutomaticProperties()
        {
        }

        public void DisplayData()
        {
            Console.WriteLine("*** Customer Data ***");
            Console.WriteLine($"Id: #{Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
        }
    }
}
