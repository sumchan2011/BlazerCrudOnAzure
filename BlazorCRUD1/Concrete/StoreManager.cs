using BlazorCRUD1.Contracts;
using BlazorCRUD1.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD1.Concrete
{
    public class StoreManager : IStoreManager
    {
        private readonly IDapperManager _dapperManager;

        public StoreManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public Task<Store> GetById(int Id)
        {
            var store = Task.FromResult(_dapperManager.Get<Store>($"select * from [Store] where ID = {Id}", null,
                    commandType: CommandType.Text));
            return store;
        }

        public Task<int> Update(Store store)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", store.ID, DbType.Int32);
            dbPara.Add("StoreName", store.StoreName, DbType.String);
            dbPara.Add("StoreAddress", store.StoreAddress, DbType.String);
            dbPara.Add("StoreAddress2", store.StoreAddress2, DbType.String);
            dbPara.Add("StoreAddress3", store.StoreAddress3, DbType.String);
            dbPara.Add("StoreLocalPhone", store.StoreLocalPhone, DbType.String);
            dbPara.Add("StoreMobilePhone", store.StoreMobilePhone, DbType.String);
            dbPara.Add("StoreFax", store.StoreFax, DbType.String);
            dbPara.Add("StoreBANKAC1", store.StoreBANKAC1, DbType.String);
            dbPara.Add("StoreBANKAC2", store.StoreBANKAC2, DbType.String);
            dbPara.Add("StoreBANKAC3", store.StoreBANKAC3, DbType.String);
            dbPara.Add("StoreEmail", store.StoreEmail, DbType.String);
            dbPara.Add("StoreUnit", store.StoreUnit, DbType.Int32);
            dbPara.Add("StoreItemPerPage", store.StoreItemPerPage, DbType.Int32);
            var updateArticle = Task.FromResult(_dapperManager.Update<int>("[dbo].[SP_Update_Store2]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateArticle;

        }
    }
}
