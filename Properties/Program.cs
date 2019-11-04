using Properties.Samples;
using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void Basic()
        {
            var basicCustomer = new CustomerBasic();
            basicCustomer.DisplayData();

            var basicCustomer_1 = new CustomerBasic(1, "Jon Snow", "Knight's watch");
            basicCustomer_1.DisplayData();

            var basicCustomer_2 = new CustomerBasic();
            basicCustomer_2.SetId(2);
            basicCustomer_2.SetName("Sansa Stark");
            basicCustomer_2.SetAddress("Winterfell");

            Console.ReadKey();
        }

        static void ManualProperties()
        {
            var manualProperties = new CustomerManualProperties
            {
                Id = 3,
                Name = "Danny",
                Address = "Dragonstone"
            };

            manualProperties.DisplayData();

            Console.ReadKey();
        }

        static void AutomaticProperties()
        {
            var automaticProperties = new CustomerAutomaticProperties
            {
                Id = 4,
                Name = "Dario",
                Address = "Dragons Bay"
            };

            automaticProperties.DisplayData();

            automaticProperties.Address = "Pentos";
            automaticProperties.DisplayData();

            Console.ReadKey();
        }

        static void PropertyOperations()
        {
            var customerPropertyOperations = new CustomerPropertyOperations(5)
            {
                Name = "Cercei Lanister",
                Address = "King's Landing"
            };

            customerPropertyOperations.DisplayData();

            /*
             * This another readonly property and we can't change the value
             */
            // customerPropertyOperations.CreatedDate = DateTime.Now.AddDays(-2);


            /*
             * This returns an error because the Id is readonly
             */
            // customerPropertyOperations.Id = 6;

            var customPropertyOperations_2 = new CustomerPropertyOperations
            {
                Name = "Bran",
                Address = "Beyond the Wall"
            };

            /*
             * This doesn't work because readonly properties can only be assigned in constructor
             */
            // customPropertyOperations_2.Id = 6;

            customPropertyOperations_2.DisplayData();

            Console.ReadKey();
        }
    }
}
