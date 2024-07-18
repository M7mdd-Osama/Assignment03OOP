namespace Assignment03OOP
{
    internal class Program
    {
        public static int Sum(int X, int Y)
        {
            return X + Y;
        }
        public static double Sum(double X, double Y)
        {
            return X + Y;
        }
        public static int Sum(int X, int Y, int Z)
        {
            return X + Y + Z;
        }
        public static double Sum(int X, double Y)
        {
            return X + Y;
        }
        static void Main(string[] args)
        {
            #region Polymorphism [Overloading]
            //int Result = Sum(1, 2);
            //Console.WriteLine(Result);
            //Result = Sum(1, 2, 3);
            //Console.WriteLine(Result);
            //double Result02 = Sum(1.3, 2.5);
            //Console.WriteLine(Result02);

            Console.WriteLine(1);
            Console.WriteLine(2.3);
            Console.WriteLine(2.6M);
            Console.WriteLine(1.3F);
            Console.WriteLine("2");
            Console.WriteLine('M');
            #endregion
        }
    }
}
