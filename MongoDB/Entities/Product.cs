using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
    }
}
