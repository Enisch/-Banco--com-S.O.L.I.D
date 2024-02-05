using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class GeradorAutomaticoDeAtributos
    {
        //Sistema aleatorio de dados sem DB
        Random R = new Random();
        atributosConta ac;

        string[] nome =
        {
            "Julio A.",
            "André B.",
            "Jessica D.B."
        };

        double[] saldo =
        {
            4535,
            78964,
            14456,
            756845,
            0500
        };

       public GeradorAutomaticoDeAtributos()
        {
            int n = R.Next(0, 2);
            int s= R.Next(0, 4);

            string name= nome[n].ToString();
            double sal = saldo[s];

             ac = new atributosConta(name, sal);

        }

        public atributosConta retornarValor()
        {
            return ac;
        }
        
        
        





    }
}
