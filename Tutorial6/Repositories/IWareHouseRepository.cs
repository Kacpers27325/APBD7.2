namespace Tutorial6.Repositories;

public interface IWareHouseRepository
{
    Task<bool> DoesProductExist(int id);
    Task<bool> DoesMagazynExist(int id);
    Task<bool> IsFulfilled(int id);
    
    Task AddProduct(int id, int idWarehouse, int amount, string createdAt);
    Task<bool> IsInInOrder(int id);
    Task UpdateData(int id);
    Task<int> InsertData(int id);
    Task ReturnKey(int id);
}