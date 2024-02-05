using ConsoleApp1.Classes;
using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class Pagamentos
    {

        int escolha = 0;
        double ValorCompra = 1;


        public void MetodoDePagamento()
        {
            Console.WriteLine("Digite 1 para Debito, e 2 para credito.\n");
            try
            {
                escolha = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            switch (escolha)
            {

                default:
                    Console.WriteLine("Valor incorreto.");
                    break;

                case 1:

                    IDebito debito1 = new Debito();

                    Console.WriteLine("Digite valor da compra.\n");
                    try
                    {
                        ValorCompra = Convert.ToDouble(Console.ReadLine());
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    Console.WriteLine("Digite 'S',caso queira parcelar a compra.");
                    string? confirmacao = Console.ReadLine();

                    if (confirmacao != "S" || confirmacao != "s")
                        debito1.OperacaoComDebito(ValorCompra);

                    else
                    {
                        Console.WriteLine("Parcelar em quantas vezes?\n");
                        int Vezes = Convert.ToInt32(Console.ReadLine());

                        if (Vezes > 0)
                            debito1.OperecaoParceladaCOmDebito(ValorCompra, Vezes);

                        else
                            debito1.OperacaoComDebito(ValorCompra);

                    }


                    break;

                case 2:

                    ICredito credito = new Credito();

                    Console.WriteLine("Digite valor da compra.\n");
                    try
                    {
                        ValorCompra = Convert.ToDouble(Console.ReadLine());
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    Console.WriteLine("Digite 'S',caso queira parcelar a compra.");
                    string? confirmacao1 = Console.ReadLine();

                    if (confirmacao1 != "S" || confirmacao1 != "s")
                        credito.OperaçãoComCredito(ValorCompra);


                    else
                    {
                        Console.WriteLine("Parcelar em quantas vezes?\n");
                        int Vezes = Convert.ToInt32(Console.ReadLine());

                        if (Vezes > 0)
                            credito.OperaçãoParceladaComCredito(ValorCompra, Vezes);

                        else
                            credito.OperaçãoComCredito(ValorCompra);

                    }
                    break;

            };

        }






    }
}
