using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QQClass;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.IO;


namespace MyQQServer
{
    public partial class F_Server : Form
    {
        public F_Server()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //QQClass.Controls.ClassMsg msg = new QQClass.Controls.ClassMsg(0, LV_SysUser.Items[0].Text, null);
            //SendMsgToAll(msg);//发送消息给所有此用户的联系人,告之用户掉线
        }

        private void SendMsgToAll(ClassMsg msg)//发送消息给所有用户
        {
            try
            {
                foreach (System.Windows.Forms.ListViewItem item in this.LV_SysUser.Items)
                {
                    System.Net.IPAddress ip = System.Net.IPAddress.Parse(item.SubItems[1].Text);
                    int port = Convert.ToInt32(item.SubItems[2].Text);
                    System.IO.MemoryStream stream = new ClassSerializers().SerializeBinary(msg);
                    QQClass.UDPSocket udp = new QQClass.UDPSocket();
                    udp.Send(ip, port, stream.ToArray());
                }
            }
            catch{ }

        }

        private void SendMsgToOne(System.Net.IPAddress ip, int port, ClassMsg msg)//发送消息给一个用户
        {
            try
            {
                System.IO.MemoryStream stream = new ClassSerializers().SerializeBinary(msg);
                QQClass.UDPSocket udp = new QQClass.UDPSocket();
                udp.Send(ip, port, stream.ToArray());
            }
            catch { }

        }

        private void Tool_Open(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Text == "开始服务")
            {
                ((ToolStripMenuItem)sender).Text = "结束服务";
                udpSocket1.Active = true;
            }
            else
            {
                ((ToolStripMenuItem)sender).Text = "开始服务";
                udpSocket1.Active = false;
            }
        }

        private void Server(bool IsServer)//开始或停止服务
        {

        }

        private void sockUDP1_DataArrival(byte[] Data, System.Net.IPAddress Ip, int Port)
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

                switch (msg.sendKind)
                {
                    case SendKind.SendCommand://命令
                        {
                            switch (msg.msgCommand)
                            {
                                case MsgCommand.Registering://注册用户
                                    RegisterUser(msg, Ip, Port);
                                    break;
                                case MsgCommand.Logining://登录用户
                                    UserLogin(msg, Ip, Port, 1);
                                    break;
                                case MsgCommand.UserList://用户列表
                                    SendUserList(msg, Ip, Port);
                                    break;
                                case MsgCommand.SendToOne://发送消息给单用户
                                    SendUserMsg(msg, Ip, Port);
                                    break;
                                case MsgCommand.Close://下线
                                    UpdateUserState(msg, Ip, Port);
                                    break;
                            }
                            break;
                        }
                    case SendKind.SendMsg://消息
                        {
                            switch (msg.msgCommand)
                            {
                                case MsgCommand.SendToOne://发送消息给单用户
                                    SendUserMsg(msg, Ip, Port);
                                    break;
                            }
                            break;
                        }
                    case SendKind.SendFile://文件
                        {
                            break;
                        }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="Ip"></param>
        /// <param name="Port"></param>
        /// <param name="State"></param>
        private void UserLogin(ClassMsg msg, System.Net.IPAddress Ip, int Port, int State)
        {
            RegisterMsg registermsg = (RegisterMsg)new ClassSerializers().DeSerializeBinary(new MemoryStream(msg.Data));

            ClassOptionData OptionData = new ClassOptionData();//创建并引用ClassOptionData
            MsgCommand msgState = msg.msgCommand;   //获取接收消息的命令
            String UserName = registermsg.UserName;//登录用户名称
            String PassWord = registermsg.PassWord;//用户密码
            String vIP = Ip.ToString();//用户IP地址

            SqlDataReader DataReader = OptionData.ExSQLReDr("Select * From tb_CurreneyUser Where Name = "+ "'"+UserName+"'"+" and PassWord = "
                            +"'"+PassWord+"'");//在数据库中通过用户名和密码进行查找

            DataReader.Read();//读取查找到的记录
            string ID = Convert.ToString(DataReader.GetInt32(0));//获取第一条记录中的ID字段值
            if (DataReader.HasRows)//当DataReader中有记录信息时
            {
                //修改当前记录的标识为上线状态
                OptionData.ExSQL("Update tb_CurreneyUser Set Sign = " + Convert.ToString((int)(MsgCommand.Logined)) + ",IP = " + "'" + vIP + "',Port = " + "'" + Port.ToString() + "'" + " Where ID = " + ID);
                msg.msgCommand =  MsgCommand.Logined;//设置为上线命令
                msg.SID = ID;//用户ID值
                SendMsgToOne(Ip, Port, msg);//将消息返回给发送用户
                UpdateUserState(msg,Ip,Port);//更新用户在线状态
            }
            OptionData.Dispose();
            UpdateUser();//更新用户列表
            
        }

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="Ip"></param>
        /// <param name="Port"></param>
        private void RegisterUser(ClassMsg msg, System.Net.IPAddress Ip, int Port)
        {
            msg = InsertUser(msg,Ip,Port);
            UpdateUserList(msg, Ip, Port);
        }

        /// <summary>
        /// 插入用户
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="Ip"></param>
        /// <param name="Port"></param>
        /// <returns></returns>
        private ClassMsg InsertUser(ClassMsg msg, System.Net.IPAddress Ip, int Port)
        {
            RegisterMsg registermsg = (RegisterMsg)new ClassSerializers().DeSerializeBinary(new MemoryStream(msg.Data));

            ClassOptionData OptionData = new ClassOptionData();
            MsgCommand Sate = msg.msgCommand;
            String UserName = registermsg.UserName; //注册用户的名称
            String PassWord = registermsg.PassWord;//注册用户的密码
            String vIP = Ip.ToString();//注册用户的IP地址
            //向数据表中添加注册信息
            OptionData.ExSQL("insert into tb_CurreneyUser (IP,Port,Name,PassWord,Sign) values ('" + vIP + "'," +
                Port.ToString() + ",'" + UserName + "','" + PassWord + "'," + Convert.ToString((int)(MsgCommand.Registered)) + ")");
            SqlDataReader DataReader = OptionData.ExSQLReDr("Select * From tb_CurreneyUser");
            UpdateUser();//更新用户列表
            OptionData.Dispose();
            msg.msgCommand =  MsgCommand.Registered;//用户注册结束命令
            SendMsgToOne(Ip,Port,msg);//将注册命令返回给注册用户
            return msg;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateUser();//加载用户列表
            //udpSocket1.Active = true;
        }


        /// <summary>
        /// 更新用户列表
        /// </summary>
        private void UpdateUser()
        {
            ClassOptionData OptionData = new ClassOptionData();
            SqlDataReader DataReader = OptionData.ExSQLReDr("Select * From tb_CurreneyUser");
            LV_SysUser.Items.Clear();
            while (DataReader.Read())
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = Convert.ToString(DataReader.GetInt32(0));
                listItem.SubItems.Add(DataReader.GetString(1));
                listItem.SubItems.Add(Convert.ToString(DataReader.GetInt32(2)));
                listItem.SubItems.Add(DataReader.GetString(3));
                listItem.SubItems.Add(Convert.ToString(DataReader.GetInt32(5)));

                LV_SysUser.Items.Add(listItem);
            }
            OptionData.Dispose();
        }

        private void F_Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            udpSocket1.Active = false;
            ClassOptionData OptionData = new ClassOptionData();
            OptionData.ExSQL("Update tb_CurreneyUser Set Sign =12 Where ID >0");
            OptionData.Dispose();

        }

        private void udpSocket1_DataArrival(byte[] Data, IPAddress Ip, int Port)
        {
            DataArrivaldelegate outdelegate = new DataArrivaldelegate(DataEvent);
            this.BeginInvoke(outdelegate, new object[] { Data, Ip, Port }); 

        }

        private void DataEvent(byte[] Data, System.Net.IPAddress Ip, int Port)
        {
            //MessageBox.Show(Encoding.Unicode.GetString(Data));
            //this.Text = Encoding.Unicode.GetString(Data);
            //MessageBox.Show(this.Text);
        }


        /// <summary>
        /// 发送用户信息
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="Ip"></param>
        /// <param name="Port"></param>
        private void SendUserList(ClassMsg msg, System.Net.IPAddress Ip, int Port)
        {
            ClassUsers Users = new ClassUsers();
            ClassOptionData OptionData = new ClassOptionData();
            SqlDataReader DataReader = OptionData.ExSQLReDr("Select * From tb_CurreneyUser");

            while (DataReader.Read())
            {
                ClassUserInfo UserItem = new ClassUserInfo();
                UserItem.UserID = Convert.ToString(DataReader.GetInt32(0));
                UserItem.UserIP = DataReader.GetString(1);
                UserItem.UserPort = Convert.ToString(DataReader.GetInt32(2));
                UserItem.UserName = DataReader.GetString(3);
                UserItem.State = Convert.ToString(DataReader.GetInt32(5));
                Users.add(UserItem);
            }
            OptionData.Dispose();
            msg.Data = new ClassSerializers().SerializeBinary(Users).ToArray();
            udpSocket1.Send(Ip,Port,new ClassSerializers().SerializeBinary(msg).ToArray());
        }

        private void UpdateUserList(ClassMsg msg, System.Net.IPAddress Ip, int Port)
        {
            ClassUsers Users = new ClassUsers();
            ClassOptionData OptionData = new ClassOptionData();
            SqlDataReader DataReader = OptionData.ExSQLReDr("Select * From tb_CurreneyUser");//查找所有注册的用户信息

            while (DataReader.Read())//遍历所有用户
            {
                ClassUserInfo UserItem = new ClassUserInfo();//创建并引用ClassUserInfo类
                UserItem.UserID = Convert.ToString(DataReader.GetInt32(0));//记录用户用编号
                UserItem.UserIP = DataReader.GetString(1);//记录用户的IP地址
                UserItem.UserPort = Convert.ToString(DataReader.GetInt32(2));//记录端口号
                UserItem.UserName = DataReader.GetString(3);//记录用户名称
                UserItem.State = Convert.ToString(DataReader.GetInt32(5));//记录当前状态
                Users.add(UserItem);//将单用户信息添加到用户列表中
            }

            msg.Data = new ClassSerializers().SerializeBinary(Users).ToArray();//将用户列表写入到二进制流中
            //查找当前已上线的用户
            DataReader = OptionData.ExSQLReDr("Select * From tb_CurreneyUser Where Sign = "+ MsgCommand.Logined);
            while (DataReader.Read())//向所有上线用户发送用户列表
            {

                udpSocket1.Send(IPAddress.Parse(DataReader.GetString(1)), DataReader.GetInt32(2), new ClassSerializers().SerializeBinary(msg).ToArray());
            }
            OptionData.Dispose();
        }

        private void SendUserMsg(ClassMsg msg, System.Net.IPAddress Ip, int Port)
        {
            ClassOptionData OptionData = new ClassOptionData();
            SqlDataReader DataReader = OptionData.ExSQLReDr("Select * From tb_CurreneyUser Where ID = " + msg.RID);
            DataReader.Read();
            string ip = DataReader.GetString(1);
            int port = DataReader.GetInt32(2);
            udpSocket1.Send(IPAddress.Parse(ip), port, new ClassSerializers().SerializeBinary(msg).ToArray());
            OptionData.Dispose();
            DataReader.Dispose();
        }

        /// <summary>
        /// 更新用户在线状态
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="Ip"></param>
        /// <param name="Port"></param>
        private void UpdateUserState(ClassMsg msg, System.Net.IPAddress Ip, int Port)
        {
            
            ClassOptionData OptionData = new ClassOptionData();
            OptionData.ExSQL("Update tb_CurreneyUser Set Sign = " + Convert.ToString((int)(msg.msgCommand))+ " Where ID = "+ msg.SID);
            SqlDataReader DataReader = OptionData.ExSQLReDr("Select * From tb_CurreneyUser Where Sign = " + Convert.ToString((int)(MsgCommand.Logined)));
            if (msg.msgCommand == MsgCommand.Close)
                msg.msgID = "Down";
            else if (msg.msgCommand == MsgCommand.Logined)
                msg.msgID = "Up";
            msg.msgCommand = MsgCommand.UpdateState;
            while (DataReader.Read())
            {
                udpSocket1.Send(IPAddress.Parse(DataReader.GetString(1)),
                        DataReader.GetInt32(2), new ClassSerializers().SerializeBinary(msg).ToArray());
            }
            OptionData.Dispose();
            UpdateUser();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}