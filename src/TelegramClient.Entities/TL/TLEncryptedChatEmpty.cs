using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(-1417756512)]
    public class TlEncryptedChatEmpty : TlAbsEncryptedChat
    {
        public override int Constructor => -1417756512;

        public int Id { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            Id = br.ReadInt32();
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(Id);
        }
    }
}