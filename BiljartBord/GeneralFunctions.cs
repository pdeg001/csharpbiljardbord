using Newtonsoft.Json;
using System;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace BiljartBord
{
    internal class GeneralFunctions
    {

        private PrivateFontCollection pfc = new PrivateFontCollection();
        public string bordDataFolder { get; set; }
        public OperatingSystem OSVersion { get; }
        string currScoreFile = "currscore.json", currScoreDummyFile = "dummycurrscore.json";
        ProcessJson pJson = new ProcessJson();

        

        public string GetLocalIp()
        {
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                return endPoint.Address.ToString();
            }
        }
        public FontCollection GetBordFont()
        {
            Stream fontStream = this.GetType().Assembly.GetManifestResourceStream("BiljartBord.TickingTimebombBB.ttf");
            byte[] fontdata = new byte[fontStream.Length];
            fontStream.Read(fontdata, 0, (int)fontStream.Length);
            fontStream.Close();
            unsafe
            {
                fixed (byte* pFontData = fontdata)
                {
                    pfc.AddMemoryFont((System.IntPtr)pFontData, fontdata.Length);
                }
            }
            return pfc;
        }

        public bool CheckInternetConnection()
        {
            Ping myPing = new Ping();
            String host = "google.com";
            byte[] buffer = new byte[32];
            int timeout = 1000;
            PingOptions pingOptions = new PingOptions();
            PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
            if (reply.Status == IPStatus.Success)
            {
                return true;
            }

            return false;
        }

        public string SetInningsText(string inning, bool rightMouseClick)
        {
            int addValue = 1;
            string[] inningText = inning.Split(' ');
            string strInningValue = $"{inningText[0]}{inningText[1]}{inningText[2]}";
            int iValue = int.Parse(strInningValue);

            if (iValue == 0 && rightMouseClick)
            {
                return inning;
            }

            if (rightMouseClick)
            {
                addValue = addValue * -1;
            }
            iValue += addValue;
            string newInning = iValue.ToString().PadLeft(3, '0');

            object[] array = {newInning.Substring(0,1), newInning.Substring(1, 1), newInning.Substring(2, 1) };
            return string.Join(" ", array);
        }

        public string gBordDataFolder()
        {
            return bordDataFolder;
        }

        public ProcessJson.CurrScore.Root GetCurrScore()
        {
            if (File.Exists(Path.Combine(bordDataFolder, currScoreFile)))
            {
                string strCurrScore = File.ReadAllText(Path.Combine(bordDataFolder, currScoreFile));
                return JsonConvert.DeserializeObject<ProcessJson.CurrScore.Root>(strCurrScore);
            }

            return null;
        }

    }
}
