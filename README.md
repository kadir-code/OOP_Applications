# OOP_Applications
This repository contains object oriented programming works and for covering oop principles by implementing winform applications.
### Why Is OOP Needed?
It is a model that organizes the design of software over data and objects.It allows writing object-level code with C#.
### Class Concept
It is the part where the properties and behaviors of the objects needed are kept. Determined behaviors are transferred to classes with methods. While the variables specified in the class hold the information to be used in the class; Methods define the tasks that the class will perform. An object produced in a class can be used in the whole program, and for a change to be made on the object, it is sufficient to update the class in which the object is located.
### Inheritance
```
class Vehicle 
{
  //Common vehicle properties
}

class Car : Vehicle 
{
  //Vehicle's properties
  //Car's properties and methods
}
```
It is the case that the properties of a class can also be used in a subclass.
### Abstraction
It is the definition of the behavior and properties of a class.
* Abstract classes are generally used when implementing inheritance.
* They cannot be transferred to the object and used with the new word.
* The use of all methods of classes derived from abstract classes is mandatory.
* A class can only inherit from an abstract class.
* They cannot be defined as static.

### Polymorphism
A subclass that inherits traits from a superclass may behave differently from the superclass. The ability to define different properties even though they have common properties with superclass objects is called polymorphism.

### Encapsulation
While the properties and behaviors of a class are abstracted and stored in a class, we can limit which properties of that class can be exposed or not by encapsulation. With encapsulation, it is checked whether the specified features will be presented or not.

### Interface
It is a construct that is used for abstraction. It is used to inherit the written method definitions from the classes that will derive from it.
* Objects cannot be created with the new keyword.
* All interfaces are defined as abstract and public by default.
* It allows multiple inheritance.
* Only the signatures of the methods are included in it, they cannot contain a filled method.

> All methods in the interface must be used by the derived class.

### Method Overriding
A method defined in the superclass is inherited to a subclass with the same signature and parameter, but the method body is rewritten.
* The value returned by the overridden method must be the same as the value defined in the superclass.
* The final keyword and static methods cannot be overridden.

