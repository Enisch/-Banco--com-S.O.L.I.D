using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    internal interface IDebito
    {
        void OperacaoComDebito(double v);
        void OperecaoParceladaCOmDebito(double v,int vezes);

    }
}
