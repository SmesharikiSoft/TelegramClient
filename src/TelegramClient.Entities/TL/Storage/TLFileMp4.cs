using System.IO;

namespace TelegramClient.Entities.TL.Storage
{
    [SerializeAttribute(-1278304028)]
    public class TlFileMp4 : TlAbsFileType
    {
        public override int Constructor => -1278304028;


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