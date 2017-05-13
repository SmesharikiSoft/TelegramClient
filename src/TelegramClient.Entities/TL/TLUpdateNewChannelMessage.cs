using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(1656358105)]
    public class TlUpdateNewChannelMessage : TlAbsUpdate
    {
        public override int Constructor => 1656358105;

        public TlAbsMessage Message { get; set; }
        public int Pts { get; set; }
        public int PtsCount { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            Message = (TlAbsMessage) ObjectUtils.DeserializeObject(br);
            Pts = br.ReadInt32();
            PtsCount = br.ReadInt32();
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Message, bw);
            bw.Write(Pts);
            bw.Write(PtsCount);
        }
    }
}