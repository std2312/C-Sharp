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
            //SendMsgToAll(msg);//������Ϣ�����д��û�����ϵ��,��֮�û�����
        }

        private void SendMsgToAll(ClassMsg msg)//������Ϣ�������û�
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

        private void SendMsgToOne(System.Net.IPAddress ip, int port, ClassMsg msg)//������Ϣ��һ���û�
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
            if (((ToolStripMenuItem)sender).Text == "��ʼ����")
            {
                ((ToolStripMenuItem)sender).Text = "��������";
                udpSocket1.Active = true;
            }
            else
            {
                ((ToolStripMenuItem)sender).Text = "��ʼ����";
                udpSocket1.Active = false;
            }
        }

        private void Server(bool IsServer)//��ʼ��ֹͣ����
        {

        }

        private void sockUDP1_DataArrival(byte[] Data, System.Net.IPAddress Ip, int Port)
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

                switch (msg.sendKind)
                {
                    case SendKind.SendCommand://����
                        {
                            switch (msg.msgCommand)
                            {
                                case MsgCommand.Registering://ע���û�
                                    RegisterUser(msg, Ip, Port);
                                    break;
                                case MsgCommand.Logining://��¼�û�
                                    UserLogin(msg, Ip, Port, 1);
                                    break;
                                case MsgCommand.UserList://�û��б�
                                    SendUserList(msg, Ip, Port);
                                    break;
                                case MsgCommand.SendToOne://������Ϣ�����û�
                                    SendUserMsg(msg, Ip, Port);
                                    break;
                                case MsgCommand.Close://����
                                    UpdateUserState(msg, Ip, Port);
                                    break;
                            }
                            break;
                        }
                    case SendKind.SendMsg://��Ϣ
                        {
                            switch (msg.msgCommand)
                            {
                                case MsgCommand.SendToOne://������Ϣ�����û�
                                    SendUserMsg(msg, Ip, Port);
                                    break;
                            }
                            break;
                        }
                    case SendKind.SendFile://�ļ�
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
        /// �û���¼
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="Ip"></param>
        /// <param name="Port"></param>
        /// <param name="State"></param>
        private void UserLogin(ClassMsg msg, System.Net.IPAddress Ip, int Port, int State)
        {
            RegisterMsg registermsg = (RegisterMsg)new ClassSerializers().DeSerializeBinary(new MemoryStream(msg.Data));

            ClassOptionData OptionData = new ClassOptionData();//����������ClassOptionData
            MsgCommand msgState = msg.msgCommand;   //��ȡ������Ϣ������
            String UserName = registermsg.UserName;//��¼�û�����
            String PassWord = registermsg.PassWord;//�û�����
            String vIP = Ip.ToString();//�û�IP��ַ

            SqlDataReader DataReader = OptionData.ExSQLReDr("Select * From tb_CurreneyUser Where Name = "+ "'"+UserName+"'"+" and PassWord = "
                            +"'"+PassWord+"'");//�����ݿ���ͨ���û�����������в���

            DataReader.Read();//��ȡ���ҵ��ļ�¼
            string ID = Convert.ToString(DataReader.GetInt32(0));//��ȡ��һ����¼�е�ID�ֶ�ֵ
            if (DataReader.HasRows)//��DataReader���м�¼��Ϣʱ
            {
                //�޸ĵ�ǰ��¼�ı�ʶΪ����״̬
                OptionData.ExSQL("Update tb_CurreneyUser Set Sign = " + Convert.ToString((int)(MsgCommand.Logined)) + ",IP = " + "'" + vIP + "',Port = " + "'" + Port.ToString() + "'" + " Where ID = " + ID);
                msg.msgCommand =  MsgCommand.Logined;//����Ϊ��������
                msg.SID = ID;//�û�IDֵ
                SendMsgToOne(Ip, Port, msg);//����Ϣ���ظ������û�
                UpdateUserState(msg,Ip,Port);//�����û�����״̬
            }
            OptionData.Dispose();
            UpdateUser();//�����û��б�
            
        }

        /// <summary>
        /// �û�ע��
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
        /// �����û�
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
            String UserName = registermsg.UserName; //ע���û�������
            String PassWord = registermsg.PassWord;//ע���û�������
            String vIP = Ip.ToString();//ע���û���IP��ַ
            //�����ݱ������ע����Ϣ
            OptionData.ExSQL("insert into tb_CurreneyUser (IP,Port,Name,PassWord,Sign) values ('" + vIP + "'," +
                Port.ToString() + ",'" + UserName + "','" + PassWord + "'," + Convert.ToString((int)(MsgCommand.Registered)) + ")");
            SqlDataReader DataReader = OptionData.ExSQLReDr("Select * From tb_CurreneyUser");
            UpdateUser();//�����û��б�
            OptionData.Dispose();
            msg.msgCommand =  MsgCommand.Registered;//�û�ע���������
            SendMsgToOne(Ip,Port,msg);//��ע������ظ�ע���û�
            return msg;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateUser();//�����û��б�
            //udpSocket1.Active = true;
        }


        /// <summary>
        /// �����û��б�
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
        /// �����û���Ϣ
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
            SqlDataReader DataReader = OptionData.ExSQLReDr("Select * From tb_CurreneyUser");//��������ע����û���Ϣ

            while (DataReader.Read())//���������û�
            {
                ClassUserInfo UserItem = new ClassUserInfo();//����������ClassUserInfo��
                UserItem.UserID = Convert.ToString(DataReader.GetInt32(0));//��¼�û��ñ��
                UserItem.UserIP = DataReader.GetString(1);//��¼�û���IP��ַ
                UserItem.UserPort = Convert.ToString(DataReader.GetInt32(2));//��¼�˿ں�
                UserItem.UserName = DataReader.GetString(3);//��¼�û�����
                UserItem.State = Convert.ToString(DataReader.GetInt32(5));//��¼��ǰ״̬
                Users.add(UserItem);//�����û���Ϣ��ӵ��û��б���
            }

            msg.Data = new ClassSerializers().SerializeBinary(Users).ToArray();//���û��б�д�뵽����������
            //���ҵ�ǰ�����ߵ��û�
            DataReader = OptionData.ExSQLReDr("Select * From tb_CurreneyUser Where Sign = "+ MsgCommand.Logined);
            while (DataReader.Read())//�����������û������û��б�
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
        /// �����û�����״̬
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

        private void �˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}