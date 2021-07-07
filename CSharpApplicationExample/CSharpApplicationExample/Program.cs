using System;
using System.Runtime.InteropServices;

namespace CSharpApplicationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Using QT Libraries in C# Aplication Example - TheCodeProgram";
            callQtFunctions();
            Console.ReadLine();
        }

        [DllImport("vitalsignlib.dll")]
        static extern int vs_init(int a, int b);

        [DllImport("vitalsignlib.dll")]
        static extern int vs_start(int a, int b);

        [DllImport("vitalsignlib.dll")]
        static extern int vs_stop(int a, int b);

        [DllImport("vitalsignlib.dll")]
        static extern int vs_clean(int a, int b);

        

        static void callQtFunctions()
        {
            Console.WriteLine("Result of 5 + 7 is " + vs_init(5, 7).ToString());
            Console.WriteLine("Result of 21 - 10 is " + vs_start(21, 10).ToString());
            Console.WriteLine("Result of 9 x 3 is " + vs_stop(9, 3).ToString());
            Console.WriteLine("Result of 70 / 5 is " + vs_clean(72, 5).ToString());
        }


    }
}
