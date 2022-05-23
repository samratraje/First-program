# Methods
- One-Way Methods
	- These methods may or many not accept values, but definitely does not return any value
	- USe the 'void' keyword that represents method is One-way
- Two-Way Methods
	- These methods may or many not accept values, but definitely return value
	- They uses keyword of datatype to represent what type of dat is returned
- Rules for Preventing the APplication from any crash
	- If the Crash is happing because of Wrong Type of data, then prvent it by checking the Type of INput Data
		- use the 'typeof()' operator to verify the type of data usin the 'if' condition

# C# Programming Features
- Programming COnstructs
	- if Statement, if..else statement, if...else...if Nested if
	- Loops
		- for..loop
		- foreach..loop
		- while
		- do..while
- Data Structures
	- Array
		- A CLass that represents mutiple values of SAME-TYPE
		- Any array declared in the application, will be by-default will be an instance of Array Class. 
	- System.Collections namespace
		- ArayList, LinkedList Queue, Stack, etc.
			- Each Entry is stored as Object
	- System.Collections.Generics
		- Generic Concept
- Object Oriented Programming in C#
	- class
		- Access Specifiers
			- private : Set the access of declaration (Data Member, Method, Property) within the class, 
			- public: Set the access of declaration 'Everywhere by any consumer of the class', 
			- protected: Set the access of declaration within class an its derive class, 
			- internal: Set the access of declaration withing a containing namespace and assembly,
			- protected internal: Set the access of declaration in same assemly in derived class also in derived class of dirrerent assemly
			- 
		- Modifiers
			- abstract: When used for class, it is abstract class and it cannot be instntiated, i.e. cannot be repesented as a 'REACL-WORLD' object,
				- WHen used for the method, then the method does not have any logic (Implementation)
				- The Abstract class 'MUST BE INHERITED'
				- The Abstract methos 'MUST BE OVERIIDEN'
					- Write your logic
			- virtual: APplied only on the method, this has an implementation (logic), but this can be changed by the derived class , 
			- static : a class of which instance cannot be created, this is also knws as a 'Shared' class. The static class can have only static method,
			- sealed: Class which cannot be inherited sealed methods cannot be overriden ,
			- override: COmpletely Change implementation of virtual method of te base class or use its as it is in derived class, 
			- new: Shadowing
		- methods
		- properties
	- The class MUST ne instantiated using 'new' keyword,otherwise the runtime will not be able to assign memory to it and if we use the class reference w/o instance the 'Object Referenece is Not to Set an INstance of an object' error will occure at runtime
		- ClaMath math = new ClaMath();
		- FAct: WHen the class is instantiated, its 'DEfault COnstrutor' is called
		- NOTE: A class can have multiple COnstructors with various parameters aka parameterized constructors
	- Logcal Operator
		- || or
		- && AND
		- ! NOT

# Using OOPs For Appliaction Development
- CReate Two-Types of Classes
	- A Class that will only contains properties to accept nd store data	
		- Model Class /  Entity Classes (Generally Name USed) / Value Object / Data Transmision Object (DTO)
		- These propertie with be public properties with get/set
			- set to to accept the data and pass it to the private member
			- get is to read data from provate member and return it
	- A Class that will contain methods to proform Crete / Read / Update /Delete operations using the ENtity Class.
		- Every method in this class with eithr accepts Entity class or return entity class or Both 
	- A class can have 'only one' base class 
	- If the class is DTO / ENtity class, then it can have 'AUTO-IMPLEMENTED' properties (C# 3.0)
- Create an Abstract class that contains Blue-Print for the Implementation
	- This class can contains FOllowing methods
		- virtual methods with default implemenattion, this can be as it is used by derived class or can be changed by derived class by overriding virtual method
		- abstract method, this is a method declaration w/o any implementation, this MUST be implemented by derived class by overriding it, if derived class is not overriding abstract method, then the derived class MUST be made as abstract class otherwise it will not compiled.
- CReate a Sealed class for the logic which cannot be oveiien by deriving the class
	- TaxRules
- Create a 'static' class for having 'one-logic' global to entire application
	- Static class need not tob instantiated
	- It can have only static methods
	- Methods from static class  are directly accessed using name of the class 