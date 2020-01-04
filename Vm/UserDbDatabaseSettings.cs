namespace UserApi.Vm
{
    public class UserDbDatabaseSettings : IUserDbDatabaseSettings
    {
        public string AddressListCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IUserDbDatabaseSettings
    {
        string AddressListCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}