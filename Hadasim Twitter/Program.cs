using System;
public class Solution
{
    public static int height, width;
    static void DisplayMenu()// Method to display the main menu
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Rectangular tower");
        Console.WriteLine("2. Triangle tower");
        Console.WriteLine("3. Exit");
    }
    // Method to handle Option 1: Rectangular tower
    static void RectangularTower()
    {
        Console.WriteLine("Please enter height and width details of the building");
        height = int.Parse(Console.ReadLine());
        width = int.Parse(Console.ReadLine());
        if (Math.Abs(height - width) > 5 || height == width)
            Console.WriteLine("The area of the rectangle is: " + height * width);
        else
            Console.WriteLine("The perimeter of the rectangle is:" + 2 * (height + width));
    }
    // Method to handle Option 2: Triangle tower
    static void TriangleTower()
    {
        Console.WriteLine("Please enter height and width details of the building");
        height = int.Parse(Console.ReadLine());
        width = int.Parse(Console.ReadLine());
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Calculate perimeter of the triangle");
        Console.WriteLine("2. Print the triangle");
        Console.Write("Please enter your choice: ");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                CalculatePerimeter();
                break;
            case "2":
                PrintTriangle();
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter a valid option.");
                break;
        }
    }
    // Method to calculate perimeter of the triangle
    static void CalculatePerimeter()
    {
        double edge = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(width/2, 2));
        Console.WriteLine(edge * 2 + width);
    }
    // Method to print the triangle
    static void PrintTriangle()
    {
        int rows;
        //Compatibility check and edge cases - if there are no odd values ​​between the width and 1 and if the width is 1 and the height is too large.
        if (width % 2 == 0 || width >= 2 * height || (width == 3 || width == 1) && height > 2)
            Console.WriteLine("The triangle cannot be printed.");
        else
        {
            //Print the first line
            for (int i = 0; i < (width - 1) / 2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("*");
            //Printing the middle part of the tower
            for (int i = width / 2 - 1; i > 0; i--)
            {
                //How many rows of 3 stars are needed according to the remainder of the division
                if (i== width / 2 - 1) { rows = height-2- (width / 2 - 2)*((height - 2) / (width / 2 - 1));}
                else { rows = (height - 2) / (width / 2 - 1); }
                for (int j = 0; j < rows; j++)
                { 
                    for (int k = 0; k < (width - (width - 2 * i)) / 2; k++)//Calculate how many spaces are needed
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < (width - 2 * i); k++)//Calculation of how many stars are needed
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            if (height != 1) 
            {
                //Print the last line
                for (int i = 0; i < width; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    static void Main(string[] args)
    {
        while (true)
        {
            DisplayMenu();
            Console.Write("Please enter your choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("You chose Option 1");
                    RectangularTower();
                    break;
                case "2":
                    Console.WriteLine("You chose Option 2");
                    TriangleTower();
                    break;
                case "3":
                    Console.WriteLine("Exiting the program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }
}
