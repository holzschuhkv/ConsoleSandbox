using System;

namespace DLLInjection
{
    class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(int ZeroOnly, string lpWindowName);

        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetWindowsHookEx", SetLastError = true)]
        static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        private delegate int HookProc(int code, IntPtr wParam, IntPtr lParam);

        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("Hello World!");
        }
    }
}
