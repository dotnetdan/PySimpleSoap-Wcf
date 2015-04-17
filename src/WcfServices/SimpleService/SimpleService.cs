using System.ServiceModel;

namespace WcfServices.SimpleService
{
    [ServiceContract]
    public class SimpleService
    {
        [OperationContract]
        public void VoidOperation()
        {
        }

        [OperationContract]
        [FaultContract(typeof(FaultException))]
        public void VoidOperationThrowsException()
        {
            throw new FaultException();
        }
    }
}
