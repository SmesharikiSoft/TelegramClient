using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(1251338318)]
    public class TlInputNotifyChats : TlAbsInputNotifyPeer
    {
        public override int Constructor => 1251338318;


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
        }
    }
}