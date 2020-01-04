using UserApi.Vm;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace UserApi.Services
{
    public class AddressService
    {
        private readonly IMongoCollection<Address> _addressList;

        public AddressService(IUserDbDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _addressList = database.GetCollection<Address>(settings.AddressListCollectionName);
        }

        public List<Address> Get() =>
            _addressList.Find(address => true).ToList();

        public Address Get(string id) =>
            _addressList.Find<Address>(address => address.Id == id).FirstOrDefault();

        public Address Create(Address book)
        {
            _addressList.InsertOne(book);
            return book;
        }

        public void Update(string id, Address bookIn) =>
            _addressList.ReplaceOne(book => book.Id == id, bookIn);

        public void Remove(Address bookIn) =>
            _addressList.DeleteOne(book => book.Id == bookIn.Id);

        public void Remove(string id) => 
            _addressList.DeleteOne(book => book.Id == id);
    }
}