public class Solution
{
    const int MAX_DIFFERENCE = 5; // The maximum possible difference between the lengths of the sides of a rectangle
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
        if (Math.Abs(height - width) > MAX_DIFFERENCE || height == width)
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
    // Method to calculate perimeter of the triangle using the Pythagorean theorem
    static void CalculatePerimeter()
    {
        double edge = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(width/2, 2));
        Console.WriteLine(edge * 2 + width);
    }
    // Method to print the triangle
    static void PrintTriangle()
    {
        //Compatibility check and edge cases - if there are no odd values ​​between the width and 1 and if the width is 1 and the height is too large.
        if (width % 2 == 0 || width >= 2 * height || (width == 3 || width == 1) && height > 2)
            Console.WriteLine("The triangle cannot be printed.");
        else
        {
            //Print the first line
            string FirstLine = new string(' ', (width - 1) / 2) + "*";
            Console.WriteLine(FirstLine);
            //Printing the middle part of the tower
            if (height != 1) //A test that needs more than one line
            {
                //Setting values ​​for calculating the middle of the tower print
                int oddAmount = (width - 2) / 2;
                int rowsPerSet = (height - 2) / oddAmount;
                int remainingRows = (height - 2) % oddAmount;
                // Print additional odd rows if necessary
                for (int i = 0; i < remainingRows; i++)
                {
                    Console.WriteLine(new string(' ', (width - 2) / 2) + "***");
                }
                // Print the main body of the triangle
                for (int i = 1; i < oddAmount + 1; i++)
                {
                    for (int j = 0; j < rowsPerSet; j++)
                    {
                        Console.Write(new string(' ', (width - (2 * i + 1)) / 2));
                        Console.WriteLine(new string('*', 2 * i + 1));
                    }
                }
                //Print the last line
                string lastLine = new string('*', width);
                Console.WriteLine(lastLine);
            }
        }
    }
    static void Main(string[] args)
    {
        while (true) //repeatedly shows the user the menu
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
