using System;
using System.Collections.Generic;
using System.ServiceModel;
using Newtonsoft.Json;

namespace WcfServices.EmployeeService
{
    /// <summary>
    /// Service for testing input/output contracts that have inheritance more than two levels deep.
    /// </summary>
    [ServiceContract]
    public class EmployeeService
    {
        [OperationContract]
        public bool InsertManager(Manager manager)
        {
            Console.WriteLine(JsonConvert.SerializeObject(manager, Formatting.Indented));
            return true;
        }

        [OperationContract]
        public Manager GetManager()
        {
            return new Manager
                   {
                       EmployeeId = "Employee1",
                       ManagerId = "Manager1",
                       PersonId = "Persaon1",
                       Contacts = new List<Contact> { new Contact { ContactId = "Contact1", PersonId = "Person2" }, 
                                                      new Contact { ContactId = "Contact1", PersonId = "Person2" } }
                   };
        }


    }
}
