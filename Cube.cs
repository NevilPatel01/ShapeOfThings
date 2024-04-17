/*
 * I, Nevil Patel, 000892482 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
 *  Class:  Cube.cs
 *  Date: October 13, 2023
 *  Purpose : The purpose of making this file is to create a class with all required formula in it.
 */

using System;

namespace Lab2
{
    /// <summary>
    /// This class Represent the cube shape 3-dimensional object Extend the Box Class which containg the formula of Area and 
    /// Volume of Cube with it's value like Side Length.
    /// </summary>
    public class Cube : Box
    {
        /// <summary>
        /// Initalizing a new instace called Cube to store Type String as 'Cube'.
        /// </summary>
        public Cube() : base()
        {
            Type = "Cube";
        }

        /// <summary>
        /// Override the SetData method and Take input from the user to enter the side length value of the cube.
        /// There is a if else statement which check if the number is positive it enter that value into SideLength,
        /// else it shows a message to enter valid positive number.
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the side length of the cube: ");
            if (double.TryParse(Console.ReadLine(), out double sideLength) && sideLength > 0)
            {
                Length = sideLength;
                Width = sideLength;
                Height = sideLength;
            }
            else
            {
                Console.WriteLine("Please enter a positive number.");
                SetData();
            }
        }

        /// <summary>
        /// Override the ToString Method and Generates a string representation of the cube's properties and calculated values with 2 decimal values.
        /// </summary>
        /// <returns>It Return the structured String with appropriate output according to the formula of Cube.</returns>
        public override string ToString()
        {
            return $"{Type} \t\tSL = {Length} \t\t\tSA = {CalculateArea():F2} \tV = {CalculateVolume():F2}";
        }
    }
}
