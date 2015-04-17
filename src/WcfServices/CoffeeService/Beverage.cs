using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WcfServices.CoffeeService
{
    [DataContract]
    public class Beverage : BaseBeverage
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public List<Ingredient> Ingredients { get; set; }
    }

    [DataContract]
    public class BaseBeverage
    {
        [DataMember]
        public string BaseBeverageName { get; set; }
    }

    [DataContract]
    public class Ingredient
    {
        [DataMember]
        public string Name { get; set; }
    }
}
