using Calculadora.OperacoesMatematicas.OperacoesQuantidade;
using Calculadora.Menus;

namespace CalculadoraEspecial.ControlesDeFluxo
{
    public class SwitchSubtracao
    {
        public static void Subtracao()
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
                            QuantidadeSubtracao.VoltarMenuAnterior();
                        }
                        else
                            Console.WriteLine("Opção inválida, escolha uma opção disponivel.\n");
                        Thread.Sleep(2000);
                        Calculadora.OperacoesMatematicas.Subtracao.Subtrair();
                        break;
                }
        }
    }
}