﻿namespace ConsoleSandbox.Advanced
{
    class LinqLambda
    {
        // work in progress

        void Main()
        {
            var buyers = new List<Buyers>()
            {
                    new Buyers() {myAge = 23, Name = "Buyer1", District = "One"},
                    new Buyers() {myAge = 12, Name = "Buyer2", District = "One"},
                    new Buyers() {myAge = 72, Name = "Buyer3", District = "One"},
                    new Buyers() {myAge = 42, Name = "Buyer4", District = "Two"},
                    new Buyers() {myAge = 33, Name = "Buyer5", District = "Two"}
            };
            var suppliers = new List<Supplier>()
            {
                    new Supplier() {myAge = 12, Name = "Supplier1", District = "One"},
                    new Supplier() {myAge = 72, Name = "Supplier2", District = "One"},
                    new Supplier() {myAge = 23, Name = "Supplier3", District = "One"},
                    new Supplier() {myAge = 23, Name = "Supplier4", District = "Two"}
            };

            var linqQuery = from x in buyers
                            where x.myAge >= 20
                            select x; // Linq Query

            var linqQuery2 = buyers.Where(x => x.myAge >= 20);

            var simpleGrouping = buyers.Where(x => x.myAge >= 20)
                                       .GroupBy(x => x.Name)
                                       .OrderByDescending(x => x.Key);

            var simpleGrouping2 = buyers.GroupBy(x => new { x.myAge, x.Name });

            var innerJoin = suppliers.Join(suppliers, s => s.District, b => b.District, // District must be the same on each object
                                            (s, b) => new // creating an new object
                                            {
                                                SupplierName = s.Name,
                                                DistrictName = b.District
                                            });

            var compositeJoin = suppliers.Join(suppliers,
                                                s => new { s.District, s.myAge }, // have to be the same
                                                b => new { b.District, b.myAge }, // have to be the same
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
        private int _mymyAge;
        public string Name { get; set; } // auto-property
        public string District { get; set; }

        public int myAge
        {
            get => _mymyAge;
            set => _mymyAge = value;
        }

        public Buyers()
        {
            Name = "";
            _mymyAge = 0;
        }
    }

    class Supplier
    {
        public string Name { get; set; }
        public string District { get; set; }
        public int myAge { get; set; }
    }
}