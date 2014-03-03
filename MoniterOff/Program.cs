using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace MoniterOff
{
    public static class Monitor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(int hWnd, uint Msg, int wParam, int lParam);

        public static void PowerOff()
        {
            SendMessage(-1, 0x112, 0xf170, 2);
        }
        public static void PowerOn()
        {
            SendMessage(-1, 0x112, 0xf170, -1);
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Monitor.PowerOff();
        }
    }
}
