using Assignment03OOP.Binding;
using Assignment03OOP.Polymorphism_Overriding;

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

        public static void ProcessEmployee(Employee emplyee)
        {
            if (emplyee != null)
            {
                emplyee.GetEmployeeType();
                emplyee.GetEmployeeData();
            }
        }
        ///public static void ProcessEmployee(ParttimeEmployee emplyee)
        ///{
        ///    if (emplyee != null)
        ///    {
        ///        emplyee.GetEmployeeType();
        ///        emplyee.GetEmployeeData();
        ///    }
        ///}

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

            #region Not Binding
            //Ref from Child => Object from Parent

            //TypeB ChildRef = new TypeA(); //Invalid
            //TypeB ChildRef = (TypeB) new TypeA(1); //Valid 

            //TypeA typeA = new TypeA(1);
            //TypeB typeB = (TypeB) typeA; //Invalid

            //TypeA typeA = new TypeB(1,3); 
            //TypeB typeB = (TypeB)typeA; //Valid
            #endregion

            #region Ex 01
            //FulltimeEmployee fulltimeEmployee = new FulltimeEmployee(10, "Mohamed", 21, 3000);
            //ProcessEmployee(fulltimeEmployee);
            //ParttimeEmployee parttimeEmployee = new ParttimeEmployee()
            //{
            //    Id = 30,
            //    Name = "MOHAMED"
            //};
            //ProcessEmployee(parttimeEmployee);
            #endregion

        }
    }
}
