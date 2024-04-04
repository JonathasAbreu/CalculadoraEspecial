using Calculadora.Menus;
using Calculadora.OperacoesMatematicas.OperacoesQuantidade;
using Calculadora.OperacoesMatematicas;

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
                    Environment.Exit(0);
                    break;
            }
        }
        public static void SwitchDivisao()
        {
            MenuQuantidade.ExibirMenuQuantidade();

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
                    Divisao.Dividir();
                    break;
            }
        }
        public static void SwitchMultiplicacao()
        {
            int quantidadeMultiplicacao = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (quantidadeMultiplicacao)
            {
                case 1:
                    QuantidadeMultiplicacao.DoisNumeros();
                    break;
                case 2:
                    QuantidadeMultiplicacao.TresNumeros();
                    break;
                case 3:
                    QuantidadeMultiplicacao.QuatroNumeros();
                    break;
                case 4:
                    QuantidadeMultiplicacao.CincoNumeros();
                    break;
                default:
                    if (quantidadeMultiplicacao == 0)
                    {
                        Console.WriteLine("Voltando ao menu anterior.");
                        Thread.Sleep(3000);
                        QuantidadeMultiplicacao.Sair();
                    }
                    else
                        Console.WriteLine("Opção inválida, escolha uma opção disponivel.\n");
                    Thread.Sleep(2000);
                    Multiplicacao.Multiplicar();
                    break;
            }
        }
        public static void SwitchSoma()
        {
            MenuQuantidade.ExibirMenuQuantidade();

                int quantidadeSoma = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (quantidadeSoma)
                {
                    case 1:
                        QuantidadeSoma.DoisNumeros();
                        break;
                    case 2:
                        QuantidadeSoma.TresNumeros();
                        break;
                    case 3:
                        QuantidadeSoma.QuatroNumeros();
                        break;
                    case 4:
                        QuantidadeSoma.CincoNumeros();
                        break;
                    default:
                        if (quantidadeSoma == 0)
                        {
                            Console.WriteLine("Voltando ao menu anterior.");
                            Thread.Sleep(3000);
                            QuantidadeSoma.Sair();
                        }
                        else
                            Console.WriteLine("Opção inválida, escolha uma opção disponivel.\n");
                        Thread.Sleep(2000);
                        Soma.Somar();
                        break;
                }
        }
        public static void SwitchSubtracao()
        {
            MenuQuantidade.ExibirMenuQuantidade();

                int quantidadeSubtracao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (quantidadeSubtracao)
                {
                    case 1:
                        QuantidadeSubtracao.DoisNumeros();
                        break;
                    case 2:
                        QuantidadeSubtracao.TresNumeros();
                        break;
                    case 3:
                        QuantidadeSubtracao.QuatroNumeros();
                        break;
                    case 4:
                        QuantidadeSubtracao.CincoNumeros();
                        break;
                    default:
                        if (quantidadeSubtracao == 0)
                        {
                            Console.WriteLine("Voltando ao menu anterior.");
                            Thread.Sleep(3000);
                            QuantidadeSubtracao.Sair();
                        }
                        else
                            Console.WriteLine("Opção inválida, escolha uma opção disponivel.\n");
                        Thread.Sleep(2000);
                        Subtracao.Subtrair();
                        break;
                }
        }
    
    }
}
