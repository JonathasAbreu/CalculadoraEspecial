using Calculadora.Menus;
using Calculadora.OperacoesMatematicas.OperacoesQuantidade;
using Calculadora.ControleDeFluxo;

namespace Calculadora.OperacoesMatematicas
{
    public class Multiplicacao
    {
        public static void Multiplicar()
        {
            try
            {
                Switch.SwitchMultiplicacao();
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
