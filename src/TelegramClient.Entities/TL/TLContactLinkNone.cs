using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(-17968211)]
    public class TlContactLinkNone : TlAbsContactLink
    {
        public override int Constructor => -17968211;


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