using System;
using System.Runtime.InteropServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello, World! Running on {RuntimeInformation.OSDescription} - {RuntimeInformation.OSArchitecture}");
        }
    }
}