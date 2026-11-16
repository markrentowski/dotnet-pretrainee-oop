## About
This is a simple employee management system

## Features
- different employee types (Developer, Manager, Designer)
- display of information about the employee and his/her work
- generating reports
- on-screen menu to run specific functions
- validations in place to prevent invalid input for the menu and employee properties

## OOP Principles
- **Encapsulation:** Employee salary variable is protected against direct modifications, but can be changed using a public _ChangeSalary_ method;
- **Inheritance:** Different employee types are inherited from the base class Employee and share base properties
- **Asbstraction and polymorphism:** Employee base class has an abstract _Work_ method which is overridden in every inherited class
- **Interfaces:** An _IReportable_ interface is providing _GenerateReport_ method for _Developer_ and _Manager_ types 
- **Event Handling:** Salary change has a _SalaryChanged_ event handler which is used in _ChangeEmployeeSalary_ method