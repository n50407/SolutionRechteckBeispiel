using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleDemoDelegateFunctionPointerSample
{
    internal class Program
    {

        public delegate void MyFirstDelegate();
        static void Main(string[] args)
        {
            SayHello();
            var erg = SayHelloMitAntwort();
            MyFirstDelegate d1 =new MyFirstDelegate(SayHello);

            //var myMethodPoinert = SayHello;
            SayHello();
            d1();



        }

        public void SayHelloToMyStudents(string[] students, MyFirstDelegate mySortAlgorithm)
        {
            

            

            mySortAlgorithm();
            //einmal aufsteigen, einmal absteigen, einmal chaos, einmal merge-sort, einmal quick-sort, einmal bubble-sort, einmal selection-sort, einmal insertion-sort

        }

        public static void SayHello()
        {
            string message = "Hello, World!";
            Console.WriteLine(message);
        }

        public static string SayHelloMitAntwort()
        {
            string message = "Hello, World!";
            Console.WriteLine(message);
            return message;
        }
    }
}
