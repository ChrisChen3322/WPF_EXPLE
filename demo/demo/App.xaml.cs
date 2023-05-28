using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace demo
{

    //Scaffold-DbContext "Server=MSI\SQLEXPRESS;Database=UWASH_POS;Trusted_Connection=True;TrustServerCertificate=true;User ID=sa;Password=jserp23380498" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            [DllImport("User32", CharSet = CharSet.Unicode)]
            static extern IntPtr FindWindowW(string lpClassName, string lpWindowName);

            [DllImport("User32", CharSet = CharSet.Unicode)]
            static extern bool SetForegroundWindow(IntPtr hwnd);

            Mutex mutex = new Mutex(true, "測試範例", out bool isNewInstance);
            GC.Collect();
            if (isNewInstance != true)
            {
                IntPtr intPtr = FindWindowW(null, "測試範例窗口");
                if (intPtr != IntPtr.Zero)
                {
                    SetForegroundWindow(intPtr);
                }

                Shutdown();
            }
            //int processCount = 0;
            //Process[] pa = Process.GetProcesses();//获取当前进程数组。
            //foreach (Process PTest in pa)
            //{
            //    if (PTest.ProcessName == Process.GetCurrentProcess().ProcessName)
            //    {
            //        processCount += 1;
            //    }
            //}
            //if (processCount > 1)
            //{
            //    string p_name = Process.GetCurrentProcess().ProcessName;
            //    IntPtr intPtr = FindWindow(null, "測試範例窗口");
            //    if (intPtr != IntPtr.Zero)
            //    {
            //        SetForegroundWindow(intPtr);
            //    }
            //    return; //Exit;

            //}
        }
        

    }
}
