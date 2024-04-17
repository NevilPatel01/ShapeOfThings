# Shape of Things
This console application, Shape of Things, is designed to manage various shapes using an object-oriented approach. Here's how it works:

## Features:
### Abstract Class: Shape

- Represents a single shape with common properties and methods.
- Provides a blueprint for creating shape objects.
- Ensures encapsulation and abstraction.

### Object Hierarchy:

- Includes classes for different shapes, such as Rectangle, Square, Box, Cube, Ellipse, Circle, Cylinder, Sphere, Triangle, and Tetrahedron.
- Each shape class extends the Shape abstract class and implements specific methods for setting dimensions, calculating area, and, for three-dimensional shapes, calculating volume.
- Implements proper inheritance and polymorphism to support a variety of shapes.

### Menu-Driven Interface:

- Prompts the user to create instances of different shapes via a menu.
- Uses polymorphism to store shapes into a list for easy management.
- Continues to prompt until the user selects the exit option.

### Data Display:

- Displays a neat and orderly table of all instantiated shapes.
- Includes dimensions, areas, and, for three-dimensional shapes, volumes.
- Utilizes the overridden ToString() method to print each line of the table.

### Main Class:

- Implements a list to store shapes of any kind.
- Provides error checking for user input to ensure smooth user interaction.
- Ensures a highly modularized Main() method for better code organization.

### Shape Class Implementation:

- Each derived class implements SetData(), CalculateArea(), and CalculateVolume() methods according to the specific requirements of each shape.
- Ensures proper formulae for area and volume calculations, following guidelines and recommendations.

## How to Run:
- Compile and run the Lab2 class.
- Choose from the menu options to create instances of different shapes.
- Enter dimensions for each shape as prompted.
- View the neat and orderly table displaying information about instantiated shapes.
- Repeat the process as needed until exiting the program.

## Note:
- This program follows object-oriented principles, including abstraction, encapsulation, inheritance, and polymorphism.
- It ensures accurate calculations of area and volume for various shapes, providing a comprehensive solution for shape management.
- Each shape class is implemented in a separate file for better code organization and readability.

This Project Shape of Things application was developed by Nevil Dineshkumar Patel. The code is the intellectual property of the author, and any unauthorized copying, reproduction, or distribution is strictly prohibited.
