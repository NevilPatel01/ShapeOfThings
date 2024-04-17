/*
 * I, Nevil Patel, 000892482 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
 *  Class:  Square.cs
 *  Date: October 13, 2023
 *  Purpose : The purpose of making this file is to create a class with all required formula in it.
 */

using System;

namespace Lab2
{
    /// <summary>
    /// This class Represent the Square shape 2-dimensional object extends from the Rectangle Class which containg the 
    /// formula of Area but Volume will be 0 because Square is 2-d shape and calculate with it's value like Length.
    /// </summary>
    public class Square : Rectangle
    {

        /// <summary>
        /// Initalizing a new instace called Square to store Type String as 'Square'.
        /// </summary>
        public Square() : base()  
        {
            Type = "Square";
        }

        /// <summary>
        /// Override the SetData method and Take input from the user to enter the Length value of the Square.
        /// There is a if else statement of Length which check if the number is positive it enter that value into Length,
        /// else it shows a message to enter valid positive number.
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the side length of the square: ");
            if (double.TryParse(Console.ReadLine(), out double sideLength) && sideLength > 0)
            {
                Length = sideLength;
                Width = sideLength;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                SetData();
            }
        }

        /// <summary>
        /// Override the ToString Method and Generates a string representation of the Square's properties and calculated values with 2 decimal values.
        /// </summary>
        /// <returns>It Return the structured String with appropriate output according to the formula of Square.</returns>
        public override string ToString()
        {
            return $"{Type} \t\tL = {Length} \t\t\t\tA = {CalculateArea():F2} \tV = {CalculateVolume():F2}";
        }
    }
}
