using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using QQClass;
using System.Net;
using System.Net.Sockets;
using System.IO;


namespace MyQQClient
{
    public partial class F_Client : Form
    {
        ClassUsers users;
        ClassForms FormList = new ClassForms();

        public F_Client()
        {
            InitializeComponent();
        }
        class Win32API
        {
            [DllImport("User32.dll")]
            public static extern bool PtInRect(ref Rectangle r, Point p);
        }

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
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Drawing.Point  pp=new  Point(Cursor.Position.X,Cursor.Position.Y);//获取鼠标在屏幕的坐标点
            Rectangle Rects = new Rectangle(this.Left, this.Top, this.Left + this.Width, this.Top + this.Height);//存储当前窗体在屏幕的所在区域
            if ((this.Top < 0) && Win32API.PtInRect(ref Rects, pp))//当鼠标在当前窗体内，并且窗体的Top属性小于0
                this.Top = 0;//设置窗体的Top属性为0
            else
                //当窗体的上边框与屏幕的顶端的距离小于5时
                if (this.Top > -5 && this.Top < 5 && !(Win32API.PtInRect(ref Rects, pp)))
                    this.Top = 5 - this.Height;//将QQ窗体隐藏到屏幕的顶端

        }

        private void F_Client_Load(object sender, EventArgs e)
        {
            F_Logon FrmLogon = new F_Logon();   //创建并引用登录窗体
            if (FrmLogon.ShowDialog(this) == DialogResult.OK)   //当登窗体的对话框的返回值为OK时
            {
                FrmLogon.Dispose();
                udpSocket1.Active = true;
                label1.Text = Publec_Class.UserName;
                GetUserList();
            }
            else
            {
                FrmLogon.Dispose();
                Close();
            }
            Trans(label1, pictureBox1);
            Trans(label2, pictureBox1);
        }

        private void GetUserList()
        {
            ClassMsg msg = new ClassMsg();
            msg.sendKind = SendKind.SendCommand;
            msg.msgCommand = MsgCommand.UserList;
            udpSocket1.Send(IPAddress.Parse(Publec_Class.ServerIP), Convert.ToInt32(Publec_Class.ServerPort), new ClassSerializers().SerializeBinary(msg).ToArray());
        }


        private delegate void DataArrivaldelegate(byte[] Data, System.Net.IPAddress Ip, int Port);

        private void DataArrival(byte[] Data, System.Net.IPAddress Ip, int Port) //当有数据到达后的处理进程
        {
            try
            {
                ClassMsg msg = new ClassSerializers().DeSerializeBinary((new System.IO.MemoryStream(Data))) as ClassMsg;

                switch (msg.msgCommand)
                {
                    case  MsgCommand.UserList://获取用户列表
                        GetUserList(Data,Ip,Port);
                        break;
                    case  MsgCommand.SendToOne:
                        GetMsg(Data, Ip, Port);
                        break;
                    case MsgCommand.UpdateState:
                        UpdateState(Data,Ip,Port);
                        break;

                }
            }
            catch { }
        }

        private void udpSocket1_DataArrival(byte[] Data, System.Net.IPAddress Ip, int Port)
        {
            DataArrivaldelegate outdelegate = new DataArrivaldelegate(DataArrival);
            this.BeginInvoke(outdelegate, new object[] { Data, Ip, Port });
        }

        private void GetUserList(byte[] Data, System.Net.IPAddress Ip, int Port)
        {
            ClassMsg msg = (ClassMsg)new ClassSerializers().DeSerializeBinary(new MemoryStream(Data));
            users = (ClassUsers)new ClassSerializers().DeSerializeBinary(new MemoryStream(msg.Data));   //获取所有用户信息
            treeView1.Nodes.Clear();  //清空所有节点          
            for (int i = 0; i < users.Count; i++)//遍历所有用户
            {
                ClassUserInfo userItem = users[i];
                TreeNode Node = new TreeNode();
                Node.Text = userItem.UserName;//获取当前用户的名称
                Node.Tag = userItem;
                if (userItem.State == Convert.ToString((int)MsgCommand.Logined))    //当用户为上线状态
                {
                    Node.ImageIndex = 1;//设置上线用户的图片
                    Node.SelectedImageIndex = 1;
                }
                else
                {
                    Node.ImageIndex = 0;//设置下线用户的图片
                    Node.SelectedImageIndex = 0;
                }
                treeView1.Nodes.Add(Node);
            }
        }

        private void GetMsg(byte[] Data, System.Net.IPAddress Ip, int Port)
        {
            ClassMsg msg = (ClassMsg)new ClassSerializers().DeSerializeBinary(new MemoryStream(Data));
            string sid = msg.SID;//发送方用户ID
            string msgid = msg.msgID;//消息标识，GUID
            
            switch (msg.sendKind)
            {
                case SendKind.SendMsg://发送的消息
                    {
                        switch (msg.sendState)  //消息发送的状态
                        {
                            case SendState.Single://容量小的单消息
                                {
                                    String rtf = Encoding.Unicode.GetString(msg.Data);//获取发送信息
                                    Form msgform = null;    //定义一个窗体
                                    for (int i = 0; i < treeView1.Nodes.Count; i++)//在treeView1控件中遍历节点
                                    {
                                        if ((treeView1.Nodes[i].Tag as ClassUserInfo).UserID == sid)//如果当前节点的Tag值为发送信息的用户ID
                                        {
                                            msgform = FindForm(treeView1.Nodes[i]);//查找相关窗体信息
                                            if (msgform != null)
                                            {
                                                (msgform as F_Chat).Rich_Out.SelectionStart = 0;//将光标定位到RichTextBox控件的起始位
                                                (msgform as F_Chat).Rich_Out.AppendText((treeView1.Nodes[i].Tag as ClassUserInfo).UserName);//将发送方的名称添加到RichTextBox控件中
                                                (msgform as F_Chat).Rich_Out.AppendText("  " + DateTime.Now.ToString());//将发送时间添加到RichTextBox控件中
                                                (msgform as F_Chat).Rich_Out.AppendText("\r\n");//回车
                                                (msgform as F_Chat).Rich_Out.SelectedRtf = rtf;//添加发送的信息
                                                msgform.Text = "与" + (treeView1.Nodes[i].Tag as ClassUserInfo).UserName + "对话";
                                                msgform.Activate();//激活窗体
                                            }
                                            else
                                            {
                                                msgform = new F_Chat(); //创建并引用消信发送窗体
                                                msgform.Tag = treeView1.Nodes[i];//设置远程客户端的ID号
                                                (msgform as F_Chat).udpsocket = udpSocket1; //获取udpSocket1控件的所有信息
                                                FormList.add(msgform);//将当前窗体信息添加到窗体列表中
                                                (msgform as F_Chat).FormList = FormList;
                                                (msgform as F_Chat).Rich_Out.SelectionStart = 0;
                                                (msgform as F_Chat).Rich_Out.AppendText(
                                                        (treeView1.Nodes[i].Tag as ClassUserInfo).UserName);
                                                (msgform as F_Chat).Rich_Out.AppendText("  " + DateTime.Now.ToString());
                                                (msgform as F_Chat).Rich_Out.AppendText("\r\n");
                                                (msgform as F_Chat).Rich_Out.SelectedRtf = rtf;
                                                msgform.Text = "与" + (treeView1.Nodes[i].Tag as ClassUserInfo).UserName + "对话";
                                                msgform.Show();//显示发送消息窗体
                                            }
                                        }
                                    }
                                    break;
                                }
                            case SendState.Start://大容量开始消息
                                {
                                    FileStream fs = null;
                                    try
                                    {
                                        string FileName = "c:\\" + msgid + ".msg";//设置文件接收路径
                                        fs = File.Create(FileName);//创建文件
                                        fs.Write(msg.Data, 0, msg.Data.Length);//向文件中写入接收物信息
                                    }
                                    finally
                                    {
                                        fs.Close();//关闭文件
                                    }
                                    break;
                                }
                            case SendState.Sending://大容量消息发送中
                                {
                                    FileStream fs = null;
                                    try
                                    {
                                        string FileName = "c:\\" + msgid + ".msg";//设置文件接收路径
                                        fs = File.OpenWrite(FileName);//打开当前要写入的文件
                                        fs.Seek(0, SeekOrigin.End);//将该流的当前位值设为0
                                        fs.Write(msg.Data, 0, msg.Data.Length);//向文件中写入当前接收的信息
                                    }
                                    finally
                                    {
                                        fs.Close();
                                    }
                                    break;
                                }
                            case SendState.End://大容量消息结束
                                {
                                    FileStream fs = null;
                                    try
                                    {
                                        string FileName = "c:\\" + msgid + ".msg";//文件所在路径
                                        fs = File.OpenRead(FileName);//打开现有文件，以便进行读取
                                        //fs.Seek(0, SeekOrigin.End);
                                        //fs.Write(msg.Data, 0, msg.Data.Length);

                                        byte[] fsdata = new byte[Convert.ToInt32(fs.Length)];//将读取的信息存入到二进制流中
                                        //fs.Seek(0, SeekOrigin.Begin);
                                        fs.Read(fsdata,0,Convert.ToInt32(fs.Length));//将读取的流写入到缓冲区中
                                        String rtf = Encoding.Unicode.GetString(fsdata);//将流转换成字符串
                                        Form msgform = null;
                                        for (int i = 0; i < treeView1.Nodes.Count; i++)
                                        {
                                            if ((treeView1.Nodes[i].Tag as ClassUserInfo).UserID == sid)
                                            {
                                                msgform = FindForm(treeView1.Nodes[i]);
                                                if (msgform != null)
                                                {
                                                    (msgform as F_Chat).Rich_Out.SelectionStart = 0;
                                                    (msgform as F_Chat).Rich_Out.AppendText(
                                                            (treeView1.Nodes[i].Tag as ClassUserInfo).UserName);
                                                    (msgform as F_Chat).Rich_Out.AppendText("  " + DateTime.Now.ToString());
                                                    (msgform as F_Chat).Rich_Out.AppendText("\r\n");
                                                    (msgform as F_Chat).Rich_Out.SelectedRtf = rtf;
                                                    msgform.Text = "与" + (treeView1.Nodes[i].Tag as ClassUserInfo).UserName + "对话";
                                                    msgform.Activate();
                                                }
                                                else
                                                {
                                                    msgform = new F_Chat();
                                                    msgform.Tag = treeView1.Nodes[i];
                                                    (msgform as F_Chat).udpsocket = udpSocket1;
                                                    FormList.add(msgform);
                                                    (msgform as F_Chat).FormList = FormList;
                                                    (msgform as F_Chat).Rich_Out.SelectionStart = 0;
                                                    (msgform as F_Chat).Rich_Out.AppendText(
                                                            (treeView1.Nodes[i].Tag as ClassUserInfo).UserName);
                                                    (msgform as F_Chat).Rich_Out.AppendText("  " + DateTime.Now.ToString());
                                                    (msgform as F_Chat).Rich_Out.AppendText("\r\n");
                                                    (msgform as F_Chat).Rich_Out.SelectedRtf = rtf;
                                                    msgform.Text = "与" + (treeView1.Nodes[i].Tag as ClassUserInfo).UserName + "对话";
                                                    msgform.Show();
                                                }
                                            }
                                        }
                                    }
                                    finally
                                    {
                                        fs.Close();

                                    }
                                    break;
                                }

                        }
                        break;
                    }
                case SendKind.SendFile:
                    {
                        break;
                    }
            }

        }

        private void F_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (udpSocket1.Active)
            {
                ClassMsg msg = new ClassMsg();
                msg.sendKind = SendKind.SendCommand;
                msg.msgCommand = MsgCommand.Close;
                msg.SID = Publec_Class.UserID;
                msg.Data = Encoding.Unicode.GetBytes("");
                udpSocket1.Send(IPAddress.Parse(Publec_Class.ServerIP), Convert.ToInt32(Publec_Class.ServerPort),
                            new ClassSerializers().SerializeBinary(msg).ToArray());
                udpSocket1.Active = false;
            }
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                if (FindForm(treeView1.SelectedNode) == null)
                {
                    F_Chat msgform = new F_Chat();
                    msgform.Tag = treeView1.SelectedNode;
                    msgform.udpsocket = udpSocket1;
                    FormList.add(msgform);
                    msgform.FormList = FormList;
                    msgform.Text = "与" + (treeView1.SelectedNode.Tag as ClassUserInfo).UserName + "对话";
                    msgform.Show();
                }
            }
        }

        private Form FindForm(TreeNode Node)
        {
            for (int i = 0; i < FormList.Count; i++)
            {
                if ((TreeNode)FormList[i].Tag == Node)
                    return FormList[i];
            }
            return null;
        }

        private void UpdateState(byte[] Data, System.Net.IPAddress Ip, int Port)
        {
            ClassMsg msg = (ClassMsg)new ClassSerializers().DeSerializeBinary(new MemoryStream(Data));
            string sid = msg.SID;//发送方用户ID
            for (int i = 0; i < treeView1.Nodes.Count; i++)
            {
                if ((treeView1.Nodes[i].Tag as ClassUserInfo).UserID == sid)
                {
                    if (msg.msgID == "Up")
                    {
                        treeView1.Nodes[i].ImageIndex = 1;
                        treeView1.Nodes[i].SelectedImageIndex = 1;
                    }
                    else if (msg.msgID == "Down")
                    {
                        treeView1.Nodes[i].ImageIndex = 0;
                        treeView1.Nodes[i].SelectedImageIndex = 0;
                    }
                    break;
                }
            }

        }

    }
}