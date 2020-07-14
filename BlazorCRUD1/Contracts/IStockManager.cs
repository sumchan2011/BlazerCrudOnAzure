using BlazorCRUD1.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD1.Contracts
{
    public interface IStockManager
    {
        Task<int> Create(Stock stock);
        Task<int> Delete(int Id);
        Task<int> Count(int search);
        Task<int> Update(Stock stock);
        Task<Stock> GetById(int Id);
        Task<List<Stock>> ListAll(int skip, int take, string orderBy, int productID, string direction);
        Task<List<Stock>> SimpleListAll(int productID);
        Task<double> GetTotalStockByProductID(int productID);
    }
}
