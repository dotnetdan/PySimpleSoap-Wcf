using System.Runtime.Serialization;

namespace WcfServices.CoffeeService
{
    [DataContract]
    public class IcedCoffee : Coffee
    {
        [DataMember]
        public int IceCubes { get; set; }
    }
}

