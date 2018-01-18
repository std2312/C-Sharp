using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PMS.PMSClass;
namespace PMS
{
    public partial class frmDepManager : Form
    {
        public frmDepManager()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//创建数据库操作对象
        public TreeNode tn;//声明字段
        private void frmDepManager_Load(object sender, EventArgs e)
        {
            treeView1.ImageList = imageList1;//设置ImageList属性
            treeView1.ImageIndex = 0;//设置ImageList索引
            treeView1.SelectedImageIndex = 0;//设置选中节点后显示的ImageList索引
            tn = treeView1.Nodes.Add("所有部门");//添加节点信息
            SqlConnection conn = DBConnection.MyConnection();//创建数据库连接对象
            conn.Open();//打开数据库连接
            SqlCommand cmd = new SqlCommand("select * from tb_department", conn);//创建数据库命令对象
            SqlDataReader sdr = cmd.ExecuteReader();//得到数据读取器
            while (sdr.Read())//读取数据
            {
                tn.Nodes.Add(sdr["DepName"].ToString());//添加节点
            }
            sdr.Close();//关闭数据读取器
            conn.Close();//关闭数据库连接
            treeView1.ExpandAll();//展开所有节点
            treeView1.SelectedNode = treeView1.Nodes[0];//设置窗体加载时，treeview控件的父节点被选中
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddDep adddep = new frmAddDep();//创建部门编辑窗体对象
            adddep.ShowDialog();//显示模式窗体
        }

        private void frmDepManager_Activated(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();//清空节点
            frmDepManager_Load(sender, e);//执行窗体Load事件
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text == "所有部门")
            {
                MessageBox.Show("不能删除根目录", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//退出事件
            }
            else
            {
                if (treeView1.SelectedNode.Text == "部门未分配")
                {
                    MessageBox.Show("不能删除缺省分类", "提示",//弹出消息对话框
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;//退出事件
                }
                else
                {
                    string depname = treeView1.SelectedNode.Text;//得到选中节点文本内容
                    string str =//创建SQL字符串
                        "delete from tb_department where DepName='" + depname + "'";
                    if (operate.OperateData(str) > 0)
                    {
                        MessageBox.Show("部门删除成功", "提示",//弹出消息对话框
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    string upstr =//创建SQL字符串
                        "update tb_employee  set employeeDept='部门未分配' where employeeDept='" + depname + "'";
                    operate.OperateData(upstr);//更新数据库信息
                }
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text == "所有部门")
            {
                MessageBox.Show("不能修改根目录", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//退出事件
            }
            else
            {
                string depName = treeView1.SelectedNode.Text;//得到选中节点文本内容
                frmChangeDep changedep = new frmChangeDep();//创建修改部门名称窗体对象
                changedep.name = depName;//为字段赋值
                changedep.ShowDialog();//显示模式窗体
            }
        }
    }
}