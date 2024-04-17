/*
 * I, Nevil Patel, 000892482 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
 *  Class:  Ellipse.cs
 *  Date: October 13, 2023
 *  Purpose : The purpose of making this file is to create a class with all required formula in it.
 */

using System;

namespace Lab2
{
    /// <summary>
    /// This class Represent the Ellipse shape 2-dimensional object Extend Shape Class which containg the formula of Area but Volume will be 0 because Ellipse is 2-d shape and calculate with it's value like Major radius and Minor Radius.
    /// </summary>
    public class Ellipse : Shape
    {
        /// <summary>
        /// Getter and Protected Setter Method for for Public Variable like Major Radius and Minor Radius of Ellipse with Double Datatype.
        /// </summary>
        public double MajorRadius { get; protected set; }
        public double MinorRadius { get; protected set; }

        /// <summary>
        /// Initalizing a new Instace called Ellipse to store Type String as 'Ellipse'.
        /// </summary>
        public Ellipse()
        {
            Type = "Ellipse";
        }

        /// <summary>
        /// Override the SetData method and Take input from the user to enter the Major Radius and Minor Radius value of the Ellipse.
        /// There is a if else statement of Major Radius and Minor Radius which check if the number is positive it enter that 
        /// value into Major Radius and Minor Radius,
        /// else it shows a message to enter valid positive number.
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the major radius of the ellipse: ");
            if (double.TryParse(Console.ReadLine(), out double major) && major > 0)
            {
                MajorRadius = major;
            }
            else
            {
                Console.WriteLine("Please enter a positive number.");
                SetData();
                return;
            }

            Console.Write("Enter the minor radius of the ellipse: ");
            if (double.TryParse(Console.ReadLine(), out double minor) && minor > 0)
            {
                MinorRadius = minor;
            }
            else
            {
                Console.WriteLine("Please enter a positive number.");
                SetData();
            }
        }

        /// <summary>
        /// Override the CalculateArea method to customize formula according to Ellipse Shape.
        /// </summary>
        /// <returns>Calculate the input according to the formula and return the value of Ellipse Area.</returns>
        public override double CalculateArea()
        {
            return PI * MajorRadius * MinorRadius;
        }

        /// <summary>
        /// Override the CalculateVolume method to customize formula according to Ellipse Shape.
        /// </summary>
        /// <returns>Ellipse is a 2D shape, so the volume will be 0.</returns>
        public override double CalculateVolume()
        {
            return 0;
        }

        /// <summary>
        /// Override the ToString Method and Generates a string representation of the Ellipse's properties and calculated values with 2 decimal values.
        /// </summary>
        /// <returns>It Return the structured String with appropriate output according to the formula of Ellipse.</returns>
        public override string ToString()
        {
            return $"{Type} \tMaR = {MajorRadius}, MiR = {MinorRadius} \t\tA = {CalculateArea():F2} \tV = {CalculateVolume():F2}";
        }
    }
}
