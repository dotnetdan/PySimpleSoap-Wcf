using System;
using System.ServiceModel;

namespace WcfServices
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(EmployeeService.EmployeeService)))
            using (var basicWcfHost = new ServiceHost(typeof(SimpleService.SimpleService)))
            using (var coffeeHost = new ServiceHost(typeof(CoffeeService.CoffeeService)))
            {
                host.Open();
                foreach (var endpoint in host.Description.Endpoints)
                {
                    Console.WriteLine("Endpoint ready at {0}", endpoint.Address);
                }

                basicWcfHost.Open();
                foreach (var endpoint in basicWcfHost.Description.Endpoints)
                {
                    Console.WriteLine("Endpoint ready at {0}", endpoint.Address);
                }

                coffeeHost.Open();
                foreach (var endpoint in coffeeHost.Description.Endpoints)
                {
                    Console.WriteLine("Endpoint ready at {0}", endpoint.Address);
                }     

                Console.ReadLine();
            }
        }
    }
}
