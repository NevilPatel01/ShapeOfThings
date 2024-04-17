/*
 * I, Nevil Patel, 000892482 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
 *  Class:  Sphere.cs
 *  Date: October 13, 2023
 *  Purpose : The purpose of making this file is to create a class with all required formula in it.
 */

using System;

namespace Lab2
{
    /// <summary>
    /// This class Represent the Sphere shape 3-dimensional object extends Cylinder Class which containg the formula of Area and 
    /// Volume of Sphere with it's value like Radius.
    /// </summary>
    public class Sphere : Cylinder
    {
        /// <summary>
        /// Initalizing a new instace called Sphere to store Type String as 'Sphere'.
        /// </summary>
        public Sphere() : base()
        {
            Type = "Sphere";
        }

        /// <summary>
        /// Override the SetData method and Take input from the user to enter the radius value of the Sphere.
        /// There is a if else statement which check if the number is positive it enter that value into Radius,
        /// else it shows a message to enter valid positive number.
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the radius of the sphere: ");
            if (double.TryParse(Console.ReadLine(), out double radius) && radius > 0)
            {
                Radius = radius;
                Height = radius;
            }
            else
            {
                Console.WriteLine("Please enter a positive number.");
                SetData();
            }
        }

        /// <summary>
        /// Override the CalculateArea method to customize formula according to Sphere Shape.
        /// </summary>
        /// <returns>Calculate the input according to the formula and return the value of Sphere Area.</returns>
        public override double CalculateArea()
        {
            return 4 * PI * Radius * Radius;
        }

        /// <summary>
        /// Override the CalculateVolume method to customize formula according to Sphere Shape.
        /// </summary>
        /// <returns>Calculate the input according to the formula and return the value of Sphere Volume.</returns>
        public override double CalculateVolume()
        {
            return (4/3) * PI * Radius * Radius * Radius;
        }

        /// <summary>
        /// Override the ToString Method and Generates a string representation of the Sphere's properties and calculated values with 2 decimal values.
        /// </summary>
        /// <returns>It Return the structured String with appropriate output according to the formula of Sphere.</returns>
        public override string ToString()
        {
            return $"{Type} \t\tR = {Radius} \t\t\t\tSA = {CalculateArea():F2} \tV = {CalculateVolume():F2}";
        }
    }
}
