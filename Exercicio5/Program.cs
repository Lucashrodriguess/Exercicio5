using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Com base na tabela abaixo, escreva um programa 
             * que leia o código de um item e a quantidade deste item. A 
seguir, calcule e mostre o valor da conta a pagar*/

            int codigo = 0, quantidade = 0;
            double valor;
           


                Console.WriteLine("Codigo          Especificação              Preço");
                Console.WriteLine("1             cachorro quente             R$ 4.00");
                Console.WriteLine("2             X-Salada                    R$ 4.50");
                Console.WriteLine("3             X-Bacon                     R$ 5.00");
                Console.WriteLine("4             Torrada Simples             R$ 2.00");
                Console.WriteLine("5             Refrigerante                R$ 1.50");
                Console.WriteLine("6             Sair     ");

            

             while (codigo != 6)

                {

                    Console.WriteLine("Digite a opção Desejada");
                    codigo = int.Parse(Console.ReadLine());


                    if (codigo == 1)
                    {
                        Console.WriteLine("Cachorro quente");
                        Console.WriteLine("Digite a quantidade de Cachorro quente desejada");
                        quantidade = int.Parse(Console.ReadLine());
                        valor = quantidade * 4.00;
                        Console.WriteLine("Quantidade a pagar sera R$" + valor.ToString("F2", CultureInfo.InvariantCulture));
                       
                    }
              

                    else if (codigo == 2)
                    {
                        Console.WriteLine("X-Salada");
                        Console.WriteLine("Digite a quantidade X-Salada desejada");
                        quantidade = int.Parse(Console.ReadLine());
                        valor = quantidade * 4.5;
                        Console.WriteLine("Quantidade a pagar sera R$" + valor.ToString("F2", CultureInfo.InvariantCulture));
                    }

                    else if (codigo == 3)
                    {
                        Console.WriteLine("X-Bacon");
                        Console.WriteLine("Digite a quantidade X-Bacon  desejada");
                        quantidade = int.Parse(Console.ReadLine());
                        valor = quantidade * 5.00;
                        Console.WriteLine("Quantidade a pagar sera R$" + valor.ToString("F2", CultureInfo.InvariantCulture));
                    }
                    else if (codigo == 4)
                    {
                        Console.WriteLine("Torrada Simples");
                        Console.WriteLine("Digite a quantidade Torrada desejada");
                        quantidade = int.Parse(Console.ReadLine());
                        valor = quantidade * 2.00;
                        Console.WriteLine("Quantidade a pagar sera R$" + valor.ToString("F2", CultureInfo.InvariantCulture));
                    }
                    else if (codigo == 5)
                    {
                        Console.WriteLine("Refrigerante");
                        Console.WriteLine("Digite a quantidade Refrigerante desejada");
                        quantidade = int.Parse(Console.ReadLine());
                        valor = quantidade * 1.50;
                        Console.WriteLine("Quantidade a pagar sera R$" + valor.ToString("F2", CultureInfo.InvariantCulture));
                    }
                    else if (codigo <= 0 || codigo >= 7)
                    {
                        Console.WriteLine("Codigo errado");
                    }
                    else if (codigo == 6)
                    {
                        Console.WriteLine("Sair");
                        break;
                    }
                
                    }
        }
        } 
}