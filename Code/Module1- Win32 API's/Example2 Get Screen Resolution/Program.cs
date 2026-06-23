using System;
using System.Runtime.InteropServices;
namespace Example2_Get_Screen_Resolution
{
    internal class Program
    {
        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(int nIndex);
        static void Main(string[] args)
        {
            int screenWidth = GetSystemMetrics(0);
            int screenHeight = GetSystemMetrics(1);
            Console.WriteLine("Screen Width: {0}, Screen Height: {1}", screenWidth, screenHeight);
        }
    }
}
