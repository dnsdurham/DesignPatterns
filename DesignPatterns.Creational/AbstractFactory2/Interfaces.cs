using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory2
{
    public interface IDisplayDriver
    {
        void Draw();
    }

    public interface IPrintDriver
    {
        void Print();
    }

    public interface IResolutionFactory
    {
        IDisplayDriver GetDisplayDriver();
        IPrintDriver GetPrintDriver();
    }
}
