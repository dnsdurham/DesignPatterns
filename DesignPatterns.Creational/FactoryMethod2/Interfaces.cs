using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod2
{
    public interface IMyDbFactory
    {
        IDbObject Create(FacDbType type);
    }

    public interface IDbObject
    {
        void OpenDatabase();
        string GetData();
        void CloseDatabase();
    }
}
