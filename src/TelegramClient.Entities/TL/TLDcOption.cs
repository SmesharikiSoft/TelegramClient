using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(98092748)]
    public class TlDcOption : TlObject
    {
        public int Flags { get; set; }
        public bool Ipv6 { get; set; }
        public bool MediaOnly { get; set; }
        public bool TcpoOnly { get; set; }
        public int Id { get; set; }
        public string IpAddress { get; set; }
        public int Port { get; set; }


        public void ComputeFlags()
        {
            Flags = 0;
            Flags = Ipv6 ? Flags | 1 : Flags & ~1;
            Flags = MediaOnly ? Flags | 2 : Flags & ~2;
            Flags = TcpoOnly ? Flags | 4 : Flags & ~4;
        }

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
            Ipv6 = (Flags & 1) != 0;
            MediaOnly = (Flags & 2) != 0;
            TcpoOnly = (Flags & 4) != 0;
            Id = br.ReadInt32();
            IpAddress = StringUtil.Deserialize(br);
            Port = br.ReadInt32();
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ComputeFlags();
            bw.Write(Flags);


            bw.Write(Id);
            StringUtil.Serialize(IpAddress, bw);
            bw.Write(Port);
        }
    }
}