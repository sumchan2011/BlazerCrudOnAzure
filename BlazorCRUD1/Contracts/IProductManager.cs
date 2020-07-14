using BlazorCRUD1.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD1.Contracts
{
    public interface IProductManager
    {
        Task<int> Create(Product product);
        Task<int> Delete(Product product);
        Task<int> Count(string search);
        Task<int> Update(Product product , Boolean isDelete);
        Task<Product> GetById(int Id);
        Task<List<Product>> ListAll(int skip, int take, string orderBy, string direction, string search);
        Task<List<Product>> ListAll(int skip, int take, string orderBy, string direction);
        Task<List<Product>> ListFilterAll(int skip, int take, string orderBy, string direction, string name,string origin,double lower, double upper);
        Task<List<Product>> SimplyListFilterAll(string name, string origin, double lower, double upper);
    }
}
