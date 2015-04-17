using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WcfServices.EmployeeService
{
    [DataContract]
    public class Employee : Person
    {
        [DataMember]
        public string EmployeeId { get; set; }

        [DataMember]
        public List<Contact> Contacts { get; set; }
    }
}