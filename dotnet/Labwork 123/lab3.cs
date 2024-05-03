class ExceptionHandl
{
    public static void run3()
    {
        try
        {
            Console.Write("Enter price: ");
            string input = Console.ReadLine();
            decimal price = decimal.Parse(input);
            Console.WriteLine($"Price: {price}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Price must be a number.");
        }
    }
}