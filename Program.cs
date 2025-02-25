// Written by Kapil
// Feb 24 2025


using System;
using System.Collections.Generic;  // Required for using List<T>
using HomeWork5;

class Program
{
    public static void Main(string[] arg)
    {
        // 1. Vehicles and Cars
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Vehicle("Toyota", "Corolla", 2020),
            new Car("Honda", "Civic", 2019, 4),
            new Motorcycle("Harley-Davidson", "Street 750", 2021, true)
        };

        Console.WriteLine("Vehicles and Cars:");
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.ToString());
        }
        Console.WriteLine();

        // 2. Employees and Specializations
        List<Employee> employees = new List<Employee>
        {
            new Employee("Kapil", 50000),
            new Manager("Jung", 75000, 10),
            new Engineer("Basnet", 60000, "Software Development")
        };

        Console.WriteLine("Employees and Specializations:");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee.ToString());
        }
        Console.WriteLine();

        // 3. Shapes and Areas
        List<Shape> shapes = new List<Shape>
        {
            new Rectangle("Red", 5, 10),
            new Circle("Blue", 7)
        };

        Console.WriteLine("Shapes and Areas:");
        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.ToString());
        }
        Console.WriteLine();

        // 4. Animals and Sounds
        List<Animal> animals = new List<Animal>
        {
            new Animal("Generic Animal"),
            new Dog("Buddy"),
            new Cat("Whiskers")
        };

        Console.WriteLine("Animals and Sounds:");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.ToString());
        }
        Console.WriteLine();

        // 5. Library System
        List<Book> books = new List<Book>
        {
            new Book("1984", "George Orwell", 1949),
            new EBook("The Great Gatsby", "F. Scott Fitzgerald", 1925, 2.5),
            new PrintedBook("To Kill a Mockingbird", "Harper Lee", 1960, 281)
        };

        Console.WriteLine("Library System:");
        foreach (var book in books)
        {
            Console.WriteLine(book.ToString());
        }
    }
}
