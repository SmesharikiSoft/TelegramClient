using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(1461528386)]
    public class TlUpdateReadFeaturedStickers : TlAbsUpdate
    {
        public override int Constructor => 1461528386;


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