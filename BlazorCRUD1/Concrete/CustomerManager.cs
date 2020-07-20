using BlazorCRUD1.Contracts;
using BlazorCRUD1.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BlazorCRUD1.Concrete
{
    public class CustomerManager : ICustomerManager
    {
        private readonly IDapperManager _dapperManager;

        public CustomerManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public Task<int> Create(Customer customer)
        {
            var productId = Task.FromResult(_dapperManager.Get<int>($"INSERT INTO [Customer](CustomerName,CustomerPhone,CustomerEmail,CustomerCompany,DELETED,UpdatedDateTime,UpdatedBy) OUTPUT Inserted.ID VALUES('{customer.CustomerName}','{customer.CustomerPhone}','{customer.CustomerEmail}','{customer.CustomerCompany}','{false}',CONVERT(datetime,'{customer.UpdatedDateTime}',103),'{customer.UpdatedBy}')", null,
                    commandType: CommandType.Text));
            return productId;
        }

        public Task<Customer> GetById(int id)
        {
            var customer = Task.FromResult(_dapperManager.Get<Customer>($"select * from [Customer] where ID = {id}", null,
                    commandType: CommandType.Text));
            return customer;
        }

        public Task<int> Delete(int id)
        {
            var deleteArticle = Task.FromResult(_dapperManager.Execute($"Delete [Customer] where ID = {id}", null,
                    commandType: CommandType.Text));
            return deleteArticle;
        }

        public Task<int> Count(string search)
        {
            var totArticle = Task.FromResult(_dapperManager.Get<int>($"select COUNT(*) from [Customer] WHERE CustomerPhone like '{search}'", null,
                    commandType: CommandType.Text));
            return totArticle;
        }

        public Task<List<Customer>> ListAll(string customerID)
        {
            var customer = Task.FromResult(_dapperManager.GetAll<Customer>
                ($"SELECT * FROM [Customer] WHERE CAST(CustomerPhone AS VARCHAR(20)) LIKE '{customerID}%';", null, commandType: CommandType.Text));
            return customer;
        }

        public Task<List<Customer>> ListAll(int skip, int take, string orderBy, string direction = "DESC", string customerID = "")
        {
            var customer = Task.FromResult(_dapperManager.GetAll<Customer>
                ($"SELECT * FROM [Customer] WHERE CAST(CustomerPhone AS VARCHAR(20)) LIKE '{customerID}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return customer;
        }

        public Task<int> Update(Customer customer)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", customer.ID, DbType.Int32);
            dbPara.Add("CustomerPhone", customer.CustomerPhone, DbType.Int32);
            dbPara.Add("CustomerName", customer.CustomerName, DbType.String);
            dbPara.Add("CustomerCompany", customer.CustomerCompany, DbType.String);
            dbPara.Add("CustomerEmail", customer.CustomerEmail, DbType.String);
            var updateArticle = Task.FromResult(_dapperManager.Update<int>("[dbo].[SP_Update_Customer]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateArticle;
        }
    }
}
