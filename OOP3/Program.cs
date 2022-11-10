//Lucas Persson Öhlin - SUT22
using System;

namespace OOP3 {

    internal class Program {

        static void Main(string[] args) {

            Geometry geometry;

            geometry = new Circle(5);
            Console.WriteLine($"Area Circle: {geometry.Area()}");

            geometry = new Square(6);
            Console.WriteLine($"Area Square: {geometry.Area()}");

            geometry = new Rectangle(7, 10);           
            Console.WriteLine($"Area Rectangle: {geometry.Area()}");

        }

    }

    //Abstract makes the class restricted so it cannot be used to create objects (to access it, it must be inherited from another class).
    abstract class Geometry {

        public abstract double Area();

    }

    //Just to be pedantic I wrote out "internal" which is there by default mind you... Just to teach myself that it's there for future projects
    internal class Circle : Geometry {

        //Private since we don't access these variables from outside the class
        private float pi = 3.141f;

        //{ get; set; } is a property, can be used as if it's a public data member but is in fact a special method called an "accessors"
        //The data is easily accessed and still premote flexiblity and safety
        private double radius { get; set; }

        public Circle(double radius) {

            this.radius = radius;

        }

        public override double Area() {

            //Calculate the area of a circle
            return pi * radius * radius;

        }

    }

    internal class Square : Geometry {

        private double size { get; set; }

        public Square(double size) {

            this.size = size;

        }

        public override double Area() {

            //Calculate the area of a square
            return size * size; 

        }

    }

    internal class Rectangle : Geometry {

        private double width { get; set; }
        private double length { get; set; }

        public Rectangle(double width, double length) {

            this.width = width;
            this.length = length;

        }

        public override double Area() {

            //Calculate the area of a rectangle
            return length * width;

        }

    }

}
