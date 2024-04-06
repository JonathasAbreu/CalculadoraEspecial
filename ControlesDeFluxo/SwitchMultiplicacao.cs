using Calculadora.OperacoesMatematicas.OperacoesQuantidade;
using Calculadora.Menus;

namespace CalculadoraEspecial.ControlesDeFluxo
{
    public class SwitchMultiplicacao
    {
        public static void Multiplicacao()
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
                        QuantidadeMultiplicacao.VoltarMenuAnterior();
                    }
                    else
                        Console.WriteLine("Opção inválida, escolha uma opção disponivel.\n");
                    Thread.Sleep(2000);
                    Calculadora.OperacoesMatematicas.Multiplicacao.Multiplicar();
                    break;
            }
        }
    }
}