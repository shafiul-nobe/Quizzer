using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Entities
{
    [BsonIgnoreExtraElements(Inherited = true)]
    public class RootEntityBase
    {
        [BsonId]
        public string ItemId { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string Language { get; set; }
        public virtual DateTime LastUpdateDate { get; set; }
        public virtual string LastUpdatedBy { get; set; }
        public string[] Tags { get; set; }
        public virtual string TenantId { get; set; }
        public bool IsMarkedToDelete { get; set; }
    }
}
