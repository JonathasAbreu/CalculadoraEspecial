using Calculadora.Menus;
using Calculadora.OperacoesMatematicas.OperacoesQuantidade;
using Calculadora.OperacoesMatematicas;

namespace Calculadora.ControleDeFluxo
{
    public class SwitchEncerramento
    {
        public static void Final()
        {
            Console.WriteLine("Deseja continuar usando a calculadora?\n");
            Console.WriteLine("Digite 1 para SIM ou 2 para NÃO");

            string escolhaNoFinal = Console.ReadLine();

            switch (escolhaNoFinal)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Legal! Vamos fazer outro cálculo.");
                    Thread.Sleep(2000);
                    MenuPrincipal.MenuInicial();
                    break;
                case "2":
                    Console.WriteLine("\nFoi um prazer te ajudar. Obrigado por usar a calculadora!\n");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nOpção inválida. Infelizmente vou precisar encerrar o programa.\n");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
