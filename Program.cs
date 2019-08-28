using Demo1;
using HighspeedNetworkEchartsTest1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform.Animation.Train
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
            //Application.Run(new HighspeedRailwayFrm());
            //Application.Run(new FrmElement());
            //Application.Run(new FrmTimetable());
            //Application.Run(new TestChart1());
            //Application.Run(new Formtest());
        }
    }
}
