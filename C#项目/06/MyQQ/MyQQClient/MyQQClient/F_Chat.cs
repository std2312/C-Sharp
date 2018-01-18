using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using QQClass;
using System.IO;

namespace MyQQClient
{
    public partial class F_Chat : Form
    {
        public UDPSocket udpsocket;
        public ClassForms FormList;
        public bool Voiding;
        public bool SendViod;
        cVideo viodeo;

        public F_Chat()
        {
            InitializeComponent();
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse(Publec_Class.ServerIP);//�������˵�IP��ַ
            string port = Publec_Class.ServerPort;//�˿ں�
            string revid = ((this.Tag as TreeNode).Tag as ClassUserInfo).UserID;//����ID��
            string sid = Publec_Class.UserID;//����ID
            string msgid = Guid.NewGuid().ToString();//����ȫ��Ωһ��ʶ

            byte[] data = Encoding.Unicode.GetBytes(rich_Input.Rtf);//����ǰҪ���͵���Ϣת���ɶ�������
            ClassMsg msg = new ClassMsg();
            msg.sendKind = SendKind.SendMsg;//���͵���Ϣ
            msg.msgCommand = MsgCommand.SendToOne;//���͵��ǵ��û���Ϣ
            msg.SID = sid;//����ID
            msg.RID = revid;//����ID
            msg.Data = data;//���͵���Ϣ
            msg.msgID = msgid;

            if (data.Length <= 1024)//���������Ϣ�ĳ���С�ڵ���1024
            {
                msg.sendState = SendState.Single;
                //����Ϣֱ�ӷ��͸�Զ�̿ͻ���
                udpsocket.Send(ip, Convert.ToInt32(port), new ClassSerializers().SerializeBinary(msg).ToArray());
            }
            else
            {
                ClassMsg start = new ClassMsg();
                start.sendKind = SendKind.SendMsg;
                start.sendState = SendState.Start;//�ļ����Ϳ�ʼ����
                start.msgCommand = MsgCommand.SendToOne;//���͵��û�����
                start.SID = sid;
                start.RID = revid;
                start.Data = Encoding.Unicode.GetBytes("");
                start.msgID = msgid;
                udpsocket.Send(ip, Convert.ToInt32(port), new ClassSerializers().SerializeBinary(start).ToArray());
                MemoryStream stream = new MemoryStream(data);//�����������洢���ڴ�����
                int sendlen = 1024; //�����ļ�ÿ�鷢�͵ĳ���
                long sunlen = (stream.Length);//�����ļ��Ĵ�С
                int offset = 0;//�����ļ����͵���ʼλ��
                while (sunlen > 0)  //��������
                {
                    sendlen = 1024;
                    if (sunlen <= sendlen)
                        sendlen = Convert.ToInt32(sunlen);
                    byte[] msgdata = new byte[sendlen];
                    stream.Read(msgdata, offset, sendlen);//��ȡҪ���͵��ֽڿ�
                    msg.sendState = SendState.Sending;//����״̬Ϊ�ļ�������
                    msg.Data = msgdata;
                    udpsocket.Send(ip, Convert.ToInt32(port), new ClassSerializers().SerializeBinary(msg).ToArray());//���͵�ǰ�����Ϣ
                    sunlen = sunlen - sendlen;//��¼��һ�����ʼλ��
                }
                ClassMsg end = new ClassMsg();
                end.sendKind = SendKind.SendMsg;
                end.sendState = SendState.End;//�ļ����ͽ�������
                end.msgCommand = MsgCommand.SendToOne;
                end.SID = sid;
                end.RID = revid;
                end.Data = Encoding.Unicode.GetBytes("");
                end.msgID = msgid;
                udpsocket.Send(ip, Convert.ToInt32(port), new ClassSerializers().SerializeBinary(end).ToArray());//������Ϣ��֪ͨ�ļ����ͽ���



                string dir = System.Environment.CurrentDirectory;
                dir = dir.Substring(0, dir.Length - 9);
                pictureBox1.Load(dir + @"Image\QQ12.jpg");
            }

            Rich_Out.SelectionStart = 0;//���ı�����ʼ����Ϊ0
            Rich_Out.AppendText(Publec_Class.UserName);//����ǰ�û�����ӵ��ı�����
            Rich_Out.AppendText("  "+ DateTime.Now.ToString());//����ǰ���͵�ʱ����ӵ��ı�����
            Rich_Out.AppendText("\r\n");//���лس�
            Rich_Out.SelectedRtf = rich_Input.Rtf;//��������Ϣ��ӵ������ı�����
            rich_Input.Clear();//��շ����ı���
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_Chat_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormList.Romove(this);
            udpSocket1.Active = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void tool_Video_Click(object sender, EventArgs e)
        {
            viodeo = new cVideo(pictureBox1.Handle, pictureBox1.Width, pictureBox1.Height);
            viodeo.StartWebCam();

            ClassMsg msg = new ClassMsg();
            msg.sendKind = SendKind.SendCommand;
            msg.msgCommand = MsgCommand.VideoOpen;
            msg.Data = Encoding.Unicode.GetBytes("");

            IPAddress ip = IPAddress.Parse(((this.Tag as TreeNode).Tag as ClassUserInfo).UserIP);
            string port = "11005";
            string revid = ((this.Tag as TreeNode).Tag as ClassUserInfo).UserID;
            string sid = Publec_Class.UserID;

            udpsocket.Send(ip, Convert.ToInt32(port), new ClassSerializers().SerializeBinary(msg).ToArray());
            Voiding = true;
            SendViod = false;
            timer1.Enabled = true;
            panel2.Visible = true;
        }

        private void udpSocket1_DataArrival(byte[] Data, IPAddress Ip, int Port)
        {
            DataArrivaldelegate outdelegate = new DataArrivaldelegate(DataArrival);
            this.BeginInvoke(outdelegate, new object[] { Data, Ip, Port });
        }

        private delegate void DataArrivaldelegate(byte[] Data, System.Net.IPAddress Ip, int Port);

        private void DataArrival(byte[] Data, System.Net.IPAddress Ip, int Port) //�������ݵ����Ĵ������
        {
            try
            {
                ClassMsg msg = new ClassSerializers().DeSerializeBinary((new System.IO.MemoryStream(Data))) as ClassMsg;

                switch (msg.msgCommand)
                {
                    case MsgCommand.VideoOpen:
                        Voiding = true;
                        SendViod = false;
                        break;
                    case MsgCommand.Videoing:
                        GetVoid(Data, Ip, Port);
                        break;
                    case MsgCommand.VideoClose:
                        Voiding = false;
                        break;

                }
            }
            catch { }
        }

        private void GetVoid(byte[] Data, System.Net.IPAddress Ip, int Port)
        {
            ClassMsg msg = (ClassMsg)new ClassSerializers().DeSerializeBinary(new MemoryStream(Data));
            string sid = msg.SID;//���ͷ��û�ID
            string msgid = msg.msgID;//��Ϣ��ʶ��GUID
            switch (msg.msgCommand)
            {
                case MsgCommand.Videoing://���͵���Ϣ
                    {
                        switch (msg.sendState)  //��Ϣ���͵�״̬
                        {
                            case SendState.Start:
                                {
                                    FileStream fs = null;
                                    try
                                    {
                                        string FileName = "c:\\Void.bmp";//�����ļ�����·��
                                        fs = File.Create(FileName);//�����ļ�
                                        fs.Write(msg.Data, 0, msg.Data.Length);//���ļ���д���������Ϣ
                                    }
                                    finally
                                    {
                                        fs.Close();//�ر��ļ�
                                    }
                                    break;
                                }
                            case SendState.Sending:
                                {
                                    FileStream fs = null;
                                    try
                                    {
                                        string FileName = "c:\\Void.bmp";//�����ļ�����·��
                                        fs = File.OpenWrite(FileName);//�򿪵�ǰҪд����ļ�
                                        fs.Seek(0, SeekOrigin.End);//�������ĵ�ǰλֵ��Ϊ0
                                        fs.Write(msg.Data, 0, msg.Data.Length);//���ļ���д�뵱ǰ���յ���Ϣ
                                    }
                                    finally
                                    {
                                        fs.Close();
                                    }
                                    break;
                                }
                            case SendState.End:
                                {
                                    pictureBox8.Load("c:\\Void.bmp");
                                    break;
                                }

                        }
                    }
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Voiding || !SendViod || pictureBox1.Image != null)
            {
                SendViod = true;

                //��ʼ����
                IPAddress ip = IPAddress.Parse(((this.Tag as TreeNode).Tag as ClassUserInfo).UserIP);
                string port = "11005";
                string revid = ((this.Tag as TreeNode).Tag as ClassUserInfo).UserID;
                string sid = Publec_Class.UserID;

                ClassMsg msg = new ClassMsg();
                msg.sendKind = SendKind.SendCommand;
                msg.msgCommand = MsgCommand.Videoing;
                msg.sendState = SendState.Sending;
                msg.SID = sid;
                msg.RID = revid;
                msg.Data = Encoding.Unicode.GetBytes("");

                ClassMsg start = new ClassMsg();
                start.sendKind = SendKind.SendCommand;
                start.msgCommand = MsgCommand.Videoing;
                start.sendState = SendState.Start;
                start.SID = sid;
                start.RID = revid;
                start.Data = Encoding.Unicode.GetBytes("");

                udpsocket.Send(ip, Convert.ToInt32(port), new ClassSerializers().SerializeBinary(start).ToArray());


                viodeo.GrabImage(pictureBox1.Handle, "C:\\TempVoid.Bmp");
                FileStream stream = File.OpenRead("C:\\TempVoid.Bmp");

                //pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                //stream.

                int sendlen = 1024;
                long sunlen = (stream.Length);
                int offset = 0;

                while (sunlen > 0)
                {
                    sendlen = 1024;

                    if (sunlen <= sendlen)
                        sendlen = Convert.ToInt32(sunlen);
                    byte[] msgdata = new byte[sendlen];
                    stream.Read(msgdata, offset, sendlen);

                    msg.sendState = SendState.Sending;

                    msg.Data = msgdata;

                    udpsocket.Send(ip, Convert.ToInt32(port), new ClassSerializers().SerializeBinary(msg).ToArray());
                    sunlen = sunlen - sendlen;

                }

                ClassMsg end = new ClassMsg();
                end.sendKind = SendKind.SendCommand;
                end.sendState = SendState.End;
                end.msgCommand = MsgCommand.Videoing;
                end.SID = sid;
                end.RID = revid;
                end.Data = Encoding.Unicode.GetBytes("");
                stream.Close();
                udpsocket.Send(ip, Convert.ToInt32(port), new ClassSerializers().SerializeBinary(end).ToArray());
                SendViod = false;
            }
        }

        private void button_Incepl_Click(object sender, EventArgs e)
        {
            Voiding = false;
            SendViod = true;
            timer1.Enabled = false;
            panel2.Visible = false;
            viodeo.CloseWebcam();
            //MessageBox.Show(System.Environment.CurrentDirectory + @"\Image\QQ08.jpg");
            string dir = System.Environment.CurrentDirectory;
            dir = dir.Substring(0, dir.Length - 9);
            pictureBox8.Load(dir + @"Image\QQ08.jpg");
            pictureBox1.Load(dir + @"Image\QQ12.jpg");
        }

        private void F_Chat_Load(object sender, EventArgs e)
        {
            udpSocket1.Active = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }


    }
}