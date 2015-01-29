using System;

namespace DesignPatterns.Creational.FactoryMethod2
{
    public class MyMyDbFactory : IMyDbFactory
    {
        public IDbObject Create(FacDbType type)
        {
            switch (type)
            {
                case FacDbType.Oracle:
                    return new OracleDbObject();
                case FacDbType.SqlServer:
                    return new SqlServerDbObject();
                case FacDbType.PostGres:
                    return new PostGresDbObject();
                default:
                    throw new Exception("Unknown Database Type!");
            }
        }
    }
}
