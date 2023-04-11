Introduction
Classes
The primary object-oriented construct in C# is the class, which is a combination of data (fields) and behavior (methods). The fields and methods of a class are known as its members.

Access to members can be restricted through access modifiers, the two most common ones being:

public: the member can be accessed by any code (no restrictions).
private: the member can only be accessed by code in the same class.
You can think of a class as a template for creating instances of that class. To create an instance of a class (also known as an object), the new keyword is used:

class Car
{
}

// Create two car instances
var myCar = new Car();
var yourCar = new Car();
Fields have a type and can be defined anywhere in a class. Public fields are defined in PascalCase and private fields are defined in camelCase and prefixed with an underscore _:

class Car
{
    // Accessible by anyone
    public int Weight;

    // Only accessible by code in this class
    private string _color;
}
One can optionally assign an initial value to a field. If a field does not specify an initial value, it wll be set to its type's default value. An instance's field values can be accessed and updated using dot-notation.

class Car
{
    // Will be set to specified value
    public int Weight = 2500;

    // Will be set to default value (0)
    public int Year;
}

var newCar = new Car();
newCar.Weight; // => 2500
newCar.Year;   // => 0

// Update value of the field
newCar.Year = 2018;
Private fields are usually updated as a side-effect of calling a method. Such methods usually don't return any value, in which case the return type should be void:

class CarImporter
{
    private int _carsImported;

    public void ImportCars(int numberOfCars)
    {
        // Update private field from public method
        _carsImported = _carsImported + numberOfCars;
    }
}
