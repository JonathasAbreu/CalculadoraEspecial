using Calculadora.Menus;

namespace Calculadora.ControleDeFluxo
{
    public class Switch
    {
        public static void EscolhaFinal()
        {
            Console.WriteLine("Deseja fazer outro cálculo?\n");
            Console.WriteLine("Digite 1 para SIM ou 2 para NÃO");

            string escolhaNoFinal = Console.ReadLine();

            switch (escolhaNoFinal)
            {
                case "1":
                    Console.WriteLine("\nLegal! Vamos fazer outro cálculo.");
                    Thread.Sleep(2000);
                    MenuPrincipal.MenuInicial();
                    break;
                case "2":
                    Console.WriteLine("\nFoi um prazer te ajudar. Até a próxima!\n");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nOpção inválida. Infelizmente vou precisar encerrar o programa.\n");
                    break;
            }

        }
    }
}