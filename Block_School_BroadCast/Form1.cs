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
            
            Int32 RegT = (Int32)rgkRun.GetValue(strShortFileName);
            if (RegT == 0)
            {
                pictureBox2.Image = Properties.Resources.switch_on;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.switch_off;
                a = 0;
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
            }
            else
            {
                rgkRun.SetValue(strShortFileName, 1, RegistryValueKind.DWord);
                pictureBox2.Image = Properties.Resources.switch_off;
            }
        }
    }
}
