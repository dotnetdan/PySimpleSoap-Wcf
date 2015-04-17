using System.Runtime.Serialization;

namespace WcfServices.CoffeeService
{
    [DataContract]
    public class CoffeeBean
    {
        [DataMember]
        public string Roast { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
