using System;
using System.Net.Sockets;
using AppKit;
using Foundation;

namespace WOL_G
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }
        partial void onclick(NSObject sender)
        {
            string physicalAddress = "00-1B-FC-38-1C-99"; // リモート起動するコンピュータのＭＡＣアドレス
            string packet = "FF-FF-FF-FF-FF-FF";
            for (int i = 0; i < 16; i++)
            {
                packet += "-" + physicalAddress;
            }
            string[] s = packet.Split('-');
            byte[] packetData = new byte[6 + 6 * 16];
            for (int i = 0; i < 102; i++)
            {
                packetData[i] = (byte)(Convert.ToInt32(s[i], 16));
            }
            UdpClient client = new UdpClient();
            client.EnableBroadcast = true;
            client.Send(packetData, 102, "192.168.2.115", 9);

        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
