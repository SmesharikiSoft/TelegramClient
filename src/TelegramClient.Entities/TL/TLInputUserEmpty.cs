using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(-1182234929)]
    public class TlInputUserEmpty : TlAbsInputUser
    {
        public override int Constructor => -1182234929;


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