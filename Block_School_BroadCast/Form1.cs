using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace Block_School_BroadCast
{
    public partial class Form1 : Form
    {
        private string Broadcast_App_Name = "REDAgent.exe";
        private string ReName_App = "REDAgenthank.exe";
        private string Broadcast_App_Path = @"C:\CHYIOU\CHYI-IOU\";
        private string strShortFileName = @"HideFastUserSwitching";

        public Form1()
        {
            InitializeComponent();
            Check_Broadcast_App_Status();
            Check_System_Switch_User();
        }
        [DllImport("user32.dll")]//拖動無窗體的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        private void Start_MouseDown(object sender, MouseEventArgs e)
        {
            //拖動窗體
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        public void Check_Broadcast_App_Status()
        {
            if (File.Exists(Broadcast_App_Path + Broadcast_App_Name))
            {
                pictureBox1.Image = Properties.Resources.switch_off;
            }
            else if(File.Exists(Broadcast_App_Path + ReName_App))
            {
                i = 1;
                pictureBox1.Image = Properties.Resources.switch_on;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.switch_off;
                Insert_Text("廣播軟體不存在");
            }
        }
        public void Check_System_Switch_User()
        {
            RegistryKey rgkRun = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
            // 獲得應用進程名稱
            var Regl = rgkRun.GetValue(strShortFileName);
            if(Regl == null)
            {
                Insert_Text("找不到登陸檔");
                pictureBox2.Image = Properties.Resources.switch_on;
            }
            else
            {
                Int32 RegT = (Int32)rgkRun.GetValue(strShortFileName); 
                if (RegT == 0)
                {
                    pictureBox2.Image = Properties.Resources.switch_on;
                    Insert_Text("已開啟顯示切換使用者");
                }
                else
                {
                    pictureBox2.Image = Properties.Resources.switch_off;
                    Insert_Text("已關閉顯示切換使用者");
                    a = 0;
                }
            }
        }
        public void Kill_process()
        {
            string ProcessName = "REDAgent.exe";
            using (Process P = new Process())
            {
                try
                {
                    P.StartInfo = new ProcessStartInfo()
                    {
                        FileName = "taskkill",
                        CreateNoWindow = true,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        Arguments = "/F /IM \"" + ProcessName + "\""
                    };
                    P.Start();
                    P.WaitForExit(600);
                }
                catch
                {
                    P.StartInfo = new ProcessStartInfo()
                    {
                        FileName = "taskill",
                        CreateNoWindow = true,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        Arguments = "\"" + ProcessName + "\" /A /V"
                    };
                    P.Start();
                    P.WaitForExit(600);
                }
            }
        }
        public void Insert_Text(string content)
        {
            int count = Information_Box.Text.Length;
            string get_box_text = Information_Box.Text;
            Information_Box.Text = get_box_text.Insert(count, content + "\r\n");
            //////自動卷軸到最底下
            Information_Box.ScrollBars = ScrollBars.Vertical;
            Information_Box.SelectionStart = Information_Box.Text.Length;
            Information_Box.ScrollToCaret();
        }
        int i = 0;
        bool b = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            i = i ^ 1; //做 xor 運算 ，按一下 True ，再按一下 False......... 
            b = Convert.ToBoolean(i);
            if(File.Exists(Broadcast_App_Path + Broadcast_App_Name) || File.Exists(Broadcast_App_Path + ReName_App))
            { 
                if (b)
                {
                    Kill_process();
                    File.Move(Broadcast_App_Path + Broadcast_App_Name, Broadcast_App_Path + ReName_App);
                    pictureBox1.Image = Properties.Resources.switch_on;
                    Insert_Text("阻檔成功");
                }
                else
                {
                    File.Move(Broadcast_App_Path + ReName_App, Broadcast_App_Path + Broadcast_App_Name);
                    pictureBox1.Image = Properties.Resources.switch_off;
                    Insert_Text("恢復成功");
                }
            }
            else
            {
                    Insert_Text("廣播軟體不存在");
            }
        }

        int a = 0;
        bool c = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            a = a ^ 1; //做 xor 運算 ，按一下 True ，再按一下 False......... 
            c = Convert.ToBoolean(a);
            RegistryKey rgkRun = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            // 設置指定的註冊表項的指定名稱/值對。如果指定的項不存在，則創建該項。
            if (c)
            { 
                rgkRun.SetValue(strShortFileName, 0, RegistryValueKind.DWord);
                pictureBox2.Image = Properties.Resources.switch_on;
                Insert_Text("已開啟顯示切換使用者");
            }
            else
            {
                rgkRun.SetValue(strShortFileName, 1, RegistryValueKind.DWord);
                pictureBox2.Image = Properties.Resources.switch_off;
                Insert_Text("已關閉顯示切換使用者");
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Maxsize_Windows_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void Mini_Size_Windows_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Minn_To_Task_Bar_Click(object sender, EventArgs e)
        {
            this.Task_Bar_Icon.Text = "Block Broadcast 已縮小至工作列";
            this.Task_Bar_Icon.Icon = Properties.Resources.sword_icon;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Task_Bar_Icon.Visible = true;
        }

        private void Task_Bar_Icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
        }
    }
}
