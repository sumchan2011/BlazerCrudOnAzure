using BlazorCRUD1.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD1.Contracts
{
    public interface IUserManager
    {
        Task<int> Create(User user);
        Task<int> Update(User user);
        bool Verify(User user);
        Task<int> Login(User user);

        //Task<int> GetLoginToken(User user);
        //Task<int> Count();
    }
}
