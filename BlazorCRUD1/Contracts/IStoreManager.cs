using BlazorCRUD1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD1.Contracts
{
    public interface IStoreManager
    {
        Task<int> Update(Store store);

        Task<Store> GetById(int Id);
    }
}
