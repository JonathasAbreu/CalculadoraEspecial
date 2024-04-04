using Calculadora.Menus;
using Calculadora.OperacoesMatematicas.OperacoesQuantidade;

namespace Calculadora.OperacoesMatematicas
{
    public class Multiplicacao
    {
        public static void Multiplicar()
        {
            try
            {
                MenuQuantidade.ExibirMenuQuantidade();

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
                        Multiplicar();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nDigite apenas o número da opção. Aguarde essa mensagem sair para digitar novamente.");
                Thread.Sleep(4000);
                Multiplicar();
            }
        }
    }
}