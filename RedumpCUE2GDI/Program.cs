using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using CueSharp;

namespace RedmupCUE2GDI
{
    class Program
    {
        [DllImport("kernel32.dll")]
        private static extern bool AttachConsole(int dwProcessId);

        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Form1 form1 = new Form1("0");
                form1.ShowDialog();
            }
            else
            {
                AttachConsole(-1);
                Form1 form1 = new Form1(args[0]);
                form1.ShowDialog();
            }
        }
    }
}
