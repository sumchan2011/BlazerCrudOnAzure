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
                $"INSERT INTO [SaleTxn](SaleTxnStatus, SaleTxnQty, SaleTxnSubTotal, SaleReceivedQty, SaleTxnProductID, SaleTxnOrderID ,DELETED, UpdatedDateTime, UpdatedBy) OUTPUT Inserted.ID VALUES('{saleTxn.SaleStatus}','{saleTxn.SaleTxnQty}','{saleTxn.SaleSubTotal}', '{saleTxn.SaleReceivedQty}','{saleTxn.SaleProduct.ID}','{saleTxn.SaleTxnOrderID}' ,'{false}', CONVERT(datetime,'{saleTxn.UpdatedDateTime}',103), '{saleTxn.UpdatedBy}')",
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
            /*
            dbPara.Add("ProductID", stock.ProductID, DbType.Int32);
            dbPara.Add("StockCost", stock.StockCost, DbType.Double);
            dbPara.Add("StockQty", stock.StockQty, DbType.Double);
            dbPara.Add("StockDate", stock.StockDate, DbType.DateTime);
            dbPara.Add("LastUpdateDate", stock.LastUpdateDate, DbType.DateTime);
            dbPara.Add("LastUpdateUser", stock.LastUpdateUser, DbType.String);
            */
            var updateArticle = Task.FromResult(_dapperManager.Update<int>("[dbo].[SP_Update_Article]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateArticle;
        }
    }
}
