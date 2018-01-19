using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Daila.NewClass;//引入命名空间
using System.Data.OleDb;

using System.IO;
using Daila.NewMehod;
namespace Daila
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public enum CHANNEL_STATE : short
        {
            CH_FREE,//0"空闲"
            CH_RECEIVEID,//有来电呼入
            CH_WAITSECONDRING,//2" 等待第二次振铃"
            CH_WELCOME,//3"这里是东进电话银行演示系统
             CH_WELCOME0,
             CH_WELCOME1,
            CH_SELECT,//8"选择功能"
            CH_SELECT1,//9
            CH_PLAYRESULT,//10"播放查询结果";
            CH_RECORDFILE,//11
            CH_PLAYRECORD,//12
            CH_OFFHOOK,//13
            CH_WAITUSERONHOOK,//14"等待内线挂机"
            CH_ConBusy,//人工忙
            CH_ACCOUNT1,//请稍候
            CH_ACCOUNT2,//正在连接
            CH_ACCOUNT3,
            CH_ACCOUNT4,//已接通
            CH_ACCOUNT,//已接通
            CH_ConBusy0,//对方正忙
            CH_Connect,//正在转接"
            CH_Over,//请挂机
            CH_IsOver,//对方已挂机
            CH_PASSWORD0,//请拨号
            CH_PASSWORD,//请拨号
            CH_PASSWORD1,//已接通
            CH_RECEIVEID2,//有来电呼
            CH_DIAL,//拔号
            CH_CHECKSIG,
            CH_PLAY,
            CH_ONHOOK,
            CH_BUSY,
            CH_NOBODY,
            CH_NOSIGNAL,
            CH_NODIALTONE,
            CH_NORESULT
        }
        public enum CHANNEL_TYPE : short
        {
            User,//0 内线
            Trunk,//1外线
            Empty//2悬空
        }

        public enum SigType : int//信号音类型，可以有如下值：
        {
            SIG_STOP,//0       停止播放信号音
            SIG_DIALTONE,//1  拨号音
            SIG_BUSY1,//2      忙音一
            SIG_BUSY2,//3      忙音二
            SIG_RINGBACK//  回铃音

        }
        public enum HangUp : int
        {


            HANG_UP_FLAG_FALSE,//0 没有挂机
            HANG_UP_FLAG_TRUE,//1已经挂机（从进入HANG_UP_FLAG_START                                                                   状态开始，挂机时间大于0.5秒。）
            HANG_UP_FLAG_START,//2 	  ● 开始挂机
            HANG_UP_FLAG_PRESS_R //3 拍了一下叉簧


        }

        public struct LINESTRUCT                                 //定义linestruct
        {
            public CHANNEL_TYPE nType;
            public CHANNEL_STATE State;
            //	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]				
            public string CallerID;
            //	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string Dtmf;
            public int nTimeElapse;
            public string UserCity;
            public int intTimeCount;


        }
        public LINESTRUCT[] Lines;
        public LINESTRUCT[] DaiLines;   //定义lines为linestruct[];
        public long LoadDriveFlag;
        public short TotalLine;
        public short[] sWitCh = new short[128];
        public short[] SigCheck = new short[128];
        public bool[] bUser = new bool[128];
        public short[] Dtmf = new short[128];
        public static int intLY=0;//控件电话信息
        #region//窗体加载事件
        private void frmMain_Load(object sender, EventArgs e)
        {
            //实始化LIStVIEW控件
            lvQs.Clear();
            lvQs.LargeImageList = imageList1;
            lvQs.Items.Add("添加客户信息", 0);
            lvQs.Items.Add("删除客户信息", 1);
            lvQs.Items.Add("修改客户信息", 0);
            lvQs.Items.Add("查询客户信息", 1);
            //实始化语音卡
            LoadDriveFlag = D160A.LoadDRV();      //public static extern long LoadDRV();
            if (LoadDriveFlag == -1)       //以前为1，改成-1；
            {
                MessageBox.Show("Load drive failure");
                return;
            }

            TotalLine = D160A.CheckValidCh();        //  检测在当前机器内可用的通道总数。           //public static extern short CheckValidCh();
            if (D160A.EnableCard(TotalLine, 8 * 512) == 1)//public static extern long EnableCard(short wusedCh, short wFileBufLen);
            {
                MessageBox.Show("Enable card error");
                return;
            }

            Lines = new LINESTRUCT[TotalLine];     //public LINESTRUCT[] Lines;
            //  DaiLines = new LINESTRUCT[TotalLine]; 
            for (short i = 0; i < TotalLine; i++)
            {
                Lines[i].nType = (CHANNEL_TYPE)D160A.CheckChType(i);
                Lines[i].State = (CHANNEL_STATE)(0);//(i);//0

                Lines[i].CallerID = "";//
                Lines[i].Dtmf = "";
                SigCheck[i] = (short)1;
                sWitCh[i] = (short)-1;
                bUser[i] = true;
                Dtmf[i] = (short)-1;
                ChnlState_LV.Items.Add(i.ToString());
                if (Lines[i].nType == CHANNEL_TYPE.User)
                { ChnlState_LV.Items[i].SubItems.Add("内线"); }
                if (Lines[i].nType == CHANNEL_TYPE.Trunk)
                { ChnlState_LV.Items[i].SubItems.Add("外线"); };
                if (Lines[i].nType == CHANNEL_TYPE.Empty)
                { ChnlState_LV.Items[i].SubItems.Add("空悬"); };
                if (Lines[i].State == CHANNEL_STATE.CH_FREE)
                { ChnlState_LV.Items[i].SubItems.Add("空闲"); }
                ChnlState_LV.Items[i].SubItems.Add("");
                ChnlState_LV.Items[i].SubItems.Add("");
                ChnlState_LV.Items[i].SubItems.Add("");
            }

            D160A.SetBusyPara((short)350);
            D160A.Sig_Init(0);
            timer1.Enabled = true;			
       
        }//end if 
        #endregion
        #region //获取控件数量
        public int DataGridViewCount(OleDbDataReader dr)
        {
            int intFalg = 0;
            try
            {
                OleDbDataReader oledDr = dr;
                while (oledDr.Read())
                {   

                    intFalg++;
                }
                return intFalg;
            }
            catch (Exception ee)
            {
                return intFalg;
            }

        }
                #endregion
        #region//填冲控件
        public int DataGridFalg(OleDbDataReader dr, int intCount)
        {
            int intFalg = 0;
            try
            {
                OleDbDataReader oledDr = dr;
                intFalg = 0;
                dataGridView1.RowCount = intCount;
                while (oledDr.Read())
                {
                    this.dataGridView1[0, intFalg].Value = oledDr[0].ToString();
                    this.dataGridView1[1, intFalg].Value = oledDr[1].ToString();
                    this.dataGridView1[2, intFalg].Value = oledDr[2].ToString();
                    this.dataGridView1[3, intFalg].Value = oledDr[7].ToString();
                    this.dataGridView1[4, intFalg].Value = oledDr[10].ToString();
                    intFalg++;
                }
                return intFalg;
            }
            catch (Exception ee)
            {
                return intFalg;
            }
        }
        #endregion
        #region//此方法处理通话记录
        public void tbTelRecordAdd(string stringId,int intChannel)
        {
            tbTelRecordClass tbClass = new tbTelRecordClass();
            tbTelRecordMenthod tbMenhod = new tbTelRecordMenthod();
            tbCustomerMethod tbCustom = new tbCustomerMethod();
            tbCustomerClass tbCuClass = new tbCustomerClass();
            tbClass.strfldTel = stringId;
            tbClass.daSearchDate = DateTime.Now;
            tbClass.shfldChannel = intChannel;
            if (intLY == 1)
            {
                tbCuClass.kuTel = stringId;
                tbCuClass.kuOffice = stringId;
                int intFalgTel = DataGridFalg(tbCustom.tbCustomerSecarf(tbCuClass, "khTel"), DataGridViewCount(tbCustom.tbCustomerSecarf(tbCuClass, "khTel")));
                tbClass.strsType = "打入";
            }
            if (intLY == 0)
            {
                tbClass.strsType = "打出";
            }
            tbMenhod.tbTelRecordAdd(tbClass);
            intLY = 0;

        }
        #endregion
        #region 启动timer1控件调用DaiWorkIng方法维持语音卡工作
        private void timer1_Tick(object sender, EventArgs e)
        {
            DaiWorkIng();
        }
        #endregion
        #region 此方法处理语音卡工作的方法实现，自动台，和转人工台
        private void DaiWorkIng()
        {                                   //239行对应475行
            D160A.PUSH_PLAY();//入口参数：无函数返回：无;功能描述：维持文件录放音的持续进行，需在处理函数的大循环中调用。
            D160A.FeedSigFunc();//维持断续振铃及信号音的函数；请在程序大循环中调用。
            byte[] FileName;//原代码
            short TmpDTMF,Code;
            for (short i = 0; i < TotalLine; i++)      //TotalLine = D160A.CheckValidCh();   
            {
                ListViewState(i);
                switch (Lines[i].State)
                {

                    case CHANNEL_STATE.CH_FREE:  //DJ160Int.CH_FREE://0"空闲"   //252对应267行  ch_free;
                        if (D160A.RingDetect(i) == true)
                        {
                            if (Lines[i].nType == CHANNEL_TYPE.User)//内线
                            {
                                // 某一通道开始挂机检测；当某通道摘机后，可以调用本函数。该函数只对内线通道有效。
                                D160A.StartHangUpDetect(i);
                                Lines[i].State = CHANNEL_STATE.CH_OFFHOOK;
                                Lines[i].nTimeElapse = 0;
                                Lines[i].intTimeCount = 0;
                                sWitCh[i] = i;
                            }
                            if (Lines[i].nType == CHANNEL_TYPE.Trunk)//外线
                            {//给通道状态赋值
                                Lines[i].State = CHANNEL_STATE.CH_RECEIVEID;
                                D160A.ResetCallerIDBuffer(i);   //清空主叫Buf，为外线收主叫作准备
                                Lines[i].nTimeElapse = 0;
                                sWitCh[i] = i;
                            }
                        }
                        break;                          //267对应252行
                    case CHANNEL_STATE.CH_RECEIVEID: //"接收主叫号码//268对应283行ch_receiveID;
                        byte[] TmpCID = new byte[32];
                        int iResult = 0;
                        iResult = D160A.GetCallerIDStr(i, TmpCID); //接收主叫号码
                        if (iResult == 3 || iResult == 4)//收完主叫，外线摘机使能
                        {
                            for (int j = 0; j < TmpCID.Length; j++)//存储电话号
                            {
                              
                                Lines[i].CallerID = Lines[i].CallerID + ((char)TmpCID[j]).ToString();
                                intLY = 1;
                            
                            }
                            //外线提机
                            string strin = Encoding.UTF8.GetString(TmpCID).Substring(8,11);
                            D160A.OffHook(i);
                            D160A.StartSigCheck(i);
                            Lines[i].State = CHANNEL_STATE.CH_OFFHOOK;
                            tbTelRecordAdd(strin, (int)i);
                        }
                        break;   //283对应268
                    case CHANNEL_STATE.CH_OFFHOOK:         //ch_offhook;
                        D160A.InitDtmfBuf(i);
                        StartPlayFileEx(i, "Bank.001");//放音
                        Lines[i].State = CHANNEL_STATE.CH_WELCOME;//欢迎
                        break;
                    case CHANNEL_STATE.CH_WELCOME:						//ch_welcome;
                        TmpDTMF = D160A.GetDtmfCode(i);//接受按键,返回值-1 缓冲区中没有DTMF按键
                        if (TmpDTMF != -1)
                        {
                            D160A.StopPlayFile(i);//停止放音
                            Lines[i].Dtmf = Lines[i].Dtmf + CvtDTMF(TmpDTMF);//TmpDTMF.ToString();//DTMF号码转换ASCII
                            Lines[i].State = CHANNEL_STATE.CH_SELECT;//请随意输入8位银行帐号	
                        }
                        else//后加代码
                        {
                            if (D160A.CheckPlayEnd(i))//检查指定通道放音是否结束0未结束1结束
                            {
                                D160A.StopPlayFile(i);//停止放音
                                StartPlayFileEx(i, "Bank.004");
                                Lines[i].State = CHANNEL_STATE.CH_SELECT;
                            }
                        }
                        break;
                    case CHANNEL_STATE.CH_SELECT:       //ch_select;

                        TmpDTMF = D160A.GetDtmfCode(i);
                        if (TmpDTMF != -1)
                        {
                            Lines[i].Dtmf = TmpDTMF.ToString();
                            switch (Lines[i].Dtmf)
                            {
                                case "1":
                                    D160A.StopPlayFile(i);
                                    D160A.RsetIndexPlayFile(i);

                                    FileName = GetFilePath("bank.005");
                                    D160A.AddIndexPlayFile(i, FileName);

                                    FileName = GetFilePath("d5");
                                    D160A.AddIndexPlayFile(i, FileName);

                                    D160A.StartIndexPlayFile(i);
                                    Lines[i].State = CHANNEL_STATE.CH_PLAYRESULT;
                                    break;

                                case "2":
                                    D160A.StopPlayFile(i);
                                    D160A.RsetIndexPlayFile(i);

                                    FileName = GetFilePath("bank.006");
                                    D160A.AddIndexPlayFile(i, FileName);


                                    FileName = GetFilePath("bank.008");
                                    D160A.AddIndexPlayFile(i, FileName);

                                    D160A.StartIndexPlayFile(i);
                                    Lines[i].State = CHANNEL_STATE.CH_PLAYRESULT;
                                    break;

                                case "3":
                                    D160A.StopPlayFile(i);
                                    D160A.RsetIndexPlayFile(i);

                                    FileName = GetFilePath("bank.007");
                                    D160A.AddIndexPlayFile(i, FileName);

                                    FileName = GetFilePath("d3");
                                    D160A.AddIndexPlayFile(i, FileName);

                                    D160A.StartIndexPlayFile(i);
                                    Lines[i].State = CHANNEL_STATE.CH_PLAYRESULT;
                                    break;
                                case "4"://转人工
                                    Lines[i].State = CHANNEL_STATE.CH_WELCOME1;
                                    break;
                            }
                        }
                        else if (Lines[i].intTimeCount == 3)//判断重复播音次数
                        { Lines[i].State = CHANNEL_STATE.CH_PLAYRESULT; }
                        else if (Lines[i].nTimeElapse != 1000)
                        { Lines[i].nTimeElapse += 20; }
                        else if (Lines[i].nTimeElapse == 1000)
                        {
                            Lines[i].State = CHANNEL_STATE.CH_WELCOME;
                            Lines[i].nTimeElapse = 0;
                            Lines[i].intTimeCount++;
                        }
                        break;
                    case CHANNEL_STATE.CH_PLAYRESULT:        //ch_playresult;

                        if (D160A.CheckIndexPlayFile(i))
                        {
                            D160A.StopIndexPlayFile(i);
                            if (Lines[i].nType == CHANNEL_TYPE.Trunk)
                            { ResetChnl(i); }
                            else if (Lines[i].nType == CHANNEL_TYPE.User)
                            {//控制信号音的播放。本函数实质上使用内存循环放音来实现的。其中：
                                //拨号音的时间长度为响0.75秒，停止3秒；
                                //忙音一的时间长度为响0.35秒，停止0.35秒；
                                //忙音二的时间长度为响0.7秒，停止0.7秒；
                                D160A.StartPlaySignal(i, (int)(SigType.SIG_BUSY1));
                                Lines[i].State = CHANNEL_STATE.CH_WAITUSERONHOOK;
                            }
                        }
                        break;
                    case CHANNEL_STATE.CH_WAITUSERONHOOK:    //H_WAITUSERONHOOK
                        if (!D160A.RingDetect(i))
                        {
                            D160A.StartPlaySignal(i, (int)(SigType.SIG_STOP));
                            ResetChnl(i);
                        }
                        break;
                    //转人工模块
                    case CHANNEL_STATE.CH_WELCOME1:
                        D160A.InitDtmfBuf(sWitCh[i]);//清空摘机的线路通道
                        StartPlayFileEx(sWitCh[i], "Bank.001");//播放音乐等待接通
                        Lines[i].State = CHANNEL_STATE.CH_WELCOME0;
                        break;
                    case CHANNEL_STATE.CH_WELCOME0:
                        if (D160A.CheckPlayEnd(sWitCh[i]))//检查摘机的线路通道播放音乐是否完成
                        {
                            D160A.StopPlayFile(sWitCh[i]);//停止摘机的线路通道播音
                            Lines[i].State = CHANNEL_STATE.CH_PASSWORD;//选择通道号
                        }
                        break;
                    case CHANNEL_STATE.CH_PASSWORD://选择通道号
                        Code = D160A.GetDtmfCode(sWitCh[i]);//在摘机的线路通道中输入要连接的内绩通道
                        if (Code != -1)
                        {
                            Dtmf[i] = Code;//将选择联接的通道号赋值给数组
                            if (Dtmf[i] > 0 && Dtmf[i] < 8 || Dtmf[i] == 10)
                            {

                                D160A.StartPlaySignal(sWitCh[i], (int)SigType.SIG_STOP);//控制主叫通道的语音
                                Lines[i].State = CHANNEL_STATE.CH_SELECT1;//判断选择通道的状态

                            }
                        }
                        break;
                    case CHANNEL_STATE.CH_SELECT1://判断选择通道的状态
                        if (Lines[Dtmf[i]].State == CHANNEL_STATE.CH_FREE)//判断被叫通道是否空闲
                        {
                            D160A.FeedRealRing(Dtmf[i]);//对被叫通道馈断续的铃流．选择的人工作席
                            D160A.StartPlaySignal(sWitCh[i], (int)SigType.SIG_RINGBACK);//控制信号音的播放，SIG_RINGBACK  回铃音
                            Lines[Dtmf[i]].State = CHANNEL_STATE.CH_RECEIVEID;//显示被叫通道的状态
                            Lines[i].State = CHANNEL_STATE.CH_ACCOUNT1;
                        }
                        else//
                        {
                            D160A.StartPlaySignal(sWitCh[i], (int)SigType.SIG_BUSY2);//控制主叫通道信号音的播放
                            Lines[Dtmf[i]].State = CHANNEL_STATE.CH_ConBusy0;//显示被叫通道的状态
                            Lines[i].State = CHANNEL_STATE.CH_ConBusy;
                        }
                        break;
                    case CHANNEL_STATE.CH_ConBusy://此功能显示通道忙
                        if (Lines[sWitCh[i]].nType == CHANNEL_TYPE.Trunk)
                        { }
                        else if (Lines[sWitCh[i]].nType == CHANNEL_TYPE.User)
                        {
                            bUser[Dtmf[i]] = false;
                            Lines[i].State = CHANNEL_STATE.CH_ACCOUNT1;//下步操作
                        }
                        break;
                    case CHANNEL_STATE.CH_ACCOUNT1:
                        //检测被叫通道是否摘机
                        if (D160A.OffHookDetect(Dtmf[i]) == 1 && bUser[Dtmf[i]] == true)//检测录音模块的摘挂机状态，只对录音模块有效。
                        {

                            D160A.StartPlaySignal(sWitCh[i], (int)SigType.SIG_STOP);//控制信号音的播放,停止
                            D160A.StopPlay(sWitCh[i]);//控制文件的播放/////////////////////
                            Lines[sWitCh[i]].State = CHANNEL_STATE.CH_Over;//请挂机
                            Lines[i].State = CHANNEL_STATE.CH_ACCOUNT2;//已挂机
                            break;
                        }//检测二次拍叉簧动作
                        else if (D160A.HangUpDetect(Dtmf[i]) == (int)HangUp.HANG_UP_FLAG_PRESS_R && sWitCh[i] != i)
                        {//检测某一通道的挂机状态,拍了一下叉簧
                            D160A.FeedPower(Dtmf[i]);//对被叫线通道馈电，同时停止馈铃流,同时停止溃电
                            ResetChnl(Dtmf[i]);//调用方法
                            D160A.StartPlaySignal(i, (int)SigType.SIG_STOP);//调用方法
                            D160A.StopPlay(sWitCh[i]);
                            Dtmf[i] = sWitCh[i];//将主叫号码赋值给被叫号码
                            Lines[Dtmf[i]].State = CHANNEL_STATE.CH_Connect;//正在转接
                            Lines[sWitCh[i]].State = CHANNEL_STATE.CH_PASSWORD1;//正在转接
                            Lines[i].State = CHANNEL_STATE.CH_ACCOUNT;
                            bUser[Dtmf[i]] = true;
                            break;
                        }  //在对方正在振铃时挂机处理 
                        else if (Lines[i].nType == CHANNEL_TYPE.User)//内线
                        {
                            if (D160A.HangUpDetect(sWitCh[i]) == (int)HangUp.HANG_UP_FLAG_TRUE)//已经挂机
                            {
                                ResetPower(i); //调用自定义方法
                                ResetChnl(Dtmf[i]); //调用自定义方法
                                bUser[i] = true;
                                break;
                            }
                        }//在对方正在振铃时挂机处理
                        break;
                    case CHANNEL_STATE.CH_ACCOUNT2://已挂
                        D160A.FeedPower(Dtmf[i]);//对某一路内线通道馈电，同时停止馈铃流
                        Lines[i].State = CHANNEL_STATE.CH_ACCOUNT;//停止文件
                        Lines[Dtmf[i]].State = CHANNEL_STATE.CH_PASSWORD1;//已接通  
                        break;
                    case CHANNEL_STATE.CH_ACCOUNT://停止播放文件
                        D160A.StopPlay(i);//停止放音
                        sWitCh[i] = (short)-1;

                        if (D160A.SetLink(i, Dtmf[i]) == 1) //两路连通。
                        {
                            Lines[i].State = CHANNEL_STATE.CH_ACCOUNT3;
                        }
                        break;

                    case CHANNEL_STATE.CH_ACCOUNT3:
                        D160A.StartHangUpDetect(Dtmf[i]);//某一通道开始挂机检测；当某通道摘机后，可以调用本函数。该函数只对内线通道有效。
                        Lines[i].State = CHANNEL_STATE.CH_ACCOUNT4;
                        break;
                    case CHANNEL_STATE.CH_ACCOUNT4:
                        // '检测转机用户拍叉簧
                        if (D160A.HangUpDetect(Dtmf[i]) == (int)HangUp.HANG_UP_FLAG_PRESS_R)//检测某一通道的挂机状态,拍了一下叉簧
                        {
                            sWitCh[i] = Dtmf[i];
                            Lines[Dtmf[i]].State = CHANNEL_STATE.CH_Connect;//正在转接
                            D160A.ClearLink(i, Dtmf[i]);//两路拆除连通。
                            D160A.StopPlay(Dtmf[i]);
                            Dtmf[i] = -1;
                            Lines[i].State = CHANNEL_STATE.CH_WELCOME;
                            StartPlayFileEx(sWitCh[i], "Dial.001");//播放音乐等待接
                        }
                        //  '检测被叫用户挂机
                        if (D160A.HangUpDetect(Dtmf[i]) == (int)HangUp.HANG_UP_FLAG_TRUE)
                        {
                            SigCheck[Dtmf[i]] = (short)D160A.ClearLink(i, Dtmf[i]);//两路拆除连通。
                            if (SigCheck[Dtmf[i]] == 0)
                            {
                                D160A.StartPlaySignal(i, (int)SigType.SIG_BUSY1);//调用方法
                            }
                            ResetPower(i);//自定义方法调用
                            ResetChnl(Dtmf[i]);//自定义方法2
                            Lines[i].State = CHANNEL_STATE.CH_IsOver;

                        }
                        //'检测为内线的主叫用户挂机
                        if (Lines[i].nType == CHANNEL_TYPE.User)
                        {
                            if (D160A.HangUpDetect(i) == (int)HangUp.HANG_UP_FLAG_TRUE)
                            {
                                SigCheck[Dtmf[i]] = (short)D160A.ClearLink(i, Dtmf[i]);//两路拆除连通。
                                if (D160A.ClearLink(i, Dtmf[i]) == 0)
                                {
                                    D160A.StartPlaySignal(i, (int)SigType.SIG_BUSY1);//调用方法
                                }
                                ResetChnl(i);//调用函数
                            }
                        }
                        break;

                }  //473对应251行

                //判断外线if (Lines[i].nType == CHANNEL_TYPE.Trunk && Lines[i].State != CHANNEL_STATE.CH_FREE)
                if (Lines[i].nType == CHANNEL_TYPE.Trunk && Lines[i].State != CHANNEL_STATE.CH_FREE && Lines[i].State != CHANNEL_STATE.CH_RECEIVEID)
                {
                    if (D160A.Sig_CheckBusy(i) == 1)//进行挂机忙音检测,1 检测到忙音
                    {
                        SigCheck[i] = (short)D160A.ClearLink(i, Dtmf[i]); // 两路拆除连通。
                        if (SigCheck[i] == 0)
                        {
                            D160A.StartPlaySignal(i, (int)SigType.SIG_BUSY1);//调用方法
                            Lines[Dtmf[i]].State = CHANNEL_STATE.CH_Over;
                        }
                        ResetChnl(i);//调用方法ResetChnl(i)
                    }

                }//判断内线条件
                else if (Lines[i].nType == CHANNEL_TYPE.User && Lines[i].State != CHANNEL_STATE.CH_FREE && Lines[i].State != CHANNEL_STATE.CH_RECEIVEID)
                {      
                    if (D160A.RingDetect(i))
                    {
                        if (SigCheck[i] == 0)
                        {
                            Lines[i].State = CHANNEL_STATE.CH_Over;
                        }
                    }
                    else if (D160A.HangUpDetect(i) == (int)HangUp.HANG_UP_FLAG_TRUE)
                    {
                        ResetChnl(i); 
                    }
                }

            }
        }
        #endregion
        #region 此方法播放音频文件
        private void StartPlayFileEx(short wChnlNo, string FileName)
        {
            byte[] FName = GetFilePath(FileName);//原代码
            D160A.StartPlayFile(wChnlNo, FName, 0);	//public static extern bool StartPlayFile(short wChnlNo, byte[] FileName, int StartPos);		
        }
        #endregion
        #region 此方法处理音频文件的路径
        private byte[] GetFilePath(string FileName)
        {
            //获取文件路径//说明，声音文件的路径中不能含有中文
            string strPath = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            strPath = strPath.Substring(0, strPath.LastIndexOf("\\"));
            strPath += @"\Voice\" + FileName;
            char[] TmpFName = new char[128];
            byte[] FName = new byte[128];
            for (int i = 0; i < strPath.Length; i++)
            {
                TmpFName[i] = Convert.ToChar(strPath.Substring(i, 1));
            }
            for (int i = 0; i < TmpFName.Length; i++)
            {
                FName[i] = (byte)TmpFName[i];
            }
            return FName;
        }
        #endregion
        #region 此方法动态处理界面的显示
        private void ListViewState(short wChnlNo)
        {                                  //519对应552行
            string strTmp = "";                             //初始化strTmp;
            switch (Lines[wChnlNo].State)
            {
                case CHANNEL_STATE.CH_FREE: //空闲                 //若ch_free;
                    strTmp = "空闲";
                    break;
                case CHANNEL_STATE.CH_WELCOME:              //若ch_welcome;
                    strTmp = "企业电话客服演示系统";
                    break;
                case CHANNEL_STATE.CH_SELECT:                 //若ch_select;
                    strTmp = "按1公司介绍，按2产品介绍，按3优惠政策，按4人工服务";
                    break;
                case CHANNEL_STATE.CH_WAITUSERONHOOK:// "等待内线挂机";
                    strTmp = "等待内线挂机";
                    break;
                case CHANNEL_STATE.CH_ConBusy:
                    strTmp = "对方正忙";
                    break;
 
                case CHANNEL_STATE.CH_ConBusy0:
                    strTmp = "对方正忙";
                    break;
                case CHANNEL_STATE.CH_Connect:
                    strTmp = "正在转接";
                    break;
                case CHANNEL_STATE.CH_Over:
                    strTmp = "请挂机";
                    break;
                case CHANNEL_STATE.CH_IsOver:
                    strTmp = "对方已挂机";
                    break;
                case CHANNEL_STATE.CH_PASSWORD0:
                case CHANNEL_STATE.CH_PASSWORD:
                    strTmp = "请拨号";
                    break;
                case CHANNEL_STATE.CH_PASSWORD1:
                case CHANNEL_STATE.CH_ACCOUNT4:
                case CHANNEL_STATE.CH_ACCOUNT:
                    strTmp = "已接通";
                    break;
                case CHANNEL_STATE.CH_RECEIVEID:
                    strTmp = "有来电呼入。。。";
                    break;
                case CHANNEL_STATE.CH_ACCOUNT1:
                    strTmp = "请稍候。。。。";
                    break;
                case CHANNEL_STATE.CH_ACCOUNT2:
                    strTmp = "正在连接。。。";
                    break;
            }
            if (ChnlState_LV.Items[wChnlNo].SubItems[2].Text != Lines[wChnlNo].State.ToString())
                ChnlState_LV.Items[wChnlNo].SubItems[2].Text = Lines[wChnlNo].State.ToString();

            if (ChnlState_LV.Items[wChnlNo].SubItems[3].Text != Lines[wChnlNo].CallerID)
                ChnlState_LV.Items[wChnlNo].SubItems[3].Text = Lines[wChnlNo].CallerID;

            if (ChnlState_LV.Items[wChnlNo].SubItems[4].Text != Lines[wChnlNo].Dtmf)
                ChnlState_LV.Items[wChnlNo].SubItems[4].Text = Lines[wChnlNo].Dtmf;


            if (ChnlState_LV.Items[wChnlNo].SubItems[5].Text != strTmp)
                ChnlState_LV.Items[wChnlNo].SubItems[5].Text = strTmp;

        }
        #endregion
        #region 此方法控件状状标记，停止放音
        private void ResetChnl(short wChnlNo)
        {


            D160A.StopPlay(wChnlNo);
            D160A.StartPlaySignal(wChnlNo, (int)SigType.SIG_STOP);
          //  if (Lines[ChannelID].State == CHANNEL_STATE.CH_WELCOME || Lines[ChannelID].State == CHANNEL_STATE.CH_PASSWORD || Lines[ChannelID].State == CHANNEL_STATE.CH_SELECT)
            if ((Lines[wChnlNo].State == CHANNEL_STATE.CH_WELCOME) || (Lines[wChnlNo].State == CHANNEL_STATE.CH_ACCOUNT) || (Lines[wChnlNo].State == CHANNEL_STATE.CH_PASSWORD) || (Lines[wChnlNo].State == CHANNEL_STATE.CH_SELECT1) || (Lines[wChnlNo].State == CHANNEL_STATE.CH_OFFHOOK))
            {
                D160A.StopPlayFile(wChnlNo);//停止播放文件
            }
            else if (Lines[wChnlNo].State == CHANNEL_STATE.CH_PLAYRESULT)
            { D160A.StopIndexPlayFile(wChnlNo); }
            else if (Lines[wChnlNo].State == CHANNEL_STATE.CH_ACCOUNT1)//操作被叫通道流
            {
                D160A.FeedPower(wChnlNo);
            }else if (Lines[wChnlNo].State == CHANNEL_STATE.CH_ACCOUNT3)//操作
            { D160A.ClearLink(wChnlNo,Dtmf[wChnlNo]); }//拆分通道通路

            //外线
            if (Lines[wChnlNo].nType == CHANNEL_TYPE.Trunk)
            {
                //检测信号
                D160A.StartSigCheck(wChnlNo);
                //外线挂机
                D160A.HangUp(wChnlNo);
                D160A.Sig_ResetCheck(wChnlNo);

            }
            if (Lines[wChnlNo].nType == CHANNEL_TYPE.User)
            {
                D160A.FeedPower(wChnlNo);
            }
            bUser[wChnlNo] = true;
            SigCheck[wChnlNo] = (short)1;
            sWitCh[wChnlNo] = (short)-1;
            Dtmf[wChnlNo] = (short)-1;
            Lines[wChnlNo].Dtmf = "";
            Lines[wChnlNo].CallerID = "";
            Lines[wChnlNo].nTimeElapse = 0;
            //Lines[wChnlNo].State = CHANNEL_STATE.CH_FREE(0);//空闲
            Lines[wChnlNo].State = (CHANNEL_STATE)(0);
      
        }
        #endregion 
        #region 此方法处理接收电话按键DTMF
        private string CvtDTMF(short DTMFCode)
        {
            char c;
            switch (DTMFCode)
            {
                case 10:
                    c = '0';
                    break;
                case 11:
                    c = '*';
                    break;
                case 12:
                    c = '#';
                    break;
                case 15:
                    c = (char)(DTMFCode - 13 + (short)'a');
                    break;
                case 0:
                    c = 'd';
                    break;
                default:
                    c = (char)(DTMFCode + (short)'0');//change DTMF from number to ASCII
                    break;
            }
            return c.ToString();

        }
        #endregion
        #region LIistView控件上Button按钮的单击事件
        private void bntKu_Click(object sender, EventArgs e)
        {
            lvQs.Dock = DockStyle.None;
            bntKu.Dock = DockStyle.Top;
            bntEm.Dock = DockStyle.Bottom;
            bntQt.SendToBack();
            bntQt.Dock = DockStyle.Bottom;
            lvQs.BringToFront();
            lvQs.Dock = DockStyle.Bottom;
            lvQs.Clear();

            lvQs.Items.Add("添加客户信息", 0);
            lvQs.Items.Add("删除客户信息", 1);
            lvQs.Items.Add("修改客户信息", 2);
            lvQs.Items.Add("查询客户信息", 3);


        }

        private void bntEm_Click(object sender, EventArgs e)
        {
            lvQs.Dock = DockStyle.None;
            bntEm.Dock = DockStyle.Top;
            bntKu.Dock = DockStyle.Top;
            bntQt.Dock = DockStyle.Bottom;
            lvQs.Dock = DockStyle.Bottom;
            lvQs.Clear();

            lvQs.Items.Add("添加员工信息", 0);
            lvQs.Items.Add("删除员工信息", 1);
            lvQs.Items.Add("修改员工信息", 2);
            lvQs.Items.Add("查询员工信息", 3);

        }

        private void bntQt_Click(object sender, EventArgs e)
        {
            lvQs.Dock = DockStyle.None;
            bntQt.SendToBack();
            bntQt.Dock = DockStyle.Top;
            bntEm.SendToBack();
            bntEm.Dock = DockStyle.Top;
            bntKu.SendToBack();
            bntKu.Dock = DockStyle.Top;
            lvQs.Dock = DockStyle.Bottom;
            lvQs.Clear();

            lvQs.Items.Add("产品信息", 0);
            lvQs.Items.Add("产品分类", 1);
            lvQs.Items.Add("通话信息", 2);
            lvQs.Items.Add("电话查询", 3);
        }

        private void tlsKuMenuItemAdd_Click(object sender, EventArgs e)
        {
            frmCustomerUpdate CustomerUpdate1 = new frmCustomerUpdate(1);//添加
            CustomerUpdate1.Owner = this;
            CustomerUpdate1.ShowDialog();

        }
        #endregion 
        #region 主界面菜单的单击事件
        private void tlsKuMenuItemDelete_Click(object sender, EventArgs e)
        {
            frmCustomerUpdate CustomerUpdate3 = new frmCustomerUpdate(3);
            CustomerUpdate3.Owner = this;
            CustomerUpdate3.ShowDialog();
        }

        private void tlsKuMenuItemUpdate_Click(object sender, EventArgs e)
        {
            frmCustomerUpdate CustomerUpdate2 = new frmCustomerUpdate(2);
            CustomerUpdate2.Owner = this;
            CustomerUpdate2.ShowDialog();
        }

        private void tlsKuMenuItemSecar_Click(object sender, EventArgs e)
        {
            frmCustomer CustomerF = new frmCustomer();
            CustomerF.Owner = this;
            CustomerF.ShowDialog();
        }

        private void tlsEmMenuItenAdd_Click(object sender, EventArgs e)
        {
            frmEmployeeInfo frmInfo1 = new frmEmployeeInfo(1);
            frmInfo1.Owner = this;
            frmInfo1.ShowDialog();
        }

        private void tlsEmMenuItemSecar_Click(object sender, EventArgs e)
        {
            frmEmployeeInfo frmInfo2 = new frmEmployeeInfo(2);
            frmInfo2.Owner = this;
            frmInfo2.ShowDialog();
        }

        private void tlsEmMenuItemDelete_Click(object sender, EventArgs e)
        {
            frmEmployeeInfo frmInfo3 = new frmEmployeeInfo(3);
            frmInfo3.Owner = this;
            frmInfo3.ShowDialog();
        }

        private void tlsEmMenuItemUpdate_Click(object sender, EventArgs e)
        {
            frmEmployeeInfo frmInfo4 = new frmEmployeeInfo(4);
            frmInfo4.Owner = this;
            frmInfo4.ShowDialog();
        }

        private void tlsCpMenuItemInfo_Click(object sender, EventArgs e)
        {
            frmtbProPath frmpath = new frmtbProPath(1);
            frmpath.Owner = this;
            frmpath.ShowDialog();
        }

        private void tlsCpMenuItemKind_Click(object sender, EventArgs e)
        {
            frmtbProduction frmProd = new frmtbProduction();
            frmProd.Owner = this;
            frmProd.ShowDialog();
        }
          #endregion
        #region listView1_Click事件
        private void listView1_Click(object sender, EventArgs e)
        {
            if (lvQs.SelectedItems[0].Text == "产品信息")
            {
                frmtbProduction frmProd1 = new frmtbProduction();
                frmProd1.Owner = this;
                frmProd1.ShowDialog();
            }
            if (lvQs.SelectedItems[0].Text == "产品分类")
            {
                frmtbProPath frmpath1 = new frmtbProPath();
                frmpath1.Owner = this;
                frmpath1.ShowDialog();
            }
            if (lvQs.SelectedItems[0].Text == "通话信息")
            {
                frmDai dai = new frmDai();
                dai.Owner = this;
                dai.ShowDialog();

            }
            if (lvQs.SelectedItems[0].Text == "电话查询")
            {
                frmTel tel = new frmTel();
                tel.Owner = this;
                tel.ShowDialog();
            }
            if (lvQs.SelectedItems[0].Text == "添加员工信息")
            {
                frmEmployeeInfo frmInfo11 = new frmEmployeeInfo(1);
                frmInfo11.Owner = this;
                frmInfo11.ShowDialog();
            }
            if (lvQs.SelectedItems[0].Text == "删除员工信息")
            {
                frmEmployeeInfo frmInfo33 = new frmEmployeeInfo(3);
                frmInfo33.Owner = this;
                frmInfo33.ShowDialog();
            }
            if (lvQs.SelectedItems[0].Text == "修改员工信息")
            {
                frmEmployeeInfo frmInfo11 = new frmEmployeeInfo(2);
                frmInfo11.Owner = this;
                frmInfo11.ShowDialog();
            }
            if (lvQs.SelectedItems[0].Text == "查询员工信息")
            {
                frmEmployeeInfo frmInfo22 = new frmEmployeeInfo(4);
                frmInfo22.Owner = this;
                frmInfo22.ShowDialog();
            }
            if (lvQs.SelectedItems[0].Text == "添加客户信息")
            {
                frmCustomerUpdate CustomerUpdate11 = new frmCustomerUpdate(1);
                CustomerUpdate11.Owner = this;
                CustomerUpdate11.ShowDialog();
            }
            if (lvQs.SelectedItems[0].Text == "修改客户信息")
            {
                frmCustomerUpdate CustomerUpdate22 = new frmCustomerUpdate(2);
                CustomerUpdate22.Owner = this;
                CustomerUpdate22.ShowDialog();
            }
            if (lvQs.SelectedItems[0].Text == "删除客户信息")
            {
                frmCustomerUpdate CustomerUpdate33 = new frmCustomerUpdate(3);
                CustomerUpdate33.Owner = this;
                CustomerUpdate33.ShowDialog();
            }
            if (lvQs.SelectedItems[0].Text == "查询客户信息")
            {
                frmCustomer CustomerF = new frmCustomer();
                CustomerF.Owner = this;
                CustomerF.ShowDialog();
            }


        }
        #endregion
        public void ResetPower(short I)
        {
            D160A.FeedPower(Dtmf[I]);
            D160A.StartPlaySignal(sWitCh[I], (int)SigType.SIG_STOP);
            SigCheck[Dtmf[I]] = (short)D160A.ClearLink(I, Dtmf[I]);
            if (SigCheck[Dtmf[I]] == 0)
            {
                D160A.StartPlaySignal(I, (int)SigType.SIG_BUSY1);
            }
            Lines[I].State = CHANNEL_STATE.CH_IsOver;

        }



        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否真的要退出程序！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result ==DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void tlsDaMenuItemSecar_Click(object sender, EventArgs e)
        {
            frmTel tel = new frmTel();
            tel.Owner = this;
            tel.ShowDialog();
        }

        private void tlsDaMenuItemLaida_Click(object sender, EventArgs e)
        {
            frmDai dai = new frmDai();
            dai.Owner = this;
            dai.ShowDialog();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }




     






    }
}