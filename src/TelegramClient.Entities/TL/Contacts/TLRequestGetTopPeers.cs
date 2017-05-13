using System.IO;

namespace TelegramClient.Entities.TL.Contacts
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-728224331)]
    public class TlRequestGetTopPeers : TlMethod
    {
        public int Flags { get; set; }
        public bool Correspondents { get; set; }
        public bool BotsPm { get; set; }
        public bool BotsInline { get; set; }
        public bool Groups { get; set; }
        public bool Channels { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }
        public int Hash { get; set; }
        public TlAbsTopPeers Response { get; set; }


        public void ComputeFlags()
        {
            Flags = 0;
            Flags = Correspondents ? Flags | 1 : Flags & ~1;
            Flags = BotsPm ? Flags | 2 : Flags & ~2;
            Flags = BotsInline ? Flags | 4 : Flags & ~4;
            Flags = Groups ? Flags | 1024 : Flags & ~1024;
            Flags = Channels ? Flags | 32768 : Flags & ~32768;
        }

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
            Correspondents = (Flags & 1) != 0;
            BotsPm = (Flags & 2) != 0;
            BotsInline = (Flags & 4) != 0;
            Groups = (Flags & 1024) != 0;
            Channels = (Flags & 32768) != 0;
            Offset = br.ReadInt32();
            Limit = br.ReadInt32();
            Hash = br.ReadInt32();
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ComputeFlags();
            bw.Write(Flags);


            bw.Write(Offset);
            bw.Write(Limit);
            bw.Write(Hash);
        }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TlAbsTopPeers) ObjectUtils.DeserializeObject(br);
        }
    }
}