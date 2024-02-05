using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    internal interface ICredito
    {

        
        void OperaçãoComCredito(double ValorDaCompra);
        void OperaçãoParceladaComCredito(double ValorDaCompra,int vezes);
        double VerificarLimite();
        
    }
}
