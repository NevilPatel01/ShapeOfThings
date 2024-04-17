/*
 * I, Nevil Patel, 000892482 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
 *  Class:  Circle.cs
 *  Date: October 13, 2023
 *  Purpose : The purpose of making this file is to create a class with all required formula in it.
 */

using System;

namespace Lab2
{
    /// <summary>
    /// This class Represent the Circle shape 2-dimensional object which containg the formula of Area but 
    /// Volume will be 0 because triangle is 2-d shape and calculate with it's value like Radius.
    /// </summary>
    public class Circle : Ellipse
    {
        /// <summary>
        /// Initalizing a new Instace called Circle to store Type String as 'Radius'.
        /// </summary>
        public Circle() : base() 
        {
            Type = "Circle";
        }

        /// <summary>
        /// Override the SetData method and Take input from the user to enter the Radius value of the Circle.
        /// There is a if else statement of Radius which check if the number is positive it enter that value into Radius,
        /// else it shows a message to enter valid positive number.
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the radius of the circle: ");
            if (double.TryParse(Console.ReadLine(), out double radius) && radius > 0)
            {
                MajorRadius = radius;
                MinorRadius = radius;
            }
            else
            {
                Console.WriteLine("Please enter a positive number.");
            }
        }

        /// <summary>
        /// Override the ToString Method and Generates a string representation of the Circle's properties and calculated values with 2 decimal values.
        /// </summary>
        /// <returns>It Return the structured String with appropriate output according to the formula of Circle.</returns>
        public override string ToString()
        {
            return $"{Type} \t\tR = {MajorRadius} \t\t\t\tA = {CalculateArea():F2} \tV = {CalculateVolume():F2}";
        }
    }
}
