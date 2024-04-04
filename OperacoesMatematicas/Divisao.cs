using Calculadora.Menus;
using Calculadora.OperacoesMatematicas.OperacoesQuantidade;

namespace Calculadora.OperacoesMatematicas
{
    public class Divisao
    {
        public static void Dividir()
        {
            try
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
                        Dividir();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nDigite apenas o número da opção. Aguarde essa mensagem sair para digitar novamente.");
                Thread.Sleep(4000);
                Dividir();
            }
        }
    }
}