using System;

namespace OOP3 {

    internal class Program {

        static void Main(string[] args) {

            //Constructing three new objects from the three respective class's constructors
            var circel = new Circel(5);
            var fyrkant = new Fyrkant(6);
            var rektangel = new Rektangel(7, 10);

            Console.WriteLine($"Area Circel: {circel.Area()}");
            Console.WriteLine($"Area Fyrkant: {fyrkant.Area()}");
            Console.WriteLine($"Area Rektangel: {rektangel.Area()}");

        }

    }

    //Abstract makes the class restricted so it cannot be used to create objects (to access it, it must be inherited from another class).
    abstract class Geometri {

        public abstract double Area();

    }

    //Just to be pedantic I wrote out "internal" which is there by default mind you... Just to teach myself that it's there for future projects
    internal class Circel : Geometri {

        //Private since we don't access these variables from outside the class
        private float pi = 3.141f;

        //{ get; set; } is a property, can be used as if it's a public data member but is in fact a special method called an "accessors"
        //The data is easily accessed and still premote flexiblity and safety
        private double radius { get; set; }

        public Circel(double radius) {

            this.radius = radius;

        }

        public override double Area() {

            //Calculate the area of a circle
            return pi * radius * radius;

        }

    }

    internal class Fyrkant : Geometri {

        private double size { get; set; }

        public Fyrkant(double size) {

            this.size = size;

        }

        public override double Area() {

            //Calculate the area of a square
            return size * size; 

        }

    }

    internal class Rektangel : Geometri {

        private double width { get; set; }
        private double length { get; set; }

        public Rektangel(double width, double length) {

            this.width = width;
            this.length = length;
        }

        public override double Area() {

            //Calculate the area of a rectangle
            return length * width;

        }

    }

}
