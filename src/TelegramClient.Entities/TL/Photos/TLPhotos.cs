using System.IO;

namespace TelegramClient.Entities.TL.Photos
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(-1916114267)]
    public class TlPhotos : TlAbsPhotos
    {
        [SerializationOrder(0)]
        public TlVector<TlAbsPhoto> Photos { get; set; }

        [SerializationOrder(1)]
        public TlVector<TlAbsUser> Users { get; set; }
    }
}