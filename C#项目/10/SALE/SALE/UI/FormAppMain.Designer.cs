
namespace SALE.UI
{
    partial class FormAppMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基础设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品大类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品系列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.支付方式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.代理级别ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.省市设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.银行设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.物流公司ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作员设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作员设置ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.权限设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.代理管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.代理商档案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.代理登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.零售业务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售交易ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售发货单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.代理业务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退货基础ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收货单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收款单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.换货业务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.换货单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.调款单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发货单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.业务明细表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.汇总表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图表分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.某时间段内产品销售对比分析图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.月份间销售情况对比分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelOperator = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem,
            this.代理管理ToolStripMenuItem,
            this.销售管理ToolStripMenuItem,
            this.报表ToolStripMenuItem,
            this.图表分析ToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1092, 24);
            this.menuStripMain.TabIndex = 3;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础设置ToolStripMenuItem,
            this.操作员设置ToolStripMenuItem,
            this.权限设置ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Image = global::SALE.Properties.Resources._16系统设置;
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Y)));
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.系统管理ToolStripMenuItem.Text = "系统设置(&Y)";
            // 
            // 基础设置ToolStripMenuItem
            // 
            this.基础设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.商品大类ToolStripMenuItem,
            this.商品系列ToolStripMenuItem,
            this.支付方式ToolStripMenuItem,
            this.代理级别ToolStripMenuItem,
            this.省市设置ToolStripMenuItem,
            this.银行设置ToolStripMenuItem,
            this.物流公司ToolStripMenuItem,
            this.人员设置ToolStripMenuItem});
            this.基础设置ToolStripMenuItem.Image = global::SALE.Properties.Resources._16基础设置;
            this.基础设置ToolStripMenuItem.Name = "基础设置ToolStripMenuItem";
            this.基础设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.基础设置ToolStripMenuItem.Text = "基础设置";
            // 
            // 商品大类ToolStripMenuItem
            // 
            this.商品大类ToolStripMenuItem.Image = global::SALE.Properties.Resources._16商品大类;
            this.商品大类ToolStripMenuItem.Name = "商品大类ToolStripMenuItem";
            this.商品大类ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.商品大类ToolStripMenuItem.Tag = "111";
            this.商品大类ToolStripMenuItem.Text = "产品大类";
            this.商品大类ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 商品系列ToolStripMenuItem
            // 
            this.商品系列ToolStripMenuItem.Image = global::SALE.Properties.Resources._16商品系列;
            this.商品系列ToolStripMenuItem.Name = "商品系列ToolStripMenuItem";
            this.商品系列ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.商品系列ToolStripMenuItem.Tag = "112";
            this.商品系列ToolStripMenuItem.Text = "产品系列";
            this.商品系列ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 支付方式ToolStripMenuItem
            // 
            this.支付方式ToolStripMenuItem.Image = global::SALE.Properties.Resources._16支付方式;
            this.支付方式ToolStripMenuItem.Name = "支付方式ToolStripMenuItem";
            this.支付方式ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.支付方式ToolStripMenuItem.Tag = "113";
            this.支付方式ToolStripMenuItem.Text = "支付方式";
            this.支付方式ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 代理级别ToolStripMenuItem
            // 
            this.代理级别ToolStripMenuItem.Image = global::SALE.Properties.Resources._16代理级别;
            this.代理级别ToolStripMenuItem.Name = "代理级别ToolStripMenuItem";
            this.代理级别ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.代理级别ToolStripMenuItem.Tag = "114";
            this.代理级别ToolStripMenuItem.Text = "代理级别";
            this.代理级别ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 省市设置ToolStripMenuItem
            // 
            this.省市设置ToolStripMenuItem.Image = global::SALE.Properties.Resources._16省市设置;
            this.省市设置ToolStripMenuItem.Name = "省市设置ToolStripMenuItem";
            this.省市设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.省市设置ToolStripMenuItem.Tag = "116";
            this.省市设置ToolStripMenuItem.Text = "省市设置";
            this.省市设置ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 银行设置ToolStripMenuItem
            // 
            this.银行设置ToolStripMenuItem.Image = global::SALE.Properties.Resources._16银行设置;
            this.银行设置ToolStripMenuItem.Name = "银行设置ToolStripMenuItem";
            this.银行设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.银行设置ToolStripMenuItem.Tag = "117";
            this.银行设置ToolStripMenuItem.Text = "银行设置";
            this.银行设置ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 物流公司ToolStripMenuItem
            // 
            this.物流公司ToolStripMenuItem.Image = global::SALE.Properties.Resources._16物流公司;
            this.物流公司ToolStripMenuItem.Name = "物流公司ToolStripMenuItem";
            this.物流公司ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.物流公司ToolStripMenuItem.Tag = "118";
            this.物流公司ToolStripMenuItem.Text = "物流公司";
            this.物流公司ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 人员设置ToolStripMenuItem
            // 
            this.人员设置ToolStripMenuItem.Image = global::SALE.Properties.Resources._16人员设置;
            this.人员设置ToolStripMenuItem.Name = "人员设置ToolStripMenuItem";
            this.人员设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.人员设置ToolStripMenuItem.Tag = "119";
            this.人员设置ToolStripMenuItem.Text = "人员设置";
            this.人员设置ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 操作员设置ToolStripMenuItem
            // 
            this.操作员设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作员设置ToolStripMenuItem1,
            this.修改密码ToolStripMenuItem});
            this.操作员设置ToolStripMenuItem.Image = global::SALE.Properties.Resources._16操作员设置;
            this.操作员设置ToolStripMenuItem.Name = "操作员设置ToolStripMenuItem";
            this.操作员设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.操作员设置ToolStripMenuItem.Text = "操作员设置";
            // 
            // 操作员设置ToolStripMenuItem1
            // 
            this.操作员设置ToolStripMenuItem1.Image = global::SALE.Properties.Resources._16操作员维护;
            this.操作员设置ToolStripMenuItem1.Name = "操作员设置ToolStripMenuItem1";
            this.操作员设置ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.操作员设置ToolStripMenuItem1.Tag = "121";
            this.操作员设置ToolStripMenuItem1.Text = "操作员维护";
            this.操作员设置ToolStripMenuItem1.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Image = global::SALE.Properties.Resources._16修改密码;
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.修改密码ToolStripMenuItem.Tag = "122";
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 权限设置ToolStripMenuItem
            // 
            this.权限设置ToolStripMenuItem.Image = global::SALE.Properties.Resources._16权限设置;
            this.权限设置ToolStripMenuItem.Name = "权限设置ToolStripMenuItem";
            this.权限设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.权限设置ToolStripMenuItem.Tag = "130";
            this.权限设置ToolStripMenuItem.Text = "权限分配";
            this.权限设置ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 代理管理ToolStripMenuItem
            // 
            this.代理管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.代理商档案ToolStripMenuItem,
            this.代理登记ToolStripMenuItem});
            this.代理管理ToolStripMenuItem.Image = global::SALE.Properties.Resources._16代理管理;
            this.代理管理ToolStripMenuItem.Name = "代理管理ToolStripMenuItem";
            this.代理管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.代理管理ToolStripMenuItem.Text = "代理管理";
            // 
            // 代理商档案ToolStripMenuItem
            // 
            this.代理商档案ToolStripMenuItem.Image = global::SALE.Properties.Resources._16代理商档案;
            this.代理商档案ToolStripMenuItem.Name = "代理商档案ToolStripMenuItem";
            this.代理商档案ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.代理商档案ToolStripMenuItem.Tag = "210";
            this.代理商档案ToolStripMenuItem.Text = "代理商档案";
            this.代理商档案ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 代理登记ToolStripMenuItem
            // 
            this.代理登记ToolStripMenuItem.Image = global::SALE.Properties.Resources._16代理登记;
            this.代理登记ToolStripMenuItem.Name = "代理登记ToolStripMenuItem";
            this.代理登记ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.代理登记ToolStripMenuItem.Tag = "220";
            this.代理登记ToolStripMenuItem.Text = "代理登记";
            this.代理登记ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 销售管理ToolStripMenuItem
            // 
            this.销售管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.零售业务ToolStripMenuItem,
            this.代理业务ToolStripMenuItem,
            this.换货业务ToolStripMenuItem});
            this.销售管理ToolStripMenuItem.Image = global::SALE.Properties.Resources._16业务管理;
            this.销售管理ToolStripMenuItem.Name = "销售管理ToolStripMenuItem";
            this.销售管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.销售管理ToolStripMenuItem.Text = "业务管理";
            // 
            // 零售业务ToolStripMenuItem
            // 
            this.零售业务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.销售订单ToolStripMenuItem,
            this.销售交易ToolStripMenuItem,
            this.销售发货单ToolStripMenuItem});
            this.零售业务ToolStripMenuItem.Image = global::SALE.Properties.Resources._16销售业务;
            this.零售业务ToolStripMenuItem.Name = "零售业务ToolStripMenuItem";
            this.零售业务ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.零售业务ToolStripMenuItem.Tag = "";
            this.零售业务ToolStripMenuItem.Text = "销售业务";
            this.零售业务ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 销售订单ToolStripMenuItem
            // 
            this.销售订单ToolStripMenuItem.Image = global::SALE.Properties.Resources._16红点;
            this.销售订单ToolStripMenuItem.Name = "销售订单ToolStripMenuItem";
            this.销售订单ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.销售订单ToolStripMenuItem.Tag = "311";
            this.销售订单ToolStripMenuItem.Text = "订货单";
            this.销售订单ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 销售交易ToolStripMenuItem
            // 
            this.销售交易ToolStripMenuItem.Image = global::SALE.Properties.Resources._16蓝点;
            this.销售交易ToolStripMenuItem.Name = "销售交易ToolStripMenuItem";
            this.销售交易ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.销售交易ToolStripMenuItem.Tag = "312";
            this.销售交易ToolStripMenuItem.Text = "交易单";
            this.销售交易ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 销售发货单ToolStripMenuItem
            // 
            this.销售发货单ToolStripMenuItem.Image = global::SALE.Properties.Resources._16绿点;
            this.销售发货单ToolStripMenuItem.Name = "销售发货单ToolStripMenuItem";
            this.销售发货单ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.销售发货单ToolStripMenuItem.Tag = "313";
            this.销售发货单ToolStripMenuItem.Text = "发货单";
            this.销售发货单ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 代理业务ToolStripMenuItem
            // 
            this.代理业务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退货基础ToolStripMenuItem,
            this.收货单ToolStripMenuItem,
            this.收款单ToolStripMenuItem});
            this.代理业务ToolStripMenuItem.Image = global::SALE.Properties.Resources._16退货业务;
            this.代理业务ToolStripMenuItem.Name = "代理业务ToolStripMenuItem";
            this.代理业务ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.代理业务ToolStripMenuItem.Text = "退货业务";
            // 
            // 退货基础ToolStripMenuItem
            // 
            this.退货基础ToolStripMenuItem.Image = global::SALE.Properties.Resources._16红点;
            this.退货基础ToolStripMenuItem.Name = "退货基础ToolStripMenuItem";
            this.退货基础ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退货基础ToolStripMenuItem.Tag = "321";
            this.退货基础ToolStripMenuItem.Text = "退货单";
            this.退货基础ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 收货单ToolStripMenuItem
            // 
            this.收货单ToolStripMenuItem.Image = global::SALE.Properties.Resources._16蓝点;
            this.收货单ToolStripMenuItem.Name = "收货单ToolStripMenuItem";
            this.收货单ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.收货单ToolStripMenuItem.Tag = "322";
            this.收货单ToolStripMenuItem.Text = "收货单";
            this.收货单ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 收款单ToolStripMenuItem
            // 
            this.收款单ToolStripMenuItem.Image = global::SALE.Properties.Resources._16绿点;
            this.收款单ToolStripMenuItem.Name = "收款单ToolStripMenuItem";
            this.收款单ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.收款单ToolStripMenuItem.Tag = "323";
            this.收款单ToolStripMenuItem.Text = "退款单";
            this.收款单ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 换货业务ToolStripMenuItem
            // 
            this.换货业务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.换货单ToolStripMenuItem,
            this.调款单ToolStripMenuItem,
            this.发货单ToolStripMenuItem});
            this.换货业务ToolStripMenuItem.Image = global::SALE.Properties.Resources._16换货业务;
            this.换货业务ToolStripMenuItem.Name = "换货业务ToolStripMenuItem";
            this.换货业务ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.换货业务ToolStripMenuItem.Text = "换货业务";
            // 
            // 换货单ToolStripMenuItem
            // 
            this.换货单ToolStripMenuItem.Image = global::SALE.Properties.Resources._16红点;
            this.换货单ToolStripMenuItem.Name = "换货单ToolStripMenuItem";
            this.换货单ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.换货单ToolStripMenuItem.Tag = "331";
            this.换货单ToolStripMenuItem.Text = "换货单";
            this.换货单ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 调款单ToolStripMenuItem
            // 
            this.调款单ToolStripMenuItem.Image = global::SALE.Properties.Resources._16蓝点;
            this.调款单ToolStripMenuItem.Name = "调款单ToolStripMenuItem";
            this.调款单ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.调款单ToolStripMenuItem.Tag = "332";
            this.调款单ToolStripMenuItem.Text = "调款单";
            this.调款单ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 发货单ToolStripMenuItem
            // 
            this.发货单ToolStripMenuItem.Image = global::SALE.Properties.Resources._16绿点;
            this.发货单ToolStripMenuItem.Name = "发货单ToolStripMenuItem";
            this.发货单ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.发货单ToolStripMenuItem.Tag = "333";
            this.发货单ToolStripMenuItem.Text = "发货单";
            this.发货单ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 报表ToolStripMenuItem
            // 
            this.报表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.业务明细表ToolStripMenuItem,
            this.汇总表ToolStripMenuItem});
            this.报表ToolStripMenuItem.Image = global::SALE.Properties.Resources._16数据报表;
            this.报表ToolStripMenuItem.Name = "报表ToolStripMenuItem";
            this.报表ToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.报表ToolStripMenuItem.Text = "数据报表";
            // 
            // 业务明细表ToolStripMenuItem
            // 
            this.业务明细表ToolStripMenuItem.Image = global::SALE.Properties.Resources._16明细表;
            this.业务明细表ToolStripMenuItem.Name = "业务明细表ToolStripMenuItem";
            this.业务明细表ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.业务明细表ToolStripMenuItem.Tag = "410";
            this.业务明细表ToolStripMenuItem.Text = "明细表";
            this.业务明细表ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 汇总表ToolStripMenuItem
            // 
            this.汇总表ToolStripMenuItem.Image = global::SALE.Properties.Resources._16汇总表;
            this.汇总表ToolStripMenuItem.Name = "汇总表ToolStripMenuItem";
            this.汇总表ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.汇总表ToolStripMenuItem.Tag = "420";
            this.汇总表ToolStripMenuItem.Text = "汇总表";
            this.汇总表ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 图表分析ToolStripMenuItem
            // 
            this.图表分析ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.某时间段内产品销售对比分析图ToolStripMenuItem,
            this.月份间销售情况对比分析ToolStripMenuItem});
            this.图表分析ToolStripMenuItem.Image = global::SALE.Properties.Resources._16图表分析;
            this.图表分析ToolStripMenuItem.Name = "图表分析ToolStripMenuItem";
            this.图表分析ToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.图表分析ToolStripMenuItem.Text = "图表分析";
            // 
            // 某时间段内产品销售对比分析图ToolStripMenuItem
            // 
            this.某时间段内产品销售对比分析图ToolStripMenuItem.Image = global::SALE.Properties.Resources._16某时段分析;
            this.某时间段内产品销售对比分析图ToolStripMenuItem.Name = "某时间段内产品销售对比分析图ToolStripMenuItem";
            this.某时间段内产品销售对比分析图ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.某时间段内产品销售对比分析图ToolStripMenuItem.Tag = "510";
            this.某时间段内产品销售对比分析图ToolStripMenuItem.Text = "某时段产品销售对比分析";
            this.某时间段内产品销售对比分析图ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // 月份间销售情况对比分析ToolStripMenuItem
            // 
            this.月份间销售情况对比分析ToolStripMenuItem.Image = global::SALE.Properties.Resources._16月份间分析;
            this.月份间销售情况对比分析ToolStripMenuItem.Name = "月份间销售情况对比分析ToolStripMenuItem";
            this.月份间销售情况对比分析ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.月份间销售情况对比分析ToolStripMenuItem.Tag = "520";
            this.月份间销售情况对比分析ToolStripMenuItem.Text = "月份间销售情况对比分析";
            this.月份间销售情况对比分析ToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTime,
            this.statusLabelTime,
            this.statusLabelOperator});
            this.statusStripMain.Location = new System.Drawing.Point(0, 664);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1092, 22);
            this.statusStripMain.TabIndex = 4;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(0, 17);
            // 
            // statusLabelTime
            // 
            this.statusLabelTime.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.statusLabelTime.Name = "statusLabelTime";
            this.statusLabelTime.Size = new System.Drawing.Size(538, 17);
            this.statusLabelTime.Spring = true;
            this.statusLabelTime.Text = "动态时间显示";
            this.statusLabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLabelOperator
            // 
            this.statusLabelOperator.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.statusLabelOperator.Name = "statusLabelOperator";
            this.statusLabelOperator.Size = new System.Drawing.Size(538, 17);
            this.statusLabelOperator.Spring = true;
            this.statusLabelOperator.Text = "当前的操作员";
            this.statusLabelOperator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormAppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::SALE.Properties.Resources.大图c_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 686);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.statusStripMain);
            this.IsMdiContainer = true;
            this.Name = "FormAppMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编程词典销售分析系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelTime;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelOperator;
        private System.Windows.Forms.ToolStripMenuItem 基础设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作员设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品大类ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品系列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 支付方式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 代理级别ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 省市设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 银行设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 物流公司ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人员设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 代理管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 代理商档案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 代理登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 零售业务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 代理业务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售交易ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售发货单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退货基础ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收货单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收款单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 换货业务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 换货单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 调款单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发货单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图表分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 业务明细表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 汇总表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作员设置ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 权限设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 某时间段内产品销售对比分析图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 月份间销售情况对比分析ToolStripMenuItem;
    }
}

