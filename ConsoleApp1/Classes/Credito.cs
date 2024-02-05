using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Interfaces;
using ConsoleApp1.Classes;

namespace ConsoleApp1.Classes
{
    internal class Credito : ICredito
    {
        atributosConta ac;
        GeradorAutomaticoDeAtributos gaa= new GeradorAutomaticoDeAtributos();
        
       double saldo {  get; set; }
        double valorParcelado = 0;
        int vezesFaltantes = 0;

        public Credito()
        {
            ac=gaa.retornarValor();
            
            saldo=ac.VerificarSaldo();
        }
        double limite { get { return saldo * 2; } set { } }//Limite aleatorio


        void ICredito.OperaçãoComCredito(double ValorDaCompra)
        {
            if (ValorDaCompra > limite)
                Console.WriteLine("Valor extrapola o limite atual.");
            else
            {
                limite -= ValorDaCompra;
                Console.WriteLine("Compra efetuada.");
            }
                
        }

        void ICredito.OperaçãoParceladaComCredito(double ValorDaCompra,int Vezes)
        {
            if (ValorDaCompra > limite)
                Console.WriteLine("Valor extrapola o limite atual.");
            else
            {
                vezesFaltantes = Vezes;
                valorParcelado = ValorDaCompra / Vezes;
                limite -= ValorDaCompra;
                Console.WriteLine("Compra efetuada.");
            }
        }

        double ICredito.VerificarLimite()
        {

            return limite;   
        }
    }

    }

