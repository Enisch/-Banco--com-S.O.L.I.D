using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Classes;

namespace ConsoleApp1.Classes
{
    internal class atributosConta
    {

        private string? Nome { get; set; }
        //private string senha { get; set; } só faz sentido caso use banco de dados;
        private double Saldo { get; set; }


        public atributosConta(string nome, double saldo)
        {
            Nome=nome;
            
            Saldo = saldo;
        }

        public atributosConta(double saldo) 
        { 
            //Atribui saldo novo
            Saldo=saldo;
        
        } 

        public double VerificarSaldo()
        {
            return Saldo;
        }








    }
}
