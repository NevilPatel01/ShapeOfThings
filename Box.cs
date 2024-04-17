/*
 * I, Nevil Patel, 000892482 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
 *  Class:  Box.cs
 *  Date: October 13, 2023
 *  Purpose : The purpose of making this file is to create a class with all required formula in it.
 */

using System;

namespace Lab2
{
    /// <summary>
    /// This class Represent the Box shape 3-dimensional object Extend from Shape Class 
    /// which containg the formula of Area and Volume of Box with it's value like Length, Width and Height.
    /// </summary>
    public class Box : Shape
    {
        /// <summary>
        /// Getter and Protected Setter Method forfor Public Variable like Length, Width and Height of Box with Double Datatype.
        /// </summary>
        public double Length { get; protected set; }
        public double Width { get; protected set; }
        public double Height { get; protected set; }

        /// <summary>
        /// Initalizing a new instace called Box to store Type String as 'Box'.s
        /// </summary>
        public Box()
        {
            Type = "Box";
        }

        /// <summary>
        /// Override the SetData method and Take input from the user to enter the Length, Width and Height value of the Box.
        /// There is a if else statement which check if the number is positive it enter that value into Length, Width and Height,
        /// else it shows a message to enter valid positive number.
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the length of the box: ");
            if (double.TryParse(Console.ReadLine(), out double length) && length > 0)
            {
                Length = length;
            }
            else
            {
                Console.WriteLine("Please enter a positive number.");
                SetData();
                return;
            }

            Console.Write("Enter the width of the box: ");
            if (double.TryParse(Console.ReadLine(), out double width) && width > 0)
            {
                Width = width;
            }
            else
            {
                Console.WriteLine("Please enter a positive number.");
                SetData();
                return;
            }

            Console.Write("Enter the height of the box: ");
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
        /// Override the CalculateArea method to customize formula according to Box Shape.
        /// </summary>
        /// <returns>Calculate the input according to the formula and return the value of Box Area.</returns>
        public override double CalculateArea()
        {
            return 2 * (Length * Width + Width * Height + Height * Length);
        }

        /// <summary>
        /// Override the CalculateVolume method to customize formula according to Box Shape.
        /// </summary>
        /// <returns>Calculate the input according to the formula and return the value of Box Volume.</returns>
        public override double CalculateVolume()
        {
            return Length * Width * Height;
        }

        /// <summary>
        /// Override the ToString Method and Generates a string representation of the Box's properties and calculated values with 2 decimal values.
        /// </summary>
        /// <returns>It Return the structured String with appropriate output according to the formula of Box.</returns>
        public override string ToString()
        {
            return $"{Type} \t\tL = {Length}, W = {Width}, H = {Height}, \tSA = {CalculateArea():F2} \tV = {CalculateVolume():F2}";
        }
    }
}
