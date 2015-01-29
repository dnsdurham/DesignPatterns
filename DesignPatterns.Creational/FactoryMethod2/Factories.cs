using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
