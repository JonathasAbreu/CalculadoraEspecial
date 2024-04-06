using Calculadora.Menus;
using Calculadora.OperacoesMatematicas.OperacoesQuantidade;
using Calculadora.ControleDeFluxo;
using CalculadoraEspecial.ControlesDeFluxo;

namespace Calculadora.OperacoesMatematicas
{
    public class Subtracao
    {
        public static void Subtrair()
        {
            // colocar esse switch dentro da classe especifica.
            try
            {
                SwitchSubtracao.Subtracao();
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
