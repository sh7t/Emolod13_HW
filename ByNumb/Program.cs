using ByNumb.Forms;
using ByNumb.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByNumb
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                if (File.Exists(Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data"), new AssemblyName(args.Name).Name + ".dll")))
                    return Assembly.LoadFrom(Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data"), new AssemblyName(args.Name).Name + ".dll")); 
                return null;
            };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeScreen());
        }
    }
}
