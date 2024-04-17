/*
 * I, Nevil Patel, 000892482 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
 *  Class:  Tetrahedron.cs
 *  Date: October 13, 2023
 *  Purpose : The purpose of making this file is to create a class with all required formula in it.
 */

using System;

namespace Lab2
{
    /// <summary>
    /// This class Represent the Tetrahedron shape 3-dimensional object extends Triangle Class which containg the formula of Area and 
    /// Volume of Tetrahedron with it's value like SideLength.
    /// </summary>
    public class Tetrahedron : Triangle
    {
        /// <summary>
        /// Initalizing a new instace called Tetrahedron to store Type String as 'Tetrahedron'.
        /// </summary>
        public Tetrahedron() : base()
        {
            Type = "Tetrahedron";
        }

        /// <summary>
        /// Override the SetData method and Take input from the user to enter the SideLength value of the Tetrahedron.
        /// There is a if else statement which check if the number is positive it enter that value into SideLength,
        /// else it shows a message to enter valid positive number.
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the side length of the tetrahedron: ");
            if (double.TryParse(Console.ReadLine(), out double sideLength) && sideLength > 0)
            {
                BaseLength = sideLength;
                Height = sideLength;
            }
            else
            {
                Console.WriteLine("Please enter a positive number.");
                SetData();
            }
        }

        /// <summary>
        /// Override the CalculateArea method to customize formula according to Tetrahedron Shape.
        /// </summary>
        /// <returns>Calculate the input according to the formula and return the value of Tetrahedron Area.</returns>
        public override double CalculateArea() 
        {
            return Math.Sqrt(3) * BaseLength * BaseLength;
        }

        /// <summary>
        /// Override the CalculateVolume method to customize formula according to Triangle Shape.
        /// </summary>
        /// <returns>Triangle is a 2D shape, so the volume will be 0.</returns>
        public override double CalculateVolume()
        {
            return (Math.Sqrt(2)/12) * BaseLength * BaseLength * BaseLength;
        }

        /// <summary>
        /// Override the ToString Method and Generates a string representation of the Tetrahedron's properties and calculated values with 2 decimal values.
        /// </summary>
        /// <returns>It Return the structured String with appropriate output according to the formula of Tetrahedron.</returns>
        public override string ToString()
        {
            return $"{Type} \tSL = {BaseLength} \t\t\tSA = {CalculateArea():F2} \tV = {CalculateVolume():F2}";
        }
    }
}
