namespace LineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comparision comparision = new Comparision(1,2,3,4);
            double line1 = comparision.CalculateLength();
            Console.WriteLine("Length of first line"+line1);
            comparision LineComparision = new comparision(1, 2, 3, 4);
            double line1 = comparision.CalculateLength();
            Console.WriteLine("Length of first line"+line2);
            if (line1 == line2)
            {
                Console.WriteLine("Line 1 and Line 2 are equal");
            }
            else
                Console.WriteLine("Not equal");
        }
    }
}