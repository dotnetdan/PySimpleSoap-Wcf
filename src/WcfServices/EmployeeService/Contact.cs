using System.Runtime.Serialization;

namespace WcfServices.EmployeeService
{
    [DataContract]
    public class Contact : Person
    {
        [DataMember]
        public string ContactId { get; set; }
    }
}