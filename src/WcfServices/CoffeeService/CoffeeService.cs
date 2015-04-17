using System;
using System.Collections.Generic;
using System.ServiceModel;
using Newtonsoft.Json;

namespace WcfServices.CoffeeService
{
    [ServiceContract]
    public class CoffeeService
    {
        [OperationContract]
        public bool SubmitIcedCoffee(IcedCoffee icedCoffee)
        {
            Console.WriteLine("{0} Iced coffee recieved.", DateTime.Now);
            Console.WriteLine(JsonConvert.SerializeObject(icedCoffee, Formatting.Indented));
            return true;
        }

        [OperationContract]
        public IcedCoffee GetIcedCoffee()
        {
            return new IcedCoffee
                   {
                       Beans = new List<CoffeeBean> {new CoffeeBean {Name = "Colombian", Roast = "Dark"}},
                       Ingredients = new List<Ingredient> { new Ingredient {Name= "An ingredient"} },
                       IceCubes = 4,
                       Name = "Colombian"
                   };
        }
    }
}
