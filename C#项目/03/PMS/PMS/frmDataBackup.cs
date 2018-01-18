using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PMS.PMSClass;
using System.Data.SqlClient;
using System.Collections;
using System.IO;
namespace PMS
{
    public partial class frmDataBackup : Form
    {
        public frmDataBackup()
        {
            InitializeComponent();
        }
        public string strg;//�����ֶ�
        private void button1_Click(object sender, EventArgs e)//�������ݿ�
        {
            try
            {
                strg = Application.StartupPath.ToString();//�õ�Ӧ�ó���·��
                strg = strg.Substring(0, strg.LastIndexOf("\\"));//��ȡ·��
                strg = strg.Substring(0, strg.LastIndexOf("\\"));//��ȡ·��
                strg += @"\Backup";//���·����Ϣ
                string sqltxt =//����SQL�ַ���
                    @"BACKUP DATABASE db_PMS TO Disk='" + strg + "\\PMS.bak" + "'";
                if (File.Exists(strg + "\\PMS.bak"))//�ж��ļ��Ƿ����
                {
                    File.Delete(strg + "\\PMS.bak");//ɾ���ļ�
                    SqlConnection conn = DBConnection.MyConnection();//�������ݿ����Ӷ���
                    conn.Open();//�������ݿ�
                    SqlCommand cmd = new SqlCommand(sqltxt, conn);//�������ݿ��������
                    cmd.ExecuteNonQuery();//ִ�в���
                    conn.Dispose();//�ͷ����ݿ�������Դ
                    if (MessageBox.Show("���ݳɹ�", "��ʾ", MessageBoxButtons.OK,//������Ϣ�Ի���
                        MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        this.Close();//�رմ���
                    }
                }
                else
                {
                    SqlConnection conn = DBConnection.MyConnection();//�������ݿ����Ӷ���
                    conn.Open();//�������ݿ�
                    SqlCommand cmd = new SqlCommand(sqltxt, conn);//�������ݿ��������
                    cmd.ExecuteNonQuery();//ִ�в���
                    conn.Dispose();//�ͷ����ݿ�������Դ
                    if (MessageBox.Show("���ݳɹ�", "��ʾ", MessageBoxButtons.OK,//������Ϣ�Ի���
                        MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        this.Close();//�رմ���
                    }
                }
            }
            catch (Exception ex)//�����쳣
            {
                MessageBox.Show(ex.Message.ToString(), "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)//��ԭ���ݿ�
        {
            try
            {
                SqlConnection conn = DBConnection.MyConnection();//�������ݿ�����
                string path = Application.StartupPath.ToString();//�õ�Ӧ�ó���·��
                path = path.Substring(0, path.LastIndexOf("\\"));//��ȡ·��
                path = path.Substring(0, path.LastIndexOf("\\"));//��ȡ·��
                path += "\\Backup\\PMS.bak";//���·����Ϣ
                string str =//����SQL�ַ���
                    "use master restore database db_PMS from Disk='" + path + "'";
                conn.Open();//�����ݿ�����
                SqlCommand cmd = new SqlCommand(str, conn);//�������ݿ��������
                cmd.ExecuteNonQuery();//ִ�в���
                conn.Close();//�ر�����
                if (MessageBox.Show("��ԭ�ɹ�", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    this.Close();//�ر����ݿ�����
                }
            }
            catch//�����쳣
            {
                button2_Click(sender, e);//ִ�а�ťClick�¼�
            }
        }
    }
}