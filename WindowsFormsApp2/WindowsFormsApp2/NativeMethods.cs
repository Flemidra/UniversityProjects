using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal static class NativeMethods
    {
        // P/Invoke
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] // Mueve la pestana utilizando el mouse
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]// Mueve la pestana utilizando el mouse
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Methods
        public static void ReleaseCaptureAction()
        {
            ReleaseCapture();
        }

        public static void SendMessageAction(System.IntPtr hWnd, int wMsg, int wParam, int lParam)
        {
            SendMessage(hWnd, wMsg, wParam, lParam);
        }
    }
}
