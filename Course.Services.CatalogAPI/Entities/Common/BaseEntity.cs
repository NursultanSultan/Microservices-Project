using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Course.Services.CatalogAPI.Entities.Common
{
    public class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}
