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
            if (line1.CompareTo(line2) == 0)
            {
                Console.WriteLine("Both line are same");
                return;
            }
            if (line1.CompareTo(line2) > 0)
                Console.WriteLine("Line 1 is greter than Line 2");
            else
                Console.WriteLine("Line 2 is greter than Line 1");
        }
    }
}