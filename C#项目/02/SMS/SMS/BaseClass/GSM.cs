using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
namespace SMS.BaseClass
{
    class GSM
    {
        //��ʼ��gsm modem,������gsm modem
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemInitNew",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern bool GSMModemInitNew(
            string device,
            string baudrate,
            string initstring,
            string charset,
            bool swHandshake,
            string sn);

        //��ȡ����è�µı�ʶ����
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemGetSnInfoNew",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern string GSMModemGetSnInfoNew(string device, string baudrate);

        //��ȡ��ǰͨѶ�˿�
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemGetDevice",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern string GSMModemGetDevice();

        //��ȡ��ǰͨѶ������
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemGetBaudrate",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern string GSMModemGetBaudrate();

        //�Ͽ����Ӳ��ͷ��ڴ�ռ�		
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemRelease",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern void GSMModemRelease();

        //ȡ�ô�����Ϣ	
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemGetErrorMsg",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern string GSMModemGetErrorMsg();

        //���Ͷ���Ϣ
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemSMSsend",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern bool GSMModemSMSsend(
            string serviceCenterAddress,
            int encodeval,
            string text,
            int textlen,
            string phonenumber,
            bool requestStatusReport);

        //���ն���Ϣ�����ַ�����ʽΪ:�ֻ�����|��������||�ֻ�����|��������||
        //RD_optΪ�����ն���Ϣ�����κδ�����Ϊ���պ�ɾ����Ϣ
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemSMSReadAll",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern string GSMModemSMSReadAll(int RD_opt);
    }
}
