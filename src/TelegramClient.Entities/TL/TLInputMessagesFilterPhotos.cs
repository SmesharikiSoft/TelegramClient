using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(-1777752804)]
    public class TlInputMessagesFilterPhotos : TlAbsMessagesFilter
    {
        public override int Constructor => -1777752804;


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