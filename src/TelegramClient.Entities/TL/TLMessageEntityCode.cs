using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(681706865)]
    public class TlMessageEntityCode : TlAbsMessageEntity
    {
        public override int Constructor => 681706865;

        public int Offset { get; set; }
        public int Length { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            Offset = br.ReadInt32();
            Length = br.ReadInt32();
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(Offset);
            bw.Write(Length);
        }
    }
}