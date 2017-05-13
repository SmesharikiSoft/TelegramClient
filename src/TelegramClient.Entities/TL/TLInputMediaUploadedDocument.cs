using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-797904407)]
    public class TlInputMediaUploadedDocument : TlAbsInputMedia
    {
        public int Flags { get; set; }
        public TlAbsInputFile File { get; set; }
        public string MimeType { get; set; }
        public TlVector<TlAbsDocumentAttribute> Attributes { get; set; }
        public string Caption { get; set; }
        public TlVector<TlAbsInputDocument> Stickers { get; set; }


        public void ComputeFlags()
        {
            Flags = 0;
            Flags = Stickers != null ? Flags | 1 : Flags & ~1;
        }

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
            File = (TlAbsInputFile) ObjectUtils.DeserializeObject(br);
            MimeType = StringUtil.Deserialize(br);
            Attributes = ObjectUtils.DeserializeVector<TlAbsDocumentAttribute>(br);
            Caption = StringUtil.Deserialize(br);
            if ((Flags & 1) != 0)
                Stickers = ObjectUtils.DeserializeVector<TlAbsInputDocument>(br);
            else
                Stickers = null;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ComputeFlags();
            bw.Write(Flags);
            ObjectUtils.SerializeObject(File, bw);
            StringUtil.Serialize(MimeType, bw);
            ObjectUtils.SerializeObject(Attributes, bw);
            StringUtil.Serialize(Caption, bw);
            if ((Flags & 1) != 0)
                ObjectUtils.SerializeObject(Stickers, bw);
        }
    }
}