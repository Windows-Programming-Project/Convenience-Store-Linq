﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Convenience_Store_Linq.DanhMuc;
namespace Convenience_Store_Linq
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmMain());
            //Application.Run(new FrmManuafacture());
            //Application.Run(new FrmType());
            //Application.Run(new FrmStock());
            //Application.Run(new FrmSupplier());
            //Application.Run(new FrmDetail());
           // Application.Run(new FrmEmployee());
           // Application.Run(new FrmCustomer());
            Application.Run(new FrmAccount());
        }
    }
}
