using System.IO;

namespace TelegramClient.Entities.TL
{
    [SerializeAttribute(320652927)]
    public class TlInputPrivacyValueAllowUsers : TlAbsInputPrivacyRule
    {
        public override int Constructor => 320652927;

        public TlVector<TlAbsInputUser> Users { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            Users = ObjectUtils.DeserializeVector<TlAbsInputUser>(br);
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Users, bw);
        }
    }
}