using System;
using System.Runtime.InteropServices;

namespace Example5_MessageBox
{
    internal class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern int MessageBox(IntPtr hWnd, string Text, string Caption, uint Type);
        static void Main(string[] args)
        {
            MessageBox(IntPtr.Zero, "Hello, World!", "Message Box Example", 0);
        }
    }
}
