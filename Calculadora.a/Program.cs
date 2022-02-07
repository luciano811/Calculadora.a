using System;

namespace Calculadora.a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            
            string[] historicoOperacoes = new string[10];

            int contadorOperacoes = 0;

            while (true)
            {
               

                Console.WriteLine();

                 Console.WriteLine("Calculadora da Mariana");

                Console.WriteLine("Digite os números que quer operacionalizar");

                Console.Write("Digite o primeiro número:");

                string strPrimeiroNumero = Console.ReadLine();

        Console.Write("Digite o segundo número:");

                string strSegundoNumero = Console.ReadLine();

        float primeiroNumero = Convert.ToSingle(strPrimeiroNumero);

        float segundoNumero = Convert.ToSingle(strSegundoNumero);


        Console.WriteLine();

                Console.Write("Aperte enter para prosseguir");

                Console.WriteLine();

                Console.ReadLine();

                Console.WriteLine("Digite 1 para somar");

                Console.WriteLine("Digite 2 para subtrair");

                Console.WriteLine("Digite 3 para multiplicar");

                Console.WriteLine("Digite 4 para dividir");

                Console.WriteLine("Digite 5 para visualizar operações");

                Console.WriteLine("Digite s para sair");

                choice = Console.ReadLine();



                if (choice != "1" && choice != "2" && choice != "3"
                    && choice != "4" && choice != "5" && choice != "s")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida: tente novamente");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }


                if (choice == "5")
                {
                    if (contadorOperacoes == 0)
                    {
                        Console.WriteLine("Nenhum operação realizada :-)");
                    }
                    else
                    {
                        for (int i = 0; i < historicoOperacoes.Length; i++)
                        {
                            if (historicoOperacoes[i] != null)
                            {
                                if (historicoOperacoes[i].Contains("+"))
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }
                                else if (historicoOperacoes[i].Contains("-"))
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }

                                Console.WriteLine(historicoOperacoes[i]);
                            }
                        }
                    }

                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }


                if (choice == "s") break;

                float resultado = 0;
                string operadorSelecionado = "";

                if (choice == "1")
                {
                    operadorSelecionado = "+";

                    resultado = primeiroNumero + segundoNumero;

        

                }

               
                
                if (choice == "2")
                {

                    operadorSelecionado = "-";

                    resultado = primeiroNumero - segundoNumero;

    


                }



if (choice == "3")
{

                    operadorSelecionado = "*";

                    resultado = primeiroNumero * segundoNumero;

    


}



if (choice == "4")
{

                    operadorSelecionado = "/";

                    resultado = primeiroNumero / segundoNumero;

    

                   
                }
                historicoOperacoes[contadorOperacoes] = primeiroNumero + " " + operadorSelecionado + " " +
                                 segundoNumero + " = " + Math.Round(resultado, 2);

                contadorOperacoes++;

                //apresentação do resultado final
                Console.WriteLine("Resultado: " + Math.Round(resultado, 2));

                Console.ReadLine();

                Console.Clear();
            }
            


        }



    }
}
    

