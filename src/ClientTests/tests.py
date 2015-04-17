import unittest
import time
from pprint import pprint
from pysimplesoap.client import SoapClient, SoapFault

class InheritanceTests(unittest.TestCase):

    def test_input_parameter(self):
        client = SoapClient(wsdl="http://localhost:9323/EmployeeService?singleWsdl")
        pprint(client.services)
        result = client.InsertManager(manager={
            "PersonId": "Person123",
            "EmployeeId": "Employee123",
            "ManagerId": "Manager123",
            "Contacts": {"Contact": [{"ContactId": "Contact222", "PersonId": "Person222"},
                                     {"ContactId": "Contact333", "PersonId": "Person333"}]
                        }
            }
        )

        self.assertEqual(result['InsertManagerResult'], True)

    def test_output_parameter(self):
        client = SoapClient(wsdl="http://localhost:9323/EmployeeService?singleWsdl")
        manager = client.GetManager()
        pprint(manager)
        self.assertIsNotNone(manager)

class BasicWcfTests(unittest.TestCase):

    def test_void_operation(self):
        #Testing a 2-way SOAP operation defined by a C# void method adorned by the WCF [OperationContract] attribute
        client = SoapClient(wsdl="http://localhost:9323/SimpleService?singleWsdl")
        result = client.VoidOperation()

        self.assertEqual(result, None)
    
    def test_void_operation_that_throws_an_exception(self):
        #Testing a 2-way SOAP operation defined by a C# void method adorned by the WCF [OperationContract] attribute
        client = SoapClient(wsdl="http://localhost:9323/SimpleService?singleWsdl")
        
        with self.assertRaises(SoapFault):
            result = client.VoidOperationThrowsException()
            selft.assertEqual(result, None)

class ListTests(unittest.TestCase):

    def test_input_list(self):
        client = SoapClient(wsdl="http://localhost:9323/CoffeeService?singleWsdl")      
        
        print "Coffee"
        pprint(client.services)
        
        result = client.SubmitIcedCoffee(icedCoffee={
            "Name":"Iced Coffee Dark",
            "IceCubes": 5,
            "Beans":{"CoffeeBean":[{"Name":"Colombian", "Roast":"Medium"}, {"Name":"French", "Roast":"Light"}]},
            "Ingredients": {"Ingredient":[{"Name":"Coffee"}]},
            "BaseBeverageName": "FooBASE"
        })

        self.assertIsNotNone(result)
        print result

if __name__ == "__main__":
    time.sleep(1) #wait to ensure wcf services are finished starting
  
    unittest.main()
