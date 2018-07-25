using System;
using ServiceStack.OrmLite.PostgreSQL;

namespace dotnetapp.ServiceModel.repos
{
    public class ConnectionFactory
    {
        public static dbFactory()
        {
            return new OrmLiteConnectionFactory(
            connectionString,
            SqlServerDialect.Provider);
        };
    }
}
