using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExceptionHandlingExample
{
    delegate void Pruthvi(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            #region EXceptionHandlinr
            //Excception Handling
            //try
            //{
            //    int a = 60;
            //    int b = 0;
            //    Console.WriteLine(a / b);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("finally executed");
            //}
            #endregion
            #region Generics
            //Generics
            //bool result1 = MyClass.Yogesh<string, int>("India", 45);
            //bool result = MyClass.Yagnesh<string>("India", "China");
            //Console.WriteLine(result1);
            //Console.WriteLine(result);
            #endregion

            #region Delegate
            //Pruthvi op = new Pruthvi(Add);
            //op(7, 7);
            //Pruthvi op2 = new Pruthvi(Test);
            //op2(6,6);
            #endregion


            ThreadStart s = new ThreadStart(Print1);
            ThreadStart s1 = new ThreadStart(Print2);

            Thread t1 = new Thread(s);
            Thread t2 = new Thread(s1);

            t1.Start();
            t2.Start();
            t1.Suspend();
            t2.Suspend();
            t1.Resume();
            t2.Resume();
            t1.Abort();
            t2.Abort();


            //Print1();
            //Print2();

            int[] arr = new int[7];
            arr[0] = 1;
            arr[1] = 5;

            MyClass[] arr1 = new MyClass[6];
            arr1[0] = new MyClass() { };

            List<MyClass> li = new List<MyClass>();
        }

        public static void Add(int a , int b)
        {            
            Console.WriteLine(a + b);
        }

        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public static void Test(int a, int b)
        {
            Console.WriteLine("sdhsahdhasdhsad");
        }

        public static void Print1()
        {
            for (int i = 1; i < 15; i++)
            {
                Console.WriteLine("Print Value- "+i);
            }
        }

        public static void Print2()
        {
            for (int i = 50; i < 75; i++)
            {
                

                Console.WriteLine($"Print Value2- {i}");
            }
        }
    }

    class MyClass
    {
        //public static bool AreEqual(int value1, int value2)
        //{
        //    return value1.Equals(value2);
        //}

        //public static bool AreEqual(string value1, string value2)
        //{
        //    return value1.Equals(value2);
        //}

        public static bool Yagnesh<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }

        public static bool Yogesh<T, V>(T value1, V value2)
        {
            return value1.Equals(value2);
        }
    }
}
