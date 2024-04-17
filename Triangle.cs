/*
 * I, Nevil Patel, 000892482 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
 *  Class:  Triangle.cs
 *  Date: October 13, 2023
 *  Purpose : The purpose of making this file is to create a class with all required formula in it.
 */

using System;

namespace Lab2
{
    /// <summary>
    /// This class Represent the Triangle shape 2-dimensional object extends Triangle Class which containg the formula of Area but 
    /// Volume will be 0 because triangle is 2-d shape and calculate with it's value like Base Length and Height.
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Getter and Protected Setter Method for Public Variables like Base Length and height of Triangle with Double Datatype.
        /// </summary>
        public double BaseLength { get; protected set; }
        public double Height { get; protected set; }

        /// <summary>
        /// Initalizing a new Instace called Triangle to store Type String as 'Triangle'.
        /// </summary>
        public Triangle()
        {
            Type = "Triangle";
        }

        /// <summary>
        /// Override the SetData method and Take input from the user to enter the Base length and Height value of the Triangle.
        /// There is a if else statement of Base Length and Height which check if the number is positive it enter that value 
        /// into Base Length and Height,
        /// else it shows a message to enter valid positive number.
        /// </summary>
        public override void SetData()
        {

            Console.Write("Enter the base of the triangle: ");
            if (double.TryParse(Console.ReadLine(), out double baseLength) && baseLength > 0)
            {
                BaseLength = baseLength;
            }
            else
            {
                Console.WriteLine("Please enter a positive number.");
                SetData();
            }

            Console.Write("Enter the height of the triangle: ");
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
        /// Override the CalculateArea method to customize formula according to Triangle Shape.
        /// </summary>
        /// <returns>Calculate the input according to the formula and return the value of Triangle Area.</returns>
        public override double CalculateArea()
        {
            return 0.5 * BaseLength * Height;
        }

        /// <summary>
        /// Override the CalculateVolume method to customize formula according to Triangle Shape.
        /// </summary>
        /// <returns>Triangle is a 2D shape, so the volume will be 0.</returns>
        public override double CalculateVolume()
        {
            return 0;
        }

        /// <summary>
        /// Override the ToString Method and Generates a string representation of the Triangle's properties and calculated values with 2 decimal values.
        /// </summary>
        /// <returns>It Return the structured String with appropriate output according to the formula of Triangle.</returns>
        public override string ToString()
        {
            return $"{Type} \tB = {BaseLength}, H = {Height}  \t\tA = {CalculateArea():F2} \tV = {CalculateVolume():F2}";
        }
    }
}