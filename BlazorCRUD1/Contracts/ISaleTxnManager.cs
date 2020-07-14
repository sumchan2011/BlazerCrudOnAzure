using BlazorCRUD1.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD1.Contracts
{
    public interface ISaleTxnManager
    {
        Task<int> Create(SaleTxn saleTxn);

        Task<int> Delete(int Id);

        Task<int> Count(string search);

        Task<int> Update(SaleTxn saleTxn);

        Task<SaleTxn> GetById(int Id);

        Task<List<SaleTxn>> ListAll(int skip, int take, string orderBy, int productID, string direction);

        Task<List<SaleTxn>> SimplyListAll(int orderID);
    }
}
