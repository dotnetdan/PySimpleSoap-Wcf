using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WcfServices.CoffeeService
{
    [DataContract]
    public class Coffee : Beverage
    {
        [DataMember]
        public List<CoffeeBean> Beans { get; set; }
    }
}
