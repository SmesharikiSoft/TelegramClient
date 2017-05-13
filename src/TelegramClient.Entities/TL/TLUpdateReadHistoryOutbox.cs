using System.IO;

namespace TelegramClient.Entities.TL
{
    using TelegramClient.Serialization.Attributes;

    [Serialize(791617983)]
    public class TlUpdateReadHistoryOutbox : TlAbsUpdate
    {
        [SerializationOrder(0)]
        public TlAbsPeer Peer { get; set; }

        [SerializationOrder(1)]
        public int MaxId { get; set; }

        [SerializationOrder(2)]
        public int Pts { get; set; }

        [SerializationOrder(3)]
        public int PtsCount { get; set; }
    }
}