### Employee Management System - Abstraction
This project demonstrates the concept of abstraction in object-oriented programming (OOP) using C#. It models a simple Employee Management System where different types of employees (Doctor, Teacher, Architect) inherit from an abstract Employee class and implement their own version of a method to describe their job responsibilities.

Project Overview
The system uses abstract classes to define shared properties and behaviors for employees. Each specific employee type (such as Doctor, Teacher, and Architect) overrides a method called Job() to describe their job role. This demonstrates how different classes can share common attributes but have distinct behaviors based on their type.

#### Classes and Methods
1. Employee (Abstract Class)
Properties:
FirstName: The first name of the employee.
LastName: The last name of the employee.
Department: The department the employee works in.
Abstract Method:
Job(): This abstract method is implemented by each derived class to describe the specific duties of that employee type.
2. Doctor (Derived Class)
Inherits from the Employee class.
Implements the Job() method to print a message describing the doctor’s role in the organization.
3. Teacher (Derived Class)
Inherits from the Employee class.
Implements the Job() method to print a message describing the teacher’s role in the organization.
4. Architect (Derived Class)
Inherits from the Employee class.
Implements the Job() method to print a message describing the architect’s role in the organization.

#### How It Works
Each employee type (Doctor, Teacher, Architect) has its own responsibilities, which are represented by the Job() method. The Employee class contains common properties such as FirstName, LastName, and Department that are shared among all employee types. By using abstraction, we can provide a common interface for the different types of employees while allowing each class to implement its specific behavior for the Job() method.

##### Example Output

Ahmet Yılmaz, Internal Medicine department doctor is working.
Zeynep Kara, Mathematics department teacher is working.
Murat Demir, Construction department architect is working.

#### How to Run the Project
Clone or download the repository.
Open the project in Visual Studio or any C# IDE.
Build and run the application.
The program will output the roles of different employees to the console.
Conclusion
This project is a simple demonstration of the abstraction principle in object-oriented programming. It shows how abstract classes can be used to define common properties and behaviors for different types of objects, while each specific class can implement its own version of abstract methods.
