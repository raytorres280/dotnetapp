using System;
using ServiceStack.OrmLite;
using System.Data;

namespace BusinessObjects.Utilities
{
    public class DBMananger
    {
        public DBMananger()
        {
        }

        private static OrmLiteConnectionFactory _dbFactory;
        //fancy
        //public static IDbConnection GetOpenOrmLiteDbConnection(DataSourceEnum dataSource = DataSourceEnum.BootView)
        //{
        //    _dbFactory = _dbFactory ?? new OrmLiteConnectionFactory(GetConnectionString(dataSource), SqlServerDialect.Provider);
        //    _dbFactory.AutoDisposeConnection = true;
        //    _dbFactory.OnDispose = DecrementConnections;
        //    var connection = _dbFactory.OpenDbConnection();
        //    IncrementConnections(connection);

        //    return connection;
        //}

        public static string GetConnectionString(string source){
            return "";
        }
        public static IDbConnection GetOpenOrmLiteDbConnection() {
            return new OrmLiteConnectionFactory(GetConnectionString("enter url here"), PostgreSqlDialect.Provider).OpenDbConnection();
        }
    }
}
