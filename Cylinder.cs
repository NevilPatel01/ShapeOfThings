/*
 * I, Nevil Patel, 000892482 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
 *  Class:  Cylinder.cs
 *  Date: October 13, 2023
 *  Purpose : The purpose of making this file is to create a class with all required formula in it.
 */

using System;

namespace Lab2
{
    /// <summary>
    /// This class Represent the Cylinder shape 3-dimensional object extends Shape Class which containg the formula of Area and 
    /// Volume of Cylinder with it's value like Radius and Height.
    /// </summary>
    public class Cylinder : Shape
    {
        /// <summary>
        /// Getter and Protected Setter Method for Public Variables like Radius and Height of Cylinder with Double Datatype.
        /// </summary>
        public double Radius { get; protected set; }
        public double Height { get; protected set; }

        /// <summary>
        /// Initalizing a new Instace called Cylinder to store Type String as 'Cylinder'.
        /// </summary>
        public Cylinder()
        {
            Type = "Cylinder";
        }

        /// <summary>
        /// Override the SetData method and Take input from the user to enter the Radius and Height value of the Cylinder.
        /// There is a if else statement which check if the number is positive it enter that value into Radius and Height,
        /// else it shows a message to enter valid positive number.
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the radius of the cylinder: ");
            if (double.TryParse(Console.ReadLine(), out double radius) && radius > 0)
            {
                Radius = radius;
            }
            else
            {
                Console.WriteLine("Please enter a positive number.");
                SetData();
                return;
            }

            Console.Write("Enter the height of the cylinder: ");
            if (double.TryParse(Console.ReadLine(), out double height) && height > 0)
            {
                Height = height;
            }
            else
            {
                Console.WriteLine("Please enter a positive number.");
                SetData();
            }
        }

        /// <summary>
        /// Override the CalculateArea method to customize formula according to Cylinder Shape.
        /// </summary>
        /// <returns>Calculate the input according to the formula and return the value of Cylinder Area.</returns>
        public override double CalculateArea()
        {
            return 2 * PI * Radius * (Radius + Height);
        }

        /// <summary>
        /// Override the CalculateVolume method to customize formula according to Cylinder Shape.
        /// </summary>
        /// <returns>Calculate the input according to the formula and return the value of Cylinder Volume.</returns>
        public override double CalculateVolume()
        {
            return PI * Radius * Radius * Height;
        }

        /// <summary>
        /// Override the ToString Method and Generates a string representation of the Cylinder's properties and calculated values with 2 decimal values.
        /// </summary>
        /// <returns>It Return the structured String with appropriate output according to the formula of Cylinder.</returns>
        public override string ToString()
        {
            return $"{Type} \tR = {Radius}, H = {Height} \t\t\tSA = {CalculateArea():F2} \tV = {CalculateVolume():F2}";
        }
    }
}
