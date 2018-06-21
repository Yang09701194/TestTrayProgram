using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestKeyHook.Helper
{
    public static class ProcessFocus
    {
        /// <summary>
        /// The GetForegroundWindow function returns a handle to the foreground window.
        /// </summary>
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        public static bool ProcessIsFocused(string processname)
        {
            if (processname == null || processname.Length == 0)
            {
                throw new ArgumentNullException("processname");
            }

            Process[] runninProcesses = Process.GetProcessesByName(processname);
            IntPtr activeWindowHandle = GetForegroundWindow();

            foreach (Process process in runninProcesses)
            {
                if (process.MainWindowHandle.Equals(activeWindowHandle))
                {
                    return true;
                }
            }

            // Process was not found or didn't had the focus.
            return false;
        }

        public static Process FindTopProcess()
        {
            Process[] runninProcesses = Process.GetProcesses();
            IntPtr activeWindowHandle = GetForegroundWindow();

            foreach (Process process in runninProcesses)
            {
                if (process.MainWindowHandle.Equals(activeWindowHandle))
                {
                    return process;
                }
            }

            // Process was not found or didn't had the focus.
            return null;
        }




        // import the function in your class
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);
        
        public static void SendPasteToSpecifcProcessAndSetForeground(int processId)
        {
            Process p = Process.GetProcessById(processId);
            if (p != null)
            {
                IntPtr h = p.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("^v");
            }
        }


        


    }
}
