using Calculadora.Menus;
using Calculadora.OperacoesMatematicas.OperacoesQuantidade;

namespace Calculadora.OperacoesMatematicas
{
    public class Soma
    {
        public static void Somar()
        {
            try
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
                        Somar();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nDigite apenas o número da opção. Aguarde essa mensagem sair para digitar novamente.");
                Thread.Sleep(4000);
                Somar();
            }
        }
    }
}