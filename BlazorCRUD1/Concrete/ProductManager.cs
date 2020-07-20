using BlazorCRUD1.Contracts;
using BlazorCRUD1.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BlazorCRUD1.Concrete
{
    public class ProductManager : IProductManager
    {
        private readonly IDapperManager _dapperManager;

        public ProductManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public Task<int> Create(Product product)
        {
            var productId = Task.FromResult(_dapperManager.Get<int>($"INSERT INTO [Product](ProductName,ProductDetails,ProductOrigin,ProductPrice,DELETED,UpdatedDateTime,UpdatedBy) OUTPUT Inserted.ID VALUES('{product.ProductName}','{product.ProductDetails}','{product.ProductOrigin}','{product.ProductPrice}','{false}',CONVERT(datetime,'{product.UpdatedDateTime}',103),'{product.UpdatedBy}')", null,
                    commandType: CommandType.Text));
            return productId;
        }

        public Task<Product> GetById(int id)
        {
            var article = Task.FromResult(_dapperManager.Get<Product>($"select * from [Product] where ID = {id} AND DELETED = 'False'", null,
                    commandType: CommandType.Text));
            return article;
        }

        public Task<int> Delete(Product product)
        {
            return Update(product,true);
        }

        public Task<int> Count(string search)
        {
            var totArticle = Task.FromResult(_dapperManager.Get<int>($"select COUNT(*) from [Product] WHERE ProductName like '%{search}%' AND DELETED = 'False'", null,
                    commandType: CommandType.Text));
            return totArticle;
        }

        public Task<List<Product>> ListAll(int skip, int take, string orderBy, string direction = "DESC", string search = "")
        {
            var product = Task.FromResult(_dapperManager.GetAll<Product>
                ($"select P.ProductName, P.ProductPrice, P.ProductOrigin, P.ProductDetails , sum(S.StockQty) As ProductTotalStock from [Product] as P Inner Join [Stock] as S on P.ID = S.ProductID WHERE P.ProductName like '%{search}%' AND P.DELETED = 'False' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY group by P.ProductName, P.ProductOrigin, P.ProductPrice, P.ProductDetails; ", null, commandType: CommandType.Text));
            return product;
        }

        public Task<List<Product>> ListAll(int skip, int take, string orderBy, string direction = "DESC")
        {
            var product = Task.FromResult(_dapperManager.GetAll<Product>
                ($"select P.ID, P.ProductName, P.ProductPrice, P.ProductOrigin, P.ProductDetails , ISNULL(sum(S.StockQty),0.0) As ProductTotalStock from [Product] as P Left Join [Stock] as S on P.ID = S.ProductID WHERE P.DELETED = 'False' GROUP BY P.ProductName, P.ProductOrigin, P.ProductPrice, P.ProductDetails, P.ID ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return product;
        }

        public Task<int> Update(Product product,Boolean isDelete)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", product.ID, DbType.Int32);
            dbPara.Add("ProductName", product.ProductName, DbType.String);
            dbPara.Add("ProductDetails", product.ProductDetails, DbType.String);
            dbPara.Add("ProductOrigin", product.ProductOrigin, DbType.String);
            dbPara.Add("ProductPrice", product.ProductPrice, DbType.Double);
            dbPara.Add("DELETED", isDelete, DbType.Boolean);
            dbPara.Add("UpdatedDateTime", System.DateTime.Now, DbType.DateTime);
            dbPara.Add("UpdatedBy", "abc", DbType.String);
            var updateArticle = Task.FromResult(_dapperManager.Update<int>("[dbo].[SP_Update_Product_2]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateArticle;
        }

        public Task<List<Product>> ListFilterAll(int skip, int take, string orderBy, string direction, string name, string origin, double lower, double upper)
        {
            var product = Task.FromResult(_dapperManager.GetAll<Product>
                ($"SELECT P.ID, P.ProductName, P.ProductPrice, P.ProductOrigin, P.ProductDetails , sum(S.StockQty) As ProductTotalStock FROM [Product] as P Inner Join [Stock] as S on P.ID = S.ProductID WHERE P.ProductName like '%{name}%' AND P.ProductOrigin like '%{origin}%' AND P.ProductPrice > {lower} AND P.ProductPrice < {upper}  AND P.DELETED = 'False' group by P.ID, P.ProductName, P.ProductOrigin, P.ProductPrice, P.ProductDetails ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY ; ", null, commandType: CommandType.Text));
            return product;
        }

        public Task<List<Product>> SimplyListFilterAll(string name, string origin, double lower, double upper)
        {
            var product = Task.FromResult(_dapperManager.GetAll<Product>
                ($"SELECT P.ID, P.ProductName, P.ProductPrice, P.ProductOrigin, P.ProductDetails , ISNULL(sum(S.StockQty),0.0) As ProductTotalStock FROM [Product] as P Inner Join [Stock] as S on P.ID = S.ProductID WHERE P.ProductName like '%{name}%' AND P.ProductOrigin like '%{origin}%' AND P.ProductPrice > {lower} AND P.ProductPrice < {upper} AND P.DELETED = 'False' group by P.ID,P.ProductName, P.ProductOrigin, P.ProductPrice, P.ProductDetails;", null, commandType: CommandType.Text));
            return product;

        }
    }
}
