using System.Collections.Generic;
using System.Data;

namespace AbpDemoOne.SQLRepositories
{
    /// <summary>
    /// 执行原生SQL
    /// </summary>
    public interface ISqlExecuter
    {

        int Execute(string sql, params object[] parameters);

        int ExecuteSp(string sql, object param);

        IEnumerable<T> Query<T>(string sql, object param, CommandType commandType = CommandType.Text);

    }
}
