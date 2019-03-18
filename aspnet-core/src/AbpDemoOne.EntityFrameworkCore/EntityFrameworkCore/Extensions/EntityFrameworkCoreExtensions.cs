using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbpDemoOne.EntityFrameworkCore.Extensions
{
    public static class EntityFrameworkCoreExtensions
    {
        private static DbCommand CreateCommand(DatabaseFacade facade, string sql, out DbConnection connection, params object[] parameters)
        {
            var conn = facade.GetDbConnection();
            connection = conn;
            if(conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
              
            var cmd = conn.CreateCommand();
            if (facade.IsSqlServer())
            {
                cmd.CommandText = sql;
                cmd.Parameters.AddRange(parameters);
            }
            return cmd;
        }


        private async static Task<DataTable> SqlQuery(this DatabaseFacade facade, string sql, params object[] parameters)
        {
            try
            {
                var conn = facade.GetDbConnection();
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                var cmd = conn.CreateCommand();
                if (facade.IsSqlServer())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                }
               // var command = CreateCommand(facade, sql, out DbConnection conn, parameters);

                var reader = await cmd.ExecuteReaderAsync();// command.ExecuteReader();
                var dt = new DataTable();
                dt.Load(reader);
                reader.Close();
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async static Task<List<T>> SqlQuery<T>(this DatabaseFacade facade, string sql, params object[] parameters) where T : class, new()
        {
            var dt = await SqlQuery(facade, sql, parameters);
            return dt.ToList<T>();
        }

        public static List<T> ToList<T>(this DataTable dt) where T : class, new()
        {
            var propertyInfos = typeof(T).GetProperties();
            var list = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                var t = new T();
                foreach (PropertyInfo p in propertyInfos)
                {
                    if (dt.Columns.IndexOf(p.Name) != -1 && row[p.Name] != DBNull.Value)
                        p.SetValue(t, row[p.Name], null);
                }
                list.Add(t);
            }
            return list;
        }
    }
}
