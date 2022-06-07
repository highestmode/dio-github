using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_de_Impares_Consecutivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Leia um valor inteiro N que é a quantidade de casos de teste que vem a seguir.
            //Cada caso de teste consiste de dois inteiros X e Y.
            //Você deve apresentar a soma de Y ímpares consecutivos a partir de X inclusive o próprio X se ele for ímpar.
            //Por exemplo:
            //para a entrada 4 5, a saída deve ser 45, que é equivalente à: 5 + 7 + 9 + 11 + 13
            //para a entrada 7 4, a saída deve ser 40, que é equivalente à: 7 + 9 + 11 + 13


            int qntCasos;
            int x = 0, y = 0, a = 0, b = 0;
            int somador = 0;

            Console.WriteLine("Digite a quantidade de casos testes");
            qntCasos = int.Parse(Console.ReadLine());
            for (int i = 0; i < qntCasos; i++)
            {
                Console.WriteLine("Digite o primeiro valor");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor");
                y = int.Parse(Console.ReadLine());
                if ((y % 2 == 0 && x % 2 == 0) || (y % 2 != 0 && x % 2 != 0))
                {
                    Console.WriteLine("Um dos valores precisa ser par e o outro impar");
                }
                else
                {

                    if (x % 2 == 0)
                    {
                        a = x;
                        b = y;
                    }
                    else
                    {
                        a = y;
                        b = x;
                    }
                    somador = b;
                    for (int soma = 0; soma < a; soma++)
                    {

                        int[] vetor = new int[a];
                        vetor[soma] = b;
                        vetor[soma] = b += 2;
                        somador += vetor[soma];


                    }
                    Console.WriteLine(somador);




                }

                

            }
            Console.ReadLine();




        

            }

            




        }
    }

