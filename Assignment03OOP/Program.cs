﻿using Assignment03OOP.Polymorphism_Overriding;

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

            //Console.WriteLine(1);
            //Console.WriteLine(2.3);
            //Console.WriteLine(2.6M);
            //Console.WriteLine(1.3F);
            //Console.WriteLine("2");
            //Console.WriteLine('M');
            #endregion

            #region Polymorphism [Overriding]
            //TypeA typeA = new TypeA(3);
            //typeA.MyFun01();
            //typeA.MyFun02();
            //TypeB typeB = new TypeB(4, 5);
            //typeB.MyFun01();
            //typeB.MyFun02();
            #endregion

            #region Binding
            //TypeA refBase = new TypeB(2,3);
            //refBase.MyFun01();
            //refBase.MyFun02();            
            #endregion


        }
    }
}
