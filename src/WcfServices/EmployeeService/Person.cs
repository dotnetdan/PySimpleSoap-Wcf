using System.Runtime.Serialization;

namespace WcfServices.EmployeeService
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string PersonId { get; set; }
    }
}


