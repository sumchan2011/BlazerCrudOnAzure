using BlazorCRUD1.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD1.Contracts
{
    public interface IOrderManager
    {
        Task<int> Create(Order order);
        Task<int> Delete(int Id);
        Task<int> Count(string search);
        Task<int> Update(Order order);
        Task<Order> GetById(int Id);
        Task<List<Order>> ListAll(int skip, int take, string orderBy, int productID, string direction);
        Task<List<Order>> SimplyListAll(int customterID);
    }
}
