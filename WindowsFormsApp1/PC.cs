using System;
using System.Net;

namespace WindowsFormsApp1
{
    internal class Pc
    {
        public string PcName { get; set; }
        public string Ip { get; set; }

        



        public string getPcName()
        {
            PcName = Environment.MachineName;
            return PcName;
        }



        public string getIp()
        {
            string hostName = Dns.GetHostName();

            string ip = Dns.GetHostByName(hostName).AddressList[0].ToString();
            return ip;
           
        }

    }
}
    



        


     