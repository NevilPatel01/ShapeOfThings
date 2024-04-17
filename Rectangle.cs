/*
 * I, Nevil Patel, 000892482 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
 *  Class:  Rectangle.cs
 *  Date: October 13, 2023
 *  Purpose : The purpose of making this file is to create a class with all required formula in it.
 */

using System;

namespace Lab2
{
    /// <summary>
    /// This class Represent the Rectangle shape 2-dimensional object extend from shape 
    /// class which containg the formula of Area but Volume will be 0 because triangle 
    /// is 2-d shape and calculate with it's value like Length and Width.
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Getter and Protected Setter Method for Public Variable like Length and Width of Rectangle with Double Datatype.
        /// </summary>
        public double Length { get; protected set; }
        public double Width { get; protected set; }

        /// <summary>
        /// Initalizing a new Instace called Rectangle to store Type String as 'Rectangle'.
        /// </summary>
        public Rectangle()
        {
            Type = "Rectangle";
        }

        /// <summary>
        /// Override the SetData method and Take input from the user to enter the Length and Width value of the Rectangle.
        /// There is a if else statement of Length and Width which check if the number is positive 
        /// and it enter that value into Length and Width,
        /// else it shows a message to enter valid positive number.
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the length of the rectangle: ");
            if (double.TryParse(Console.ReadLine(), out double length) && length > 0)
            {
                Length = length;
            }
            else
            {
                Console.WriteLine("Please enter a positive number.");
                SetData();
            }

            Console.Write("Enter the width of the rectangle: ");
            if (double.TryParse(Console.ReadLine(), out double width) && width > 0)
            {
                Width = width;
            }
            else
            {
                Console.WriteLine("Please enter a positive number.");
                SetData();
            }
        }

        /// <summary>
        /// Override the CalculateArea method to customize formula according to Rectangle Shape.
        /// </summary>
        /// <returns>Calculate the input according to the formula and return the value of Rectangle Area.</returns>
        public override double CalculateArea()
        {
            return Length * Width;
        }

        /// <summary>
        /// Override the CalculateVolume method to customize formula according to Rectangle Shape.
        /// </summary>
        /// <returns>Rectangle is a 2D shape, so the volume will be 0.</returns>
        public override double CalculateVolume()
        {
            return 0;
        }

        /// <summary>
        /// Override the ToString Method and Generates a string representation of the Rectangle's properties and calculated values with 2 decimal values.
        /// </summary>
        /// <returns>It Return the structured String with appropriate output according to the formula of Rectangle.</returns>
        public override string ToString()
        {
            return $"{Type} \tL = {Length}, W = {Width} \t\t\tA = {CalculateArea():F2} \tV = {CalculateVolume():F2}";
        }
    }
}
