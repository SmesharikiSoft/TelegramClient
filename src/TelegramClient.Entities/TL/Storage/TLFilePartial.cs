using System.IO;

namespace TelegramClient.Entities.TL.Storage
{
    [SerializeAttribute(1086091090)]
    public class TlFilePartial : TlAbsFileType
    {
        public override int Constructor => 1086091090;


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