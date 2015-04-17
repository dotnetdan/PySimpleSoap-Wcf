using System.Runtime.Serialization;

namespace WcfServices.EmployeeService
{
    [DataContract]
    public class Manager : Employee
    {
        [DataMember]
        public string ManagerId { get; set; }
    }
}