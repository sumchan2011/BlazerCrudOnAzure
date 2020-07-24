using BlazorCRUD1.Contracts;
using BlazorCRUD1.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BlazorCRUD1.Concrete
{
    public class UserManager : IUserManager
    {
        private readonly IDapperManager _dapperManager;

        public UserManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public Task<int> Create(User user) {
            var dbPara = new DynamicParameters();
            //dbPara.Add("UserName", user.UserName, DbType.String);
            //dbPara.Add("PasswordHash", user.PasswordHash, DbType.String);
            //dbPara.Add("DELETED", false, DbType.Boolean);
            //dbPara.Add("UpdatedDateTime", user.UpdatedDateTime, DbType.DateTime);
            //dbPara.Add("UpdatedBy", user.UpdatedBy, DbType.String);

            dbPara.Add("@UserName", user.UserName, DbType.String);
            dbPara.Add("@PasswordHash", user.PasswordHash, DbType.String);
            dbPara.Add("@DELETED", false, DbType.Boolean);
            dbPara.Add("@UpdatedDateTime", user.UpdatedDateTime, DbType.DateTime);
            dbPara.Add("@UpdatedBy", user.UpdatedBy, DbType.String);

            //{ "@UpdatedDateTime", 1 }

            var userId = Task.FromResult(_dapperManager.Insert<int>(
            $"INSERT INTO [User](UserName,Password,DELETED,UpdatedDateTime,UpdatedBy) OUTPUT Inserted.ID VALUES(@UserName,@PasswordHash,@DELETED,@UpdatedDateTime,@UpdatedBy)",
                dbPara,
                commandType: CommandType.Text));
            return userId;
        }

        public Task<int> Update(User user)
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

        //public Task<int> GetLoginToken(User user)
        //{
        //    throw new System.NotImplementedException();
        //}

        public bool Verify(User user) {

            var dbPara = new DynamicParameters();
            //TODO: encrypt password
            dbPara.Add("@UserName", user.UserName, DbType.String);
            dbPara.Add("@PasswordHash", user.PasswordHash, DbType.String);

            var verified = Task.FromResult(_dapperManager.Get<int>
            ($"SELECT ID FROM [AuthUsers] WHERE UserName = @UserName and PasswordHash = @PasswordHash;", dbPara, commandType: CommandType.Text));
            return (verified != null?true:false);
        }


        public Task<int> Login(User user)
        {
            var dbPara = new DynamicParameters();
            //TODO: encrypt password
            dbPara.Add("@UserName", user.UserName, DbType.String);
            dbPara.Add("@PasswordHash", user.PasswordHash, DbType.String);

            var userId = Task.FromResult(_dapperManager.Get<int>
            ($"SELECT ID FROM [AuthUsers] WHERE UserName = @UserName and PasswordHash = @PasswordHash;", dbPara, commandType: CommandType.Text));
            return userId;
        }
    }
}