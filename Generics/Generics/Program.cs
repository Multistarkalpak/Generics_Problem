namespace Day13_FindMax
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum value finder");
            // MaxNumberCheck maxNumberCheck = new MaxNumberCheck();
            int integers = MaxNumberCheck.MaxIntegerNumber(7, 8, 6);
            Console.WriteLine(integers);
            double Double = MaxNumberCheck.MaxFloatNumber(8.5, 6.5, 7.5);
            Console.WriteLine(Double);
            string string1 = MaxNumberCheck.MaximumString("22", "23", "26");
            Console.WriteLine(string1);

            Console.WriteLine("generic method");
            GenericMethod.GetMaximum<int>(7, 8, 6);
            GenericMethod.GetMaximum<double>(8.5, 6.5, 7.5);
            GenericMethod.GetMaximum<string>("22", "23", "26");


        }
    }
}