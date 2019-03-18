using Abp.Data;
using Abp.Dependency;
using Abp.EntityFrameworkCore;
using Abp.MultiTenancy;
using AbpDemoOne.EntityFrameworkCore.Extensions;
using AbpDemoOne.SQLRepositories;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace AbpDemoOne.EntityFrameworkCore.Repositories
{
    public class SqlExecuter : ISqlExecuter, ITransientDependency
    {
        private readonly IDbContextProvider<AbpDemoOneDbContext> _dbContextProvider;
        private readonly IActiveTransactionProvider _transactionProvider;

        public SqlExecuter(IDbContextProvider<AbpDemoOneDbContext> dbContextProvider, IActiveTransactionProvider transactionProvider)
        {
            _dbContextProvider = dbContextProvider;
            _transactionProvider = transactionProvider;
        }

        public int Execute(string sql, params object[] parameters)
        {
            return _dbContextProvider.GetDbContext().Database.ExecuteSqlCommand(sql, parameters);
        }

        public IEnumerable<T> Query<T>(string sql, object param, CommandType commandType = CommandType.Text)
        {
            EnsureConnectionOpen();
            var transaction = GetActiveTransaction();
            return GetConnection().Query<T>(sql, param, transaction, commandType: commandType);
        }

        public IDbConnection GetConnection()
        {
            return _dbContextProvider.GetDbContext().Database.GetDbConnection();
        }

        public int ExecuteSp(string sql, object param)
        {
            EnsureConnectionOpen();
            var transaction = GetActiveTransaction();
            return GetConnection().Execute(sql, param, transaction, null, CommandType.StoredProcedure);
        }

        private void EnsureConnectionOpen()
        {
            var connection = GetConnection();

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        private DbTransaction GetActiveTransaction()
        {
            return (DbTransaction)_transactionProvider.GetActiveTransaction(new ActiveTransactionProviderArgs
            {
                {"ContextType", typeof(AbpDemoOneDbContext) },
                {"MultiTenancySide", MultiTenancySides.Tenant }
            });
        }
    }
}
