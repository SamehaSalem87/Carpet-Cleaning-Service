namespace Session02_task
{
    internal class Program
    {
        /* Task
         *  Islam's Carpet Cleaning Service
    Charges:
        $25 per small
        $35 per large
    Sales tax rate is 6%
    Estimates are valid for 30 days

    Prompt the user for the number of small and large rooms they would like cleaned
    and provide an estimate such as:
     
Estimate for carpet cleaning service
Number of small carpets: 3 <--
Number of large carpets: 1 <--
Price per small carpet : $25
Price per large carpet : $35
Cost : $110
Tax: $6.6
===============================
Total estimate: $116.6
This estimate is valid for 30 days */
        /* search Task
         * (Standard numeric format)
 
int X = 10;
int Y = 20;
Console.WriteLine($"Equation: {X} + {Y} = {X + Y:C}");
 
 
in one (1) pdf page:
1. why the output of this Equation = $30.00?
2. what is its benefit?
3. try another example with a different specifier with a screenshot of the output.*/



        static void Main(string[] args)
        {
             Console.Write("Enter number of small carpets: ");
             int small = int.Parse(Console.ReadLine());

             Console.Write("Enter number of large carpets: ");
             int large = int.Parse(Console.ReadLine());

             double smallPrice = 25;
             double largePrice = 35;
             double taxRate = 0.06;

             double cost = (small * smallPrice) + (large * largePrice);
             double tax = cost * taxRate;
             double total = cost + tax;

             Console.WriteLine();
             Console.WriteLine("Estimate for carpet cleaning service");
             Console.WriteLine("Number of small carpets: " + small);
             Console.WriteLine("Number of large carpets: " + large);
             Console.WriteLine("Price per small carpet: $" + smallPrice);
             Console.WriteLine("Price per large carpet: $" + largePrice);
             Console.WriteLine("Cost: $" + cost);
             Console.WriteLine("Tax: $" + tax);
             Console.WriteLine("=======================");
             Console.WriteLine("Total estimate: $" + total);
             Console.WriteLine("This estimate is valid for 30 days");


            //int X = 10;
            //int Y = 20;

            //Console.WriteLine($"Equation: {X} + {Y} = {X + Y:C}");

            /*  double price = 12345.6789;

              Console.WriteLine($"Price: {price:N2}");*/

        /*int X = 10;
        int Y = 20;

        Console.WriteLine($"Total: {X + Y:N}");*/

    }
}
}
