using BlazorCRUD1.Contracts;
using BlazorCRUD1.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BlazorCRUD1.Concrete
{
    public class StockManager : IStockManager
    {
        private readonly IDapperManager _dapperManager;

        public StockManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public Task<int> Create(Stock stock)
        {
            var productId = Task.FromResult(_dapperManager.Get<int>($"INSERT INTO [Stock](ProductID,StockCost,StockQty,DELETED,UpdatedDateTime,UpdatedBy) OUTPUT Inserted.ID VALUES('{stock.ProductID}','{stock.StockCost}','{stock.StockQty}','{false}',CONVERT(datetime,'{stock.UpdatedDateTime}',103),'{stock.UpdatedBy}')", null,
                commandType: CommandType.Text));
            return productId;
        }

        public Task<Stock> GetById(int id)
        {
            var stock = Task.FromResult(_dapperManager.Get<Stock>($"select * from [Stock] where ID = {id}", null,
                    commandType: CommandType.Text));
            return stock;
        }

        public Task<int> Delete(int id)
        {
            var deleteArticle = Task.FromResult(_dapperManager.Execute($"Delete [Stock] where ID = {id}", null,
                    commandType: CommandType.Text));
            return deleteArticle;
        }

        public Task<int> Count(int search)
        {
            var totArticle = Task.FromResult(_dapperManager.Get<int>($"select COUNT(*) from [Stock] WHERE ProductID like '%{search}%'", null,
                    commandType: CommandType.Text));
            return totArticle;
        }

        public Task<List<Stock>> ListAll(int skip, int take, string orderBy, int productID, string direction = "DESC")
        {
            var stock = Task.FromResult(_dapperManager.GetAll<Stock>
                ($"SELECT * FROM [Stock] WHERE ProductID = {productID} ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return stock;
        }

        public Task<int> Update(Stock stock)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ProductID", stock.ProductID, DbType.Int32);
            dbPara.Add("StockCost", stock.StockCost, DbType.Double);
            dbPara.Add("StockQty", stock.StockQty, DbType.Double);
            dbPara.Add("UpdatedDateTime", stock.UpdatedDateTime, DbType.DateTime);
            dbPara.Add("UpdatedBy", stock.UpdatedBy, DbType.String);
            var updateArticle = Task.FromResult(_dapperManager.Update<int>("[dbo].[SP_Update_Article]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateArticle;
        }

        public Task<List<Stock>> SimpleListAll(int productID)
        {
            var stock = Task.FromResult(_dapperManager.GetAll<Stock>
                ($"SELECT * FROM [Stock] WHERE ProductID = {productID}", null, commandType: CommandType.Text));
            return stock;
        }

        public Task<double> GetTotalStockByProductID(int productID)
        {
            var stock = Task.FromResult(_dapperManager.Get<double>($"select sum(StockQty) from [Stock] where ProductID = {productID}", null,
                commandType: CommandType.Text));
            return stock;
        }
    }
}
