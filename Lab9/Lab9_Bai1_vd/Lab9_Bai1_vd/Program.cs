﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9_Bai1_vd
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
            //Application.Run(new FrmKhachHang());
            //Application.Run(new Form2());
            //Application.Run(new FrmBanHang());
            //Application.Run(new FrTimKiemKH());
            //Application.Run(new FrTimKiemMH());
            Application.Run(new FrTimKiemKHMuaHang());
        }
    }
}
