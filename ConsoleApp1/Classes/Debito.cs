using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    internal class Debito : IDebito
    {
        atributosConta ac;
        GeradorAutomaticoDeAtributos gaa = new GeradorAutomaticoDeAtributos();
        
        private double saldo { get; set; }
        DateOnly DiaCompra = new DateOnly();//especifica os dias do pagamento da parcela.
        double ValorParcelado = 0;

        public Debito()
        {
            ac = gaa.retornarValor();
            saldo = ac.VerificarSaldo();
            
        }

        void IDebito.OperacaoComDebito(double valorDaCompra)
        {
            if (valorDaCompra > saldo)

                Console.WriteLine("Saldo indisponível.");

            else
            {
                saldo -= valorDaCompra;
                Console.WriteLine("Compra efetuada.");
            }

        }

        void IDebito.OperecaoParceladaCOmDebito(double valorDaCompra, int Vezes)
        {
            ValorParcelado = valorDaCompra / Vezes;
            Console.WriteLine($"Todo dia {DiaCompra.Day} durante {Vezes} meses Será debitado, " +
                $"automaticamente {ValorParcelado} de sua conta." +
                $"\nAté a seguinte data:{DiaCompra.AddMonths(Vezes)}. ");
          
        }


    }

}

