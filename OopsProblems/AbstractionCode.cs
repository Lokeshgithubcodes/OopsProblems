using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProblems
{
    public abstract class Shape
    {
        // Abstract method (to be implemented by derived classes)
        public abstract void Draw();

        // Regular method
        public void DisplayArea()
        {
            Console.WriteLine("Area calculation is specific to each shape.");
        }
    }

    // Interface
    public interface IDrawable
    {
        void Draw();
    }

    // Concrete class implementing the abstract class and interface
    public class Circlee : Shape, IDrawable
    {
        private double radius;

        public Circlee(double radius)
        {
            this.radius = radius;
        }

        // Implementation of the abstract method from the abstract class
        public override void Draw()
        {
            Console.WriteLine($"Drawing a circle with radius {radius}");
        }

        // Explicit implementation of the interface method
        void IDrawable.Draw()
        {
            Console.WriteLine("Drawing a circle using the IDrawable interface");
        }

        // Additional method specific to the Circle class
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }



}
