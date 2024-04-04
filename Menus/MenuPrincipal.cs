using Calculadora.OperacoesMatematicas;

namespace Calculadora.Menus
{
    public class MenuPrincipal
    {
        public static void MenuInicial()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("----- Escolha o cálculo que deseja fazer ----- \n");
                Console.WriteLine("1 - SOMA");
                Console.WriteLine("2 - SUBTRAÇÃO");
                Console.WriteLine("3 - MULTIPLICAÇÃO");
                Console.WriteLine("4 - DIVISÃO");
                Console.WriteLine("0 - SAIR DO PROGRAMA");
                Console.WriteLine("\nOpcao: ");

                int OperacaoEscolhida = int.Parse(Console.ReadLine());


                switch (OperacaoEscolhida)
                {
                    case 1:
                        Soma.Somar();
                        break;
                    case 2:
                        Subtracao.Subtrair();
                        break;
                    case 3:
                        Multiplicacao.Multiplicar();
                        break;
                    case 4:
                        Divisao.Dividir();
                        break;
                    default:
                        if (OperacaoEscolhida == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Adeus!\n");
                            Environment.Exit(0);
                        }
                        else
                            Console.Clear();
                        Console.WriteLine("\nOpção inválida, escolha uma opção disponivel.\n");
                        Thread.Sleep(2000);
                        MenuInicial();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nDigite apenas o número da opção. Aguarde essa mensagem sair para digitar novamente.");
                Thread.Sleep(4000);
                MenuInicial();
            }
        }
    }
}