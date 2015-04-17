# pysimplesoap-wcf
Interoperability test suite for PySimpleSoap clients and WCF services.

Currently focused on testing WCF services that are created using the "Contract-first" development model.

This project is a Visual Studio solution containing two projects.

##Wcf Services `src/WcfServices`
A set of self hosted WCF services, written in C#.

##PySimpleSoap Client Tests `src/ClientTests`
Python 2.7 unit test suite.  Test the use PySimpleSoap clients to call the WCF services.
