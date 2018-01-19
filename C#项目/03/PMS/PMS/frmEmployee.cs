using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PMS.PMSClass;
using System.Data.SqlClient;
namespace PMS
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//创建数据库操作对象
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            string str = //创建查询字符串
                "select ID as '编号',employeeID as '员工编号',employeeName as '员工姓名',employeeSex as '员工性别',employeeDept as '所属部门',employeeBirthday as '员工生日',employeeNation as '民族',employeeMarriage as '婚姻状况',employeeDuty as '担任职务',employeePhone as '联系电话',employeeAccession as '就职日期' from tb_employee";
            operate.BindDataGridView(dgvEmployee,str);//将查询信息绑定到DataGridView控件
            dgvEmployee.Columns[0].Width = 40;//定义数据列宽度
            dgvEmployee.Columns[1].Width = 80;//定义数据列宽度
            treeView1.ImageList = imageList1;//设置控件的ImageList属性
            treeView1.ImageIndex = 0;//设置图像列表的索引
            treeView1.SelectedImageIndex =0;//设置选中节点时显示的图像列表索引
            string sql = "select count(*) from tb_employee";//定义SQL字符串
            toolStripStatusLabel2.Text=operate.HumanNum(sql).ToString()+"人";//显示员工人数
            TreeNode tn = treeView1.Nodes.Add("所有部门");//添加节点
            SqlConnection conn = DBConnection.MyConnection();//创建数据库连接对象
            conn.Open();//打开数据库连接
            SqlCommand cmd = new SqlCommand("select * from tb_department", conn);//创建命令对象
            SqlDataReader sdr = cmd.ExecuteReader();//创建数据读取器
            while (sdr.Read())//读取数据
            {
                tn.Nodes.Add(sdr["DepName"].ToString());//添加节点
            }
            sdr.Close();//关闭数据读取器
            conn.Close();//关闭数据库连接
            treeView1.ExpandAll();//展开所有节点
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string str =//创建查询字符串
                "select ID as '编号',employeeID as '员工编号',employeeName as '员工姓名',employeeSex as '员工性别',employeeDept as '所属部门',employeeBirthday as '员工生日',employeeNation as '民族',employeeMarriage as '婚姻状况',employeeDuty as '担任职务',employeePhone as '联系电话',employeeAccession as '就职日期' from tb_employee where employeeName like '%"+toolStripTextBox1.Text.Trim()+"%'";
            operate.BindDataGridView(dgvEmployee, str);//将查询信息绑定到DataGridView控件
            dgvEmployee.Columns[0].Width = 40;//定义数据列宽度
            dgvEmployee.Columns[1].Width = 80;//定义数据列宽度
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string str = e.Node.Text;//得到选中节点的字符串
            if (str == "所有部门")
            {
                string SQLStr = //创建查询字符串
                     "select ID as '编号',employeeID as '员工编号',employeeName as '员工姓名',employeeSex as '员工性别',employeeDept as '所属部门',employeeBirthday as '员工生日',employeeNation as '民族',employeeMarriage as '婚姻状况',employeeDuty as '担任职务',employeePhone as '联系电话',employeeAccession as '就职日期' from tb_employee";
                operate.BindDataGridView(dgvEmployee, SQLStr);//将查询信息绑定到DataGridView控件
            }
            else
            {
                string strsql =//创建查询字符串
                    "select ID as '编号',employeeID as '员工编号',employeeName as '员工姓名',employeeSex as '员工性别',employeeDept as '所属部门',employeeBirthday as '员工生日',employeeNation as '民族',employeeMarriage as '婚姻状况',employeeDuty as '担任职务',employeePhone as '联系电话',employeeAccession as '就职日期' from tb_employee where employeeDept='"+str+"'";
                operate.BindDataGridView(dgvEmployee, strsql);//将查询信息绑定到DataGridView控件
                dgvEmployee.Columns[0].Width = 40;//定义数据列宽度
                dgvEmployee.Columns[1].Width = 80;//定义数据列宽度
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmAddEmployee addemployee = new frmAddEmployee();//创建添加员工信息窗体对象
            addemployee.ShowDialog();//显示模式窗体
        }

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployee.SelectedCells.Count == -1)
            {
                MessageBox.Show("请选择要修改的数据", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//退出事件
            }
            else
            {
                string YGName = dgvEmployee.SelectedCells[2].Value.ToString();//获取员工名称
                frmEmployeeInfo info = new frmEmployeeInfo();//创建员工信息窗体对象
                info.YGName = YGName;//为字段赋值
                info.YGID = dgvEmployee.SelectedCells[1].Value.ToString();//为字段赋值
                info.ShowDialog();//显示模式对话框
            }
        }

        private void dgvEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedCells.Count > 0)
            {
                string YGName = dgvEmployee.SelectedCells[1].Value.ToString();//得到员工编号
                operate.Get_Image(YGName, pictureBox1);//显示图片信息
            }
        }

        private void frmEmployee_Activated(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();//清空所有节点
            frmEmployee_Load(sender, e);//执行窗体Load事件
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedCells.Count == 0)
            {
                MessageBox.Show(//弹出消息对话框
                    "请选择要修改的数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//退出事件
            }
            else
            {
                string YGName = //得到员工姓名
                    dgvEmployee.SelectedCells[2].Value.ToString();
                frmEmployeeInfo info = new frmEmployeeInfo();//创建员工信息窗体对象
                info.YGName = YGName;//为字段赋值
                info.YGID = dgvEmployee.SelectedCells[1].Value.ToString();//为字段赋值
                info.ShowDialog();//显示模式窗体
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployee.SelectedCells.Count == 0)
                {
                    MessageBox.Show("请选择要删除的数据",//弹出消息对话框
                        "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;//退出事件
                }
                else
                {
                    string YGID = dgvEmployee.SelectedCells[1].Value.ToString();//得到ID
                    string DelSql =//创建SQL字符串
                        "delete from tb_employee where employeeID='" + YGID + "'";
                    operate.OperateData(DelSql);//删除员工信息
                    operate.DeleUserInfo(YGID);//删除员工信息
                    MessageBox.Show("删除成功", "提示",//弹出消息对话框
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch//捕获异常
            {
                MessageBox.Show("删除操作失败", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}