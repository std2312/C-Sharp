using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.Threading;
using System.Runtime.InteropServices;
using QQClass;

namespace MyQQClient
{
    public partial class F_Logon : Form
    {
        public F_Logon()
        {
            InitializeComponent();
        }

        #region//声名变量
        Publec_Class PubClass = new Publec_Class();
        #endregion

        #region  使Label控件透明
        /// <summary>
        /// 使Label控件透明.
        /// </summary>
        public void Trans(Label lab, PictureBox pic)
        {
            lab.BackColor = Color.Transparent;
            lab.Parent = pic;
        }
        #endregion

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        private void button_QQLogon_Click(object sender, EventArgs e)
        {
            if (Publec_Class.ServerPort != "" && Publec_Class.ServerIP != "")   //当读取到服务器的IP和端口号时
            {
                RegisterMsg registermsg = new RegisterMsg();
                registermsg.UserName = text_Name.Text;
                registermsg.PassWord = text_PassWord.Text;
                byte[] registerData = new ClassSerializers().SerializeBinary(registermsg).ToArray();
                ClassMsg msg = new ClassMsg();
                msg.sendKind = SendKind.SendCommand;
                msg.msgCommand = MsgCommand.Logining;
                msg.Data = registerData;
                udpSocket1.Send(IPAddress.Parse(Publec_Class.ServerIP), Convert.ToInt32(Publec_Class.ServerPort), new ClassSerializers().SerializeBinary(msg).ToArray());
                Publec_Class.UserName = text_Name.Text;
             }
        }

        private void F_Logon_Load(object sender, EventArgs e)
        {
            Trans(label1, pictureBox1);
            Trans(label2, pictureBox1);

            //如果程序启动目录中没有Server.ini文件

            if (System.IO.File.Exists(PubClass.Get_windows() + "\\Server.ini") == false)
            {
                F_SerSetup FrmSerSetup = new F_SerSetup();  //创建并引用注册窗体
                FrmSerSetup.Text = "用户注册";  //设置注册窗体的名称
                if (FrmSerSetup.ShowDialog(this) == DialogResult.OK)    //当注册窗体的对话框返回值为OK时
                {
                    FrmSerSetup.Dispose();  //释放注册窗体的所有资源
                }
                else
                {
                    FrmSerSetup.Dispose();
                    DialogResult = DialogResult.Cancel;//将当前窗体的对话框返回值设为Cancel
                }
            }
            //如果Windows目录中有Server.ini文件
            if (System.IO.File.Exists(PubClass.Get_windows() + "\\Server.ini") == true)
            {
                Publec_Class.ServerIP = "";
                Publec_Class.ServerPort = "";
                //读取INI文件
                StringBuilder temp = new StringBuilder(255);
                //读取服务器的IP地址
                GetPrivateProfileString("MyQQ", "ID", "服务器地址读取错误。", temp, 255, PubClass.Get_windows() + "\\Server.ini");
                Publec_Class.ServerIP = temp.ToString();
                //读取端口号
                GetPrivateProfileString("MyQQ", "Port", "服务器端口号读取错误。", temp, 255, PubClass.Get_windows() + "\\Server.ini");
                Publec_Class.ServerPort = temp.ToString();
                //读取用户名称
                GetPrivateProfileString("MyQQ", "Name", "服务器端口号读取错误。", temp, 255, PubClass.Get_windows() + "\\Server.ini");
                Publec_Class.ClientName = temp.ToString();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
            udpSocket1.Active = true;   //启动自定义的udpSocket1控件
        }
        
        private void button_QQClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void udpSocket1_DataArrival(byte[] Data, IPAddress Ip, int Port)
        {
            DataArrivaldelegate outdelegate = new DataArrivaldelegate(DataArrival);
            this.BeginInvoke(outdelegate, new object[] { Data, Ip, Port }); 
        }

        private delegate void DataArrivaldelegate(byte[] Data, System.Net.IPAddress Ip, int Port);

        private void DataArrival(byte[] Data, System.Net.IPAddress Ip, int Port) //当有数据到达后的处理进程
        {
            try
            {
                ClassMsg msg = new ClassSerializers().DeSerializeBinary((new System.IO.MemoryStream(Data))) as ClassMsg;

                switch (msg.msgCommand)
                {
                    case  MsgCommand.Logined://登录成功
                        Publec_Class.UserID = msg.SID;
                        DialogResult = DialogResult.OK;
                        break;

                }
            }
            catch { }
        }

        private void F_Logon_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (udpSocket1.Active)
                udpSocket1.Active = false;
        }
    }
}