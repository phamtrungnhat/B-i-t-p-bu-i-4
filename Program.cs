using System;

namespace Bai_tap_buoi_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(" STUDENT ");
            Student st = new Student();
            st.Input();
            st.PrintInfo();

            
            Console.WriteLine("\n FRACTION ");
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction();

            Console.WriteLine("Nhập phân số 1:");
            f1.Input();

            Console.WriteLine("Nhập phân số 2:");
            f2.Input();

            Console.WriteLine("Cộng: " + f1.Add(f2));
            Console.WriteLine("Trừ: " + f1.Subtract(f2));
            Console.WriteLine("Nhân: " + f1.Multiply(f2));
            Console.WriteLine("Chia: " + f1.Divide(f2));

            Console.ReadLine();
        }
    }
}
