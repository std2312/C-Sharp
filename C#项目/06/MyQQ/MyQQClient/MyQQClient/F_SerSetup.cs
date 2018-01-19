using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using System.IO;
using QQClass;

namespace MyQQClient
{
    public partial class F_SerSetup : Form
    {
        public F_SerSetup()
        {
            InitializeComponent();
        }
        Publec_Class PubClass =new Publec_Class();
        string serID = "";

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);


        private void button_Close_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (text_PassWord.Text.Trim() == text_PassWord2.Text.Trim())    //������������ͬ
            {
                RegisterMsg registermsg = new RegisterMsg();
                registermsg.UserName = text_Name.Text;
                registermsg.PassWord = text_PassWord.Text;
                byte[] registerData = new ClassSerializers().SerializeBinary(registermsg).ToArray();
                ClassMsg msg = new ClassMsg();
                msg.sendKind = SendKind.SendCommand;
                msg.msgCommand = MsgCommand.Registering;
                msg.Data = registerData;
                serID = text_IP.Text.Trim();
                udpSocket1.Send(IPAddress.Parse(serID), Convert.ToInt32(text_IP5.Text.Trim()), new ClassSerializers().SerializeBinary(msg).ToArray());
            }
            else
            {
                text_PassWord.Text = "";
                text_PassWord2.Text = "";
                MessageBox.Show("������ȷ�����벻ƥ�䣬���������롣");
            }
        }

        private delegate void DataArrivaldelegate(byte[] Data, System.Net.IPAddress Ip, int Port);

        private void sockUDP1_DataArrival(byte[] Data, System.Net.IPAddress Ip, int Port)
        {
            DataArrivaldelegate outdelegate = new DataArrivaldelegate(DataArrival); //�й�
            this.BeginInvoke(outdelegate, new object[] { Data, Ip, Port }); //�첽ִ���й�
        }

        

        private void DataArrival(byte[] Data, System.Net.IPAddress Ip, int Port) //�������ݵ����Ĵ������
        {
            try
            {
                ClassMsg msg = new ClassSerializers().DeSerializeBinary((new System.IO.MemoryStream(Data))) as ClassMsg;

                switch (msg.msgCommand)
                {
                    case  MsgCommand.Registered://ע��ɹ�
                        DialogResult = DialogResult.OK;
                        WritePrivateProfileString("MyQQ", "ID", serID, PubClass.Get_windows() + "\\Server.ini");
                        WritePrivateProfileString("MyQQ", "Port", text_IP5.Text.Trim(), PubClass.Get_windows() + "\\Server.ini");
                        WritePrivateProfileString("MyQQ", "Name", text_Name.Text.Trim(), PubClass.Get_windows() + "\\Server.ini");
                        break;
                }
            }
            catch { }
        }

        private void F_SerSetup_Load(object sender, EventArgs e)
        {
            udpSocket1.Active = true;
        }

        private void F_SerSetup_FormClosed(object sender, FormClosedEventArgs e)
        {
            udpSocket1.Active = false;
        }
    }
}