using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApplicationConsole
{
    class LinqQueriesLambdaOperations
    {
        void Main()
        {
            var buyers = new List<Buyers>()
            {
                    new Buyers() {Age = 23, Name = "Buyer1", District = "One"},
                    new Buyers() {Age = 12, Name = "Buyer2", District = "One"},
                    new Buyers() {Age = 72, Name = "Buyer3", District = "One"},
                    new Buyers() {Age = 42, Name = "Buyer4", District = "Two"},
                    new Buyers() {Age = 33, Name = "Buyer5", District = "Two"}
            };
            var suppliers = new List<Supplier>()
            {
                    new Supplier() {Age = 12, Name = "Supplier1", District = "One"},
                    new Supplier() {Age = 72, Name = "Supplier2", District = "One"},
                    new Supplier() {Age = 23, Name = "Supplier3", District = "One"},
                    new Supplier() {Age = 23, Name = "Supplier4", District = "Two"}
            };

            var linqQuery = from x in buyers
                            where x.Age >= 20
                            select x; // Linq Query

            var linqQuery2 = buyers.Where(x => (x.Age >= 20));

            var simpleGrouping = buyers.Where(x => x.Age >= 20)
                                       .GroupBy(x => x.Name)
                                       .OrderByDescending(x => x.Key);

            var simpleGrouping2 = buyers.GroupBy(x => new { x.Age, x.Name });

            var innerJoin = suppliers.Join(suppliers, s => s.District, b => b.District, // District must be the same on each object
                                            (s, b) => new // creating an new object
                                            {
                                                SupplierName = s.Name,
                                                DistrictName = b.District
                                            });

            var compositeJoin = suppliers.Join(suppliers,
                                                s => new { s.District, s.Age }, // have to be the same
                                                b => new { b.District, b.Age }, // have to be the same
                                                (s, b) => new
                                                {
                                                    SupplierName = s.Name,
                                                    DistrictName = b.District
                                                });

            Console.ReadKey();
        }
    }

    internal class Buyers
    {
        private int myAge;
        public string Name { get; set; } // auto-property
        public string District { get; set; }

        public int Age
        {
            get => myAge;
            set => myAge = value;
        }

        public Buyers()
        {
            Name = "";
            Age = 0;
        }
    }

    internal class Supplier
    {
        public string Name { get; set; }
        public string District { get; set; }
        public int Age { get; set; }
    }
}