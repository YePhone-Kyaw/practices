namespace LinqSample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer() { name = "Zayden", province = "Alberta" });
            customers.Add(new Customer() { name = "Zenith", province = "Alberta" });
            customers.Add(new Customer() { name = "Zen", province = "British Columbia" });
            customers.Add(new Customer() { name = "Zayu", province = "Ontario" });

            var provinceFilteredCustomers = (from temp in customers
                                             where temp.province == "Alberta" && temp.province == "Ontario"
                                             select temp).ToList<Customer>();

            foreach (var item in provinceFilteredCustomers)
            {
                Console.WriteLine(item.name);
            }

            Console.ReadLine();
        }
    }

    class Customer
    {
        public string name = "";
        public string province = "";
    }
}
