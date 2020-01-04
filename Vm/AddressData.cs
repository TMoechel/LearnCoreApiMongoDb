using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace UserApi.Vm
{
    public class Address
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }      
        public int IdUser { get; set; }  
        public string Zip { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
}
