using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
namespace Daila
{
    class D160A
    {


        //初始化函数;
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern long LoadDRV();
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern void FreeDRV();
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern long EnableCard(short wusedCh, short wFileBufLen);
  
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern short CheckValidCh();
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern short CheckChType(short wChnlNo);
        //[DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        //public static extern short CheckChTypeNew(short wChnlNo);
        //[DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        //public static extern bool IsSupportCallerID();
        //[DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        //public static extern void SetPackrate(short wPackRate);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern void PUSH_PLAY();
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern void SetBusyPara(short BusyLen);
        //[DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        //public static extern void SetDialPara(short RingBack, short RingBack0, short BusyLen, short RingTimes);
        //[DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        //public static extern long NewReadPass(short wCardNo);
        //[DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        //public static extern void D_SetWorkMode(short wChnlNo, byte cbWorkMode, byte cbModeVal);

        //振铃及摘挂机函数;
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern bool RingDetect(short wChnlNo);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern void OffHook(short wChnlNo);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern void HangUp(short wChnlNo);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern long ElapseTime(int wChn, int ClockType);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern void StartPlaySignal(short wChn, int ClockType);
         [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern void FeedRealRing(int ChannelNo);
            [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern void StartHangUpDetect(short ChannelNo);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern int HangUpDetect(short ChannelNo);
         [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern void FeedPower(short ChannelNo);
             [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern int ClearLink(short ChannelNo,int another);

   
        //放音函数;
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern void StartPlay(short wChnlNo, byte[] PlayBuf, int dwStartPos, int dwPlayLen);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern void StopPlay(short wChnlNo);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern bool CheckPlayEnd(short wChnlNo);

        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern bool StartPlayFile(short wChnlNo, byte[] FileName, int StartPos);//原代码

        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern void StopPlayFile(short wChnlNo);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern void RsetIndexPlayFile(short Line);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern bool AddIndexPlayFile(short Line, byte[] FileName);//原代码
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern bool StartPlayIndex(short wChnlNo, short[] pIndexTable, short wIndexLen);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern bool CheckIndexPlayFile(short wChnlNo);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern void StopIndexPlayFile(short wChnlNo);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern bool StartIndexPlayFile(short wChnlNo);



        //录音函数
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern bool StopRecord(short wChnlNo);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern bool StartRecordFile(short wChnlNo,byte[] filent,long dwrecordlen);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern bool heckRecordEnd(short wChnlNo);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern void StopRecordFile(short wChnlNo);

        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern int ReadBusyCount();

        //收码、拔号、信号音检测函数	


        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern int  ReadCheckResult(short ChannelNo,int CheckMode);

        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern void InitDtmfBuf(short wChnlNo);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern short GetDtmfCode(short wChnlNo);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern bool DtmfHit(short wChnlNo);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern void StartSigCheck(short wChnlNo);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern void FeedSigFunc();
        [DllImport("NewSig.dll", CharSet = CharSet.Auto)]
        public static extern int Sig_CheckBusy(short intcoung);

        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern void SendDtmfBuf(short intcoung,string DialNum);

        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern bool CheckSendEnd(short intcoung);




        [DllImport("NewSig.dll", CharSet = CharSet.Auto)]
        public static extern void Sig_ResetCheck(short Times);
        //收主叫号码有关的函数
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern void ResetCallerIDBuffer(short wChnlNo);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern short GetCallerIDRawStr(short wChnlNo, byte[] IDRawStr);
        [DllImport("Tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern short GetCallerIDStr(short wChnlNo, byte[] IDStr);





        //新增信号音函数
        [DllImport("NewSig.dll", CharSet = CharSet.Auto)]
        public static extern void Sig_Init(int Times);
        [DllImport("tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern int OffHookDetect(short ChannelNo);
  
        //联通函数
         [DllImport("tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern long SetLink(short ChannelNo,short wAnother);

        [DllImport("tc08a32.dll", CharSet = CharSet.Auto)]
        public static extern long ClearLink(short ChannelNo, short wAnother);
     }
}
