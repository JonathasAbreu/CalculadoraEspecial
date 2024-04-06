using Calculadora.OperacoesMatematicas.OperacoesQuantidade;
using Calculadora.Menus;


namespace CalculadoraEspecial.ControlesDeFluxo
{
    public class SwitchDivisao
    {
        public static void Divisao()
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
                        QuantidadeDivisao.VoltarMenuAnterior();
                    }
                    else
                        Console.WriteLine("Opção inválida, escolha uma opção disponivel.\n");
                    Thread.Sleep(2000);
                    Calculadora.OperacoesMatematicas.Divisao.Dividir();
                    break;
            }
        }
    }
}