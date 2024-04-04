using Calculadora.Menus;

namespace Calculadora.ControleDeFluxo
{
    public class Switch
    {
        public static void SwitchFinal()
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

        public static void SwitchDivisao()
        {
            int quantidadeDivisao = int.Parse(Console.ReadLine());
                Console.Clear();
            
                switch (quantidadeDivisao)
                {
                    case 1:
                        QuantidadeDivisao.DoisNumeros();
                        break;
                    case 2:
                        QuantidadeDivisao.TresNumeros();
                        break;
                    case 3:
                        QuantidadeDivisao.QuatroNumeros();
                        break;
                    case 4:
                        QuantidadeDivisao.CincoNumeros();
                        break;
                    default:
                        if (quantidadeDivisao == 0)
                        {
                            Console.WriteLine("Voltando ao menu anterior.");
                            Thread.Sleep(3000);
                            QuantidadeDivisao.Sair();
                        }
                        else
                            Console.WriteLine("Opção inválida, escolha uma opção disponivel.\n");
                        Thread.Sleep(2000);
                        Dividir();
                        break;
                }
        }
        }
    }
}
