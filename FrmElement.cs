using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform.Animation.Train
{
    public partial class FrmElement : Form
    {
        public FrmElement()
        {
            InitializeComponent();
        }

        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FrmElement_Load(object sender, EventArgs e)
        {
            String ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\行车记录.mdb";
            OleDbConnection conn = new OleDbConnection(ConStr);
            conn.Open();
            DataTable dtt = new DataTable();

            OleDbDataAdapter ada = new OleDbDataAdapter("select*from Station ", conn);
            ada.Fill(dtt);                              //以上连接数据库
            dataGridView2.DataSource = dtt;             //将数据库内容储存，记录行数（列车数）
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("已选择京沪高铁");
            //  System.Diagnostics.Process.Start(Application.StartupPath + "\\中国动车组交路查询.exe").WaitForExit();

            // FileStream str = new FileStream(@"F:\\CSharpCode\\loginwinform\\Winform.Animation.Train\\bin\\Debug\\中国动车组交路查询.exe", FileMode.OpenOrCreate);
            // str.Write(Resource1.中国动车组交路查询, 0, Resource1.中国动车组交路查询.Length);
            // str.Close();
            if (TreeView1.Nodes.Count > 0)
                TreeView1.Nodes[0].Expand();//这个就是TreeNode类型的了。
        }
        string name;


        private void TreeView1_NodeMouseClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            name = e.Node.Text.ToString();
            if (name == "运行时分")
            {
                String ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\行车记录.mdb";
                OleDbConnection conn = new OleDbConnection(ConStr);
                conn.Open();
                DataTable dtt = new DataTable();

                OleDbDataAdapter ada = new OleDbDataAdapter("select*from 京沪高铁列车时刻表190317 ", conn);
                ada.Fill(dtt);                              //以上连接数据库
                dataGridView2.DataSource = dtt;             //将数据库内容储存，记录行数（列车数）
            }
            if (name == "车站布置")
            {
                String ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\行车记录.mdb";
                OleDbConnection conn = new OleDbConnection(ConStr);
                conn.Open();
                DataTable dtt = new DataTable();

                OleDbDataAdapter ada = new OleDbDataAdapter("select*from 车站 ", conn);
                ada.Fill(dtt);                              //以上连接数据库
                dataGridView2.DataSource = dtt;             //将数据库内容储存，记录行数（列车数）
            }
            if (name == "道岔设置")
            {
                String ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\行车记录.mdb";
                OleDbConnection conn = new OleDbConnection(ConStr);
                conn.Open();
                DataTable dtt = new DataTable();

                OleDbDataAdapter ada = new OleDbDataAdapter("select*from 道岔标准2", conn);
                ada.Fill(dtt);                              //以上连接数据库
                dataGridView2.DataSource = dtt;             //将数据库内容储存，记录行数（列车数）
            }
            if (name == "动车组要素")
            {
                String ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\行车记录.mdb";
                OleDbConnection conn = new OleDbConnection(ConStr);
                conn.Open();
                DataTable dtt = new DataTable();

                OleDbDataAdapter ada = new OleDbDataAdapter("select*from 动车组", conn);
                ada.Fill(dtt);                              //以上连接数据库
                dataGridView2.DataSource = dtt;             //将数据库内容储存，记录行数（列车数）
            }
            if (name == "运用模式")
            {
                System.Diagnostics.Process.Start(Application.StartupPath + "\\中国动车组交路查询.exe").WaitForExit();
            }
            if (name == "区间")
            {
                String ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\行车记录.mdb";
                OleDbConnection conn = new OleDbConnection(ConStr);
                conn.Open();
                DataTable dtt = new DataTable();

                OleDbDataAdapter ada = new OleDbDataAdapter("select*from 京沪高铁线路区间数据", conn);
                ada.Fill(dtt);                              //以上连接数据库
                dataGridView2.DataSource = dtt;             //将数据库内容储存，记录行数（列车数）
            }
            /*   if (name == "联锁方式")
              {
                  String ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\行车记录.mdb";
                  OleDbConnection conn = new OleDbConnection(ConStr);
                  conn.Open();
                  DataTable dtt = new DataTable();

                  OleDbDataAdapter ada = new OleDbDataAdapter("select*from 固定设备-轨道电路", conn);
                  ada.Fill(dtt);                              //以上连接数据库
                  dataGridView2.DataSource = dtt;             //将数据库内容储存，记录行数（列车数）
              }
                 if (name == "信号制式")
                 if (name == "信号制式")
              {
                  String ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\行车记录.mdb";
                  OleDbConnection conn = new OleDbConnection(ConStr);
                  conn.Open();
                  DataTable dtt = new DataTable();

                  OleDbDataAdapter ada = new OleDbDataAdapter("select*from 固定设备-信号机", conn);
                  ada.Fill(dtt);                              //以上连接数据库
                  dataGridView2.DataSource = dtt;             //将数据库内容储存，记录行数（列车数）
        }*/
            if (name == "设备参数")
            {
                String ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\行车记录.mdb";
                OleDbConnection conn = new OleDbConnection(ConStr);
                conn.Open();
                DataTable dtt = new DataTable();

                OleDbDataAdapter ada = new OleDbDataAdapter("select*from 道岔标准", conn);
                ada.Fill(dtt);                              //以上连接数据库
                dataGridView2.DataSource = dtt;             //将数据库内容储存，记录行数（列车数）
            }
            if (name == "分界点")
            {
                String ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\行车记录.mdb";
                OleDbConnection conn = new OleDbConnection(ConStr);
                conn.Open();
                DataTable dtt = new DataTable();

                OleDbDataAdapter ada = new OleDbDataAdapter("select*from 线路2", conn);
                ada.Fill(dtt);                              //以上连接数据库
                dataGridView2.DataSource = dtt;             //将数据库内容储存，记录行数（列车数）
            }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
