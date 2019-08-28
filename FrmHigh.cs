using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using HighspeedNetworkEchartsTest1;
using System.Threading;
using Demo1;
using System.Runtime.InteropServices;
using Winform.Animation.Train;
//using WebKit;

namespace HighspeedNetworkEchartsTest1
{
    //在被调用方法类上加上[ComVisible(true)]标签，意思就是当前类可以com组件的形式供外包调用         
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisible(true)]
    public partial class HighspeedRailwayFrm : Form
    {
        public HighspeedRailwayFrm()
        {
            InitializeComponent();
            //string path = "F:\\Html\\ChineseHighSpeedRailNetwork.all_test1.html";
            ////System.Diagnostics.Process.Start("IExplore.exe", path);
            this.webBrowser1.ObjectForScripting = this;
            //webBrowser1.Navigate(path);
            //webBrowser1.Url = new Uri("F:\\leafletTest\\ChineseHighSpeedRailNetwork_all_test4.html");
            //string path = Application.StartupPath + "\\ChineseHighSpeedRailNetwork_all_test4.html";
            //webBrowser1.ScriptErrorsSuppressed = true;
            string path = "F:\\leafletTest\\ChineseHighSpeedRailNetwork_all_test4.html";
            webBrowser1.Navigate(path);
            //webBrowser1.ObjectForScripting = this;
        }
        private void HighspeedRailwayFrm_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            //string path = "D:\\C#\\CSharpCode\\HighspeedNetworkEchartsTest3\\bin\\Debug\\ChineseHighSpeedRailNetwork.all_test2.html";
            string path = "F:\\leafletTest\\ChineseHighSpeedRailNetwork_all_test4.html";
            //string path = Path.Combine(Application.StartupPath, "HTMLPage1.html");
            //System.Diagnostics.Process.Start("Chrome.exe", path);
            webBrowser1.Navigate(path);
            webBrowser2.ScriptErrorsSuppressed = true;
            string path2 = "F:\\leafletTest\\web5.html";
            webBrowser2.Navigate(path2);
           

            webBrowser3.ScriptErrorsSuppressed = true;
            string path3 = "F:\\leafletTest\\web3.html";
            webBrowser3.Navigate(path3);
            webBrowser4.ScriptErrorsSuppressed = true;
            string path4 = "F:\\leafletTest\\web3-1.html";
            webBrowser4.Navigate(path4);
            webBrowser5.ScriptErrorsSuppressed = true;
            string path5 = "F:\\leafletTest\\web4.html";
            webBrowser5.Navigate(path5);

         //   skinEngine1.SkinFile = System.Environment.CurrentDirectory + "\\Skins\\RealOne.ssk";　　//选择皮肤文件
            //skinEngine1.DisableTag = 9999;      //设置不需要被渲染的控件Tag值为9999
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


       

        object obj = null;
        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
    
        }

    private void btnLogin_Click(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            //string path = "d:\\c#\\csharpcode\\highspeednetworkechartstest1\\bin\\debug\\openrailwaymap.html";
            string path = "F:\\leafletTest\\leaflet-test9.html";
            webBrowser1.Navigate(path);           
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            //string path = "d:\\c#\\csharpcode\\highspeednetworkechartstest1\\bin\\debug\\openrailwaymap.html";
            string path = "F:\\leafletTest\\ChineseHighSpeedRailNetwork_all_test4.html";
            webBrowser1.Navigate(path);
        }

        private void 运行图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimetable f2 = new FrmTimetable();
            Thread.Sleep(1000);
            f2.Show();
        }
        private int v = 100;
        public void WebBrowserCallCSharpMethod()
        {
            MessageBox.Show("welcome to BeijingnanStation");
            webBrowser2.ScriptErrorsSuppressed = true;
            string path2 = "F:\\leafletTest\\Beijingnanzhan-table.html";
            webBrowser2.Navigate(path2);
            webBrowser3.ScriptErrorsSuppressed = true;
            string path3 = "F:\\leafletTest\\web3.html";
            //string path3 = "F:\\CSharpCode\\RailStudy0126\\HighspeedNetworkEchartsTest3\\bin\\Debug\\web3.html";
            webBrowser3.Navigate(path3);
            webBrowser4.ScriptErrorsSuppressed = true;
            string path4 = "F:\\leafletTest\\Beijingnanstation\\Beijingnanzhan-pic.html";
            webBrowser4.Navigate(path4);
            webBrowser5.ScriptErrorsSuppressed = true;
            string path5 = "F:\\leafletTest\\Beijingnanstation\\Beijingnanzhan-CAD2.html";
            webBrowser5.Navigate(path5);

            
            object value = 70;
            (webBrowser4.ActiveXInstance as SHDocVw.WebBrowser).ExecWB(SHDocVw.OLECMDID.OLECMDID_OPTICAL_ZOOM, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, ref value, ref obj);
            
            object value2 = 70;
            (webBrowser2.ActiveXInstance as SHDocVw.WebBrowser).ExecWB(SHDocVw.OLECMDID.OLECMDID_OPTICAL_ZOOM, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, ref value2, ref obj);
            object value3 = 70;
            (webBrowser5.ActiveXInstance as SHDocVw.WebBrowser).ExecWB(SHDocVw.OLECMDID.OLECMDID_OPTICAL_ZOOM, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, ref value3, ref obj);

        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            //string path = "d:\\c#\\csharpcode\\highspeednetworkechartstest1\\bin\\debug\\openrailwaymap.html";
            string path = "F:\\leafletTest\\SimJingHu\\JingHuHighTrain.html";
            webBrowser1.Navigate(path);
        }

        private void 能力要素管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmElement f3 = new FrmElement();
            Thread.Sleep(1000);
            f3.Show();
        }

        private void btnAny_Click(object sender, EventArgs e)
        {
            /*
            webBrowser1.ScriptErrorsSuppressed = true;
            string path = "F:\\leafletTest\\analyse.html";
            webBrowser1.Navigate(path);
            */
            Formtest f4 = new Formtest();
            Thread.Sleep(1000);
            f4.Show();
            //WebKit.WebKitBrowser browser = new WebKitBrowser();
            //browser.Dock = DockStyle.Fill;
            //this.Controls.Add(browser);
            //browser.Navigate("F:\\leafletTest\\analyse.html");
        }

        private void webBrowser4_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        
        }
    }
}
