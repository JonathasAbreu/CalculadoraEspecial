using Calculadora.Menus;
using Calculadora.OperacoesMatematicas.OperacoesQuantidade;

namespace Calculadora.OperacoesMatematicas
{
    public class Subtracao
    {
        public static void Subtrair()
        {
            try
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
                        Subtrair();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nDigite apenas o número da opção. Aguarde essa mensagem sair para digitar novamente.");
                Thread.Sleep(4000);
                Subtrair();
            }
        }
    }
}