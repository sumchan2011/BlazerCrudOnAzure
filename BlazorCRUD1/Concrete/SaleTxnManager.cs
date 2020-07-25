using BlazorCRUD1.Contracts;
using BlazorCRUD1.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BlazorCRUD1.Concrete
{
    public class SaleTxnManager : ISaleTxnManager
    {
        private readonly IDapperManager _dapperManager;

        public SaleTxnManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public Task<int> Create(SaleTxn saleTxn)
        {
            var dbPara = new DynamicParameters();

            var articleId = Task.FromResult(_dapperManager.Get<int>(
                $"INSERT INTO [SaleTxn](SaleTxnStatus, SaleTxnQty, SaleTxnSubTotal, SaleReceivedQty, SaleTxnProductID, SaleTxnOrderID ,DELETED, UpdatedDateTime, UpdatedBy) OUTPUT Inserted.ID VALUES('{saleTxn.SaleTxnStatus}','{saleTxn.SaleTxnQty}','{saleTxn.SaleSubTotal}', '{saleTxn.SaleReceivedQty}','{saleTxn.SaleProduct.ID}','{saleTxn.SaleTxnOrderID}' ,'{false}', CONVERT(datetime,'{saleTxn.UpdatedDateTime}',103), '{saleTxn.UpdatedBy}')",
                            null,
                            commandType: CommandType.Text));
            return articleId;
        }

        public Task<SaleTxn> GetById(int id)
        {
            var stock = Task.FromResult(_dapperManager.Get<SaleTxn>($"select * from [SaleTxn] where ID = {id}", null,
                    commandType: CommandType.Text));
            return stock;
        }

        public Task<int> Delete(int id)
        {
            var deleteArticle = Task.FromResult(_dapperManager.Execute($"Delete [SaleTxn] where ID = {id}", null,
                    commandType: CommandType.Text));
            return deleteArticle;
        }

        public Task<int> Count(string search)
        {
            var totArticle = Task.FromResult(_dapperManager.Get<int>($"select COUNT(*) from [SaleTxn]", null,
                    commandType: CommandType.Text));
            return totArticle;
        }

        public Task<List<SaleTxn>> ListAll(int skip, int take, string orderBy, int orderID, string direction = "DESC")
        {
            var stock = Task.FromResult(_dapperManager.GetAll<SaleTxn>
                ($"SELECT * FROM [SaleTxn] WHERE SaleTxnOrderID = {orderID} ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return stock;
        }

        public Task<List<SaleTxn>> SimplyListAll(int orderID)
        {
            var stock = Task.FromResult(_dapperManager.GetAll<SaleTxn>
                ($"SELECT * FROM [SaleTxn] WHERE SaleTxnOrderID = {orderID} ;", null, commandType: CommandType.Text));
            return stock;

        }

        public Task<int> Update(SaleTxn saleTxn)
        {
            var dbPara = new DynamicParameters();
            
            dbPara.Add("ID", saleTxn.ID, DbType.Int32);
            dbPara.Add("SaleTxnStatus", saleTxn.SaleTxnStatus, DbType.Int32);
            dbPara.Add("SaleTxnProductID", saleTxn.SaleTxnProductID, DbType.Int32);
            dbPara.Add("SaleTxnQty", saleTxn.SaleTxnQty, DbType.Double);
            dbPara.Add("SaleTxnSubTotal", saleTxn.SaleSubTotal, DbType.Double);
            dbPara.Add("SaleReceivedQty", saleTxn.SaleReceivedQty, DbType.Double);
            dbPara.Add("DELETED", false, DbType.Boolean);
            dbPara.Add("UpdatedDateTime", System.DateTime.Now, DbType.DateTime);
            dbPara.Add("UpdatedBy", "abc", DbType.String);
            var updateArticle = Task.FromResult(_dapperManager.Update<int>("[dbo].[SP_Update_SaleTxn]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateArticle;
        }
    }
}
