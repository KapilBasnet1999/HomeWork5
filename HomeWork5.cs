// Written by Kapil
// Feb 24 2025

using System;

namespace HomeWork5
{
    // 1. Vehicles and Cars
    public class Vehicle
    {
        // Private variables
        private string make = "n/a";
        private string model = "n/a";
        private int year = -1;

        // Properties (Getters and Setters)
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        // Constructor
        public Vehicle(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        // Override ToString()
        public override string ToString()
        {
            return $"{Year} {Make} {Model}";
        }
    }

    public class Car : Vehicle
    {
        // Private variable
        private int numberOfDoors = -1;

        // Property
        public int NumberOfDoors
        {
            get { return this.numberOfDoors; }
            set { this.numberOfDoors = value; }
        }

        // Constructor
        public Car(string make, string model, int year, int numberOfDoors) : base(make, model, year)
        {
            this.NumberOfDoors = numberOfDoors;
        }

        // Override ToString()
        public override string ToString()
        {
            return $"{base.ToString()} with {NumberOfDoors} doors";
        }
    }

    public class Motorcycle : Vehicle
    {
        // Private variable
        private bool hasSidecar = false;

        // Property
        public bool HasSidecar
        {
            get { return this.hasSidecar; }
            set { this.hasSidecar = value; }
        }

        // Constructor
        public Motorcycle(string make, string model, int year, bool hasSidecar) : base(make, model, year)
        {
            this.HasSidecar = hasSidecar;
        }

        // Override ToString()
        public override string ToString()
        {
            return $"{base.ToString()} (Has Sidecar: {HasSidecar})";
        }
    }

    // 2. Employees and Specializations
    public class Employee
    {
        // Private variables
        private string name = "n/a";
        private decimal salary = -1;

        // Properties (Getters and Setters)
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        // Constructor
        public Employee(string name, decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        // Override ToString()
        public override string ToString()
        {
            return $"Employee: {Name}, Salary: ${Salary}";
        }
    }

    public class Manager : Employee
    {
        // Private variable
        private int numberOfEmployeesManaged = -1;

        // Property
        public int NumberOfEmployeesManaged
        {
            get { return this.numberOfEmployeesManaged; }
            set { this.numberOfEmployeesManaged = value; }
        }

        // Constructor
        public Manager(string name, decimal salary, int numberOfEmployeesManaged) : base(name, salary)
        {
            this.NumberOfEmployeesManaged = numberOfEmployeesManaged;
        }

        // Override ToString()
        public override string ToString()
        {
            return $"{base.ToString()}, Employees Managed: {NumberOfEmployeesManaged}";
        }
    }

    public class Engineer : Employee
    {
        // Private variable
        private string specialization = "n/a";

        // Property
        public string Specialization
        {
            get { return this.specialization; }
            set { this.specialization = value; }
        }

        // Constructor
        public Engineer(string name, decimal salary, string specialization) : base(name, salary)
        {
            this.Specialization = specialization;
        }

        // Override ToString()
        public override string ToString()
        {
            return $"{base.ToString()}, Specialization: {Specialization}";
        }
    }

    // 3. Shapes and Areas
    public abstract class Shape
    {
        // Private variable
        private string color = "n/a";

        // Property
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        // Constructor
        public Shape(string color)
        {
            this.Color = color;
        }

        // Abstract method
        public abstract double GetArea();
        

        // Override ToString()
        public override string ToString()
        {
            return $"{Color} Shape";
        }
    }

    public class Rectangle : Shape
    {
        // Private variables
        private double width = -1;
        private double height = -1;

        // Properties
        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        // Constructor
        public Rectangle(string color, double width, double height) : base(color)
        {
            this.Width = width;
            this.Height = height;
        }

        // Override GetArea()
        public override double GetArea()
        {
            return Width * Height;
        }

        // Override ToString()
        public override string ToString()
        {
            return $"{base.ToString()}, Width: {Width}, Height: {Height}, Area: {GetArea()}";
        }
    }

    public class Circle : Shape
    {
        // Private variable
        private double radius = -1;

        // Property
        public double Radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }

        // Constructor
        public Circle(string color, double radius) : base(color)
        {
            this.Radius = radius;
        }

        // Override GetArea()
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        // Override ToString()
        public override string ToString()
        {
            return $"{base.ToString()}, Radius: {Radius}, Area: {GetArea()}";
        }
    }

    // 4. Animals and Sounds
    public class Animal
    {
        // Private variable
        private string name = "n/a";

        // Property
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Constructor
        public Animal(string name)
        {
            this.Name = name;
        }

        // Virtual method
        public virtual string MakeSound()
        {
            return "Some generic animal sound";
        }

        // Override ToString()
        public override string ToString()
        {
            return $"Animal: {Name}, Sound: {MakeSound()}";
        }
    }

    public class Dog : Animal
    {
        // Constructor
        public Dog(string name) : base(name) { }

        // Override MakeSound()
        public override string MakeSound()
        {
            return "Bark";
        }
    }

    public class Cat : Animal
    {
        // Constructor
        public Cat(string name) : base(name) { }

        // Override MakeSound()
        public override string MakeSound()
        {
            return "Meow";
        }
    }

    // 5. Library System
    public class Book
    {
        // Private variables
        private string title = "n/a";
        private string author = "n/a";
        private int yearPublished = -1;

        // Properties
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        public int YearPublished
        {
            get { return this.yearPublished; }
            set { this.yearPublished = value; }
        }

        // Constructor
        public Book(string title, string author, int yearPublished)
        {
            this.Title = title;
            this.Author = author;
            this.YearPublished = yearPublished;
        }

        // Override ToString()
        public override string ToString()
        {
            return $"{Title} by {Author} ({YearPublished})";
        }
    }

    public class EBook : Book
    {
        // Private variable
        private double fileSizeMB = -1;

        // Property
        public double FileSizeMB
        {
            get { return this.fileSizeMB; }
            set { this.fileSizeMB = value; }
        }

        // Constructor
        public EBook(string title, string author, int yearPublished, double fileSizeMB) : base(title, author, yearPublished)
        {
            this.FileSizeMB = fileSizeMB;
        }

        // Override ToString()
        public override string ToString()
        {
            return $"{base.ToString()}, File Size: {FileSizeMB}MB";
        }
    }

    public class PrintedBook : Book
    {
        // Private variable
        private int pageCount = -1;

        // Property
        public int PageCount
        {
            get { return this.pageCount; }
            set { this.pageCount = value; }
        }

        // Constructor
        public PrintedBook(string title, string author, int yearPublished, int pageCount) : base(title, author, yearPublished)
        {
            this.PageCount = pageCount;
        }

        // Override ToString()
        public override string ToString()
        {
            return $"{base.ToString()}, Pages: {PageCount}";
        }
    }
}