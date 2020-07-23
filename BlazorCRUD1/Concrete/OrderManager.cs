using BlazorCRUD1.Contracts;
using BlazorCRUD1.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BlazorCRUD1.Concrete
{
    public class OrderManager : IOrderManager
    {
        private readonly IDapperManager _dapperManager;

        public OrderManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public Task<int> Create(Order order)
        {
            var dbPara = new DynamicParameters(); 
            dbPara.Add("CustomerID", order.OrderCustomer.ID, DbType.Int32);
            dbPara.Add("OrderTxnType", order.OrderTxnType, DbType.Int32);
            dbPara.Add("", order.OrderTotalAmt, DbType.Double);
            dbPara.Add("OrderNetAmt", order.OrderNetAmt, DbType.Double);
            dbPara.Add("OrderDepositAmt", order.OrderDiscountAmt, DbType.Double);
            dbPara.Add("DELETED", false, DbType.Boolean);
            dbPara.Add("UpdatedDateTime", order.UpdatedDateTime, DbType.DateTime);
            dbPara.Add("UpdatedBy", order.UpdatedBy, DbType.String);
            var articleId = Task.FromResult(_dapperManager.Insert<int>(
                $"INSERT INTO [Order](CustomerID,OrderTxnType,OrderTotalAmt,OrderNetAmt,OrderDepositAmt,DELETED,UpdatedDateTime,UpdatedBy) OUTPUT Inserted.ID VALUES('{order.OrderCustomer.ID}','{order.OrderTxnType}','{order.OrderTotalAmt}','{order.OrderNetAmt}','{order.OrderDiscountAmt}','{false}',CONVERT(datetime,'{order.UpdatedDateTime}',103),'{order.UpdatedBy}')",
                            dbPara,
                            commandType: CommandType.Text));
            return articleId;
        }

        public Task<Order> GetById(int id)
        {
            var stock = Task.FromResult(_dapperManager.Get<Order>($"select * from [Order] where ID = {id}", null,
                    commandType: CommandType.Text));
            return stock;
        }

        public Task<int> Delete(int id)
        {
            var deleteArticle = Task.FromResult(_dapperManager.Execute($"Delete [Order] where ID = {id}", null,
                    commandType: CommandType.Text));
            return deleteArticle;
        }

        public Task<int> Count(string search)
        {
            var totArticle = Task.FromResult(_dapperManager.Get<int>($"select COUNT(*) from [Order] WHERE ProductName like '%{search}%'", null,
                    commandType: CommandType.Text));
            return totArticle;
        }

        public Task<List<Order>> ListAll(int skip, int take, string orderBy, int productID, string direction = "DESC")
        {
            var stock = Task.FromResult(_dapperManager.GetAll<Order>
                ($"SELECT * FROM [Order] WHERE ProductID like '{productID}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return stock;
        }

        public Task<int> Update(Order order)
        {
            var dbPara = new DynamicParameters();
            /*dbPara.Add("ProductID", order.ProductID, DbType.Int32);
            dbPara.Add("StockCost", order.StockCost, DbType.Double);
            dbPara.Add("StockQty", order.StockQty, DbType.Double);
            dbPara.Add("StockDate", order.StockDate, DbType.DateTime);
            dbPara.Add("LastUpdateDate", order.LastUpdateDate, DbType.DateTime);
            dbPara.Add("LastUpdateUser", order.LastUpdateUser, DbType.String);
            */
            var updateArticle = Task.FromResult(_dapperManager.Update<int>("[dbo].[SP_Update_Article]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateArticle;
        }

        public Task<List<Order>> SimplyListAll(int customerID)
        {
            var stock = Task.FromResult(_dapperManager.GetAll<Order>
                ($"SELECT * FROM [Order] WHERE CustomerID = {customerID};", null, commandType: CommandType.Text));
            return stock;
        }

        public Task<List<Order>> SimplyListAll()
        {
            var stock = Task.FromResult(_dapperManager.GetAll<Order>
                ($"SELECT * FROM [Order];", null, commandType: CommandType.Text));
            return stock;
        }
    }
}
