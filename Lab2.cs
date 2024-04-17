/*
    I, Nevil Patel, 000892482 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
    Class:  Lab2.cs
    Date: October 13, 2023
    Purpose: This Lab2 class has the main method which display output in console of all the other classes
             through calling thier ToString method as per user's Input.
             It also has abbrevation at last of output for the shape elements.
 
 */

using System;
using System.Collections.Generic;
namespace Lab2
{
    /// <summary>
    /// This class contains the main program logic and call the ToString method to show output in Console.
    /// </summary>
    class Lab2
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            int shapeCount = 0;
            string shapeData = "";
            bool errorShown = false; // errorShown Track if their is error message or not.

            while (true)
            {
                if (!errorShown)
                {
                    Console.Clear(); // Clear the console everytime user enter another shape just to keep console look more simpler
                    Console.WriteLine("\tNevil's Geometry Calculator!!");
                    Console.WriteLine("\n1. Rectangle \t5. Ellipse \t9. Triangle");
                    Console.WriteLine("2. Square \t6. Circle \t10. Tetrahedron");
                    Console.WriteLine("3. Box \t\t7. Cylinder");
                    Console.WriteLine("4. Cube \t8. Sphere");
                    Console.WriteLine("0. Show All Stored Data and Exit");
                    Console.WriteLine($"\n{shapeCount} shape(s) entered so far");
                }

                Console.Write("\n\nEnter your choice: ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 0)
                    {
                        // display all the shapes and thier calculation and after pressing any key it exit the console
                        Console.Clear(); // Clear the console everytime user enter another shape just to keep console look more simpler
                        Console.WriteLine("All Shapes Entered and their data is shown below:");

                        // Call the PrintShapeTable method to display the shape data in a proper structured table
                        PrintShapeTable(shapes);

                        return;
                    }
                    else if (choice >= 1 && choice <= 10)
                    {
                        Shape newShape = CreateShape(choice);
                        newShape.SetData();
                        shapes.Add(newShape);
                        shapeCount++;
                        shapeData += newShape.ToString() + "\n";
                        errorShown = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 10.");
                        errorShown = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid menu choice.");
                    errorShown = true;
                }
            }
        }

        /// <summary>
        /// Call the input shape class, calculate and output according to the input data
        /// </summary>
        /// <param name="choice">The input of user's choice.</param>
        /// <returns>The created shape object according to the Input.</returns>
        public static Shape CreateShape(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new Rectangle();

                case 2:
                    return new Square();

                case 3:
                    return new Box();

                case 4:
                    return new Cube();

                case 5:
                    return new Ellipse();

                case 6:
                    return new Circle();

                case 7:
                    return new Cylinder();

                case 8:
                    return new Sphere();

                case 9:
                    return new Triangle();

                case 10:
                    return new Tetrahedron();

                default:
                    throw new ArgumentOutOfRangeException(nameof(choice), "Invalid input. Please enter a number from 1 to 10.");
            }
        }

        /// <summary>
        /// Here, It print the proper structured Shape Data Header in Output Console
        /// </summary>
        /// <param name="shapes">All The input list of shapes will display in Console.</param>
        public static void PrintShapeTable(List<Shape> shapes)
        {
            Console.WriteLine("Shape List:");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Type\t\tDimensions\t\t\tArea\t\tVolume");
            Console.WriteLine("------------------------------------------------------------------------");

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }
            Console.WriteLine("\n\n\t\tAbbreviations of Shapes:");
            Console.WriteLine("\nL = Length\tSL = Side Length\tB = Base\tW = Width\nH = Height\tA = Area\tSA = Surface Area\tV = Volume\nS = Side\tR = Radius \tMaR = Major Radius\tMiR = Minor Radius\n");
        }
    }
}
