using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(-1419371685)]
    public class TlTopPeerCategoryBotsPm : TlAbsTopPeerCategory
    {
        public override int Constructor => -1419371685;


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