using BlazorCRUD1.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD1.Contracts
{
    public interface ICustomerManager
    {
        Task<int> Create(Customer customer);
        Task<int> Delete(int Id);
        Task<int> Count(string search);
        Task<int> Update(Customer customer);
        Task<Customer> GetById(int Id);
        Task<List<Customer>> ListAll(string customerPhone);
    }
}
