using Calculadora.OperacoesMatematicas.OperacoesQuantidade;
using Calculadora.Menus;

namespace CalculadoraEspecial.ControlesDeFluxo
{
    public class SwitchSoma
    {
        public static void Soma()
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
                            QuantidadeSoma.VoltarMenuAnterior();
                        }
                        else
                            Console.WriteLine("Opção inválida, escolha uma opção disponivel.\n");
                        Thread.Sleep(2000);
                        Calculadora.OperacoesMatematicas.Soma.Somar();
                        break;
                }
        }
    }
}