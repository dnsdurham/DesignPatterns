using System;

namespace DesignPatterns.Creational.FactoryMethod2
{
    public class FacClient
    {
        private IMyDbFactory _factory;

        public FacClient(IMyDbFactory factory)
        {
            _factory = factory;
        }

        public void GetTheData(FacDbType db)
        {
            IDbObject database = _factory.Create(db);
            database.OpenDatabase();
            Console.WriteLine(database.GetData());
            database.CloseDatabase();
        }
    }

    #region DB Objects

    public class OracleDbObject : IDbObject
    {

        public void OpenDatabase()
        {
            Console.WriteLine("Oracle DB Opened");
        }

        public string GetData()
        {
            return "This is the Oracle data you asked for...";
        }

        public void CloseDatabase()
        {
            Console.WriteLine("Oracle DB Closed");
        }
    }

    public class SqlServerDbObject : IDbObject
    {

        public void OpenDatabase()
        {
            Console.WriteLine("Sql Server DB Opened");
        }

        public string GetData()
        {
            return "This is the Sql Server data you asked for...";
        }

        public void CloseDatabase()
        {
            Console.WriteLine("Sql Server DB Closed");
        }
    }

    public class PostGresDbObject : IDbObject
    {

        public void OpenDatabase()
        {
            Console.WriteLine("PostGres DB Opened");
        }

        public string GetData()
        {
            return "This is the PostGres data you asked for...";
        }

        public void CloseDatabase()
        {
            Console.WriteLine("PostGres DB Closed");
        }
    }

    #endregion  
}
