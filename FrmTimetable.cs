using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class FrmTimetable : Form
    {
        public FrmTimetable()
        {
            InitializeComponent();
         
        }
        int[] arr_time ={540,558,570,584,604,624,638,652,660,668,680,690,   // 对一条线路实验时使用，记录一列车在每站的到达时间
                         706,716,728,744,748,762,766,772,782,788,794,808};

        int[] lea_time ={540,558,570,584,604,624,638,652,660,668,680,690,   // 对一条线路实验时使用，记录一列车在每站的离开时间
                         706,716,728,746,748,762,766,772,782,788,794,808};
   
        int[] diff = { 0,23,28 ,34,42, 35, 16, 27, 22, 14, 24,30, 30,   
                           20, 24, 23, 26, 9, 12, 22, 10, 12, 16 };         //每站之间地理距离
        int[] pos = { 0, 23, 51, 85, 127, 162, 178, 205, 227, 241, 265, 295, 325, 
                        345, 369, 392, 418, 427, 439, 451, 473, 483, 495, 511 };     //每站之间实际距离
        String[] name = {"北京南","廊坊","天津南","沧州西","德州东","济南西","泰安","曲阜东","滕州东","枣庄"
                            ,"徐州东","宿州东","蚌埠南","定远","滁州","南京南","秦淮河","镇江南","丹阳北","常州北",
                            "无锡东","苏州北","昆山南","上海虹桥"};              //  站名
        String[] number = { "0","1 ","2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17","18","19","20","21","22","23","24"};          // 0-23点
        string[] name2 ={"北京南a","北京南b","廊坊a","廊坊d","天津南a","天津南d","沧州西a",
                         "沧州西d",	"德州东a","德州东d","济南西a","济南西d","泰安a","泰安d",
                         "曲阜东a",	"曲阜东d","滕州东a","滕州东d","枣庄a","枣庄d","徐州东a",
                          "徐州东d","宿州东a","宿州东d","蚌埠南a","蚌埠南d","定远a","定远d"	,"滁州a",
                          "滁州d", "南京南京沪场a","南京南京沪场d","秦淮河a","秦淮河d","镇江南a","镇江南d","丹阳北a","丹阳北d",
                          "常州北a","常州北d","无锡东a","无锡东d","苏州北a","苏州北d","昆山南京沪场a",	
                          "昆山南京沪场d","上海虹桥高速场a","上海虹桥高速场d"};         // 与数据库名称一致，读取数据用

        private void Form1_Load(object sender, EventArgs e)
        {
            String ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\行车记录.mdb";
            OleDbConnection conn = new OleDbConnection(ConStr);
            conn.Open();
            DataTable dtt = new DataTable();
            OleDbDataAdapter ada = new OleDbDataAdapter("select*from 表5 ", conn);
            ada.Fill(dtt);                              //以上连接数据库


            int rows_count = dtt.Rows.Count;
            dataGridView1.DataSource = dtt;             //将数据库内容储存，记录行数（列车数）


            Bitmap bmp = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            this.pictureBox1.BackgroundImage = bmp;
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            Pen pen1 = new Pen(Color.Green, 2);
            Pen pen2 = new Pen(Color.Gray, 0.5f);
            Pen pen3 = new Pen(Color.Black, 1.5f);          //  笔号  pen1、pen2 背景；pen3 运行线



            for (int i = 0; i < pos.Length; i++)
            {
                g.DrawString(name[i], this.Font, Brushes.Black, 10, 10 + pos[i]);
                Point point1 = new Point(60, 15 + pos[i]);
                Point point2 = new Point(780, 15 + pos[i]);
                g.DrawLine(pen1, point1, point2);
            }


            for (int i = 0; i <= 24; i++)
            {
                Point point1 = new Point(60 + 30 * i, 14);
                Point point2 = new Point(60 + 30 * i, pos[23] + 15);
                g.DrawLine(pen1, point1, point2);


                for (int j = 1; j < 2; j++)
                {
                    if (i == 24) { break; }
                    Point point3 = new Point(60 + 30 * i + j * 15, 14);
                    Point point4 = new Point(60 + 30 * i + j * 15, pos[23] + 15);
                    g.DrawLine(pen2, point3, point4);
                    g.DrawString(number[i], this.Font,Brushes.Black,55+30*i,530);

                }
            }              
            
            // 以上为背景制作


            int m = 0;
            int n = 0;
            int u = 0;
            int[] l = new int[rows_count];              


            int[,] array = new int[rows_count, name2.Length];
            Point[, ,] pt = new Point[rows_count, 2, name2.Length / 2];

            for (int i = 0; i < rows_count; i++) 
            { 
                for (int j = 0; j < name2.Length; j++)
                {
                    DataRow dr2 = dtt.Rows[i];
                    array[i,j] = int.Parse(Convert.ToString(dr2[name2[j]]));
                    array[i,j] = array[i,j] / 2 + 60;
                }           //  对列车时间处理，使其适应坐标
            }

            for (int i = 0; i < rows_count; i++)
            {
                l[i] = 0;
                for (int j = 0; j < name2.Length; j++)
                {
                    if (array[i,j] == 60)
                    {
                        break;
                    }
                    l[i]++;
                }
            }           // 判断列车终到站

            int a = l[2];

            for (int i = 0; i < rows_count; i++)
            {
                m = 0;
                n = 0;
                u = 0;
                for (int j = 0; j <name2.Length; j++)
                {

                        while (j % 2 == 0)
                        {
                            pt[i,0,m] = new Point(array[i,j], 15 + pos[u]);
                            m++;
                            break;
                        }
                        while (j % 2 == 1)
                        {
                            pt[i,1,n] = new Point(array[i,j], 15 + pos[u]);
                            n++;
                            u++;
                            break;
                        }           //  分别将到达与离开时间记录
                    
                       
                    }
                   
                }

            for (int i = 0; i < rows_count; i++)
            {
                for (int j = 0; j < 2; j++) {
                    for (int k1 = 0; k1 < (l[i]/2); k1++) {
                        g.DrawLine(pen3, pt[i,1,k1], pt[i,0,k1]);
                    }
                    for (int k2 = 1; k2 < (l[i]/2); k2++)
                    {
                        g.DrawLine(pen3, pt[i, 1, k2-1], pt[i, 0, k2]);
                    }
                }
            }    //  划线：后站到达与前站出发连线、同一站点到达与出发连线
            pictureBox1.Image = bmp;
  }
       
        //能力指标分析


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
