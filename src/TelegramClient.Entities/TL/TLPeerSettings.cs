using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-2122045747)]
    public class TlPeerSettings : TlObject
    {
        public int Flags { get; set; }
        public bool ReportSpam { get; set; }


        public void ComputeFlags()
        {
            Flags = 0;
            Flags = ReportSpam ? Flags | 1 : Flags & ~1;
        }

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
            ReportSpam = (Flags & 1) != 0;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ComputeFlags();
            bw.Write(Flags);
        }
    }
}