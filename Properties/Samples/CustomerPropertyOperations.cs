using System;

namespace Properties.Samples
{
    public class CustomerPropertyOperations
    {
        /// <summary>
        /// This property is readonly
        /// </summary>
        public int Id { get; }

        public string Name { get; set; }

        private string _address;
        public string Address { set { _address = value; } }

        public DateTime CreatedDate => DateTime.Now;

        public bool IsReachable { get; set; }

        public CustomerPropertyOperations(int id)
        {
            Id = id;
        }

        public CustomerPropertyOperations()
        {

        }

        public void DisplayData()
        {
            Console.WriteLine("*** Customer Data ***");
            Console.WriteLine($"Id: #{Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Created at: {CreatedDate}");

            /*
             * This property is write-only and we cannot view it's value
             */
            // Console.WriteLine($"Address: {Address}");
        }
    }
}
